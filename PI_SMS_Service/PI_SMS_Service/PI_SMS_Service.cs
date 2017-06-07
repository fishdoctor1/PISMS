using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Data.SqlClient;
using PISDKDlg;
using System.Globalization;
using System.Timers;
using System.Threading;
using System.IO;
using System.Data.OleDb;

namespace PI_SMS_Service
{
    public partial class PI_SMS_Service : ServiceBase
    {
        DataTable template_dataTable = new DataTable();
        DataTable User_In_Template = new DataTable();
        DataTable EventID_In_Template = new DataTable();
        DataTable EventDataTable = new DataTable();
        DataTable Tag_in_TemplateTable = new DataTable();
        DataTable Prepare_TemplateID_ForSendSMS = new DataTable();
        public DataTable Pub_Config = new DataTable();
        OleDbConnection connecAccess = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + AppDomain.CurrentDomain.BaseDirectory + "\\SystemConfig.mdb;Persist Security Info=False");

        string connectionString = "Data Source = 172.28.57.123; Initial Catalog =PISMS; User ID =PISMS; Password =P@ssw0rd";
        public  System.Timers.Timer aTimer;        

        string TimeNow;
        //DateTime NowDateTime1;
        //DateTime NowDateTime2;
        //int NowDateTime1Hour;
        //int NowDateTime1Min;
        //int NowDateTime2Hour;
        //int NowDateTime2Min;
        string Time;
        string NowDayOfWeek;
        string TagValue;
        string TagTimeStamp;

        PISDK.PISDK g_SDK;

        PISDKDlg.ApplicationObject g_SDKDlgAppObject; // PISDK dialog app. object 

        public PI_SMS_Service()
        {
            InitializeComponent();

            // Declare DataColumn and DataRow variables.
            //DataColumn column;

            //// Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            //column = new DataColumn();
            //column.DataType = System.Type.GetType("System.String");
            //column.ColumnName = "TemplateID";
            //Prepare_TemplateID_ForSendSMS.Columns.Add(column);

            //column = new DataColumn();
            //column.DataType = System.Type.GetType("System.String");
            //column.ColumnName = "TemplateDescriptionForSend";
            //Prepare_TemplateID_ForSendSMS.Columns.Add(column);
            //column.Dispose();
            try
            {

                g_SDK = new PISDK.PISDKClass();

                g_SDKDlgAppObject = new PISDKDlg.ApplicationObjectClass();

            }
            catch (System.Runtime.InteropServices.COMException comExc)
            {
                //MessageBox.Show(comExc.Message, comExc.ErrorCode + " Error",

                //MessageBoxButtons.OK,

                //MessageBoxIcon.Exclamation);
            }
        }

        public void OnDebug()
        {
            OnStart(null);
        }

        public void getconfig()
        {
            try
            {
                String qsetting = "";
                qsetting = "SELECT  ServerIP,SMSHeader,DataBaseName,UserID,Passwordd FROM TSetting";

                connecAccess.Open();

                OleDbCommand cmd = new OleDbCommand(qsetting, connecAccess);
                OleDbDataAdapter c = new OleDbDataAdapter(cmd);

                Pub_Config = new DataTable();
                Pub_Config.Clear();
                c.SelectCommand = cmd;
                c.Fill(Pub_Config);

                connecAccess.Close();
            }
            catch (Exception ex)
            {
                
            }

        }

        protected override void OnStart(string[] args)
        {
            // Create a timer and set a two second interval.
            Prepare_TemplateID_ForSendSMS.Columns.Add("TemplateID", typeof(string));//0
            Prepare_TemplateID_ForSendSMS.Columns.Add("TemplateDescriptionForSend", typeof(string));
            aTimer = new System.Timers.Timer();           

            // Hook up the Elapsed event for the timer. 

            aTimer.Elapsed += OnTimedEvent;
            //aTimer.Elapsed += OnTimedEvent2;
            

            this.aTimer.Interval = 1;
            this.aTimer.AutoReset = false; // prevent race condition
            this.aTimer.Start();
        }

