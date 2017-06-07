using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace PI_SMS
{
    public partial class SendTemplate : Form
    {
        DataTable UserTemplate_data = new DataTable(); //User In Template
        DataTable template_dataTable = new DataTable();
        DataTable UserconfigUser_data = new DataTable();
        DataTable Tag_in_TemplateTable = new DataTable();
        string connectionString = "";
        string DataBaseName = "";

        public DataTable Pub_Config = new DataTable();
        OleDbConnection connecAccess = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + AppDomain.CurrentDomain.BaseDirectory + "\\SystemConfig.mdb;Persist Security Info=False");

        PISDK.PISDK g_SDK;

        PISDKDlg.ApplicationObject g_SDKDlgAppObject; // PISDK dialog app. object 

        private readonly PISMS pisms;
        public SendTemplate(PISMS pisms)
        {
            InitializeComponent();
            this.pisms = pisms;
            string IP = pisms.Pub_Config.Rows[0].ItemArray[0].ToString();
            DataBaseName = pisms.Pub_Config.Rows[0].ItemArray[2].ToString();
            string UserID = pisms.Pub_Config.Rows[0].ItemArray[3].ToString();
            string Password = pisms.Pub_Config.Rows[0].ItemArray[4].ToString();
            connectionString = "Data Source = " + IP + "; Initial Catalog =" + DataBaseName + "; User ID =" + UserID + "; Password =" + Password;

            g_SDK = new PISDK.PISDKClass();

            g_SDKDlgAppObject = new PISDKDlg.ApplicationObjectClass();

            fillcombobox();
            LoadDataToTable_Template();
            FilldatagridviewTemplate();
            LoadDataToTable_UserconfigUser_data();
            FilldataGridViewAllUser();
            getconfig();
        }

        private void fillcombobox()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    SqlDataReader datareader;
                    DataTable tableTemplate = new DataTable();
                    string queryString = "SELECT TemplateName,TemplateIDAuToInc FROM [" + DataBaseName + "].[dbo].[NotificationTemplate] ORDER BY TemplateName";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    datareader = command.ExecuteReader();
                    tableTemplate.Load(datareader);
                    comboBoxTemplate.DisplayMember = "TemplateName";
                    comboBoxTemplate.ValueMember = "TemplateIDAuToInc";
                    comboBoxTemplate.DataSource = tableTemplate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                for (int row =0;row < dataGridViewUserToSend.Rows.Count; row++)
                {
                    dataGridViewUserToSend.Rows[row].Cells["DeleteUserToSend"].Value = checkBox1.Checked.ToString();
                }
            }
            else
            {
                for (int row = 0; row < dataGridViewUserToSend.Rows.Count; row++)
                {
                    dataGridViewUserToSend.Rows[row].Cells["DeleteUserToSend"].Value = checkBox1.Checked.ToString();
                }
            }
        }

        #region LoadDataToTable_Template

        void LoadDataToTable_Template()
        {
            try
            {
                template_dataTable.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT * FROM [" + DataBaseName + "].[dbo].[NotificationTemplate] ORDER BY TemplateName";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(template_dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region FilldatagridviewTemplate

        private void FilldatagridviewTemplate()
        {
            try
            {
                for (int row = 0; row < template_dataTable.Rows.Count; row++)
                {
                    dataGridViewTemplate.Rows.Add();
                    dataGridViewTemplate.Rows[row].Cells["TemplateID"].Value = template_dataTable.Rows[row].ItemArray[3]; //AutoIncrement
                    dataGridViewTemplate.Rows[row].Cells["Template"].Value = template_dataTable.Rows[row].ItemArray[4];
                    dataGridViewTemplate.Rows[row].Cells["addTemplate"].Value = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region LoadDataToTable_UserconfigUser_data

        private void LoadDataToTable_UserconfigUser_data()
        {
            try
            {

                UserconfigUser_data.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT * FROM [" + DataBaseName + "].[dbo].[User] ORDER BY UserID";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(UserconfigUser_data);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region FilldataGridViewAllUser

        void FilldataGridViewAllUser()
        {
            try
            {
                for (int row = 0; row < UserconfigUser_data.Rows.Count; row++)
                {
                    dataGridViewAllUser.Rows.Add();
                    dataGridViewAllUser.Rows[row].Cells[0].Value = false;
                    //dataGridViewAllUser.Rows[row].Cells["UserID"].Value = UserconfigUser_data.Rows[row].ItemArray[0];
                    dataGridViewAllUser.Rows[row].Cells["FirstnameAvilableUser"].Value = UserconfigUser_data.Rows[row].ItemArray[6];
                    dataGridViewAllUser.Rows[row].Cells["LastnameAvilableUser"].Value = UserconfigUser_data.Rows[row].ItemArray[7];
                    //dataGridViewAllUser.Rows[row].Cells["Email"].Value = UserconfigUser_data.Rows[row].ItemArray[2];
                    dataGridViewAllUser.Rows[row].Cells["PhoneAvilableUser"].Value = UserconfigUser_data.Rows[row].ItemArray[3];
                    //dataGridViewAllUser.Rows[row].Cells["UserIDAuToInc"].Value = UserconfigUser_data.Rows[row].ItemArray[5];
                    //dataGridViewAllUser.Rows[row].Cells["Role"].Value = UserconfigUser_data.Rows[row].ItemArray[4].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region get config

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

        #endregion

        private void buttonUser_Click(object sender, EventArgs e)
        {
            dataGridViewAllUser.Visible = true;
            dataGridViewTemplate.Visible = false;

        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            dataGridViewTemplate.Visible = true;
            dataGridViewAllUser.Visible = false;
        }

        #region LoadData_UserTemplate

        private void LoadDataTo_UserTemplateTable(int row)
        {
            try
            {
                UserTemplate_data.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string TemplateSelected = dataGridViewTemplate.Rows[row].Cells["TemplateID"].Value.ToString();
                    string queryString = "SELECT [" + DataBaseName + "].[dbo].[User].UserID,[" + DataBaseName + "].[dbo].[User].FirstName,[" + DataBaseName + "].[dbo].[User].LastName,[" + DataBaseName + "].[dbo].[User].UserIDAuToInc,[" + DataBaseName + "].[dbo].[User].HandPhone" +
" From[" + DataBaseName + "].[dbo].[User_Template_Relation]" +
" JOIN NotificationTemplate ON[" + DataBaseName + "].[dbo].[User_Template_Relation].TemplateIDAuToInc = [" + DataBaseName + "].[dbo].[NotificationTemplate].TemplateIDAuToInc" +
" JOIN [" + DataBaseName + "].[dbo].[User] ON[" + DataBaseName + "].[dbo].[User_Template_Relation].UserIDAutoInc = [" + DataBaseName + "].[dbo].[User].UserIDAutoInc" +
" WHERE [NotificationTemplate].TemplateIDAuToInc='" + TemplateSelected + "' ORDER BY FirstName";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(UserTemplate_data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region FilldatagridviewUserToSendByTemplate

        private void FilldatagridviewUserToSendByTemplate()
        {
            try
            {
                for (int row = 0; row < UserTemplate_data.Rows.Count; row++)
                {
                    dataGridViewUserToSend.Rows.Add();
                    int rowdatagridview = (dataGridViewUserToSend.RowCount)-1;
                    dataGridViewUserToSend.Rows[rowdatagridview].Cells["DeleteUserToSend"].Value = false;
                    //dataGridViewUserToSend.Rows[row].Cells["UserID"].Value = UserTemplate_data.Rows[row].ItemArray[0];
                    dataGridViewUserToSend.Rows[rowdatagridview].Cells["FirstnameToSend"].Value = UserTemplate_data.Rows[row].ItemArray[1];
                    dataGridViewUserToSend.Rows[rowdatagridview].Cells["LastNameToSend"].Value = UserTemplate_data.Rows[row].ItemArray[2];
                    //dataGridViewUserToSend.Rows[row].Cells["UserIDAuToInc"].Value = UserTemplate_data.Rows[row].ItemArray[3];
                    dataGridViewUserToSend.Rows[rowdatagridview].Cells["PhoneNoToSend"].Value = UserTemplate_data.Rows[row].ItemArray[4];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
       
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAllUser.Visible == true)
                {
                    for (int row = 0; row < dataGridViewTemplate.Rows.Count; row++)
                    {
                        if (dataGridViewAllUser.Rows[row].Cells["adduser"].Value.ToString() == "True")
                        {
                            dataGridViewUserToSend.Rows.Add();
                            int rowdatagridview = (dataGridViewUserToSend.RowCount) - 1;
                            dataGridViewUserToSend.Rows[rowdatagridview].Cells[0].Value = false;
                            dataGridViewUserToSend.Rows[rowdatagridview].Cells["FirstnameToSend"].Value = dataGridViewAllUser.Rows[row].Cells["FirstnameAvilableUser"].Value.ToString();
                            dataGridViewUserToSend.Rows[rowdatagridview].Cells["LastNameToSend"].Value = dataGridViewAllUser.Rows[row].Cells["LastnameAvilableUser"].Value.ToString();
                            dataGridViewUserToSend.Rows[rowdatagridview].Cells["PhoneNoToSend"].Value = dataGridViewAllUser.Rows[row].Cells["PhoneAvilableUser"].Value.ToString();
                        }

                    }
                }

                else if (dataGridViewTemplate.Visible == true)
                {
                    for (int row = 0; row < dataGridViewTemplate.Rows.Count; row++)
                    {
                        if (dataGridViewTemplate.Rows[row].Cells["addTemplate"].Value.ToString() == "True")
                        {
                            LoadDataTo_UserTemplateTable(row);
                            FilldatagridviewUserToSendByTemplate();
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                for (int row = dataGridViewUserToSend.Rows.Count - 1; row >=0; row--)
                {
                    if (dataGridViewUserToSend.Rows[row].Cells[0].Value.ToString() == "True")
                    {
                        dataGridViewUserToSend.Rows.RemoveAt(row);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonManAdd_Click(object sender, EventArgs e)
        {
            dataGridViewUserToSend.Rows.Add();
            int rowdatagridview = (dataGridViewUserToSend.RowCount) - 1;
            dataGridViewUserToSend.Rows[rowdatagridview].Cells["FirstnameToSend"].Value = "Unknown";
            dataGridViewUserToSend.Rows[rowdatagridview].Cells["PhoneNoToSend"].Value = textBox1.Text.ToString();
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

            }

        }

        #endregion

        private void GET_TemplateDescription(ref string TemplateDescription)
        {
            for(int row = 0; row < template_dataTable.Rows.Count; row++)
            {

                if(template_dataTable.Rows[row].ItemArray[3].ToString() == comboBoxTemplate.SelectedValue.ToString())
                {
                    TemplateDescription = template_dataTable.Rows[row].ItemArray[0].ToString();
                }
            }
            
        }

        private void GET_TagValue(ref string[] TagTimeStamp, ref string[] TagValue)
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
                //MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("ERROR " + comExc,"ERROR");
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            using (SMSGateway.CTSMSDTACSoapClient client = new SMSGateway.CTSMSDTACSoapClient())
            {
                try
                {
                    int Template_ID = Convert.ToInt32(comboBoxTemplate.SelectedValue.ToString());
                    string TemplateDescription = "";
                    GET_TemplateDescription(ref TemplateDescription);
                    Load_TaginTemplate_To_DataTable(Template_ID);

                    string[] TagTimeStamp = new string[Tag_in_TemplateTable.Rows.Count];
                    string[] TagValue = new string[Tag_in_TemplateTable.Rows.Count];

                    GET_TagValue(ref TagTimeStamp, ref TagValue);

                    string header = Pub_Config.Rows[0].ItemArray[1].ToString();

                    string message = TemplateDescription + "\n"; //Template Description

                    for (int tag = 0; tag < Tag_in_TemplateTable.Rows.Count; tag++)
                    {
                        string tagalias = Tag_in_TemplateTable.Rows[tag].ItemArray[2].ToString(); //Tag alias
                        message += tagalias + "\n";
                        message += TagValue[tag] + "\n";

                    }
                    for (int row = 0; row < dataGridViewUserToSend.Rows.Count; row++)
                    {
                        string phonenumber = dataGridViewUserToSend.Rows[row].Cells[3].Value.ToString();
                        char in_msg_type = 'E';

                        SMSGateway.SMS_Result response = client.sendSMS2DTAC(phonenumber, header, message, in_msg_type);
                        response.result.ToString();

                        message = message.Remove(message.Length - 2);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
