using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PI_SMS
{
    public partial class Template : Form
    {
        DataTable template_dataTable = new DataTable();
        string connectionString = "";
        int SelectedrowIndexdataGridView;
        string DataBaseName="";


        private readonly PISMS pisms;

        public Template(PISMS Frompisms)
        {
            InitializeComponent();
            pisms = Frompisms;
            start();
            
        }

        public void start()
        {
            template_dataTable.Clear();
            dataGridViewTemplate.Rows.Clear();


            //PISMS pisms = new PISMS();
            string IP = pisms.Pub_Config.Rows[0].ItemArray[0].ToString();
            DataBaseName = pisms.Pub_Config.Rows[0].ItemArray[2].ToString();
            string UserID = pisms.Pub_Config.Rows[0].ItemArray[3].ToString();
            string Password = pisms.Pub_Config.Rows[0].ItemArray[4].ToString();
            connectionString = "Data Source = " + IP + "; Initial Catalog =" + DataBaseName + "; User ID =" + UserID + "; Password =" + Password;

            LoadDataToTable_Template();
            for (int row = 0; row < template_dataTable.Rows.Count; row++)
            {
                dataGridViewTemplate.Rows.Add();
            }
            Filldatagridview();
        }

        #region Load DataTable

        void LoadDataToTable_Template()
        {
            try
            {
                template_dataTable.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT * FROM ["+DataBaseName+"].[dbo].[NotificationTemplate] ORDER BY TemplateName";
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

        #region filldata

        private void Filldatagridview()
        {
            try
            {
                for (int row = 0; row < template_dataTable.Rows.Count; row++)
                {
                    dataGridViewTemplate.Rows[row].Cells["TemplateID"].Value = template_dataTable.Rows[row].ItemArray[3]; //AutoIncrement
                    dataGridViewTemplate.Rows[row].Cells["TemplateName"].Value = template_dataTable.Rows[row].ItemArray[4];                    
                    dataGridViewTemplate.Rows[row].Cells["DescriptionCol"].Value = template_dataTable.Rows[row].ItemArray[0];
                    dataGridViewTemplate.Rows[row].Cells["SMSCol"].Value = template_dataTable.Rows[row].ItemArray[1];                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region mouseclick in datagridview

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {

                }
                else
                {
                    ContextMenuStrip my_menu = new ContextMenuStrip();
                    SelectedrowIndexdataGridView = dataGridViewTemplate.HitTest(e.X, e.Y).RowIndex;
                    dataGridViewTemplate.ClearSelection();
                    if (SelectedrowIndexdataGridView >= 0)
                    {
                        dataGridViewTemplate.Rows[SelectedrowIndexdataGridView].Selected = true;
                    }
                    
                    //MessageBox.Show("right click");
                    //MessageBox.Show(SelectedrowIndexdataGridView.ToString());

                    if (SelectedrowIndexdataGridView >= 0)
                    {
                        my_menu.Items.Add("Edit").Name = "Edit";
                        my_menu.Items.Add("Remove").Name = "Delete";
                    }
                    my_menu.Show(dataGridViewTemplate, new Point(e.X, e.Y));

                    //Event menu Click
                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClicked);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void my_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string TemplateSelected = dataGridViewTemplate.Rows[SelectedrowIndexdataGridView].Cells["TemplateID"].Value.ToString();
            switch (e.ClickedItem.Name.ToString())
            {
                case "Delete":
                    //Console.WriteLine("Delete case");
                    try
                    {                       
                        using (SqlConnection connection = new SqlConnection(
                       connectionString))
                        {
                            string queryString3 = "DELETE FROM ["+DataBaseName+"].[dbo].[Template_Event_RelationTable] WHERE TemplateIDAuToInc ='" + TemplateSelected + "'";
                            SqlCommand command3 = new SqlCommand(queryString3, connection);
                            command3.Connection.Open();
                            command3.ExecuteNonQuery();

                            string queryString = "DELETE FROM ["+DataBaseName+"].[dbo].[Template_Tag_Relation] WHERE TemplateIDAuToInc ='" + TemplateSelected + "'";
                            SqlCommand command = new SqlCommand(queryString, connection);                        
                            command.ExecuteNonQuery();

                            string queryString4 = "DELETE FROM ["+DataBaseName+"].[dbo].[User_Template_Relation] WHERE TemplateIDAuToInc ='" + TemplateSelected + "'";
                            SqlCommand command4 = new SqlCommand(queryString4, connection);
                            command4.ExecuteNonQuery();

                            string queryString2 = " DELETE FROM ["+DataBaseName+"].[dbo].[NotificationTemplate] WHERE TemplateIDAuToInc ='" + TemplateSelected + "'";
                            SqlCommand command2 = new SqlCommand(queryString2, connection);
                            //command2.Connection.Open();
                            command2.ExecuteNonQuery();
                            dataGridViewTemplate.Rows.RemoveAt(SelectedrowIndexdataGridView);
                            LoadDataToTable_Template();
                            Filldatagridview();
                            dataGridViewTemplate.Update();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Edit":
                    try
                    {
                        buttonUpdate.Visible = true;
                        buttonAdd.Visible = false;
                        textBoxTemplate.Text = dataGridViewTemplate.Rows[SelectedrowIndexdataGridView].Cells["TemplateName"].Value.ToString();
                        textBoxDescription.Text = dataGridViewTemplate.Rows[SelectedrowIndexdataGridView].Cells["DescriptionCol"].Value.ToString();
                        checkBox1.Checked = Boolean.Parse(dataGridViewTemplate.Rows[SelectedrowIndexdataGridView].Cells["SMSCol"].Value.ToString());

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }           
        }

        #endregion

        #region add
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    int checksameTemplate = 0;
                    string templatename = textBoxTemplate.Text;
                    string description = textBoxDescription.Text;
                    string SmsStatus = checkBox1.Checked.ToString();

                    for (int row = 0; row < dataGridViewTemplate.Rows.Count; row++)
                    {
                        string Template_Ondatagridview = dataGridViewTemplate.Rows[row].Cells["TemplateName"].Value.ToString();
                        //check same TagName
                        if (templatename == Template_Ondatagridview)
                        {
                            MessageBox.Show("Error TemplateName Duplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            checksameTemplate = 1;
                            break;
                        }
                    }

                    if (checksameTemplate == 0)
                    {
                        template_dataTable.Clear();

                        string queryString = "INSERT INTO ["+DataBaseName+"].[dbo].[NotificationTemplate] ([TemplateName],[Description],[SmsNotify])VALUES('"
                            + templatename + "','"
                            + description + "','" 
                            + SmsStatus + "')";

                        SqlCommand command = new SqlCommand(queryString, connection);
                        command.Connection.Open();
                        command.ExecuteNonQuery();

                        dataGridViewTemplate.Rows.Add();
                        LoadDataToTable_Template();
                        Filldatagridview();
                        dataGridViewTemplate.Update();
                        textBoxTemplate.Clear();
                        textBoxDescription.Clear();
                    }//end if decide insert

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        #endregion

        #region Cancel

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonAdd.Visible = true;
            buttonUpdate.Visible = false;
            textBoxTemplate.Clear();
            textBoxDescription.Clear();
            checkBox1.Checked = false;
        }
        #endregion

        private void checkBoxEnableAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnableAll.Checked)
            {
                checkBoxDisablAll.Checked = false;
            }

        }

        private void checkBoxDisablAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDisablAll.Checked)
            {
                checkBoxEnableAll.Checked = false;
            }

        }

        private void buttonUpdateStatusSMS_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "";
                if (checkBoxDisablAll.Checked)
                {
                    queryString = "UPDATE ["+DataBaseName+"].[dbo].[NotificationTemplate] SET SMSNotify='False' ";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        SqlCommand command = new SqlCommand(queryString, connection);
                        SqlDataAdapter data = new SqlDataAdapter(command);
                        command.Connection.Open();
                        command.ExecuteNonQuery();

                        LoadDataToTable_Template();
                        Filldatagridview();
                        dataGridViewTemplate.Update();
                    }
                }
                else if (checkBoxEnableAll.Checked)
                {
                    queryString = "UPDATE ["+DataBaseName+"].[dbo].[NotificationTemplate] SET SMSNotify='" + checkBoxEnableAll.Checked + "' ";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        SqlCommand command = new SqlCommand(queryString, connection);
                        SqlDataAdapter data = new SqlDataAdapter(command);
                        command.Connection.Open();
                        command.ExecuteNonQuery();

                        LoadDataToTable_Template();
                        Filldatagridview();
                    }
                }
                else if (!checkBoxEnableAll.Checked && !checkBoxDisablAll.Checked)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        for (int row = 0; row < dataGridViewTemplate.Rows.Count; row++)
                        {
                            queryString = "UPDATE [" + DataBaseName + "].[dbo].[NotificationTemplate] SET SMSNotify='" + dataGridViewTemplate.Rows[row].Cells["SMSCol"].Value.ToString() + "' WHERE TemplateIDAuToInc='"+ dataGridViewTemplate.Rows[row].Cells["TemplateID"].Value.ToString() + "'";

                            SqlCommand command = new SqlCommand(queryString, connection);
                            SqlDataAdapter data = new SqlDataAdapter(command);
                            if (row == 0)
                            {
                                command.Connection.Open();
                            }

                            command.ExecuteNonQuery();


                        }
                    }
                    LoadDataToTable_Template();
                    Filldatagridview();
                }
                MessageBox.Show("UPDATE Done", "UPDATE");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                                           
        }

        public void mydispose()
        {
            template_dataTable.Dispose();
            panel1.Dispose();
            panel2.Dispose();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
                       connectionString))
                {
                    string queryString3 = "Update [" + DataBaseName + "].[dbo].[NotificationTemplate] SET [TemplateName]='" + textBoxTemplate.Text.ToString() + "',[Description]='" + textBoxDescription.Text.ToString() + "',[SMSNotify]='" + checkBox1.Checked.ToString() + "' WHERE TemplateIDAuToInc= '"+ dataGridViewTemplate.Rows[SelectedrowIndexdataGridView].Cells["TemplateID"].Value.ToString() + "'"; 
                    SqlCommand command3 = new SqlCommand(queryString3, connection);
                    command3.Connection.Open();
                    command3.ExecuteNonQuery();

                    LoadDataToTable_Template();
                    Filldatagridview();
                    dataGridViewTemplate.Update();

                    buttonAdd.Visible = true;
                    buttonUpdate.Visible = false;
                    textBoxTemplate.Clear();
                    textBoxDescription.Clear();
                    checkBox1.Checked = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
