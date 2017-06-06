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
using System.IO;

namespace PI_SMS
{
    public partial class AssignEventToTemplate : Form
    {
        
        DataTable EventID_In_Template = new DataTable(); //Event In Template
        DataTable UserMatchSearch = new DataTable();
        DataTable tableTemplate = new DataTable();
        DataTable tableEvent = new DataTable(); 
        DataTable AllEventDataTable = new DataTable();
        DataTable UserMatchSearch2 = new DataTable();
        DataTable EventinDataGridview2 = new DataTable();//Event not in Template
        bool[] checkbox_Add;
        string connectionString = "";
        string DataBaseName = "";
        int SelectedRowIndexdataGridView;
        int SelectedRowIndexdataGridViewAdd;
        private readonly PISMS pisms;
        public AssignEventToTemplate(PISMS frompisms)
        {
            InitializeComponent();
            pisms = frompisms;           
            InitialDataTableForSearch();           
            start();

        }

        public void start()
        {
            try
            {               
                //PISMS pisms = new PISMS();
                string IP = pisms.Pub_Config.Rows[0].ItemArray[0].ToString();
                DataBaseName = pisms.Pub_Config.Rows[0].ItemArray[2].ToString();
                string UserID = pisms.Pub_Config.Rows[0].ItemArray[3].ToString();
                string Password = pisms.Pub_Config.Rows[0].ItemArray[4].ToString();
                connectionString = "Data Source = " + IP + "; Initial Catalog =" + DataBaseName + "; User ID =" + UserID + "; Password =" + Password;

                comboBoxTemplate.DropDownStyle = ComboBoxStyle.DropDownList;
                loadallevent();
                FillComboBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Fill ComboBox

        public void FillComboBox()
        {
            try
            {
                SqlDataReader datareader;
                tableTemplate.Clear();
                //tableEvent.Clear();
                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {

                    string queryString = "SELECT TemplateName,TemplateIDAuToInc FROM ["+DataBaseName+"].[dbo].[NotificationTemplate] ORDER BY TemplateName";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Connection.Open();

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

        #region LoadData Event in Template

        private void LoadDataToTableEventinTemplate()
        {
            try
            {
                EventID_In_Template.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    
                    string queryString = "SELECT ["+DataBaseName+"].[dbo].[Event].EventName,["+DataBaseName+"].[dbo].[Event].Monday,["+DataBaseName+"].[dbo].[Event].Tuesday,["+DataBaseName+"].[dbo].[Event].Wednesday,["+DataBaseName+"].[dbo].[Event].Thursday,["+DataBaseName+"].[dbo].[Event].Friday,["+DataBaseName+"].[dbo].[Event].Saturday,["+DataBaseName+"].[dbo].[Event].Sunday,["+DataBaseName+"].[dbo].[Event].Time,["+DataBaseName+"].[dbo].[Event].EventID" +
" From["+DataBaseName+"].[dbo].[Template_Event_RelationTable]"+
" JOIN NotificationTemplate ON["+DataBaseName+"].[dbo].[Template_Event_RelationTable].TemplateIDAuToInc = ["+DataBaseName+"].[dbo].[NotificationTemplate].TemplateIDAuToInc"+
" JOIN Event ON["+DataBaseName+"].[dbo].[Template_Event_RelationTable].EventID = ["+DataBaseName+"].[dbo].[Event].EventID"+
" WHERE [NotificationTemplate].TemplateIDAuToInc = '" + comboBoxTemplate.SelectedValue.ToString() + "' ORDER BY EventName";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(EventID_In_Template);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region load all event

        private void loadallevent()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                AllEventDataTable.Clear();
                string queryString = "SELECT * FROM ["+DataBaseName+"].[dbo].[Event] ORDER BY EventName";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataAdapter data = new SqlDataAdapter(command);
                command.Connection.Open();
                command.ExecuteNonQuery();
                data.Fill(AllEventDataTable);
                checkbox_Add = new bool[AllEventDataTable.Rows.Count];
            }
                
        }

        #endregion

        #region Filldatagridview

        private void Filldatagridview()
        {
            try
            {
                for (int row = 0; row < EventID_In_Template.Rows.Count; row++)
                {
                    dataGridViewevent_in_template.Rows[row].Cells[0].Value = EventID_In_Template.Rows[row].ItemArray[0].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[1].Value = EventID_In_Template.Rows[row].ItemArray[1].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[2].Value = EventID_In_Template.Rows[row].ItemArray[2].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[3].Value = EventID_In_Template.Rows[row].ItemArray[3].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[4].Value = EventID_In_Template.Rows[row].ItemArray[4].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[5].Value = EventID_In_Template.Rows[row].ItemArray[5].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[6].Value = EventID_In_Template.Rows[row].ItemArray[6].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[7].Value = EventID_In_Template.Rows[row].ItemArray[7].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[8].Value = EventID_In_Template.Rows[row].ItemArray[8].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[9].Value = EventID_In_Template.Rows[row].ItemArray[9].ToString();
                }
                labelnumberEventinTemplate.Text = EventID_In_Template.Rows.Count.ToString();
            }          
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region fill datagridviewAdd

        private void Filldatagridview2()
        {
            try
            {
                dataGridViewAdd.Rows.Clear();
                int RowNotDuplicate = 0;
                DataRow rowTable2;
                EventinDataGridview2.Clear();

                for (int rowAlluserDataTable = 0; rowAlluserDataTable < AllEventDataTable.Rows.Count; rowAlluserDataTable++)
                {

                    int checkAlluser_duplicate_UserinTemplate = 0;
                    for (int rowgrid1 = 0; rowgrid1 < EventID_In_Template.Rows.Count; rowgrid1++)
                    {
                        if (EventID_In_Template.Rows[rowgrid1].ItemArray[0].ToString() == AllEventDataTable.Rows[rowAlluserDataTable].ItemArray[0].ToString())
                        {
                            checkAlluser_duplicate_UserinTemplate = 1;
                            break;
                        }

                    }
                    if (checkAlluser_duplicate_UserinTemplate == 0)
                    {
                        dataGridViewAdd.Rows.Add();
                        dataGridViewAdd.Rows[RowNotDuplicate].Cells[0].Value = false;
                        dataGridViewAdd.Rows[RowNotDuplicate].Cells["EventNameAdd"].Value = AllEventDataTable.Rows[rowAlluserDataTable].ItemArray[0];
                        dataGridViewAdd.Rows[RowNotDuplicate].Cells["EventIDAdd"].Value = AllEventDataTable.Rows[rowAlluserDataTable].ItemArray[9];
                        
                        //rowTable2 = UserinDataGridview2.NewRow();
                        //rowTable2["UserID"] = AllEventDataTable.Rows[rowAlluserDataTable].ItemArray[0].ToString();
                        //rowTable2["FirstName"] = AllEventDataTable.Rows[rowAlluserDataTable].ItemArray[6].ToString();                        
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

        #region ADD

        private void buttonadd_Click(object sender, EventArgs e)
        {
            try
            {
                for (int row = 0; row < dataGridViewAdd.Rows.Count; row++)
                {
                    bool result;
                    string EventID="";
                    Boolean.TryParse(dataGridViewAdd.Rows[row].Cells[0].Value.ToString(), out result);
                    int checkDuplicateUser = 0;
                    if (result == true)// checkBoxtrue Then Check Duplicate
                    {
                        EventID = dataGridViewAdd.Rows[row].Cells["EventIDAdd"].Value.ToString();
                        
                    }

                    if (result == true && checkDuplicateUser == 0)
                    {

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string comboboxselect = comboBoxTemplate.SelectedValue.ToString();
                            string queryString = "INSERT INTO ["+DataBaseName+"].[dbo].[Template_Event_RelationTable] (TemplateIDAuToInc,EventID) VALUES('" + comboBoxTemplate.SelectedValue.ToString() + "','" + EventID + "')";
                            //Console.WriteLine(row + " : Checked True");
                            SqlCommand command = new SqlCommand(queryString, connection);
                            command.Connection.Open();
                            command.ExecuteNonQuery();

                        }

                    }

                }
                checkBoxAdd.Checked = false;
                LoadDataToTableEventinTemplate(); //EventinTemplate

                dataGridViewevent_in_template.Rows.Clear();
                for (int row = 0; row < EventID_In_Template.Rows.Count; row++)
                {
                    dataGridViewevent_in_template.Rows.Add();
                }
                Filldatagridview();
                Filldatagridview2();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                     

        }

#endregion

        #region ComboBox selectedChange

        private void comboBoxTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDataToTableEventinTemplate(); //LoadEventin Template
                dataGridViewevent_in_template.Rows.Clear();
                    for (int row = 0; row < EventID_In_Template.Rows.Count; row++)
                    {
                        dataGridViewevent_in_template.Rows.Add();
                    }
                    Filldatagridview();
                    Filldatagridview2();
                    //string s = comboBoxTemplate.SelectedValue.ToString(); //ID
                    //string ss = comboBoxTemplate.ValueMember.ToString(); // ColumnDataBase Name
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

#endregion

        #region Mouse ClickdataGrid Delete

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
                    SelectedRowIndexdataGridView = dataGridViewevent_in_template.HitTest(e.X, e.Y).RowIndex;
                    dataGridViewevent_in_template.ClearSelection();
                    dataGridViewevent_in_template.Rows[SelectedRowIndexdataGridView].Selected = true;

                    if (SelectedRowIndexdataGridView >= 0)
                    {
                        my_menu.Items.Add("Remove").Name = "Delete";
                    }
                    my_menu.Show(dataGridViewevent_in_template, new Point(e.X, e.Y));

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
            //int rowIndex = dataGridView1.CurrentCell.RowIndex;
            try
            {
                string EventSelected = dataGridViewevent_in_template.Rows[SelectedRowIndexdataGridView].Cells["EventID"].Value.ToString();
                switch (e.ClickedItem.Name.ToString())
                {
                    case "Delete":


                        using (SqlConnection connection = new SqlConnection(
                       connectionString))
                        {
                            string queryString3 = "DELETE FROM ["+DataBaseName+"].[dbo].[Template_Event_RelationTable] WHERE EventID ='" + EventSelected + "'";
                            SqlCommand command3 = new SqlCommand(queryString3, connection);
                            command3.Connection.Open();
                            command3.ExecuteNonQuery();

                            dataGridViewevent_in_template.Rows.RemoveAt(SelectedRowIndexdataGridView);
                            LoadDataToTableEventinTemplate();
                            Filldatagridview();
                            Filldatagridview2();
                            dataGridViewevent_in_template.Update();
                            
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {           
            //dgvProjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                string searchValue = textBoxSearch.Text;
                int strIndex = 0;
                DataRow rowTableSearch;
                UserMatchSearch.Clear();
                int rowIndex = 0;
                foreach (DataRow row in EventID_In_Template.Rows)
                {
                    strIndex = row.ItemArray[0].ToString().IndexOf(searchValue);
                    if (strIndex >= 0)
                    {
                        //dataGridView1.ClearSelection();                        
                        //dataGridView1.Rows[rowIndex].Selected = true;
                        //dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                        //dataGridView1.Focus();

                        rowTableSearch = UserMatchSearch.NewRow();
                        rowTableSearch["EventName"] = EventID_In_Template.Rows[rowIndex].ItemArray[0].ToString();
                        rowTableSearch["Mon"] = EventID_In_Template.Rows[rowIndex].ItemArray[1].ToString();
                        rowTableSearch["Tue"] = EventID_In_Template.Rows[rowIndex].ItemArray[2].ToString();
                        rowTableSearch["Wed"] = EventID_In_Template.Rows[rowIndex].ItemArray[3].ToString();
                        rowTableSearch["Thu"] = EventID_In_Template.Rows[rowIndex].ItemArray[4].ToString();
                        rowTableSearch["Fri"] = EventID_In_Template.Rows[rowIndex].ItemArray[5].ToString();
                        rowTableSearch["Sat"] = EventID_In_Template.Rows[rowIndex].ItemArray[6].ToString();
                        rowTableSearch["Sun"] = EventID_In_Template.Rows[rowIndex].ItemArray[7].ToString();
                        rowTableSearch["Time"] = EventID_In_Template.Rows[rowIndex].ItemArray[8].ToString();
                        rowTableSearch["EventID"] = EventID_In_Template.Rows[rowIndex].ItemArray[9].ToString();
                                                                                                     
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
                dataGridViewevent_in_template.Rows.Clear();
                // Set a DataGrid control's DataSource to the DataView.
                for (int row = 0; row < UserMatchSearch.Rows.Count; row++)
                {
                    dataGridViewevent_in_template.Rows.Add();
                    dataGridViewevent_in_template.Rows[row].Cells[0].Value = UserMatchSearch.Rows[row].ItemArray[0].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[1].Value = UserMatchSearch.Rows[row].ItemArray[1].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[2].Value = UserMatchSearch.Rows[row].ItemArray[2].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[3].Value = UserMatchSearch.Rows[row].ItemArray[3].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[4].Value = UserMatchSearch.Rows[row].ItemArray[4].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[5].Value = UserMatchSearch.Rows[row].ItemArray[5].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[6].Value = UserMatchSearch.Rows[row].ItemArray[6].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[7].Value = UserMatchSearch.Rows[row].ItemArray[7].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[8].Value = UserMatchSearch.Rows[row].ItemArray[8].ToString();
                    dataGridViewevent_in_template.Rows[row].Cells[9].Value = UserMatchSearch.Rows[row].ItemArray[9].ToString();

                }//end forloop add Match Search
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        #region Inittial daTaTableForSearch

        public void InitialDataTableForSearch()
        {
            // Declare DataColumn and DataRow variables.
            DataColumn column;


            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "EventName";
            UserMatchSearch.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Mon";
            UserMatchSearch.Columns.Add(column);

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Tue";
            UserMatchSearch.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Wed";
            UserMatchSearch.Columns.Add(column);

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Thu";
            UserMatchSearch.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Fri";
            UserMatchSearch.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Sat";
            UserMatchSearch.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Sun";
            UserMatchSearch.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Time";
            UserMatchSearch.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "EventID";
            UserMatchSearch.Columns.Add(column);

            column.Dispose();
        }

        #endregion

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)//add
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    SelectedRowIndexdataGridViewAdd = dataGridViewAdd.HitTest(e.X, e.Y).RowIndex;
                }
                else
                {
                    ContextMenuStrip my_menu2 = new ContextMenuStrip();
                    SelectedRowIndexdataGridViewAdd = dataGridViewAdd.HitTest(e.X, e.Y).RowIndex;
                    dataGridViewAdd.ClearSelection();
                    dataGridViewAdd.Rows[SelectedRowIndexdataGridViewAdd].Selected = true;
                    //MessageBox.Show("right click");
                    //MessageBox.Show(SelectedRowIndexdataGridView.ToString());

                    if (SelectedRowIndexdataGridViewAdd >= 0)
                    {
                        my_menu2.Items.Add("Add").Name = "Add";
                    }
                    my_menu2.Show(dataGridViewAdd, new Point(e.X, e.Y));

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
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            int checksameEvent = 0;
                            string EventID = dataGridViewAdd.Rows[SelectedRowIndexdataGridViewAdd].Cells["EventIDAdd"].Value.ToString();
                            for (int row = 0; row < dataGridViewevent_in_template.Rows.Count; row++)
                            {

                                string Event_Ondatagridview = dataGridViewevent_in_template.Rows[row].Cells["EventID"].Value.ToString();
                                //check same TagName
                                if (EventID == Event_Ondatagridview)
                                {
                                    MessageBox.Show("Error Event Duplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    checksameEvent = 1;
                                    break;
                                }
                            }

                            if (checksameEvent == 0)
                            {
                                string queryString = "INSERT INTO ["+DataBaseName+"].[dbo].[Template_Event_RelationTable] (TemplateIDAuToInc,EventID) VALUES('" + comboBoxTemplate.SelectedValue.ToString() + "','" + EventID + "')";
                                SqlCommand command = new SqlCommand(queryString, connection);
                                command.Connection.Open();
                                command.ExecuteNonQuery();

                                dataGridViewevent_in_template.Rows.Add();
                                LoadDataToTableEventinTemplate();
                                Filldatagridview();
                                Filldatagridview2();
                                dataGridViewevent_in_template.Update();

                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

            }
        }

        private void checkBoxAdd_CheckedChanged(object sender, EventArgs e)
        {
            for (int rowgrid2 = 0; rowgrid2 < dataGridViewAdd.Rows.Count; rowgrid2++)
            {
                if (checkBoxAdd.Checked)
                {
                    dataGridViewAdd.Rows[rowgrid2].Cells[0].Value = true;
                }
                else
                {
                    dataGridViewAdd.Rows[rowgrid2].Cells[0].Value = false;
                }
            }
        }
    }
}
