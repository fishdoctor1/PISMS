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
    public partial class RealTimeGroup : Form
    {
        DataTable datagroup = new DataTable();
        string connectionString = "";
        int SelectedRowIndexdataGridView;
        string DataBaseName = "";
        private readonly PISMS pisms;
        public RealTimeGroup(PISMS frompisms)
        {
            InitializeComponent();
            pisms = frompisms;
            //PISMS pisms = new PISMS();
            string IP = pisms.Pub_Config.Rows[0].ItemArray[0].ToString();
            DataBaseName = pisms.Pub_Config.Rows[0].ItemArray[2].ToString();
            string UserID = pisms.Pub_Config.Rows[0].ItemArray[3].ToString();
            string Password = pisms.Pub_Config.Rows[0].ItemArray[4].ToString();
            connectionString = "Data Source = " + IP + "; Initial Catalog =" + DataBaseName + "; User ID =" + UserID + "; Password =" + Password;

            LoadDataToGroupTable();
            for(int i =0; i < datagroup.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
            }
            Filldatagridview();
        }

        #region LoadData

        private void LoadDataToGroupTable()
        {            
            datagroup.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT * FROM ["+DataBaseName+"].[dbo].[RealTimeGroup] ORDER By GroupName";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(datagroup);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region FilldataGrid

        private void Filldatagridview()
        {
            try
            {
                for (int row = 0; row < datagroup.Rows.Count; row++)
                {
                    dataGridView1.Rows[row].Cells["GroupName"].Value = datagroup.Rows[row].ItemArray[0];                   
                    dataGridView1.Rows[row].Cells["GroupID"].Value = datagroup.Rows[row].ItemArray[1];
                    dataGridView1.Rows[row].Cells["realtimegroupstatus"].Value = datagroup.Rows[row].ItemArray[2];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion   

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
                    SelectedRowIndexdataGridView = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[SelectedRowIndexdataGridView].Selected = true;

                    if (SelectedRowIndexdataGridView >= 0)
                    {
                        my_menu.Items.Add("Edit").Name = "Edit";
                        my_menu.Items.Add("Remove").Name = "Delete";
                    }
                    my_menu.Show(dataGridView1, new Point(e.X, e.Y));

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
            //MessageBox.Show(e.ClickedItem.Name.ToString());
            switch (e.ClickedItem.Name.ToString())
            {
                case "Delete":
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(
                       connectionString))
                        {
                            //int SelectedRowIndexdataGridView = dataGridView1.CurrentCell.RowIndex;
                            string Group_Selected = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["GroupID"].Value.ToString();
                            string queryString = "DELETE FROM ["+DataBaseName+ "].[dbo].[User_RealTimeGroup_Relation] WHERE RealTimeGroupID = '" + Group_Selected + "'  DELETE FROM ["+DataBaseName+ "].[dbo].[RealTimeGroup] WHERE RealTimeGroupID ='" + Group_Selected + "'";
                            SqlCommand command = new SqlCommand(queryString, connection);
                            SqlDataAdapter data = new SqlDataAdapter(command);
                            command.Connection.Open();
                            command.ExecuteNonQuery();
                            dataGridView1.Rows.RemoveAt(SelectedRowIndexdataGridView);
                            LoadDataToGroupTable();
                            Filldatagridview();
                            dataGridView1.Update();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    
                    break;
                case "Edit":
                    //Do Something                 
                    buttonUpdate.Visible = true;
                    buttonSave.Visible = false;
                    buttonCancel.Visible = true;
                    try
                    {
                        //int SelectedRowIndexdataGridView = dataGridView1.CurrentCell.RowIndex;
                        textBoxgroup.Text = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["GroupName"].Value.ToString();

                        //label2.Visible = true;
                        label3.Visible = true;
                        textBoxgroup.Visible = true;

                        //comboBoxGroupType.Visible = true;
                        buttonNew.Visible = false;
                        buttonCancel.Visible = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        #region SAVE New Group

        private void buttonNew_Click(object sender, EventArgs e)
        {
            
            label3.Visible = true;
            textBoxgroup.Visible = true;

            buttonNew.Visible = false;
            buttonCancel.Visible = true;
            buttonSave.Visible = true;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    int checkDuplicateGroup = 0;
                    for (int row = 0; row < datagroup.Rows.Count; row++)
                    {
                        string Group_Ondatagridview = dataGridView1.Rows[row].Cells[0].Value.ToString();
                        //check same Event
                        if (textBoxgroup.Text.ToString() == Group_Ondatagridview)
                        {
                            MessageBox.Show("Error Group duplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            checkDuplicateGroup = 1;
                            break;
                        }
                    }

                    if (checkDuplicateGroup == 0)
                    {
                        datagroup.Clear();

                        string queryString = "INSERT INTO ["+DataBaseName+"].[dbo].[RealTimeGroup] ([GroupName],[Enabled])VALUES('" + textBoxgroup.Text.ToString() + "','False')";

                        SqlCommand command = new SqlCommand(queryString, connection);
                        command.Connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Rows.Add();
                        LoadDataToGroupTable();
                        Filldatagridview();
                        dataGridView1.Update();
                    }//end if decide insert
                }

                label3.Visible = false;
                textBoxgroup.Visible = false;
 
   
                buttonNew.Visible = true;
                buttonCancel.Visible = false;
                buttonSave.Visible = false;
                textBoxgroup.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
               
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string queryString = "";                   

                        queryString =
                        "UPDATE ["+DataBaseName+"].[dbo].[RealTimeGroup] SET GroupName ='" + textBoxgroup.Text.ToString() + "'"
                        + " WHERE RealTimeGroupID='" + dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["GroupID"].Value.ToString() + "'";
                                                       
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    LoadDataToGroupTable();
                    Filldatagridview();
                    dataGridView1.Update();                  
                    label3.Visible = false;
                    textBoxgroup.Visible = false;

                    textBoxgroup.Clear();

                    buttonNew.Visible = true;
                    buttonCancel.Visible = false;
                    buttonSave.Visible = false;
                    buttonUpdate.Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            label3.Visible = false;
            textBoxgroup.Visible = false;

            textBoxgroup.Clear();

            buttonNew.Visible = true;
            buttonCancel.Visible = false;
            buttonSave.Visible = false;
            buttonUpdate.Visible = false;
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
                   connectionString))
                {

                        string queryString = "UPDATE [" + DataBaseName + "].[dbo].[RealTimeGroup] SET [Enabled] = 'True'";
                        SqlCommand command = new SqlCommand(queryString, connection);
                        SqlDataAdapter data = new SqlDataAdapter(command);

                        command.Connection.Open();
                        command.ExecuteNonQuery();

                        buttonstart.Enabled = false;
                        buttonstop.Enabled = true;
                        LoadDataToGroupTable();
                        Filldatagridview();
                    
                    
                    MessageBox.Show("Update Done");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonstop_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
                   connectionString))
                {
                        string queryString = "UPDATE [" + DataBaseName + "].[dbo].[RealTimeGroup] SET [Enabled] = 'False' ";
                        SqlCommand command = new SqlCommand(queryString, connection);
                        SqlDataAdapter data = new SqlDataAdapter(command);

                        command.Connection.Open();
                        command.ExecuteNonQuery();

                        buttonstart.Enabled = true;
                        buttonstop.Enabled = false;
                        LoadDataToGroupTable();
                        Filldatagridview();
                    

                    MessageBox.Show("Update Done");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
