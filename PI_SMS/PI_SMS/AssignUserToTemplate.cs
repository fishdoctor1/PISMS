using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Collections;

namespace PI_SMS
{
    public partial class AssignUserToTemplate : Form
    {
        DataTable TemplateName_dataTable = new DataTable();
        DataTable UserTemplate_data = new DataTable(); //User In Template
        DataTable AllUserDataTable = new DataTable();
        DataTable UserMatchSearch = new DataTable();
        DataTable UserMatchSearch2 = new DataTable();
        DataTable UserinDataGridview2 = new DataTable();//user not in Template
        string connectionString = "";

        bool[] checkbox_Add;
        int SelectedRowIndexdataGridView; //User in template row select
        int SelectedRowIndexdataGridViewAdd;
        string DataBaseName = "";

        public void mydispose()
        {
            TemplateName_dataTable.Dispose();
            UserTemplate_data.Dispose();
            AllUserDataTable.Dispose();
            UserMatchSearch.Dispose();
            UserMatchSearch2.Dispose();
            UserinDataGridview2.Dispose();
            panel1.Dispose();
            dataGridViewAvilableUser.Dispose();
            dataGridViewUserInTemplate.Dispose();
            tableLayoutPanel1.Dispose();
        }

        private readonly PISMS pisms;
        public AssignUserToTemplate(PISMS frompisms)
        {           
            InitializeComponent();
            
            InitialDataTableForSearch();
            InitialDataTableForSearch2();
            InitialDataTable_datagridview2();
            pisms = frompisms;
            start();

        }

        public void start()
        {
            //PISMS pisms = new PISMS();
            string IP = pisms.Pub_Config.Rows[0].ItemArray[0].ToString();
            DataBaseName = pisms.Pub_Config.Rows[0].ItemArray[2].ToString();
            string UserID = pisms.Pub_Config.Rows[0].ItemArray[3].ToString();
            string Password = pisms.Pub_Config.Rows[0].ItemArray[4].ToString();
            connectionString = "Data Source = " + IP + "; Initial Catalog =" + DataBaseName + "; User ID =" + UserID + "; Password =" + Password;
           
            comboBoxTemplate.DropDownStyle = ComboBoxStyle.DropDownList;
            FillComboBox();
        }
        #region Fill ComboBox

