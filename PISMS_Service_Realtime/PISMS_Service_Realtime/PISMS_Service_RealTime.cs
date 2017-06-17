using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace PISMS_Service_Realtime
{
    public partial class PISMS_Service_RealTime : ServiceBase
    {
        DataTable Alertinformation = new DataTable();
        DataTable Tag_in_RealTimeGroup = new DataTable();
        DataTable User_in_RealTimeGroup = new DataTable();
        DataTable Pub_Config = new DataTable();
        DataTable TagConditionTable = new DataTable();
        DataTable RealTimeGroupTable = new DataTable();
        OleDbConnection connecAccess = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + AppDomain.CurrentDomain.BaseDirectory + "\\SystemConfig.mdb;Persist Security Info=False");
        string connectionString, DataBaseName;
        PISDK.PISDK g_SDK;

        PISDKDlg.ApplicationObject g_SDKDlgAppObject; // PISDK dialog app. object 

        public PISMS_Service_RealTime()
        {
            InitializeComponent();

        }

        //public void OnDebug()
        //{
        //    OnStart(null);
        //}

        public void RunAsConsole(string[] args)
        {
            OnStart(args);
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
            OnStop();
        }

        protected override void OnStart(string[] args)
        {
            g_SDK = new PISDK.PISDKClass();

            g_SDKDlgAppObject = new PISDKDlg.ApplicationObjectClass();
        }

        protected override void OnStop()
        {

        }

        

        private void LoadRealTimeGroup()
        {
            try
            {
                RealTimeGroupTable.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT * FROM [" + DataBaseName + "].[dbo].[RealTimeGroup] ";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(RealTimeGroupTable);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_User_in_RealTimeGroup(string groupid)
        {
            try
            {
                User_in_RealTimeGroup.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT [" + DataBaseName + "].[dbo].[User].UserID,[" + DataBaseName + "].[dbo].[User].UserIDAuToInc,[" + DataBaseName + "].[dbo].[RealTimeGroup].RealTimeGroupID,[" + DataBaseName + "].[dbo].[User].HandPhone"
+ " FROM[" + DataBaseName + "].[dbo].[User_RealTimeGroup_Relation]"
+ " JOIN[" + DataBaseName + "].[dbo].[User] ON[" + DataBaseName + "].[dbo].[User_RealTimeGroup_Relation].UserIDAuToInc = [" + DataBaseName + "].[dbo].[User].UserIDAutoInc"
+ " JOIN[" + DataBaseName + "].[dbo].[RealTimeGroup] ON[" + DataBaseName + "].[dbo].[User_RealTimeGroup_Relation].RealTimeGroupID = [" + DataBaseName + "].[dbo].[RealTimeGroup].RealTimeGroupID"
+ " WHERE RealTimeGroup.RealTimeGroupID='" + groupid + "' ORDER BY UserID";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(User_in_RealTimeGroup);

                }
            }
            catch (Exception ex)
            {
                //essageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTag_in_RealTimeGroup(string groupid)
        {
            try
            {
                Tag_in_RealTimeGroup.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string groupselect = groupid;
                    string queryString = "SELECT [" + DataBaseName + "].[dbo].[RealTimeTag].TagName,["/*0*/
                        + DataBaseName + "].[dbo].[RealTimeTag].PIServer," +
                        "[" + DataBaseName + "].[dbo].[RealTimeTag].Type,["/*2*/
                        + DataBaseName + "].[dbo].[RealTimeTag].Enabled," +
                        "[" + DataBaseName + "].[dbo].[RealTimeTag].Mail,["/*4*/
                        + DataBaseName + "].[dbo].[RealTimeTag].Phone," +
                        "[" + DataBaseName + "].[dbo].[RealTimeTag].RealTimeTagID,["/*6*/ 
                        + DataBaseName + "].[dbo].[RealTimeTag].TagAlias," +
                        "[" + DataBaseName + "].[dbo].[RealTimeTag].High," +/*8*/
                        "[" + DataBaseName + "].[dbo].[RealTimeTag].Low," +
                        "[" + DataBaseName + "].[dbo].[RealTimeTag].Danger," +/*10*/
                        "[" + DataBaseName + "].[dbo].[RealTimeTag].MessageForm" +
" From[" + DataBaseName + "].[dbo].[RealTimeTag_RealTimeGroup_Relation]" +
" JOIN RealTimeTag ON[" + DataBaseName + "].[dbo].[RealTimeTag_RealTimeGroup_Relation].RealTimeTagID = [" + DataBaseName + "].[dbo].[RealTimeTag].RealTimeTagID" +
" JOIN[" + DataBaseName + "].[dbo].[RealTimeGroup] ON[" + DataBaseName + "].[dbo].[RealTimeTag_RealTimeGroup_Relation].RealTimeGroupID = [" + DataBaseName + "].[dbo].[RealTimeGroup].RealTimeGroupID" +
" WHERE [RealTimeGroup].RealTimeGroupID='" + groupselect + "' ";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(Tag_in_RealTimeGroup);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Load_TagCondition(string tagid)
        {
            try
            {
                TagConditionTable.Rows.Clear();
                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    //string tag = tagid;
                    string queryString = "SELECT * FROM [" + DataBaseName + "].[dbo].[RealTimeTagCondition] WHERE RealTimeTagID = '" + tagid + "'";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(TagConditionTable);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Get_value(ref string[] TagTimeStamp, ref string[] TagValue)
        {
            try
            {
                PISDK.Server myServer; // server object from the name in textBox1 

                PISDK.PIPoints myPoints; // PIPoints collection of server 

                PISDK.PIPoint snapPoint; // point from the name in textBox2 

                PISDK.PIValue myValue; // snapshot value 

                for (int row = 0; row < Tag_in_RealTimeGroup.Rows.Count; row++)
                {
                    string server = Tag_in_RealTimeGroup.Rows[row].ItemArray[1].ToString(); //Server
                    myServer = g_SDK.Servers[server];

                    myPoints = myServer.PIPoints;

                    snapPoint = myPoints[Tag_in_RealTimeGroup.Rows[row].ItemArray[0].ToString()]; //Tagname

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
                //progressBar1.Visible = false;

            }
            catch (System.Runtime.InteropServices.COMException comExc)
            {

                //MessageBox.Show(comExc.Message, comExc.ErrorCode + " Error",

                //MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void Get_demo_value(ref string[] TagTimeStamp, ref string[] TagValue)
        {
            try
            {
                for (int row = 0; row < Tag_in_RealTimeGroup.Rows.Count; row++)
                {
                    TagTimeStamp[row] = "20/06/60";
                    TagValue[row] = "3";
                }
            }
            catch(Exception ex)
            {

            }
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

        
        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer1.Stop();
            getconfig();
            connectionString = "Data Source = " + Pub_Config.Rows[0].ItemArray[0].ToString() + "; Initial Catalog =" + Pub_Config.Rows[0].ItemArray[2].ToString() + "; User ID =" + Pub_Config.Rows[0].ItemArray[3].ToString() + "; Password =" + Pub_Config.Rows[0].ItemArray[4].ToString() + "";
            DataBaseName = Pub_Config.Rows[0].ItemArray[2].ToString();
            Console.WriteLine("TIMER1");

            LoadRealTimeGroup();
            for (int group = 0; group < RealTimeGroupTable.Rows.Count; group++)
            {
                string groupid = RealTimeGroupTable.Rows[group].ItemArray[1].ToString();
                string groupstatus = RealTimeGroupTable.Rows[group].ItemArray[2].ToString();
                bool groupbool;
                bool.TryParse(groupstatus, out groupbool);
                if (groupbool)
                {
                    Load_User_in_RealTimeGroup(groupid);
                    LoadTag_in_RealTimeGroup(groupid);
                    string[] TagTimeStamp = new string[Tag_in_RealTimeGroup.Rows.Count];
                    string[] TagValue = new string[Tag_in_RealTimeGroup.Rows.Count];
                    //Get_value(ref TagTimeStamp, ref TagValue);
                    Get_demo_value(ref TagTimeStamp, ref TagValue);

                    for (int tag = 0; tag < Tag_in_RealTimeGroup.Rows.Count; tag++)
                    {

                        string TagEnable = Tag_in_RealTimeGroup.Rows[tag].ItemArray[3].ToString();
                        string phoneEnable = Tag_in_RealTimeGroup.Rows[tag].ItemArray[5].ToString();
                        string mailEnable = Tag_in_RealTimeGroup.Rows[tag].ItemArray[4].ToString();
                        string tagID = Tag_in_RealTimeGroup.Rows[tag].ItemArray[6].ToString();

                        Load_TagCondition(tagID);

                        string acknowledge = ""/*Tag_in_RealTimeGroup.Rows[tag].ItemArray[9].ToString()*/;
                        string alert = ""/*Tag_in_RealTimeGroup.Rows[tag].ItemArray[8].ToString()*/;
                        string alertbyoperator = ""/*Tag_in_RealTimeGroup.Rows[tag].ItemArray[14].ToString()*/;
                        string alertconditionvalue = ""/*Tag_in_RealTimeGroup.Rows[tag].ItemArray[15].ToString()*/;
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            Alertinformation.Clear();
                            string queryString = "SELECT * FROM [" + DataBaseName + "].[dbo].[AlertInformation] WHERE RealTimeTagID = '" + tagID + "' AND RealTimeGroupID='" + groupid + "'";
                            SqlCommand command = new SqlCommand(queryString, connection);
                            SqlDataAdapter data = new SqlDataAdapter(command);
                            command.Connection.Open();
                            command.ExecuteNonQuery();
                            data.Fill(Alertinformation);
                            alertbyoperator = Alertinformation.Rows[0].ItemArray[0].ToString();
                            for (int tagcon = 0; tagcon < TagConditionTable.Rows.Count; tagcon++)
                            {
                                if(TagConditionTable.Rows[tagcon].ItemArray[0].ToString() == alertbyoperator)
                                {
                                    alertconditionvalue = TagConditionTable.Rows[tagcon].ItemArray[1].ToString();
                                }
                                
                            }
                                
                            acknowledge = Alertinformation.Rows[0].ItemArray[5].ToString();
                            alert = Alertinformation.Rows[0].ItemArray[3].ToString();
                        }

                        bool TagEnablebool, acknowledgebool, phoneEnablebool, mailEnablebool, alertbool;
                        bool.TryParse(TagEnable, out TagEnablebool);
                        bool.TryParse(acknowledge, out acknowledgebool);
                        bool.TryParse(phoneEnable, out phoneEnablebool);
                        bool.TryParse(mailEnable, out mailEnablebool);
                        bool.TryParse(alert, out alertbool);

                        if (TagEnablebool && !acknowledgebool)
                        {
                            if (phoneEnablebool || mailEnablebool)
                            {
                                
                                
                                for (int tagcon = 0; tagcon < TagConditionTable.Rows.Count; tagcon++)
                                {
                                    string operatorr = TagConditionTable.Rows[tagcon].ItemArray[0].ToString();
                                    int condition_value = Convert.ToInt32(TagConditionTable.Rows[tagcon].ItemArray[1].ToString());
                                    string timetrue = TagConditionTable.Rows[tagcon].ItemArray[2].ToString();
                                    string timetrueUnit = TagConditionTable.Rows[tagcon].ItemArray[3].ToString();
                                    
                                    //Console.Write(TagValue[tag]);

                                    double Tagvalue;
                                    Double.TryParse(TagValue[tag], out Tagvalue);
                                    switch (operatorr)
                                    {
                                        case ">":
                                            if (Tagvalue > condition_value)
                                            {
                                                check_Tagcondition_and_timetrue(condition_value, timetrue, timetrueUnit, tagID, groupid, operatorr, alertconditionvalue, alertbool);
                                            }
                                            else if(alertbool && (alertbyoperator == ">"))//back to normal and not acknowledge
                                            {
                                                using (SqlConnection connection = new SqlConnection(connectionString))
                                                {
                                                    string queryAlert2 = "UPDATE [" + DataBaseName + "].[dbo].[AlertInformation]  SET [OnAlert]='false' WHERE RealTimeTagID='" + tagID + "' AND RealTimeGroupID='" + groupid + "'";
                                                    SqlCommand commandalert2 = new SqlCommand(queryAlert2, connection);
                                                    //SqlDataAdapter data = new SqlDataAdapter(commandalert);
                                                    commandalert2.Connection.Open();
                                                    commandalert2.ExecuteNonQuery();

                                                    string queryAlert3 = "DELETE [" + DataBaseName + "].[dbo].[Alerttime] WHERE RealTimeTagID='" + tagID + "' AND RealTimeGroupID='" + groupid + "')";
                                                    SqlCommand commandalert3 = new SqlCommand(queryAlert3, connection);
                                                    commandalert3.ExecuteNonQuery();
                                                    Console.WriteLine("Back to normal");
                                                }

                                            }
                                            break;
                                        case "<":
                                            if (Tagvalue < condition_value)
                                            {
                                                check_Tagcondition_and_timetrue(condition_value, timetrue, timetrueUnit, tagID, groupid, operatorr, alertconditionvalue, alertbool);
                                            }
                                            else if (alertbool && (alertbyoperator == "<"))//back to normal and not acknowledge
                                            {
                                                using (SqlConnection connection = new SqlConnection(connectionString))
                                                {
                                                    string queryAlert2 = "UPDATE [" + DataBaseName + "].[dbo].[AlertInformation]  SET [OnAlert]='false' WHERE RealTimeTagID='" + tagID + "' AND RealTimeGroupID='" + groupid + "'" +
                                                        " DELETE [" + DataBaseName + "].[dbo].[Alerttime] WHERE RealTimeTagID='" + tagID + "' AND RealTimeGroupID='" + groupid + "' DELETE [" + DataBaseName + "].[dbo].[TimeTrue] WHERE RealTimeTagID='" + tagID + "' AND RealTimeGroupID='" + groupid + "'";
                                                    SqlCommand commandalert2 = new SqlCommand(queryAlert2, connection);
                                                    //SqlDataAdapter data = new SqlDataAdapter(commandalert);
                                                    commandalert2.Connection.Open();
                                                    commandalert2.ExecuteNonQuery();

                                                    Console.WriteLine("Back to normal");
                                                }

                                            }
                                            break;
                                        case ">=":
                                            if (Tagvalue >= condition_value)
                                            {
                                                check_Tagcondition_and_timetrue(condition_value, timetrue, timetrueUnit, tagID, groupid, operatorr, alertconditionvalue, alertbool);
                                            }
                                            else if (alertbool && (alertbyoperator == ">="))//back to normal and not acknowledge
                                            {
                                                using (SqlConnection connection = new SqlConnection(connectionString))
                                                {
                                                    string queryAlert2 = "UPDATE [" + DataBaseName + "].[dbo].[AlertInformation]  SET [OnAlert]='false' WHERE RealTimeTagID='" + tagID + "' AND RealTimeGroupID='" + groupid + "'";
                                                    SqlCommand commandalert2 = new SqlCommand(queryAlert2, connection);
                                                    //SqlDataAdapter data = new SqlDataAdapter(commandalert);
                                                    commandalert2.Connection.Open();
                                                    commandalert2.ExecuteNonQuery();

                                                    string queryAlert3 = "DELETE [" + DataBaseName + "].[dbo].[Alerttime] WHERE RealTimeTagID='" + tagID + "' AND RealTimeGroupID='" + groupid + "')";
                                                    SqlCommand commandalert3 = new SqlCommand(queryAlert3, connection);
                                                    commandalert3.ExecuteNonQuery();
                                                    Console.WriteLine("Back to normal");
                                                }

                                            }
                                            break;
                                        case "<=":
                                            if (Tagvalue <= condition_value)
                                            {
                                                check_Tagcondition_and_timetrue(condition_value, timetrue, timetrueUnit, tagID, groupid, operatorr, alertconditionvalue, alertbool);
                                            }
                                            else if (alertbool && (alertbyoperator == "<="))//back to normal and not acknowledge
                                            {
                                                using (SqlConnection connection = new SqlConnection(connectionString))
                                                {
                                                    string queryAlert2 = "UPDATE [" + DataBaseName + "].[dbo].[AlertInformation]  SET [OnAlert]='false' WHERE RealTimeTagID='" + tagID + "' AND RealTimeGroupID='" + groupid + "'" +
                                                        " DELETE [" + DataBaseName + "].[dbo].[Alerttime] WHERE RealTimeTagID='" + tagID + "' AND RealTimeGroupID='" + groupid + "'";
                                                    SqlCommand commandalert2 = new SqlCommand(queryAlert2, connection);
                                                    //SqlDataAdapter data = new SqlDataAdapter(commandalert);
                                                    commandalert2.Connection.Open();
                                                    commandalert2.ExecuteNonQuery();

                                                    Console.WriteLine("Back to normal");
                                                }

                                            }
                                            break;
                                        case "!=":
                                            if (Tagvalue != condition_value)
                                            {
                                                check_Tagcondition_and_timetrue(condition_value, timetrue, timetrueUnit, tagID, groupid, operatorr, alertconditionvalue, alertbool);
                                            }
                                            else if (alertbool && (alertbyoperator == "!="))//back to normal and not acknowledge
                                            {
                                                using (SqlConnection connection = new SqlConnection(connectionString))
                                                {
                                                    string queryAlert2 = "UPDATE [" + DataBaseName + "].[dbo].[AlertInformation]  SET [OnAlert]='false' WHERE RealTimeTagID='" + tagID + "' AND RealTimeGroupID='" + groupid + "'";
                                                    SqlCommand commandalert2 = new SqlCommand(queryAlert2, connection);
                                                    //SqlDataAdapter data = new SqlDataAdapter(commandalert);
                                                    commandalert2.Connection.Open();
                                                    commandalert2.ExecuteNonQuery();

                                                    string queryAlert3 = "DELETE [" + DataBaseName + "].[dbo].[Alerttime] WHERE RealTimeTagID='" + tagID + "' AND RealTimeGroupID='" + groupid + "')";
                                                    SqlCommand commandalert3 = new SqlCommand(queryAlert3, connection);
                                                    commandalert3.ExecuteNonQuery();
                                                    Console.WriteLine("Back to normal");
                                                }

                                            }
                                            break;
                                    }

                                }// end tag condition
                            }

                        }//end if tag enable and !ack

                        else if (acknowledgebool &&  TagEnablebool)
                        {
                            //string operatorr = Tag_in_RealTimeGroup.Rows[tag].ItemArray[14].ToString();//oprerator

                            int condition_value= Convert.ToInt32(alertconditionvalue);//value

                            double Tagvalue;
                            Double.TryParse(TagValue[tag], out Tagvalue);
                            //Tagvalue = 10;
                            switch (alertbyoperator)
                            {
                                case ">":
                                    if (Tagvalue <= condition_value)
                                    {
                                        SendCloseStage(phoneEnablebool,mailEnablebool,tagID,groupid,tag);
                                        
                                    }
                                    
                                    break;
                                case "<":
                                    if (Tagvalue >= condition_value)
                                    {
                                        SendCloseStage(phoneEnablebool, mailEnablebool, tagID, groupid, tag);
                                        
                                    }
                                    
                                    break;
                                case ">=":
                                    if (Tagvalue < condition_value)
                                    {
                                        SendCloseStage(phoneEnablebool, mailEnablebool, tagID, groupid, tag);
                                        
                                    }
                                    
                                    break;
                                case "<=":
                                    if (Tagvalue > condition_value)
                                    {
                                        SendCloseStage(phoneEnablebool, mailEnablebool, tagID, groupid, tag);
                                        
                                    }
                                    
                                    break;
                                case "!=":
                                    if (Tagvalue == condition_value)
                                    {
                                        SendCloseStage(phoneEnablebool, mailEnablebool, tagID, groupid, tag);
                                        
                                    }
                                    
                                    break;
                            }
                        }
                    }//end loop tag
                }//end if group enable

            }//end group

            timer1.Start();
        }

        private void check_Tagcondition_and_timetrue(int condition_value, string timetrue, string timetrueUnit,string tagID, string groupid,string alertbyoperator,string alertconditionvalue, bool alertbool)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataReader datareader;
                string queryString = "SELECT StartTime FROM [" + DataBaseName + "].[dbo].[TimeTrue] WHERE RealTimeTagID = '" + tagID + "' AND RealTimeGroupID='" + groupid + "'";
                SqlCommand command = new SqlCommand(queryString, connection);
                //SqlDataAdapter data = new SqlDataAdapter(command);
                command.Connection.Open();
                command.ExecuteNonQuery();
                datareader = command.ExecuteReader();
                datareader.Read();

                if (datareader.HasRows)
                {
                    string starttime = datareader["StartTime"].ToString();
                    command.Connection.Close();
                    TimeSpan starttimespan = TimeSpan.Parse(starttime);
                    TimeSpan Endtime = new TimeSpan();
                    TimeSpan timeInterval = new TimeSpan();
                    if (timetrueUnit == "Hour")
                    {
                        timeInterval = new TimeSpan(0, Convert.ToInt32(timetrue), 0, 0);
                    }
                    else if (timetrueUnit == "Minute")
                    {
                        timeInterval = new TimeSpan(0, 0, Convert.ToInt32(timetrue), 0);
                    }
                    Endtime = starttimespan.Add(timeInterval);
                    TimeSpan CurrentTime = DateTime.Now.TimeOfDay;
                    int resultInterval = TimeSpan.Compare(CurrentTime, Endtime);
                    if (resultInterval >= 0)
                    {

                        Console.WriteLine("Alert");
                        string queryAlert = "DELETE FROM [" + DataBaseName + "].[dbo].[TimeTrue] WHERE RealTimeTagID='" + tagID + "' AND RealTimeGroupID='" + groupid + "' ";
                        SqlCommand commandalert = new SqlCommand(queryAlert, connection);
                        //SqlDataAdapter data = new SqlDataAdapter(commandalert);
                        commandalert.Connection.Open();
                        commandalert.ExecuteNonQuery();

                        if (alertbool)
                        {
                            string queryAlert4 = "UPDATE [" + DataBaseName + "].[dbo].[Alerttime]  SET [Alerttime]='" + DateTime.Now.ToString("HH:mm") + "' WHERE RealTimeTagID='" + tagID + "'";
                            SqlCommand commandalert4 = new SqlCommand(queryAlert4, connection);
                            commandalert4.ExecuteNonQuery();
                        }
                        else if (!alertbool)
                        {
                            string queryAlert5 = "UPDATE  [" + DataBaseName + "].[dbo].[AlertInformation] SET [alertbyoperator]='"+alertbyoperator+"',[OnAlert]='true' WHERE [RealTimeTagID]='" + tagID+"' AND [RealTimeGroupID]='"+ groupid + "'";
                            SqlCommand commandalert5 = new SqlCommand(queryAlert5, connection);
                            commandalert5.ExecuteNonQuery();

                            string queryAlert3 = "DELETE FROM [" + DataBaseName + "].[dbo].[Alerttime] WHERE RealTimeTagID='" + tagID + "' AND RealTimeGroupID='" + groupid + "'"+
                                " INSERT INTO [" + DataBaseName + "].[dbo].[Alerttime] ([Alerttime],[RealTimeTagID],[RealTimeGroupID]) VALUES ('" + DateTime.Now.ToString("HH:mm") + "','" + tagID + "','" + groupid + "')";
                            SqlCommand commandalert3 = new SqlCommand(queryAlert3, connection);
                            commandalert3.ExecuteNonQuery();

                            //string queryAlert2 = "UPDATE [" + DataBaseName + "].[dbo].[RealTimeTag]  SET [OnAlert]='true' WHERE RealTimeTagID='" + tagID + "'";
                            //SqlCommand commandalert2 = new SqlCommand(queryAlert2, connection);
                            //commandalert2.ExecuteNonQuery();
                        }
                                              
                    }
                }
                else
                {
                    command.Connection.Close();
                    string queryAlert = "INSERT INTO [" + DataBaseName + "].[dbo].[TimeTrue] ([StartTime],[RealTimeTagID],[RealTimeGroupID]) VALUES ('" + DateTime.Now.ToString("HH:mm") + "','" + tagID + "','" + groupid + "')";
                    SqlCommand commandalert = new SqlCommand(queryAlert, connection);
                    //SqlDataAdapter data = new SqlDataAdapter(commandalert);
                    commandalert.Connection.Open();
                    commandalert.ExecuteNonQuery();
                }

            }
        }

        private void SendCloseStage(bool phoneEnablebool ,bool mailEnablebool, string tagID, string groupid,int tag)
        {
            if (phoneEnablebool)
            {
                using (SMSGateway.CTSMSDTACSoapClient client = new SMSGateway.CTSMSDTACSoapClient())
                {
                    try
                    {
                        char type = 'E';
                        string message = Tag_in_RealTimeGroup.Rows[tag].ItemArray[11].ToString();
                        string header = Pub_Config.Rows[0].ItemArray[2].ToString();
                        for(int user = 0; user < User_in_RealTimeGroup.Rows.Count; user++)
                        {
                            string phonenumber = User_in_RealTimeGroup.Rows[user].ItemArray[3].ToString();

                            //SMSGateway.SMS_Result result = client.sendSMS2DTAC(phonenumber, header, message, type);
                        }
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string queryString = "UPDATE [" + DataBaseName + "].[dbo].[AlertInformation] SET [OnAlert]='false',[Acknowledge]='false' WHERE RealTimeTagID='" + tagID+ "' AND RealTimeGroupID ='"+ groupid + "'";
                            SqlCommand command = new SqlCommand(queryString, connection);
                            SqlDataAdapter data = new SqlDataAdapter(command);
                            command.Connection.Open();
                            command.ExecuteNonQuery();
                        }


                    }
                    catch (Exception ex)
                    {
                        
                    }
                }
            }
            if (mailEnablebool)
            {

            }
        }
    }
}