        protected override void OnStop()
        {
        }

        string path = AppDomain.CurrentDomain.BaseDirectory+"\\ServiceLog";
        string NowDate = DateTime.Now.ToString("yyyy-MM-dd");

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                if (!File.Exists(path + "\\" + NowDate + ".txt"))
                {
                    File.Create(path + "\\" + NowDate + ".txt");
                }
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                getconfig();
                connectionString = "Data Source = " + Pub_Config.Rows[0].ItemArray[0].ToString() + "; Initial Catalog =" + Pub_Config.Rows[0].ItemArray[2].ToString() + "; User ID =" + Pub_Config.Rows[0].ItemArray[3].ToString() + "; Password =" + Pub_Config.Rows[0].ItemArray[4].ToString() + "";
                Thread threadSendSMS = new Thread(Send_SMS);
                if (threadSendSMS.IsAlive)
                {
                    TimeNow = DateTime.Now.ToString("HH:mm");

                    threadSendSMS.Join();
                    LoadDataToTable_Template();
                    CheckTemplate_ONSMS();
                }
                else
                {
                    TimeNow = DateTime.Now.ToString("HH:mm");
                    LoadDataToTable_Template();
                    CheckTemplate_ONSMS();
                }

                if (Prepare_TemplateID_ForSendSMS.Rows.Count > 0)
                {
                    threadSendSMS.Start();
                }
                aTimer.Interval = 60000; //sleep 60 sec
                aTimer.AutoReset = false; // prevent race condition
                aTimer.Start();
            }
            catch(Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path + "\\" + NowDate + ".txt"))
                {
                    sw.WriteLine("!!!!!!!!!!!!!!!!!!!!ERROR!!!!!!!!!!!!!!!!!!!!");
                    sw.WriteLine(ex);

                }
            }           

        }       
        
        #region Load Tag in Template To Table

        private void Load_TaginTemplate_To_DataTable(int Template_ID)
        {
            try
            {
                Tag_in_TemplateTable.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT [PISMS].[dbo].[Tag].PIServer,[PISMS].[dbo].[Tag].TagName,[PISMS].[dbo].[Tag].TagAlias,[PISMS].[dbo].[Tag].TagIDAuToInc"
+ " FROM[PISMS].[dbo].[template_tag_relation]"
+ " JOIN NotificationTemplate ON[PISMS].[dbo].[template_tag_relation].TemplateIDAuToInc = [PISMS].[dbo].[NotificationTemplate].TemplateIDAuToInc"
+ " JOIN Tag ON[PISMS].[dbo].[template_tag_relation].TagIDAuTOInc = [PISMS].[dbo].[Tag].TagIDAuToInc"
+ " WHERE [NotificationTemplate].TemplateIDAuToInc = '" + Template_ID.ToString() + "' ORDER BY TagName";

                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(Tag_in_TemplateTable);

                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("ERROR : " +ex);
                using (StreamWriter sw = File.AppendText(path + "\\" + NowDate + ".txt"))
                {
                    sw.WriteLine("!!!!!!!!!!!!!!!!!!!!ERROR!!!!!!!!!!!!!!!!!!!!");
                    sw.WriteLine(ex);

                }
            }

        }

        #endregion

        #region Load Template

        void LoadDataToTable_Template()
        {
            try
            {
                template_dataTable.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT * FROM [PISMS].[dbo].[NotificationTemplate] ORDER BY TemplateName";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(template_dataTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR : " + ex);
                using (StreamWriter sw = File.AppendText(path + "\\" + NowDate + ".txt"))
                {
                    sw.WriteLine("!!!!!!!!!!!!!!!!!!!!ERROR!!!!!!!!!!!!!!!!!!!!");
                    sw.WriteLine(ex);

                }
            }
        }
        #endregion

        #region LoadData Event_in_Template

        private void LoadDataToTableEvent_in_Template(int TemplateID)
        {
            try
            {
                EventID_In_Template.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT [PISMS].[dbo].[Event].EventName,[PISMS].[dbo].[Event].Monday,[PISMS].[dbo].[Event].Tuesday,[PISMS].[dbo].[Event].Wednesday,[PISMS].[dbo].[Event].Thursday,[PISMS].[dbo].[Event].Friday,[PISMS].[dbo].[Event].Saturday,[PISMS].[dbo].[Event].Sunday,[PISMS].[dbo].[Event].Time,[PISMS].[dbo].[Event].EventID" +
" From[PISMS].[dbo].[Template_Event_RelationTable]" +
" JOIN NotificationTemplate ON[PISMS].[dbo].[Template_Event_RelationTable].TemplateIDAuToInc = [PISMS].[dbo].[NotificationTemplate].TemplateIDAuToInc" +
" JOIN Event ON[PISMS].[dbo].[Template_Event_RelationTable].EventID = [PISMS].[dbo].[Event].EventID" +
" WHERE [NotificationTemplate].TemplateIDAuToInc = '" + TemplateID.ToString() + "'";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(EventID_In_Template);

                }
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path + "\\" + NowDate + ".txt"))
                {
                    sw.WriteLine("!!!!!!!!!!!!!!!!!!!!ERROR!!!!!!!!!!!!!!!!!!!!");
                    sw.WriteLine(ex);

                }
            }
        }
        #endregion

        #region LoadData User_In_Template

        private void LoadDataTo_User_In_TemplateTable(int Template_ID)
        {
            try
            {
                User_In_Template.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string TemplateSelected = Template_ID.ToString();
                    string queryString = "SELECT [PISMS].[dbo].[User].UserID,[PISMS].[dbo].[User].FirstName,[PISMS].[dbo].[User].LastName,[PISMS].[dbo].[User].UserIDAuToInc,[PISMS].[dbo].[User].HandPhone" +
" From[PISMS].[dbo].[User_Template_Relation]" +
" JOIN NotificationTemplate ON[PISMS].[dbo].[User_Template_Relation].TemplateIDAuToInc = [PISMS].[dbo].[NotificationTemplate].TemplateIDAuToInc" +
" JOIN[PISMS].[dbo].[User] ON[PISMS].[dbo].[User_Template_Relation].UserIDAutoInc = [PISMS].[dbo].[User].UserIDAutoInc" +
" WHERE [NotificationTemplate].TemplateIDAuToInc='" + TemplateSelected + "' ORDER BY FirstName";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(User_In_Template);
                }
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path + "\\" + NowDate + ".txt"))
                {
                    sw.WriteLine("!!!!!!!!!!!!!!!!!!!!ERROR!!!!!!!!!!!!!!!!!!!!");
                    sw.WriteLine(ex);

                }
            }
        }

        #endregion
        
        private void CheckTemplate_ONSMS()
        {
            try
            {
                //TimeNow = DateTime.Now.ToString("HH:mm");
                //NowDateTime1 = DateTime.Parse(TimeNow);
                //NowDateTime1Hour = NowDateTime1.Hour;
                //NowDateTime1Min = NowDateTime1.Minute;
                //double min = 10;
                //NowDateTime2 = NowDateTime1.AddMinutes(min);
                ////NowDateTime2Hour = NowDateTime2.Hour;
                //NowDateTime2Min = NowDateTime2.Minute;

                //string x = DateTime1.ToString("HH:mm");
                for (int templatenumber = 0; templatenumber < template_dataTable.Rows.Count; templatenumber++)
                    {
                        string SMS_Status = template_dataTable.Rows[templatenumber].ItemArray[1].ToString();
                        int Template_ID = Convert.ToInt32(template_dataTable.Rows[templatenumber].ItemArray[3]);
                        string TemplateDescription = template_dataTable.Rows[templatenumber].ItemArray[0].ToString();
                    if (SMS_Status == "True")
                        {
                            CheckEvent_In_Template(Template_ID, templatenumber, TemplateDescription);
                        }
                }                               

            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path + "\\" + NowDate + ".txt"))
                {
                    sw.WriteLine("!!!!!!!!!!!!!!!!!!!!ERROR!!!!!!!!!!!!!!!!!!!!");
                    sw.WriteLine(ex);

                }
            }
        }

        private void CheckEvent_In_Template(int Template_ID,int templatenumber,string TemplateDescription)
        {
            try
            {
                LoadDataToTableEvent_in_Template(Template_ID);

                for (int EventNumber = 0; EventNumber < EventID_In_Template.Rows.Count; EventNumber++)
                {
                    //

                    //Check Day

                    //
                    bool DayStatus;
                    NowDayOfWeek = System.DateTime.Now.DayOfWeek.ToString();
                    Time = EventID_In_Template.Rows[EventNumber].ItemArray[8].ToString(); //Time Event in Template
                    string[] result = Time.Split(':');
                    int Timehours_EventInTemplate = Convert.ToInt32(result[0]);
                    int Timeminutes_EventInTemplate = Convert.ToInt32(result[1]);


                    if (NowDayOfWeek == "Monday")
                    {

                        string mondaystatus = EventID_In_Template.Rows[EventNumber].ItemArray[1].ToString(); //Mon
                        Boolean.TryParse(mondaystatus, out DayStatus);
                        if (DayStatus)
                        {
                            if (Time == TimeNow)
                            {
                                DataRow rowTableSearch;
                                rowTableSearch = Prepare_TemplateID_ForSendSMS.NewRow();

                                rowTableSearch["TemplateID"] = Template_ID;
                                rowTableSearch["TemplateDescriptionForSend"] = TemplateDescription;

                                Prepare_TemplateID_ForSendSMS.Rows.Add(rowTableSearch);

                            }

                        }
                    }
                    else if (NowDayOfWeek == "Tuesday")
                    {
                        string tuesdaystatus = EventID_In_Template.Rows[EventNumber].ItemArray[2].ToString(); //Tue
                        Boolean.TryParse(tuesdaystatus, out DayStatus);
                        if (DayStatus)
                        {

                            if (Time == TimeNow)
                            {
                                DataRow rowTableSearch;
                                rowTableSearch = Prepare_TemplateID_ForSendSMS.NewRow();

                                rowTableSearch["TemplateID"] = Template_ID;
                                rowTableSearch["TemplateDescriptionForSend"] = TemplateDescription;

                                Prepare_TemplateID_ForSendSMS.Rows.Add(rowTableSearch);

                            }

                        }
                    }
                    else if (NowDayOfWeek == "Wednesday")
                    {
                        string wednesdaystatus = EventID_In_Template.Rows[EventNumber].ItemArray[3].ToString(); //Wed
                        Boolean.TryParse(wednesdaystatus, out DayStatus);
                        if (DayStatus)
                        {

                            if (Time == TimeNow)
                            {
                                DataRow rowTableSearch;
                                rowTableSearch = Prepare_TemplateID_ForSendSMS.NewRow();

                                rowTableSearch["TemplateID"] = Template_ID;
                                rowTableSearch["TemplateDescriptionForSend"] = TemplateDescription;

                                Prepare_TemplateID_ForSendSMS.Rows.Add(rowTableSearch);
                            }

                        }
                    }
                    else if (NowDayOfWeek == "Thursday")
                    {
                        string Thursdaystatus = EventID_In_Template.Rows[EventNumber].ItemArray[4].ToString(); //Thu
                        Boolean.TryParse(Thursdaystatus, out DayStatus);
                        if (DayStatus)
                        {
                            if (Time == TimeNow)
                            {
                                DataRow rowTableSearch;
                                rowTableSearch = Prepare_TemplateID_ForSendSMS.NewRow();

                                rowTableSearch["TemplateID"] = Template_ID;
                                rowTableSearch["TemplateDescriptionForSend"] = TemplateDescription;

                                Prepare_TemplateID_ForSendSMS.Rows.Add(rowTableSearch);


                            }

                        }
                    }
                    else if (NowDayOfWeek == "Friday")
                    {
                        string fridaystatus = EventID_In_Template.Rows[EventNumber].ItemArray[5].ToString(); //Fri
                        Boolean.TryParse(fridaystatus, out DayStatus);
                        if (DayStatus)
                        {
                            if (Time == TimeNow)
                            {
                                DataRow rowTableSearch;
                                rowTableSearch = Prepare_TemplateID_ForSendSMS.NewRow();

                                rowTableSearch["TemplateID"] = Template_ID;
                                rowTableSearch["TemplateDescriptionForSend"] = TemplateDescription;

                                Prepare_TemplateID_ForSendSMS.Rows.Add(rowTableSearch);
                            }

                        }
                    }
                    else if (NowDayOfWeek == "Saturday")
                    {
                        string saturdaystatus = EventID_In_Template.Rows[EventNumber].ItemArray[6].ToString(); //Sat
                        Boolean.TryParse(saturdaystatus, out DayStatus);
                        if (DayStatus)
                        {

                            if (Time == TimeNow)
                            {
                                DataRow rowTableSearch;
                                rowTableSearch = Prepare_TemplateID_ForSendSMS.NewRow();

                                rowTableSearch["TemplateID"] = Template_ID;
                                rowTableSearch["TemplateDescriptionForSend"] = TemplateDescription;

                                Prepare_TemplateID_ForSendSMS.Rows.Add(rowTableSearch);

                            }

                        }
                    }
                    else if (NowDayOfWeek == "Sunday")
                    {
                        string sundaystatus = EventID_In_Template.Rows[EventNumber].ItemArray[7].ToString(); //Sun
                        Boolean.TryParse(sundaystatus, out DayStatus);
                        if (DayStatus)
                        {

                            if (Time == TimeNow)
                            {
                                DataRow rowTableSearch;
                                rowTableSearch = Prepare_TemplateID_ForSendSMS.NewRow();

                                rowTableSearch["TemplateID"] = Template_ID;
                                rowTableSearch["TemplateDescriptionForSend"] = TemplateDescription;

                                Prepare_TemplateID_ForSendSMS.Rows.Add(rowTableSearch);

                            }

                        }

                    }

                    //
                }
            }
            catch(Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path + "\\" + NowDate + ".txt"))
                {
                    sw.WriteLine("!!!!!!!!!!!!!!!!!!!!ERROR!!!!!!!!!!!!!!!!!!!!");
                    sw.WriteLine(ex);

                }
            }
            

        }       

        private void GET_TagValue(ref string[] TagTimeStamp,ref string[] TagValue)
        {
            try
            {
                PISDK.Server myServer; // server object from the name in textBox1 

                PISDK.PIPoints myPoints; // PIPoints collection of server 

                PISDK.PIPoint snapPoint; // point from the name in textBox2 

                PISDK.PIValue myValue; // snapshot value 

                for (int row = 0; row < Tag_in_TemplateTable.Rows.Count; row++)
                {
                    string server = Tag_in_TemplateTable.Rows[row].ItemArray[0].ToString(); //Server
                    myServer = g_SDK.Servers[server];

                    myPoints = myServer.PIPoints;

                    snapPoint = myPoints[Tag_in_TemplateTable.Rows[row].ItemArray[1].ToString()]; //Tag name

                    myValue = snapPoint.Data.Snapshot;

                    TagTimeStamp[row] = myValue.TimeStamp.LocalDate.ToString();

                    // 

                    // Check to see if we got a digital state back 

                    // 

                    if (myValue.Value.GetType().IsCOMObject)
                    {

                        PISDK.DigitalState myDigState;

                        myDigState = (PISDK.DigitalState)myValue.Value;

                        TagValue[row] = myDigState.Name;

                    }
                    else
                    {

                        TagValue[row] = myValue.Value.ToString();

                    }
                }

            }
            catch (System.Runtime.InteropServices.COMException comExc)
            {
                using (StreamWriter sw = File.AppendText(path + "\\" + NowDate + ".txt"))
                {
                    sw.WriteLine("!!!!!!!!!!!!!!!!!!!!ERROR!!!!!!!!!!!!!!!!!!!!");
                    sw.WriteLine(comExc);

                }
                //MessageBox.Show(comExc.Message, comExc.ErrorCode + " Error",

                //MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        #region Send_SMS

        public void Send_SMS()
        {
            try
            {
                using (SMSGateway.CTSMSDTACSoapClient client = new SMSGateway.CTSMSDTACSoapClient())
                {
                    string newFileName = AppDomain.CurrentDomain.BaseDirectory + "\\Log\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".csv";
                    int sendmessage = 0;
                    try
                    {
                        if (!File.Exists(newFileName))
                        {
                            string clientHeader = "Time" + "," + "USERID" + "," + "Phone" + "," + "message" + "," + "Status" + Environment.NewLine;

                            File.WriteAllText(newFileName, clientHeader);
                        }

                        for (int template = 0; template < Prepare_TemplateID_ForSendSMS.Rows.Count; template++)
                        {
                            int Template_ID = Convert.ToInt32(Prepare_TemplateID_ForSendSMS.Rows[template].ItemArray[0].ToString());
                            string TemplateDescription = Prepare_TemplateID_ForSendSMS.Rows[template].ItemArray[1].ToString();

                            LoadDataTo_User_In_TemplateTable(Template_ID);
                            Load_TaginTemplate_To_DataTable(Template_ID);

                            string[] TagTimeStamp = new string[Tag_in_TemplateTable.Rows.Count];
                            string[] TagValue = new string[Tag_in_TemplateTable.Rows.Count];

                            GET_TagValue(ref TagTimeStamp, ref TagValue);

                            string header = Pub_Config.Rows[0].ItemArray[1].ToString();

                            string message = TemplateDescription + "\n"; //Template Description
                            string messagelog = TemplateDescription + " ";
                            for (int tag = 0; tag < Tag_in_TemplateTable.Rows.Count; tag++)
                            {
                                string tagalias = Tag_in_TemplateTable.Rows[tag].ItemArray[2].ToString(); //Tag alias
                                message += tagalias + "\n";
                                message += TagValue[tag] + "\n";
                                messagelog += tagalias + " ";
                                messagelog += TagValue[tag] + " ";
                            }


                            for (sendmessage = 0; sendmessage < User_In_Template.Rows.Count; sendmessage++)
                            {
                                string phonenumber = User_In_Template.Rows[sendmessage].ItemArray[4].ToString();
                                char in_msg_type = 'E';

                                SMSGateway.SMS_Result response = client.sendSMS2DTAC(phonenumber, header, message, in_msg_type);
                                response.result.ToString();

                                message = message.Remove(message.Length - 2);
                                using (StreamWriter file2 = File.AppendText(newFileName))
                                {
                                    string clientDetails = DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "," + User_In_Template.Rows[sendmessage].ItemArray[0].ToString() + "," + phonenumber + "," + messagelog + "," + response.result.ToString() + "";

                                    file2.WriteLine(clientDetails);
                                }

                            }
                        }
                        Prepare_TemplateID_ForSendSMS.Clear();
                    }
                    catch (Exception ex)
                    {
                        using (StreamWriter sw = File.AppendText(path + "\\" + NowDate + ".txt"))
                        {
                            sw.WriteLine("!!!!!!!!!!!!!!!!!!!!ERROR!!!!!!!!!!!!!!!!!!!!");
                            sw.WriteLine(ex);

                        }
                    }

                }
            }
            catch(Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path + "\\" + NowDate + ".txt"))
                {
                    sw.WriteLine("!!!!!!!!!!!!!!!!!!!!ERROR!!!!!!!!!!!!!!!!!!!!");
                    sw.WriteLine(ex);

                }
            }
            
            
        }

        #endregion

    }
}