        private void FillComboBox()
        {
            try
            {
                
                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    SqlDataReader datareader;
                    DataTable tableTemplate = new DataTable();
                    string queryString = "SELECT TemplateName,TemplateIDAuToInc FROM ["+DataBaseName+"].[dbo].[NotificationTemplate] ORDER BY TemplateName";
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

        #endregion

        #region LoadData_UserTemplate

        private void LoadDataTo_UserTemplateTable()
        {
            try
            {
                UserTemplate_data.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string TemplateSelected = comboBoxTemplate.SelectedValue.ToString();
                    string queryString = "SELECT ["+DataBaseName+"].[dbo].[User].UserID,["+DataBaseName+"].[dbo].[User].FirstName,["+DataBaseName+"].[dbo].[User].LastName,["+DataBaseName+"].[dbo].[User].UserIDAuToInc,["+DataBaseName+"].[dbo].[User].HandPhone" +
" From["+DataBaseName+"].[dbo].[User_Template_Relation]"+
" JOIN NotificationTemplate ON["+DataBaseName+"].[dbo].[User_Template_Relation].TemplateIDAuToInc = ["+DataBaseName+"].[dbo].[NotificationTemplate].TemplateIDAuToInc"+
" JOIN ["+DataBaseName+"].[dbo].[User] ON["+DataBaseName+"].[dbo].[User_Template_Relation].UserIDAutoInc = ["+DataBaseName+"].[dbo].[User].UserIDAutoInc"+
" WHERE [NotificationTemplate].TemplateIDAuToInc='" + TemplateSelected+"' ORDER BY FirstName";
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

        #region fill datagridview User in Template

        private void FilldatagridviewUserinTemplate() 
        {
            try
            {
                string templateselected = comboBoxTemplate.SelectedItem.ToString();
                for (int row = 0; row < UserTemplate_data.Rows.Count; row++)
                {
                    dataGridViewUserInTemplate.Rows[row].Cells["Delete"].Value = false;
                    dataGridViewUserInTemplate.Rows[row].Cells["UserID"].Value = UserTemplate_data.Rows[row].ItemArray[0];
                    dataGridViewUserInTemplate.Rows[row].Cells["FirstName"].Value = UserTemplate_data.Rows[row].ItemArray[1];
                    dataGridViewUserInTemplate.Rows[row].Cells["LastName"].Value = UserTemplate_data.Rows[row].ItemArray[2];
                    dataGridViewUserInTemplate.Rows[row].Cells["UserIDAuToInc"].Value = UserTemplate_data.Rows[row].ItemArray[3];
                    dataGridViewUserInTemplate.Rows[row].Cells["CellPhone"].Value = UserTemplate_data.Rows[row].ItemArray[4];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region fill datagridview Avilable User

        private void Filldatagridview2()
        {
            try
            {
                dataGridViewAvilableUser.Rows.Clear();
                int RowNotDuplicate = 0;
                DataRow rowTable2;
                UserinDataGridview2.Clear();

                for (int rowAlluserDataTable = 0; rowAlluserDataTable < AllUserDataTable.Rows.Count; rowAlluserDataTable++)
                {

                    int checkAlluser_duplicate_UserinTemplate = 0;
                    for (int rowgrid1 = 0; rowgrid1 < UserTemplate_data.Rows.Count; rowgrid1++)
                    {
                        if (UserTemplate_data.Rows[rowgrid1].ItemArray[0].ToString() == AllUserDataTable.Rows[rowAlluserDataTable].ItemArray[0].ToString())
                        {
                            checkAlluser_duplicate_UserinTemplate = 1;
                            break;
                        }

                    }
                    if (checkAlluser_duplicate_UserinTemplate == 0)
                    {
                        dataGridViewAvilableUser.Rows.Add();
                        dataGridViewAvilableUser.Rows[RowNotDuplicate].Cells[0].Value = false;
                        dataGridViewAvilableUser.Rows[RowNotDuplicate].Cells["UserIDAdd"].Value = AllUserDataTable.Rows[rowAlluserDataTable].ItemArray[0];
                        dataGridViewAvilableUser.Rows[RowNotDuplicate].Cells["FirstNameAdd"].Value = AllUserDataTable.Rows[rowAlluserDataTable].ItemArray[6];
                        dataGridViewAvilableUser.Rows[RowNotDuplicate].Cells["LastNameAdd"].Value = AllUserDataTable.Rows[rowAlluserDataTable].ItemArray[7];
                        dataGridViewAvilableUser.Rows[RowNotDuplicate].Cells["UserIDAuToIncAllUser"].Value = AllUserDataTable.Rows[rowAlluserDataTable].ItemArray[5];

                        rowTable2 = UserinDataGridview2.NewRow();
                        rowTable2["UserID"] = AllUserDataTable.Rows[rowAlluserDataTable].ItemArray[0].ToString();
                        rowTable2["FirstName"] = AllUserDataTable.Rows[rowAlluserDataTable].ItemArray[6].ToString();
                        rowTable2["LastName"] = AllUserDataTable.Rows[rowAlluserDataTable].ItemArray[7].ToString();
                        rowTable2["UserIDAuToInc"] = AllUserDataTable.Rows[rowAlluserDataTable].ItemArray[5].ToString();
                        UserinDataGridview2.Rows.Add(rowTable2);
                        ++RowNotDuplicate;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion

        #region comboBox Template SelectedChange

        private void comboBoxTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDataTo_UserTemplateTable();

                dataGridViewUserInTemplate.Rows.Clear();
                labelnumberUserinTemplate.Text = UserTemplate_data.Rows.Count.ToString();
                for (int row = 0; row < UserTemplate_data.Rows.Count; row++)
                {
                    dataGridViewUserInTemplate.Rows.Add();
                }
                FilldatagridviewUserinTemplate(); //user in template
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    AllUserDataTable.Clear();
                    string queryString = "SELECT * FROM ["+DataBaseName+"].[dbo].[User] ORDER BY FirstName";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(AllUserDataTable);
                    checkbox_Add = new bool[AllUserDataTable.Rows.Count];

                    Filldatagridview2(); //avilable user

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region Mouse Click datagridview UserinTemplate

        private void dataGridViewUserInTemplate_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {

                }
                else
                {
                    ContextMenuStrip my_menu = new ContextMenuStrip();
                    SelectedRowIndexdataGridView = dataGridViewUserInTemplate.HitTest(e.X, e.Y).RowIndex;
                    dataGridViewUserInTemplate.ClearSelection();

                    //MessageBox.Show("right click");
                    //MessageBox.Show(SelectedRowIndexdataGridView.ToString());

                    if (SelectedRowIndexdataGridView >= 0)
                    {
                        dataGridViewUserInTemplate.Rows[SelectedRowIndexdataGridView].Selected = true;
                        my_menu.Items.Add("Remove").Name = "Delete";
                    }
                    my_menu.Show(dataGridViewUserInTemplate, new Point(e.X, e.Y));

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

            switch (e.ClickedItem.Name.ToString())
            {
                case "Delete":
                    try
                    {                                              
                        using (SqlConnection connection = new SqlConnection(
                       connectionString))
                        {
                            //int mouse_row = dataGridView1.CurrentCell.RowIndex;
                            string comboboxselect = comboBoxTemplate.SelectedValue.ToString();
                            string UserIDAuToInc = dataGridViewUserInTemplate.Rows[SelectedRowIndexdataGridView].Cells["UserIDAuToInc"].Value.ToString();
                            string queryString = "DELETE FROM ["+DataBaseName+"].[dbo].[User_Template_Relation] WHERE UserIDAuToInc ='" + UserIDAuToInc + "' AND TemplateIDAutoInc = '" + comboboxselect + "'";
                            SqlCommand command = new SqlCommand(queryString, connection);
                            SqlDataAdapter data = new SqlDataAdapter(command);
                            command.Connection.Open();
                            command.ExecuteNonQuery();
                            dataGridViewUserInTemplate.Rows.RemoveAt(SelectedRowIndexdataGridView);
                            LoadDataTo_UserTemplateTable();
                            FilldatagridviewUserinTemplate();
                            dataGridViewUserInTemplate.Update();
                            Filldatagridview2();
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

        #region ADDSelected Click

        private void buttonAddSelected_Click(object sender, EventArgs e)
        {
            try
            {
                for(int row=0;row< dataGridViewAvilableUser.Rows.Count;row++)
                {
                    bool result ;
                    
                    Boolean.TryParse(dataGridViewAvilableUser.Rows[row].Cells[0].Value.ToString(),out result);
                    int checkDuplicateUser = 0;
                    if(result == true)// checkBoxtrue Then Check Duplicate
                    {
                        for (int rowdatagrid1 = 0; rowdatagrid1 < dataGridViewUserInTemplate.Rows.Count; rowdatagrid1++)
                        {
                            string User_OndatagridviewAuToInc = dataGridViewUserInTemplate.Rows[rowdatagrid1].Cells["UserIDAuToInc"].Value.ToString();
                            string User_OndatagridviewID = dataGridViewUserInTemplate.Rows[rowdatagrid1].Cells["UserID"].Value.ToString();
                            //check same Event
                            if (dataGridViewAvilableUser.Rows[row].Cells[1].Value.ToString() == User_OndatagridviewID)
                            {
                                MessageBox.Show("Error User " + User_OndatagridviewID + " duplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                checkDuplicateUser = 1;
                                break;
                            }
                        }
                    }
                    
                   if (checkDuplicateUser == 1)
                    {
                        continue;
                    }

                    if (result == true && checkDuplicateUser == 0)
                    {

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string comboboxselect = comboBoxTemplate.SelectedValue.ToString();
                            string queryString = "INSERT INTO ["+DataBaseName+"].[dbo].[User_Template_Relation] ([UserIDAutoInc],[TemplateIDAuToInc]) VALUES ('" + dataGridViewAvilableUser.Rows[row].Cells[4].Value.ToString() + "' , '" + comboboxselect + "')";
                            //Console.WriteLine(row + " : Checked True");
                            SqlCommand command = new SqlCommand(queryString, connection);
                            command.Connection.Open();
                            command.ExecuteNonQuery();
                            
                        }

                    }

                }
                checkBoxAddAll.Checked = false;
                LoadDataTo_UserTemplateTable();

                dataGridViewUserInTemplate.Rows.Clear();
                for (int row = 0; row < UserTemplate_data.Rows.Count; row++)
                {
                    dataGridViewUserInTemplate.Rows.Add();
                }
                FilldatagridviewUserinTemplate();
                Filldatagridview2();
                labelnumberUserinTemplate.Text = UserTemplate_data.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region DeleteSelected

        private void buttonselect_Click(object sender, EventArgs e)//DeleteSelected
        {
            try
            {
                int SumCheckBoxTrue = 0;
                int[] RowIndexDelete = new int[dataGridViewUserInTemplate.Rows.Count]; //max index
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string queryString = "";

                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Connection.Open();
                    for (int row = 0; row < dataGridViewUserInTemplate.Rows.Count; row++)
                    {
                        bool checkboxDel;

                        checkboxDel = Boolean.Parse(dataGridViewUserInTemplate.Rows[row].Cells[0].Value.ToString());
                        if (checkboxDel == true)//checkBox True
                        {
                            RowIndexDelete[SumCheckBoxTrue] = row; //Keep Index True
                            ++SumCheckBoxTrue; //Count CheckBoxDelete True

                            string UserIDAuToInc = dataGridViewUserInTemplate.Rows[row].Cells["UserIDAuToInc"].Value.ToString();
                            string comboboxselect = comboBoxTemplate.SelectedValue.ToString();
                            //using (SqlConnection connection = new SqlConnection(connectionString))
                            //{                                                    
                           
                            queryString = "DELETE FROM ["+DataBaseName+"].[dbo].[User_Template_Relation] WHERE UserIDAuToInc ='" + UserIDAuToInc + "' AND TemplateIDAutoInc = '" + comboboxselect + "'";

                            SqlCommand command2 = new SqlCommand(queryString, connection);
                            command2.ExecuteNonQuery();

                            //}
                        }//end if checkbox true
                    }//end for
                }//end using


                checkBoxDeleteAll.Checked = false;
                for (int DeleteRow = SumCheckBoxTrue-1; DeleteRow >= 0; DeleteRow--)//delete last index first
                {
                    dataGridViewUserInTemplate.Rows.RemoveAt(RowIndexDelete[DeleteRow]);
                }
                LoadDataTo_UserTemplateTable();
                Filldatagridview2();
                labelnumberUserinTemplate.Text = UserTemplate_data.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Search Click

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            int strIndex = -1;
            DataRow rowTableSearch;
            

            UserMatchSearch.Clear();
            
            try
            {
                int rowIndex = 0;

                    foreach (DataRow row in UserTemplate_data.Rows)
                    {
                        if (checkBoxFirstName.Checked == true)
                        {
                            strIndex = row.ItemArray[1].ToString().IndexOf(searchValue);
                        }
                        if (checkBoxLastName.Checked == true)
                        {
                            strIndex = row.ItemArray[2].ToString().IndexOf(searchValue);
                        }

                        if (strIndex >= 0)
                        {
                            rowTableSearch = UserMatchSearch.NewRow();
                            rowTableSearch["UserID"] = UserTemplate_data.Rows[rowIndex].ItemArray[0].ToString();
                            rowTableSearch["FirstName"] = UserTemplate_data.Rows[rowIndex].ItemArray[1].ToString();
                            rowTableSearch["LastName"] = UserTemplate_data.Rows[rowIndex].ItemArray[2].ToString();
                            rowTableSearch["UserIDAuToInc"] = UserTemplate_data.Rows[rowIndex].ItemArray[3].ToString();
                            UserMatchSearch.Rows.Add(rowTableSearch);
                        }
                        rowIndex++;

                    }
                    dataGridViewUserInTemplate.Rows.Clear();
                    // Set a DataGrid control's DataSource to the DataView.
                    for (int row = 0; row < UserMatchSearch.Rows.Count; row++)
                    {
                        dataGridViewUserInTemplate.Rows.Add();
                        dataGridViewUserInTemplate.Rows[row].Cells["Delete"].Value = false;
                        dataGridViewUserInTemplate.Rows[row].Cells["UserID"].Value = UserMatchSearch.Rows[row].ItemArray[0];
                        dataGridViewUserInTemplate.Rows[row].Cells["FirstName"].Value = UserMatchSearch.Rows[row].ItemArray[1];
                        dataGridViewUserInTemplate.Rows[row].Cells["LastName"].Value = UserMatchSearch.Rows[row].ItemArray[2];
                        dataGridViewUserInTemplate.Rows[row].Cells["UserIDAuToInc"].Value = UserMatchSearch.Rows[row].ItemArray[3];
                    }//end forloop add Match Search

//--------------------------------------------------------------------------------------------------------------------------------------                
                DataRow rowTableSearch2;
                UserMatchSearch2.Clear();
                rowIndex = 0;

                strIndex = -1;
                    foreach (DataRow row in UserinDataGridview2.Rows)
                        {
                        if (checkBoxFirstName.Checked == true)
                        {
                            strIndex = row.ItemArray[1].ToString().IndexOf(searchValue);
                        }
                        if (checkBoxLastName.Checked == true)
                        {
                            strIndex = row.ItemArray[2].ToString().IndexOf(searchValue);
                        }

                        if (strIndex >= 0)
                        {
                            rowTableSearch2 = UserMatchSearch2.NewRow();
                            rowTableSearch2["UserID"] = UserinDataGridview2.Rows[rowIndex].ItemArray[0].ToString();
                            rowTableSearch2["FirstName"] = UserinDataGridview2.Rows[rowIndex].ItemArray[1].ToString();
                            rowTableSearch2["LastName"] = UserinDataGridview2.Rows[rowIndex].ItemArray[2].ToString();
                            rowTableSearch2["UserIDAuToInc"] = UserinDataGridview2.Rows[rowIndex].ItemArray[3].ToString();
                            UserMatchSearch2.Rows.Add(rowTableSearch2);
                        }
                        rowIndex++;

                    }
                    dataGridViewAvilableUser.Rows.Clear();
                    // Set a DataGrid control's DataSource to the DataView.
                    for (int row = 0; row < UserMatchSearch2.Rows.Count; row++)
                    {
                        dataGridViewAvilableUser.Rows.Add();
                        dataGridViewAvilableUser.Rows[row].Cells["CheckBoxADD"].Value = false;
                        dataGridViewAvilableUser.Rows[row].Cells["UserIDAdd"].Value = UserMatchSearch2.Rows[row].ItemArray[0];
                        dataGridViewAvilableUser.Rows[row].Cells["FirstNameAdd"].Value = UserMatchSearch2.Rows[row].ItemArray[1];
                        dataGridViewAvilableUser.Rows[row].Cells["LastNameAdd"].Value = UserMatchSearch2.Rows[row].ItemArray[2];
                        dataGridViewAvilableUser.Rows[row].Cells["UserIDAuToIncAllUser"].Value = UserMatchSearch2.Rows[row].ItemArray[3];
                    }//end forloop add Match Search

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        #endregion

        #region CheckBox CheckedChange

        private void checkBoxFirstName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFirstName.Checked == false)
            {
                checkBoxLastName.Visible = true;
                buttonSearch.Visible = true;
            }
            else if (checkBoxFirstName.Checked == true)
            {
                checkBoxLastName.Visible = false;
                buttonSearch.Visible = true;
            }
            if (checkBoxFirstName.Checked == false && checkBoxLastName.Checked == false)
            {
                buttonSearch.Visible = false;
            }
        }

        private void checkBoxLastName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLastName.Checked == true)
            {
                checkBoxFirstName.Visible = false;
                checkBoxFirstName.Checked = false;
                buttonSearch.Visible = true;
            }
            else if (checkBoxLastName.Checked == false)
            {
                checkBoxFirstName.Visible = true;
                buttonSearch.Visible = true;
            }
            if (checkBoxFirstName.Checked == false && checkBoxLastName.Checked == false)
            {
                buttonSearch.Visible = false;
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
            column.ColumnName = "UserIDAuToInc";
            UserMatchSearch.Columns.Add(column);

            column.Dispose();
        }

        #endregion

        #region Inittial daTaTableForSearch

        private void InitialDataTableForSearch2()
        {
            // Declare DataColumn and DataRow variables.
            DataColumn column;

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "UserID";          
            UserMatchSearch2.Columns.Add(column);
            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "FirstName";
            UserMatchSearch2.Columns.Add(column);
            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "LastName";
            UserMatchSearch2.Columns.Add(column);
            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "UserIDAuToInc";
            UserMatchSearch2.Columns.Add(column);
            column.Dispose();
        }

        #endregion

        #region Inittial daTaTable_datagridview2

        private void InitialDataTable_datagridview2()
        {
            // Declare DataColumn and DataRow variables.
            DataColumn column;

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "UserID";
            UserinDataGridview2.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "FirstName";
            UserinDataGridview2.Columns.Add(column);
    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "LastName";
            UserinDataGridview2.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "UserIDAuToInc";
            UserinDataGridview2.Columns.Add(column);
            column.Dispose();
        }

        #endregion

        #region checkBox DeleteAll

        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewUserInTemplate.Rows.Count; i++)
            {
                if (checkBoxDeleteAll.Checked)
                {

                    dataGridViewUserInTemplate.Rows[i].Cells[0].Value = true;

                }
                else
                {

                    dataGridViewUserInTemplate.Rows[i].Cells[0].Value = false;
                }
            }
        }
        
        #endregion
        
        #region checkBox AddAll

        private void checkBoxAddAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int rowgrid2 = 0; rowgrid2 < dataGridViewAvilableUser.Rows.Count; rowgrid2++)
            {
                if (checkBoxAddAll.Checked)
                {
                    dataGridViewAvilableUser.Rows[rowgrid2].Cells[0].Value = true;
                }
                else
                {
                    dataGridViewAvilableUser.Rows[rowgrid2].Cells[0].Value = false;
                }
            }
        }

        #endregion

        #region Add by rightclick

        private void dataGridViewAvilableUser_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    SelectedRowIndexdataGridViewAdd = dataGridViewAvilableUser.HitTest(e.X, e.Y).RowIndex;
                }
                else
                {
                    ContextMenuStrip my_menu2 = new ContextMenuStrip();
                    SelectedRowIndexdataGridViewAdd = dataGridViewAvilableUser.HitTest(e.X, e.Y).RowIndex;
                    dataGridViewAvilableUser.ClearSelection();

                    //MessageBox.Show("right click");
                    //MessageBox.Show(SelectedRowIndexdataGridView.ToString());

                    if (SelectedRowIndexdataGridViewAdd >= 0)
                    {
                        my_menu2.Items.Add("Add").Name = "Add";
                        dataGridViewAvilableUser.Rows[SelectedRowIndexdataGridViewAdd].Selected = true;
                    }
                    my_menu2.Show(dataGridViewAvilableUser, new Point(e.X, e.Y));

                    //Event menu Click
                    my_menu2.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClicked2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void my_menu_ItemClicked2(object sender, ToolStripItemClickedEventArgs e)
        {

            switch (e.ClickedItem.Name.ToString())
            {
                case "Add":
                    try
                    {
                        int checkDuplicateUser = 0;
                            string User_OndatagridviewAuToInc = dataGridViewAvilableUser.Rows[SelectedRowIndexdataGridViewAdd].Cells["UserIDAuToIncAllUser"].Value.ToString();
                            string User_OndatagridviewID = dataGridViewAvilableUser.Rows[SelectedRowIndexdataGridViewAdd].Cells["UserIDAdd"].Value.ToString();                        

                        if (checkDuplicateUser == 0)
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                string comboboxselect = comboBoxTemplate.SelectedValue.ToString();
                                string queryString = "INSERT INTO ["+DataBaseName+"].[dbo].[User_Template_Relation] ([UserIDAutoInc],[TemplateIDAuToInc]) VALUES ('" + dataGridViewAvilableUser.Rows[SelectedRowIndexdataGridViewAdd].Cells["UserIDAuToIncAllUser"].Value.ToString() + "' , '" + comboboxselect + "')";
                                //Console.WriteLine(row + " : Checked True");
                                SqlCommand command = new SqlCommand(queryString, connection);
                                command.Connection.Open();
                                command.ExecuteNonQuery();

                            }

                            LoadDataTo_UserTemplateTable();

                            dataGridViewUserInTemplate.Rows.Add();

                            FilldatagridviewUserinTemplate();
                            Filldatagridview2();
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

        
    }
}
