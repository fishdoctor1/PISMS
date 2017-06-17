using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace PI_SMS
{
    public partial class UserConfigurationUser : Form
    {
        string connectionString = "";

        DataTable UserconfigUser_data = new DataTable();
        DataTable UserMatchSearch = new DataTable();
        bool[] checkbox_Delete;
        int SelectedRowIndexdataGridView;
        string DataBaseName = "";
        private readonly PISMS pisms;
        public UserConfigurationUser(PISMS frompisms)
        {
            InitializeComponent();
            pisms = frompisms;
            //PISMS pisms = new PISMS();
            string IP = pisms.Pub_Config.Rows[0].ItemArray[0].ToString();
            DataBaseName = pisms.Pub_Config.Rows[0].ItemArray[2].ToString();
            string UserID = pisms.Pub_Config.Rows[0].ItemArray[3].ToString();
            string Password = pisms.Pub_Config.Rows[0].ItemArray[4].ToString();
            connectionString = "Data Source = " + IP + "; Initial Catalog =" + DataBaseName + "; User ID =" + UserID + "; Password =" + Password;

            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadDataToTable_UserconfigUser_data();
            InitialDataTableForSearch();
            checkbox_Delete = new bool[UserconfigUser_data.Rows.Count];

            for (int row = 0; row < UserconfigUser_data.Rows.Count; row++)
            {
                dataGridView1.Rows.Add();                              
            }
            Filldatagridview();
        }

        #region LoadDataToTable_UserconfigUser_data

        private void LoadDataToTable_UserconfigUser_data()
        {         
            try
            {
                
                UserconfigUser_data.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT * FROM ["+DataBaseName+"].[dbo].[User] ORDER BY UserID";
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

        #region filldatagridview

        void Filldatagridview()
        {
            try
            {
                for (int row = 0; row < UserconfigUser_data.Rows.Count; row++)
                {
                    dataGridView1.Rows[row].Cells["ColumnDelete"].Value = false;
                    dataGridView1.Rows[row].Cells["UserID"].Value = UserconfigUser_data.Rows[row].ItemArray[0];
                    dataGridView1.Rows[row].Cells["FirstName"].Value = UserconfigUser_data.Rows[row].ItemArray[6];
                    dataGridView1.Rows[row].Cells["LastName"].Value = UserconfigUser_data.Rows[row].ItemArray[7];
                    dataGridView1.Rows[row].Cells["Email"].Value = UserconfigUser_data.Rows[row].ItemArray[2];
                    dataGridView1.Rows[row].Cells["HandPhoneNo"].Value = UserconfigUser_data.Rows[row].ItemArray[3];
                    dataGridView1.Rows[row].Cells["UserIDAuToInc"].Value = UserconfigUser_data.Rows[row].ItemArray[5];
                    dataGridView1.Rows[row].Cells["Role"].Value = UserconfigUser_data.Rows[row].ItemArray[4].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Search User

        private void SearchUser_Click(object sender, EventArgs e)
        {
            string searchValue = textBox5.Text;
            int strIndex = 0;
            DataRow rowTableSearch;
            UserMatchSearch.Clear();

            try
            {
                int rowIndex = 0;
                foreach (DataRow row in UserconfigUser_data.Rows)
                {
                    if (checkBoxFirstName.Checked)
                    {
                        strIndex = row.ItemArray[6].ToString().IndexOf(searchValue);
                    }
                    else if (checkBoxLastName.Checked)
                    {
                        strIndex = row.ItemArray[7].ToString().IndexOf(searchValue);
                    }
                    else if (checkBoxPhone.Checked)
                    {
                        strIndex = row.ItemArray[3].ToString().IndexOf(searchValue);
                    }
                    else if (checkBoxUserID.Checked)
                    {
                        strIndex = row.ItemArray[0].ToString().IndexOf(searchValue);
                    }
                    if (strIndex >= 0)
                    {
                        //dataGridView1.ClearSelection();                        
                        //dataGridView1.Rows[rowIndex].Selected = true;
                        //dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                        //dataGridView1.Focus();

                        rowTableSearch = UserMatchSearch.NewRow();
                        rowTableSearch["UserID"] = UserconfigUser_data.Rows[rowIndex].ItemArray[0].ToString();
                        rowTableSearch["FirstName"] = UserconfigUser_data.Rows[rowIndex].ItemArray[6].ToString();
                        rowTableSearch["LastName"] = UserconfigUser_data.Rows[rowIndex].ItemArray[7].ToString();
                        rowTableSearch["Email"] = UserconfigUser_data.Rows[rowIndex].ItemArray[2].ToString();
                        rowTableSearch["HandPhone"] = UserconfigUser_data.Rows[rowIndex].ItemArray[3].ToString();
                        rowTableSearch["UserIDAuToInc"] = UserconfigUser_data.Rows[rowIndex].ItemArray[5].ToString();
                        rowTableSearch["Role"] = UserconfigUser_data.Rows[rowIndex].ItemArray[4].ToString();
                        UserMatchSearch.Rows.Add(rowTableSearch);
                    }
                    rowIndex++;

                }            
                dataGridView1.Rows.Clear();
                // Set a DataGrid control's DataSource to the DataView.
                for(int row=0;row< UserMatchSearch.Rows.Count; row++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[row].Cells["ColumnDelete"].Value = false;
                    dataGridView1.Rows[row].Cells["UserID"].Value = UserMatchSearch.Rows[row].ItemArray[0];
                    dataGridView1.Rows[row].Cells["FirstName"].Value = UserMatchSearch.Rows[row].ItemArray[1];
                    dataGridView1.Rows[row].Cells["LastName"].Value = UserMatchSearch.Rows[row].ItemArray[2];
                    dataGridView1.Rows[row].Cells["Email"].Value = UserMatchSearch.Rows[row].ItemArray[3];
                    dataGridView1.Rows[row].Cells["HandPhoneNo"].Value = UserMatchSearch.Rows[row].ItemArray[4];
                    dataGridView1.Rows[row].Cells["UserIDAuToInc"].Value = UserMatchSearch.Rows[row].ItemArray[5];
                    dataGridView1.Rows[row].Cells["Role"].Value = UserMatchSearch.Rows[row].ItemArray[6].ToString();
                }//end forloop add Match Search
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion

        #region Inittial daTaTableForSearch

        public void InitialDataTableForSearch()
        {
            // Declare DataColumn and DataRow variables.
            DataColumn column;


            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "UserID";
            UserMatchSearch.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "FirstName";
            UserMatchSearch.Columns.Add(column);

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "LastName";
            UserMatchSearch.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Email";
            UserMatchSearch.Columns.Add(column);

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "HandPhone";
            UserMatchSearch.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "UserIDAuToInc";
            UserMatchSearch.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Role";
            UserMatchSearch.Columns.Add(column);

            column.Dispose();
        }

        #endregion

        #region Add User

        private void SaveUserConfig_Click(object sender, EventArgs e)
        {            
            try
            {
                string UserID = textBoxUSERID.Text;
                string firstname = textBoxFirstName.Text;
                string lastname = textBoxLastName.Text;
                string Email = textBoxEmail.Text;
                string Handphone = textBoxHandPhone.Text;
                string Pass = textBoxPassword.Text;
                string confirmpass = textBoxConfirmPassword.Text;
                string role = comboBoxRole.SelectedItem.ToString();                                

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    int checksameUserID = 0;

                    for (int row = 0; row < UserconfigUser_data.Rows.Count; row++)
                    {
                        string UserID_Ondatagridview = dataGridView1.Rows[row].Cells["UserID"].Value.ToString();
                        //check same TagName
                        if (UserID == UserID_Ondatagridview)
                        {
                            MessageBox.Show("Error USERID duplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            checksameUserID = 1;
                            break;
                        }
                    }
                    if(Pass != confirmpass)
                    {
                        MessageBox.Show("Error P@ssword", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        checksameUserID = 1;
                    }
                    if (checksameUserID == 0)
                    {
                        
                        string queryString = "INSERT INTO ["+DataBaseName+"].[dbo].[User] ([UserID],[Email],[HandPhone],[Role],[FirstName],[LastName])Values('"
                        + UserID     
                        + "', '" + Email
                        + "', '" + Handphone
                        + "', '" + role
                        + "', '" + firstname
                        + "', '" + lastname + "')";

                        SqlCommand command = new SqlCommand(queryString, connection);
                        command.Connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Rows.Add();
                        LoadDataToTable_UserconfigUser_data();
                        Filldatagridview();
                        dataGridView1.Update();
                    }//end if decide insert
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        #endregion

        //public string MD5Hash(string text)
        //{
        //    //using (MD5 md5Hash = MD5.Create())
        //    //{
        //    //    // Convert the input string to a byte array and compute the hash.
        //    //    byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(text));

        //    //    // Create a new Stringbuilder to collect the bytes
        //    //    // and create a string.
        //    //    StringBuilder sBuilder = new StringBuilder();

        //    //    // Loop through each byte of the hashed data 
        //    //    // and format each one as a hexadecimal string.
        //    //    for (int i = 0; i < data.Length; i++)
        //    //    {
        //    //        sBuilder.Append(data[i].ToString("x2"));
        //    //    }

        //    //    // Return the hexadecimal string.
        //    //    return sBuilder.ToString();
        //    //}

        //}

        #region Datagridview Mouse click

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
                        my_menu.Items.Add("Remove").Name = "remove";
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
            //int SelectedRowIndexdataGridView = dataGridView1.CurrentCell.RowIndex;
            string User_IdSelected = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["UserIDAuToInc"].Value.ToString();
            switch (e.ClickedItem.Name.ToString())
            {
                case "remove":
                    //Console.WriteLine("Delete case");
                    try
                    {
                        
                        using (SqlConnection connection = new SqlConnection(
                       connectionString))
                        {
                            string queryString = ""
                                + " DELETE FROM ["+DataBaseName+"].[dbo].[User_Template_Relation] WHERE UserIDAuToInc ='" + User_IdSelected + "'"
                                + " DELETE FROM ["+DataBaseName+"].[dbo].[User_RealTimeGroup_Relation] WHERE UserIDAuToInc = '" + User_IdSelected + "'"
                                + " DELETE FROM ["+DataBaseName+"].[dbo].[User] WHERE UserIDAuToInc = '" + User_IdSelected + "'";
                            SqlCommand command = new SqlCommand(queryString, connection);
                            command.Connection.Open();
                            command.ExecuteNonQuery();

                            dataGridView1.Rows.RemoveAt(SelectedRowIndexdataGridView);
                            LoadDataToTable_UserconfigUser_data();
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
                    UpdateUserConfig.Visible = true;
                                       
                    try
                    {
                        
                        using (SqlConnection connection = new SqlConnection(
                   connectionString))
                        {

                            textBoxUSERID.ReadOnly = true;
                            textBoxUSERID.Text = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["UserID"].Value.ToString();
                            textBoxFirstName.Text = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["FirstName"].Value.ToString();
                            textBoxLastName.Text = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["LastName"].Value.ToString();
                            textBoxEmail.Text = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["Email"].Value.ToString();
                            textBoxHandPhone.Text = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["HandPhoneNo"].Value.ToString();
                            comboBoxRole.SelectedItem = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["Role"].Value.ToString();
                            SaveUserConfig.Visible = false;
                        }
                            
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        #endregion

        #region Update

        private void UpdateUserConfig_Click(object sender, EventArgs e)
        {
            SaveUserConfig.Visible = true;
            try
            {
                string userid = textBoxUSERID.Text;
                string firstname = textBoxFirstName.Text;
                string lastname = textBoxLastName.Text;
                string Email = textBoxEmail.Text;
                string Handphone = textBoxHandPhone.Text;
                string Pass = textBoxPassword.Text;
                string confirmpass = textBoxConfirmPassword.Text;
                string role = comboBoxRole.SelectedItem.ToString();
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string queryString = "";

                        queryString =
                        "UPDATE ["+DataBaseName+"].[dbo].[User] SET "
                        + " UserID='" + userid
                        + "',Email='" + Email
                        + "',HandPhone='" + Handphone
                        + "',Role='" + role
                        + "',FirstName='" + firstname
                        + "',LastName='" + lastname + "'"
                        + "WHERE UserID='" + userid + "'";           
                                      
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    LoadDataToTable_UserconfigUser_data();
                    Filldatagridview();
                    dataGridView1.Update();
                    UpdateUserConfig.Visible = false;
                    textBoxUSERID.Clear();
                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    textBoxEmail.Clear();
                    textBoxHandPhone.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    #endregion

        #region cancel

        private void CancelUserConfig_Click(object sender, EventArgs e)
        {
            textBoxUSERID.Clear();
            textBoxUSERID.Enabled = true;
            SaveUserConfig.Visible = true;
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            textBoxHandPhone.Clear();
            textBoxPassword.Clear();
            textBoxConfirmPassword.Clear();
            UpdateUserConfig.Visible = false;
        }

        #endregion

        #region checkBoxSearch CheckedChange

        private void checkBoxFirstName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFirstName.Checked == false)
            {
                checkBoxLastName.Visible = true;
                checkBoxPhone.Visible = true;
                checkBoxUserID.Visible = true;
                SearchUser.Visible = false;
                
            }
            else if (checkBoxFirstName.Checked)
            {
                checkBoxLastName.Visible = false;
                checkBoxPhone.Visible = false;
                checkBoxUserID.Visible = false;
                SearchUser.Visible = true;
            }
            //if(checkBoxFirstName.Checked == false && checkBoxLastName.Checked == false)
            //{
            //    SearchUser.Visible = false;
            //}
            
        }

        private void checkBoxLastName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLastName.Checked)
            {
                checkBoxFirstName.Visible = false;
                checkBoxFirstName.Checked = false;
                checkBoxPhone.Visible = false;
                checkBoxUserID.Visible = false;
                SearchUser.Visible = true;
            }
            else if (checkBoxLastName.Checked == false)
            {
                checkBoxFirstName.Visible = true;
                checkBoxPhone.Visible = true;
                SearchUser.Visible = false;
                checkBoxUserID.Visible = true;
            }
            //if (checkBoxFirstName.Checked == false && checkBoxLastName.Checked == false)
            //{
            //    SearchUser.Visible = false;
            //}

        }

        private void checkBoxPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPhone.Checked)
            {
                checkBoxFirstName.Visible = false;
                checkBoxFirstName.Checked = false;
                checkBoxLastName.Visible = false;
                checkBoxUserID.Visible = false;
                SearchUser.Visible = true;
            }
            else if(checkBoxPhone.Checked == false)
            {
                checkBoxUserID.Visible = true;
                checkBoxFirstName.Visible = true;
                checkBoxLastName.Visible = true;
                SearchUser.Visible = false;
            }
        }

        #endregion

        #region DeleteByCheckBox

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int SumCheckBoxTrue = 0;
                int[] RowIndexDelete = new int[dataGridView1.Rows.Count]; //max index

                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    bool checkboxDel;

                    checkboxDel = Boolean.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
                    if (checkboxDel == true)//checkBox True
                    {
                        RowIndexDelete[SumCheckBoxTrue] = row; //Keep Index True
                        ++SumCheckBoxTrue; //Count CheckBoxDelete True

                        string User_IdSelected = dataGridView1.Rows[row].Cells["UserIDAuToInc"].Value.ToString();
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string queryString = " DELETE FROM ["+DataBaseName+ "].[dbo].[User_RealTimeGroup_Relation] WHERE UserIDAuToInc ='" + User_IdSelected
                                + "' DELETE FROM ["+DataBaseName+"].[dbo].[User_Template_Relation] WHERE UserIDAuToInc ='" + User_IdSelected + "'"
                                + " DELETE FROM["+DataBaseName+"].[dbo].[User] WHERE UserIDAuToInc ='" + User_IdSelected + "'";
                            //Console.WriteLine(row + " : Checked True");
                            SqlCommand command = new SqlCommand(queryString, connection);
                            command.Connection.Open();
                            command.ExecuteNonQuery();
                            
                        }
                    }//end if checkbox true
                }//end for


                for (int DeleteRow = SumCheckBoxTrue - 1; DeleteRow >= 0; DeleteRow--)//delete last index first
                {
                    dataGridView1.Rows.RemoveAt(RowIndexDelete[DeleteRow]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//end function deleteButtonClick
        #endregion

        private void checkBoxUserID_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUserID.Checked)
            {
                checkBoxFirstName.Checked = false;
                checkBoxFirstName.Visible = false;
                checkBoxLastName.Visible = false;
                checkBoxPhone.Visible = false;
                SearchUser.Visible = true;
            }
            else
            {
                
                checkBoxFirstName.Visible = true;
                checkBoxLastName.Visible = true;
                checkBoxPhone.Visible = true;
                SearchUser.Visible = false;
            }
        }

        private void checkBoxSelectall_CheckedChanged(object sender, EventArgs e)
        {
            for(int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                if (checkBoxSelectall.Checked)
                {
                    dataGridView1.Rows[row].Cells[0].Value = true;
                }
                else
                {
                    dataGridView1.Rows[row].Cells[0].Value = false;
                }
            }
        }
    }
}
