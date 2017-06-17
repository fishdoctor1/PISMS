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
    public partial class AssignUserToRealTimeGroup : Form
    {
        DataTable GroupTable = new DataTable();
        DataTable All_User = new DataTable();
        DataTable Join_UserAndGroup = new DataTable();
        DataTable User_RealTimeGroup_Relation = new DataTable();
        DataTable UserMatchSearch = new DataTable();
        DataTable UserMatchSearch2 = new DataTable();
        DataTable UserinDataGridviewAvilUser = new DataTable();

        string connectionString = "";
        int SelectedrowIndexdataGridviewAvilableuser;
        int SelectedRowIndexdataGridViewUserinGroup;
        string DataBaseName = "";
        bool[] checkbox_Add;
        private readonly PISMS pisms;
        public AssignUserToRealTimeGroup(PISMS frompisms)
        {
            InitializeComponent();
            pisms = frompisms;
            InitialDataTableForSearch();
            InitialDataTableForSearch2();
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

            comboBoxGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            InitialDataTable_datagridviewAvilableUser();
            FillComboBox();

            Load_ALLUser();           
        }

        #region Fill ComboBoxGroup

        private void FillComboBox()
        {
            try
            {
                SqlDataReader datareader;
                GroupTable.Clear();
                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT GroupName,RealTimeGroupID FROM ["+DataBaseName+"].[dbo].[RealTimeGroup] ORDER BY GroupName";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Connection.Open();
                    datareader = command.ExecuteReader();
                    GroupTable.Load(datareader);
                    comboBoxGroup.DisplayMember = "GroupName";
                    comboBoxGroup.ValueMember = "RealTimeGroupID";
                    comboBoxGroup.DataSource = GroupTable;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        private void Load_Join_UserAndGroup()
        {
            try
            {
                Join_UserAndGroup.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT ["+DataBaseName+"].[dbo].[User].UserID,["+DataBaseName+ "].[dbo].[User].UserIDAuToInc,[" + DataBaseName + "].[dbo].[RealTimeGroup].RealTimeGroupID"
+" FROM["+DataBaseName+"].[dbo].[User_RealTimeGroup_Relation]"
+" JOIN["+DataBaseName+"].[dbo].[User] ON["+DataBaseName+"].[dbo].[User_RealTimeGroup_Relation].UserIDAuToInc = ["+DataBaseName+"].[dbo].[User].UserIDAutoInc"
+" JOIN["+DataBaseName+"].[dbo].[RealTimeGroup] ON["+DataBaseName+"].[dbo].[User_RealTimeGroup_Relation].RealTimeGroupID = ["+DataBaseName+"].[dbo].[RealTimeGroup].RealTimeGroupID" 
+" WHERE RealTimeGroup.RealTimeGroupID='" + comboBoxGroup.SelectedValue.ToString() + "' ORDER BY UserID";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(Join_UserAndGroup);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region LoadAllUser

        private void Load_ALLUser()
        {
            try
            {
                All_User.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT UserID,UserIDAutoInc" + " FROM["+DataBaseName+"].[dbo].[User] ORDER BY UserID";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(All_User);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion                       
        
        #region Search User

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxUserID.Text;
            int strIndex = 0;
            DataRow rowTableSearch;
            DataRow rowTableSearch2;
            UserMatchSearch.Clear();
            UserMatchSearch2.Clear();
            //dgvProjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                int rowIndex = 0;
                foreach (DataRow row in UserinDataGridviewAvilUser.Rows)
                {
                    strIndex = row.ItemArray[0].ToString().IndexOf(searchValue);

                    if (strIndex >= 0)
                    {

                        rowTableSearch = UserMatchSearch.NewRow();
                        rowTableSearch["UserID"] = UserinDataGridviewAvilUser.Rows[rowIndex].ItemArray[0].ToString();
                        rowTableSearch["UserIDAuToInc"] = UserinDataGridviewAvilUser.Rows[rowIndex].ItemArray[1].ToString();                       
                        UserMatchSearch.Rows.Add(rowTableSearch);
                    }
                    rowIndex++;
                    #region search equalall              
                    //if (row.Cells[1].Value.ToString().Equals(searchValue))
                    //{
                    //    dataGridView1.ClearSelection();
                    //    row.Selected = true;
                    //    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    //    //dataGridView1.Rows[rowIndex].Selected = true;
                    //    dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                    //    dataGridView1.Focus();
                    //    break;
                    //}
                    #endregion

                }
                dataGridViewAvilableuser.Rows.Clear();
                // Set a DataGrid control's DataSource to the DataView.
                for (int row = 0; row < UserMatchSearch.Rows.Count; row++)
                {
                    dataGridViewAvilableuser.Rows.Add();
                    dataGridViewAvilableuser.Rows[row].Cells["Add"].Value = false;
                    dataGridViewAvilableuser.Rows[row].Cells["UserIDadd"].Value = UserMatchSearch.Rows[row].ItemArray[0];
                    dataGridViewAvilableuser.Rows[row].Cells["UserIDAuToIncadd"].Value = UserMatchSearch.Rows[row].ItemArray[1];
                    
                }//end forloop add Match Search

                rowIndex = 0;
                foreach (DataRow row in Join_UserAndGroup.Rows)
                {
                    strIndex = row.ItemArray[0].ToString().IndexOf(searchValue);

                    if (strIndex >= 0)
                    {

                        rowTableSearch2 = UserMatchSearch2.NewRow();
                        rowTableSearch2["UserID"] = Join_UserAndGroup.Rows[rowIndex].ItemArray[0].ToString();
                        rowTableSearch2["UserIDAuToInc"] = Join_UserAndGroup.Rows[rowIndex].ItemArray[1].ToString();
                        UserMatchSearch2.Rows.Add(rowTableSearch2);
                    }
                    rowIndex++;

                }
                dataGridViewUserinGroup.Rows.Clear();
                // Set a DataGrid control's DataSource to the DataView.
                for (int row = 0; row < UserMatchSearch2.Rows.Count; row++)
                {
                    dataGridViewUserinGroup.Rows.Add();
                    dataGridViewUserinGroup.Rows[row].Cells["UserIDIngroup"].Value = UserMatchSearch2.Rows[row].ItemArray[0];
                    dataGridViewUserinGroup.Rows[row].Cells["UserIDAuToIncInGroup"].Value = UserMatchSearch2.Rows[row].ItemArray[1];

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
            column.ColumnName = "UserIDAuToInc";
            UserMatchSearch.Columns.Add(column);

            column.Dispose();
        }

        #endregion

        #region mouse click UserinGroup

        private void dataGridViewUserinGroup_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {               

                if (e.Button == MouseButtons.Left)
                {
                    SelectedRowIndexdataGridViewUserinGroup = dataGridViewUserinGroup.HitTest(e.X, e.Y).RowIndex;
                }
                else
                {
                    ContextMenuStrip my_menu = new ContextMenuStrip();
                    SelectedRowIndexdataGridViewUserinGroup = dataGridViewUserinGroup.HitTest(e.X, e.Y).RowIndex;


                    dataGridViewUserinGroup.ClearSelection();
                    

                    if (SelectedRowIndexdataGridViewUserinGroup >= 0)
                    {
                        dataGridViewUserinGroup.Rows[SelectedRowIndexdataGridViewUserinGroup].Selected = true;
                        my_menu.Items.Add("Remove").Name = "Delete";
                    }
                    my_menu.Show(dataGridViewUserinGroup, new Point(e.X, e.Y));

                    //Event menu Click
                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClickedUserinGroup);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void my_menu_ItemClickedUserinGroup(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                //int rowGroupIndex = dataGridViewGroup.CurrentCell.RowIndex;
                string GroupSelected = comboBoxGroup.SelectedValue.ToString();
                switch (e.ClickedItem.Name.ToString())
                {
                    case "Delete":
                        //Console.WriteLine("Delete case");
                        try
                        {
                            using (SqlConnection connection = new SqlConnection(
                              connectionString))
                            {
                                string userid = dataGridViewUserinGroup.Rows[SelectedRowIndexdataGridViewUserinGroup].Cells["UserIDAuToIncInGroup"].Value.ToString();
                                string queryString3 = "DELETE FROM ["+DataBaseName+"].[dbo].[User_RealTimeGroup_Relation] WHERE RealTimeGroupID ='" + GroupSelected + "' AND UserIDAutoInc = '" + userid + "' ";
                                SqlCommand command3 = new SqlCommand(queryString3, connection);
                                command3.Connection.Open();
                                command3.ExecuteNonQuery();

                                dataGridViewUserinGroup.Rows.RemoveAt(SelectedRowIndexdataGridViewUserinGroup);
                                Load_Join_UserAndGroup();
                                filldatagridviewavilableuser();
                                labelnumberUserinTemplate.Text = Join_UserAndGroup.Rows.Count.ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        #endregion

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Load_Join_UserAndGroup();

                dataGridViewUserinGroup.Rows.Clear();
                labelnumberUserinTemplate.Text = Join_UserAndGroup.Rows.Count.ToString();
                
                filldataGridViewUserinGroup(); //user in template
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    All_User.Clear();
                    string queryString = "SELECT * FROM [" + DataBaseName + "].[dbo].[User] ORDER BY FirstName";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(All_User);
                    checkbox_Add = new bool[All_User.Rows.Count];

                    filldatagridviewavilableuser(); //avilable user

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filldataGridViewUserinGroup()
        {
            try
            {
                string groupselected = comboBoxGroup.SelectedItem.ToString();
                dataGridViewUserinGroup.Rows.Clear();
                for (int row = 0; row < Join_UserAndGroup.Rows.Count; row++)
                {
                    dataGridViewUserinGroup.Rows.Add();
                    dataGridViewUserinGroup.Rows[row].Cells["del"].Value = false;
                    dataGridViewUserinGroup.Rows[row].Cells["UserIDIngroup"].Value = Join_UserAndGroup.Rows[row].ItemArray[0];
                    dataGridViewUserinGroup.Rows[row].Cells["UserIDAuToIncInGroup"].Value = Join_UserAndGroup.Rows[row].ItemArray[1];

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filldatagridviewavilableuser()
        {
            try
            {
                dataGridViewAvilableuser.Rows.Clear();
                int RowNotDuplicate = 0;
                DataRow rowTable2;
                UserinDataGridviewAvilUser.Clear();

                for (int rowAlluserDataTable = 0; rowAlluserDataTable < All_User.Rows.Count; rowAlluserDataTable++)
                {

                    int checkAlluser_duplicate_UserinTemplate = 0;
                    for (int rowgrid1 = 0; rowgrid1 < Join_UserAndGroup.Rows.Count; rowgrid1++)
                    {
                        if (Join_UserAndGroup.Rows[rowgrid1].ItemArray[0].ToString() == All_User.Rows[rowAlluserDataTable].ItemArray[0].ToString())
                        {
                            checkAlluser_duplicate_UserinTemplate = 1;
                            break;
                        }

                    }
                    if (checkAlluser_duplicate_UserinTemplate == 0)
                    {
                        dataGridViewAvilableuser.Rows.Add();
                        dataGridViewAvilableuser.Rows[RowNotDuplicate].Cells[0].Value = false;
                        dataGridViewAvilableuser.Rows[RowNotDuplicate].Cells["UserIDAdd"].Value = All_User.Rows[rowAlluserDataTable].ItemArray[0];
                        dataGridViewAvilableuser.Rows[RowNotDuplicate].Cells["UserIDAuToIncadd"].Value = All_User.Rows[rowAlluserDataTable].ItemArray[5];

                        rowTable2 = UserinDataGridviewAvilUser.NewRow();
                        rowTable2["UserID"] = All_User.Rows[rowAlluserDataTable].ItemArray[0].ToString();
                        rowTable2["UserIDAuToInc"] = All_User.Rows[rowAlluserDataTable].ItemArray[5].ToString();
                        UserinDataGridviewAvilUser.Rows.Add(rowTable2);
                        ++RowNotDuplicate;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region InitialDataTable_datagridviewAvilableUser

        private void InitialDataTable_datagridviewAvilableUser()
        {
            // Declare DataColumn and DataRow variables.
            DataColumn column;

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "UserID";
            UserinDataGridviewAvilUser.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "UserIDAuToInc";
            UserinDataGridviewAvilUser.Columns.Add(column);
            column.Dispose();
        }

        #endregion

        private void dataGridViewAvilableuser_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                SelectedrowIndexdataGridviewAvilableuser = dataGridViewAvilableuser.HitTest(e.X, e.Y).RowIndex;

                if (e.Button == MouseButtons.Left)
                {
                    SelectedrowIndexdataGridviewAvilableuser = dataGridViewAvilableuser.HitTest(e.X, e.Y).RowIndex;
                }
                else
                {
                    ContextMenuStrip my_menu = new ContextMenuStrip();
                    SelectedrowIndexdataGridviewAvilableuser = dataGridViewAvilableuser.HitTest(e.X, e.Y).RowIndex;
                    dataGridViewAvilableuser.ClearSelection();
                    
                    if (SelectedRowIndexdataGridViewUserinGroup >= 0)
                    {
                        dataGridViewAvilableuser.Rows[SelectedrowIndexdataGridviewAvilableuser].Selected = true;
                        my_menu.Items.Add("Add").Name = "Add";
                    }
                    my_menu.Show(dataGridViewAvilableuser, new Point(e.X, e.Y));

                    //Event menu Click
                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClickedAvilUser);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void my_menu_ItemClickedAvilUser(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                //int rowGroupIndex = dataGridViewGroup.CurrentCell.RowIndex;
                string GroupSelected = comboBoxGroup.SelectedValue.ToString();
                switch (e.ClickedItem.Name.ToString())
                {
                    case "Add":
                        //Console.WriteLine("Delete case");
                        try
                        {
                            using (SqlConnection connection = new SqlConnection(
                              connectionString))
                            {
                                string queryString3 = "INSERT INTO ["+DataBaseName+ "].[dbo].[User_RealTimeGroup_Relation] ([RealTimeGroupID],[UserIDAutoInc]) VALUES('"+comboBoxGroup.SelectedValue.ToString()+"','"+dataGridViewAvilableuser.Rows[SelectedrowIndexdataGridviewAvilableuser].Cells["UserIDAuToIncadd"].Value.ToString()+"')";
                                SqlCommand command3 = new SqlCommand(queryString3, connection);
                                command3.Connection.Open();
                                command3.ExecuteNonQuery();

                                dataGridViewAvilableuser.Rows.RemoveAt(SelectedrowIndexdataGridviewAvilableuser);

                                Load_Join_UserAndGroup();
                                filldatagridviewavilableuser();
                                filldataGridViewUserinGroup();
                                labelnumberUserinTemplate.Text = Join_UserAndGroup.Rows.Count.ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int SumCheckBoxTrue = 0;
                int[] RowIndexDelete = new int[dataGridViewUserinGroup.Rows.Count]; //max index
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string queryString = "";

                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Connection.Open();
                    for (int row = 0; row < dataGridViewUserinGroup.Rows.Count; row++)
                    {
                        bool checkboxDel;

                        checkboxDel = Boolean.Parse(dataGridViewUserinGroup.Rows[row].Cells[0].Value.ToString());
                        if (checkboxDel == true)//checkBox True
                        {
                            RowIndexDelete[SumCheckBoxTrue] = row; //Keep Index True
                            ++SumCheckBoxTrue; //Count CheckBoxDelete True

                            string UserIDAuToInc = dataGridViewUserinGroup.Rows[row].Cells["UserIDAuToIncInGroup"].Value.ToString();
                            string comboboxselect = comboBoxGroup.SelectedValue.ToString();
                            //using (SqlConnection connection = new SqlConnection(connectionString))
                            //{                                                    

                            queryString = "DELETE FROM [" + DataBaseName + "].[dbo].[User_RealTimeGroup_Relation] WHERE UserIDAuToInc ='" + UserIDAuToInc + "' AND RealTimeGroupID = '" + comboboxselect + "'";

                            SqlCommand command2 = new SqlCommand(queryString, connection);
                            command2.ExecuteNonQuery();

                            //}
                        }//end if checkbox true
                    }//end for
                }//end using


                checkBoxDeleteAll.Checked = false;
                for (int DeleteRow = SumCheckBoxTrue - 1; DeleteRow >= 0; DeleteRow--)//delete last index first
                {
                    dataGridViewUserinGroup.Rows.RemoveAt(RowIndexDelete[DeleteRow]);
                }
                Load_Join_UserAndGroup();
                filldatagridviewavilableuser();
                labelnumberUserinTemplate.Text = Join_UserAndGroup.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                for (int row = 0; row < dataGridViewAvilableuser.Rows.Count; row++)
                {
                    bool result;

                    Boolean.TryParse(dataGridViewAvilableuser.Rows[row].Cells[0].Value.ToString(), out result);
                    int checkDuplicateUser = 0;
                    if (result == true)// checkBoxtrue Then Check Duplicate
                    {
                        for (int rowdatagrid1 = 0; rowdatagrid1 < dataGridViewUserinGroup.Rows.Count; rowdatagrid1++)
                        {
                            string User_OndatagridviewID = dataGridViewUserinGroup.Rows[rowdatagrid1].Cells["UserIDIngroup"].Value.ToString();
                            //check same Event
                            if (dataGridViewAvilableuser.Rows[row].Cells[1].Value.ToString() == User_OndatagridviewID)
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
                            string comboboxselect = comboBoxGroup.SelectedValue.ToString();
                            string queryString = "INSERT INTO [" + DataBaseName + "].[dbo].[User_RealTimeGroup_Relation] ([UserIDAutoInc],[RealTimeGroupID]) VALUES ('" + dataGridViewAvilableuser.Rows[row].Cells[2].Value.ToString() + "' , '" + comboboxselect + "')";
                            //Console.WriteLine(row + " : Checked True");
                            SqlCommand command = new SqlCommand(queryString, connection);
                            command.Connection.Open();
                            command.ExecuteNonQuery();

                        }

                    }

                }
                Load_Join_UserAndGroup();

                dataGridViewUserinGroup.Rows.Clear();
                for (int row = 0; row < Join_UserAndGroup.Rows.Count; row++)
                {
                    dataGridViewUserinGroup.Rows.Add();
                }
                filldataGridViewUserinGroup();
                filldatagridviewavilableuser();
                labelnumberUserinTemplate.Text = Join_UserAndGroup.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       

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
            column.ColumnName = "UserIDAuToInc";
            UserMatchSearch2.Columns.Add(column);
            column.Dispose();
        }

        #endregion

        private void checkBoxDeleteAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDeleteAll.Checked)
            {
                for (int row = 0; row < dataGridViewUserinGroup.Rows.Count; row++)
                {
                    dataGridViewUserinGroup.Rows[row].Cells[0].Value = true;
                }
            }
            else
            {
                for (int row = 0; row < dataGridViewUserinGroup.Rows.Count; row++)
                {
                    dataGridViewUserinGroup.Rows[row].Cells[0].Value = false;
                }
            }
        }
    }
}
