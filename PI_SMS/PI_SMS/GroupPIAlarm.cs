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
    public partial class GroupPIAlarm : Form
    {
        DataTable Alertinformation_Search = new DataTable();
        DataTable Alertinformation = new DataTable();
        DataTable RealTimeGroupTable = new DataTable();
        DataTable RealTimeGroupTableSetbutton = new DataTable();
        DataTable TagMatchSearch = new DataTable();
        public DataTable RealTimeTag_in_RealTimeGroup = new DataTable();
        DataTable TagConditionTable = new DataTable();
        DataTable checkOnAleart = new DataTable();

        string connectionString="";
        int SelectedRowIndexdataGridViewRealTimeTag;
        int SelectedRowIndexdataGridViewTagCondition;
        string statuschangeto = "";
        DataRow rowTableSearch;

        string DataBaseName = "";
        string IP = "";
        string UserID = "";
        string Password = "";

        private readonly PISMS pisms;
        public GroupPIAlarm(PISMS frompisms)
        {
            InitializeComponent();
            pisms = frompisms;
            //PISMS pisms = new PISMS();
            IP = pisms.Pub_Config.Rows[0].ItemArray[0].ToString();
            DataBaseName = pisms.Pub_Config.Rows[0].ItemArray[2].ToString();
            UserID = pisms.Pub_Config.Rows[0].ItemArray[3].ToString();
            Password = pisms.Pub_Config.Rows[0].ItemArray[4].ToString();
            connectionString = "Data Source = " + IP + "; Initial Catalog =" + DataBaseName + "; User ID =" + UserID + "; Password =" + Password;
        
            TagMatchSearch.Columns.Add("PIServer", typeof(string));//0
            TagMatchSearch.Columns.Add("TagName", typeof(string));
            TagMatchSearch.Columns.Add("Type", typeof(string));//2
            TagMatchSearch.Columns.Add("TagID", typeof(string));
            TagMatchSearch.Columns.Add("Mail", typeof(string));//4
            TagMatchSearch.Columns.Add("Phone", typeof(string));
            TagMatchSearch.Columns.Add("Enable", typeof(string));//6
            TagMatchSearch.Columns.Add("TagAlias", typeof(string));
            TagMatchSearch.Columns.Add("OnAlert", typeof(string));//8
            TagMatchSearch.Columns.Add("Acknowledge", typeof(string));
            TagMatchSearch.Columns.Add("High", typeof(string));//10
            TagMatchSearch.Columns.Add("Low", typeof(string));
            TagMatchSearch.Columns.Add("Danger", typeof(string));//12

            FillComboBoxRealTimeGroup();
            
        }

        #region Fill ComboBoxRealTimeGroup

        public void FillComboBoxRealTimeGroup()
        {
            try
            {
                SqlDataReader datareader;
                RealTimeGroupTable.Clear();
                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {

                    string queryString = "SELECT * FROM [" + DataBaseName + "].[dbo].[RealTimeGroup] ORDER BY GroupName";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Connection.Open();

                    datareader = command.ExecuteReader();
                    RealTimeGroupTable.Load(datareader);
                    comboBoxRealTimeGroup.DisplayMember = "GroupName";
                    comboBoxRealTimeGroup.Text = "GroupName";
                    comboBoxRealTimeGroup.ValueMember = "RealTimeGroupID";
                    comboBoxRealTimeGroup.DataSource = RealTimeGroupTable;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region comboBoxRealTimeGroup_SelectedIndexChanged

        private void comboBoxRealTimeGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string s = comboBoxRealTimeGroup.SelectedValue.ToString(); //ID
            LoadRealTimeGroup();
            textBoxNonRepetitionInterval.Text = RealTimeGroupTableSetbutton.Rows[0].ItemArray[3].ToString();
            comboBoxResendIntervalunit.SelectedItem = RealTimeGroupTableSetbutton.Rows[0].ItemArray[4].ToString();
            textBoxresendtime.Text = RealTimeGroupTableSetbutton.Rows[0].ItemArray[5].ToString();
            comboBoxNonRepetitionIntervalunit.SelectedItem = RealTimeGroupTableSetbutton.Rows[0].ItemArray[6].ToString();

            dataGridViewTagCondition.Rows.Clear();
            //SET BUTTON START STOP GROUP
            if (RealTimeGroupTableSetbutton.Rows[0].ItemArray[2].ToString() == "False")
            {
                buttonStartGroup.Enabled = true;
                buttonStopGroup.Enabled = false;
            }
            else
            {
                buttonStartGroup.Enabled = false;
                buttonStopGroup.Enabled = true;
            }
            // END SET BUTTON START STOP GROUP
            LoadData_RealTimeTag_in_RealTimeGroup();
            Fill_datagridview_Tag_in_RealTimeGroup();
        }

        #endregion

        #region Fill datagridview TaginGroup

        public void Fill_datagridview_Tag_in_RealTimeGroup()
        {
            try
            {
                //LoadData_RealTimeTag_in_RealTimeGroup();

                dataGridViewTaginRealTimeGroup.Rows.Clear();
                for (int row = 0; row < RealTimeTag_in_RealTimeGroup.Rows.Count; row++)
                {
                    dataGridViewTaginRealTimeGroup.Rows.Add();
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["No"].Value = (row + 1).ToString();
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["TagName"].Value = RealTimeTag_in_RealTimeGroup.Rows[row].ItemArray[0].ToString();
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["PIServer"].Value = RealTimeTag_in_RealTimeGroup.Rows[row].ItemArray[1].ToString();
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["Type"].Value = RealTimeTag_in_RealTimeGroup.Rows[row].ItemArray[2].ToString();
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["Enable"].Value = RealTimeTag_in_RealTimeGroup.Rows[row].ItemArray[3].ToString();
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["Mail"].Value = RealTimeTag_in_RealTimeGroup.Rows[row].ItemArray[4].ToString();
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["Phone"].Value = RealTimeTag_in_RealTimeGroup.Rows[row].ItemArray[5].ToString();
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["TagID"].Value = RealTimeTag_in_RealTimeGroup.Rows[row].ItemArray[6].ToString();
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["TagAlias"].Value = RealTimeTag_in_RealTimeGroup.Rows[row].ItemArray[7].ToString();
                    
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["High"].Value = RealTimeTag_in_RealTimeGroup.Rows[row].ItemArray[8].ToString();
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["Low"].Value = RealTimeTag_in_RealTimeGroup.Rows[row].ItemArray[9].ToString();
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["Danger"].Value = RealTimeTag_in_RealTimeGroup.Rows[row].ItemArray[10].ToString();
                    LoadData_Alertinformation(RealTimeTag_in_RealTimeGroup.Rows[row].ItemArray[6].ToString(),row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region LoadRealTimeTag

        public void LoadData_RealTimeTag_in_RealTimeGroup()
        {
            try
            {
                RealTimeTag_in_RealTimeGroup.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string groupselect = comboBoxRealTimeGroup.SelectedValue.ToString();
                    string queryString = "SELECT ["+DataBaseName+"].[dbo].[RealTimeTag].TagName,["+DataBaseName+"].[dbo].[RealTimeTag].PIServer,"+
                        "["+DataBaseName+"].[dbo].[RealTimeTag].Type,["+DataBaseName+"].[dbo].[RealTimeTag].Enabled,"+/*3*/
                        "["+DataBaseName+"].[dbo].[RealTimeTag].Mail,["+DataBaseName+"].[dbo].[RealTimeTag].Phone,"+/*5*/
                        "["+DataBaseName+"].[dbo].[RealTimeTag].RealTimeTagID,["+DataBaseName+"].[dbo].[RealTimeTag].TagAlias," + /*7*/
                        "["+DataBaseName+"].[dbo].[RealTimeTag].High," +
                        "["+DataBaseName+"].[dbo].[RealTimeTag].Low," +/*9*/
                        "["+DataBaseName+"].[dbo].[RealTimeTag].Danger," +
                        "[" + DataBaseName + "].[dbo].[RealTimeTag].MessageForm"+/*11*/
" From[" +DataBaseName+"].[dbo].[RealTimeTag_RealTimeGroup_Relation]" +
" JOIN RealTimeTag ON["+DataBaseName+"].[dbo].[RealTimeTag_RealTimeGroup_Relation].RealTimeTagID = ["+DataBaseName+"].[dbo].[RealTimeTag].RealTimeTagID" +
" JOIN["+DataBaseName+"].[dbo].[RealTimeGroup] ON["+DataBaseName+"].[dbo].[RealTimeTag_RealTimeGroup_Relation].RealTimeGroupID = ["+DataBaseName+"].[dbo].[RealTimeGroup].RealTimeGroupID" +
" WHERE [RealTimeGroup].RealTimeGroupID='" + groupselect + "'";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(RealTimeTag_in_RealTimeGroup);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        public void LoadData_Alertinformation(string tagid,int row)
        {
            try
            {
                Alertinformation.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string groupselect = comboBoxRealTimeGroup.SelectedValue.ToString();
                    string queryString = "SELECT * From [" + DataBaseName + "].[dbo].[AlertInformation] WHERE RealTimeGroupID='" + groupselect + "' AND RealTimeTagID='"+ tagid + "'";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(Alertinformation);

                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["OnAlert"].Value = Alertinformation.Rows[0].ItemArray[3].ToString();
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["acknowledge"].Value = Alertinformation.Rows[0].ItemArray[5].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData_Alertinformation_Search(string tagid, int row)
        {
            try
            {
                Alertinformation_Search.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string groupselect = comboBoxRealTimeGroup.SelectedValue.ToString();
                    string queryString = "SELECT * From [" + DataBaseName + "].[dbo].[AlertInformation] WHERE RealTimeGroupID='" + groupselect + "' AND RealTimeTagID='" + tagid + "'";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(Alertinformation_Search);

                    rowTableSearch["OnAlert"] = Alertinformation.Rows[0].ItemArray[3].ToString();
                    rowTableSearch["Acknowledge"] = Alertinformation.Rows[0].ItemArray[5].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region LoadRealTimeGroup

        private void LoadRealTimeGroup()
        {
            try
            {
                RealTimeGroupTableSetbutton.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT * FROM [" + DataBaseName + "].[dbo].[RealTimeGroup] WHERE RealTimeGroupID = '" + comboBoxRealTimeGroup.SelectedValue.ToString() + "' ORDER BY GroupName ";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(RealTimeGroupTableSetbutton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion             

        #region Update Tag Status

        private void UpdateEnableStatus_Click(object sender, EventArgs e)
        {
            try
            {
                string columnchange_status = comboBoxmanagestatus.SelectedItem.ToString();

                using (SqlConnection connection = new SqlConnection(
                   connectionString))
                {

                    for (int row = 0; row < dataGridViewTaginRealTimeGroup.Rows.Count; row++)
                    {
                        string statusupdate = dataGridViewTaginRealTimeGroup.Rows[row].Cells[columnchange_status].Value.ToString();
                        if(columnchange_status == "Enable")
                        {
                            columnchange_status = "Enabled";
                        }
                        string queryString = "UPDATE ["+DataBaseName+"].[dbo].[RealTimeTag] SET [" + columnchange_status + "] = '" + statusupdate + "' WHERE RealTimeTagID = '" + dataGridViewTaginRealTimeGroup.Rows[row].Cells["TagID"].Value.ToString() + "'";
                        SqlCommand command = new SqlCommand(queryString, connection);
                        SqlDataAdapter data = new SqlDataAdapter(command);
                        if (row == 0)
                        {
                            command.Connection.Open();
                        }                       
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Update " + columnchange_status + " Done");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                

        }//end update enable status

        #endregion

        #region add TAG

        private void buttonAddTag_Click(object sender, EventArgs e)
        {
            string groupselectname = comboBoxRealTimeGroup.ValueMember.ToString();
            string groupselectid = comboBoxRealTimeGroup.SelectedValue.ToString();
            ADDRealTimeTag newtag = new ADDRealTimeTag(groupselectname, groupselectid, this, connectionString, SelectedRowIndexdataGridViewRealTimeTag,DataBaseName);
            newtag.Show();
            
        }

        #endregion

        #region checkboxTag checkedChange

        private void checkBoxEnable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string columnchange_status = comboBoxmanagestatus.SelectedItem.ToString();
                if (checkBoxEnable.Checked == true)
                {                    
                    statuschangeto = "true";
                    checkBoxDisable.Checked = false;
                    if (comboBoxmanagestatus.SelectedIndex.ToString() != "-1")
                    {
                        for (int i = 0; i < dataGridViewTaginRealTimeGroup.Rows.Count; i++)
                        {
                            dataGridViewTaginRealTimeGroup.Rows[i].Cells[columnchange_status].Value = statuschangeto;
                        }

                    }                   
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void checkBoxDisable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string columnchange_status = comboBoxmanagestatus.SelectedItem.ToString();
                if (checkBoxDisable.Checked == true)
                {

                    statuschangeto = "false";
                    checkBoxEnable.Checked = false;
                    if (comboBoxmanagestatus.SelectedIndex.ToString() != "-1")
                    {
                        for (int i = 0; i < dataGridViewTaginRealTimeGroup.Rows.Count; i++)
                        {
                            dataGridViewTaginRealTimeGroup.Rows[i].Cells[columnchange_status].Value = statuschangeto;
                        }
                    }
                                           
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DataGridview MouseClick TaginRealTime

        private void dataGridViewTaginRealTimeGroup_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    SelectedRowIndexdataGridViewRealTimeTag = dataGridViewTaginRealTimeGroup.HitTest(e.X, e.Y).RowIndex;
                    if (SelectedRowIndexdataGridViewRealTimeTag != -1)
                    {
                        Load_TagCondition();
                        FilldataGridViewTagCondition();
                        FillMessagebox();
                    }
                       
                }
                else
                {
                    ContextMenuStrip my_menu = new ContextMenuStrip();
                    SelectedRowIndexdataGridViewRealTimeTag = dataGridViewTaginRealTimeGroup.HitTest(e.X, e.Y).RowIndex;

                    if (SelectedRowIndexdataGridViewRealTimeTag >= 0)
                    {                        
                        dataGridViewTaginRealTimeGroup.ClearSelection();
                        dataGridViewTaginRealTimeGroup.Rows[SelectedRowIndexdataGridViewRealTimeTag].Selected = true;
                        Load_TagCondition();
                        FilldataGridViewTagCondition();

                        my_menu.Items.Add("Edit").Name = "Edit";
                        my_menu.Items.Add("Remove").Name = "Delete";
                        my_menu.Items.Add("Add Trigger").Name = "AddTrigger";
                    }
                    my_menu.Show(dataGridViewTaginRealTimeGroup, new Point(e.X, e.Y));

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
            string Tag_IdSelected = dataGridViewTaginRealTimeGroup.Rows[SelectedRowIndexdataGridViewRealTimeTag].Cells["TagID"].Value.ToString();
            string RealTimeGroupIDSelected = comboBoxRealTimeGroup.SelectedValue.ToString();
            switch (e.ClickedItem.Name.ToString())
            {
                case "Delete":
                    try
                    {

                        using (SqlConnection connection = new SqlConnection(
                       connectionString))
                        {
                            string queryString = " DELETE FROM ["+DataBaseName+"].[dbo].[RealTimeTag_RealTimeGroup_Relation] WHERE RealTimeTagID ='" + Tag_IdSelected + "' AND RealTimeGroupID = '" + RealTimeGroupIDSelected + "' ";
                            SqlCommand command = new SqlCommand(queryString, connection);
                            command.Connection.Open();
                            command.ExecuteNonQuery();

                            dataGridViewTaginRealTimeGroup.Rows.RemoveAt(SelectedRowIndexdataGridViewRealTimeTag);
                            LoadData_RealTimeTag_in_RealTimeGroup();
                            //Fill_datagridview_Tag_in_RealTimeGroup();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Edit":
                    //Do Something                    
                    try
                    {
                        if (SelectedRowIndexdataGridViewRealTimeTag >= 0)
                        {
                            EditRealTimeTag addtrigger = new EditRealTimeTag(connectionString, SelectedRowIndexdataGridViewRealTimeTag, this, DataBaseName);
                            addtrigger.Show();
                        }
                        else
                        {
                            MessageBox.Show("Select Tag Again");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "AddTrigger":
                    //Do Something                    
                    try
                    {
                        if(SelectedRowIndexdataGridViewRealTimeTag >= 0)
                        {
                            AddTrigger addtrigger = new AddTrigger(connectionString,SelectedRowIndexdataGridViewRealTimeTag, this, DataBaseName);
                            addtrigger.Show();
                        }
                        else
                        {
                            MessageBox.Show("Select Tag Again");
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

        #region comboBox1_SelectedIndexChanged manage status

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //checkbox manage status
        {
            try
            {
                checkBoxDisable.Enabled = true;
                checkBoxEnable.Enabled = true;
                UpdateStatusTag.Enabled = true;
                string columnchange_status = comboBoxmanagestatus.SelectedItem.ToString();
                
                if (checkBoxEnable.Checked)
                {
                    statuschangeto = "true";
                    for (int i = 0; i < dataGridViewTaginRealTimeGroup.Rows.Count; i++)
                    {
                        dataGridViewTaginRealTimeGroup.Rows[i].Cells[columnchange_status].Value = statuschangeto;
                    }
                }
                else if (checkBoxDisable.Checked)
                {
                    statuschangeto = "false";
                    for (int i = 0; i < dataGridViewTaginRealTimeGroup.Rows.Count; i++)
                    {
                        dataGridViewTaginRealTimeGroup.Rows[i].Cells[columnchange_status].Value = statuschangeto;
                    }
                }                                       

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        #endregion

        #region Search

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text;
            int strIndex = 0;
            
            TagMatchSearch.Clear();

            try
            {
                int rowIndex = 0;
                foreach (DataRow row in RealTimeTag_in_RealTimeGroup.Rows)
                {
                    strIndex = row.ItemArray[0].ToString().IndexOf(searchValue);

                    //

                    // if Match then add to TagMatchSearch(Table) dataSource From Tag_in_TemplateTable(Table)

                    //
                    if (strIndex >= 0)
                    {
                        rowTableSearch = TagMatchSearch.NewRow();
                        
                        rowTableSearch["TagName"] = RealTimeTag_in_RealTimeGroup.Rows[rowIndex].ItemArray[0].ToString();
                        rowTableSearch["PIServer"] = RealTimeTag_in_RealTimeGroup.Rows[rowIndex].ItemArray[1].ToString();
                        rowTableSearch["Type"] = RealTimeTag_in_RealTimeGroup.Rows[rowIndex].ItemArray[2].ToString();
                        rowTableSearch["TagID"] = RealTimeTag_in_RealTimeGroup.Rows[rowIndex].ItemArray[6].ToString();
                        rowTableSearch["Mail"] = RealTimeTag_in_RealTimeGroup.Rows[rowIndex].ItemArray[4].ToString();
                        rowTableSearch["Phone"] = RealTimeTag_in_RealTimeGroup.Rows[rowIndex].ItemArray[5].ToString();
                        rowTableSearch["Enable"] = RealTimeTag_in_RealTimeGroup.Rows[rowIndex].ItemArray[3].ToString();
                        rowTableSearch["TagAlias"] = RealTimeTag_in_RealTimeGroup.Rows[rowIndex].ItemArray[7].ToString();
                        //rowTableSearch["OnAlert"] = RealTimeTag_in_RealTimeGroup.Rows[rowIndex].ItemArray[8].ToString();
                        //rowTableSearch["Acknowledge"] = RealTimeTag_in_RealTimeGroup.Rows[rowIndex].ItemArray[9].ToString();
                        rowTableSearch["High"] = RealTimeTag_in_RealTimeGroup.Rows[rowIndex].ItemArray[8].ToString();
                        rowTableSearch["Low"] = RealTimeTag_in_RealTimeGroup.Rows[rowIndex].ItemArray[9].ToString();
                        rowTableSearch["Danger"] = RealTimeTag_in_RealTimeGroup.Rows[rowIndex].ItemArray[10].ToString();
                        LoadData_Alertinformation_Search(RealTimeTag_in_RealTimeGroup.Rows[rowIndex].ItemArray[6].ToString(), rowIndex);


                        TagMatchSearch.Rows.Add(rowTableSearch);
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
                dataGridViewTaginRealTimeGroup.Rows.Clear();
                // Set a DataGrid control's DataSource to the DataView.
                for (int row = 0; row < TagMatchSearch.Rows.Count; row++)
                {
                    dataGridViewTaginRealTimeGroup.Rows.Add();                    
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["PIServer"].Value = TagMatchSearch.Rows[row].ItemArray[0];
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["TagName"].Value = TagMatchSearch.Rows[row].ItemArray[1];
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["Type"].Value = TagMatchSearch.Rows[row].ItemArray[2];
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["TagID"].Value = TagMatchSearch.Rows[row].ItemArray[3];
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["Mail"].Value = TagMatchSearch.Rows[row].ItemArray[4];
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["Phone"].Value = TagMatchSearch.Rows[row].ItemArray[5];
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["Enable"].Value = TagMatchSearch.Rows[row].ItemArray[6];
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["TagAlias"].Value = TagMatchSearch.Rows[row].ItemArray[7];
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["OnAlert"].Value = TagMatchSearch.Rows[row].ItemArray[8];
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["Acknowledge"].Value = TagMatchSearch.Rows[row].ItemArray[9];
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["High"].Value = TagMatchSearch.Rows[row].ItemArray[10];
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["Low"].Value = TagMatchSearch.Rows[row].ItemArray[11];
                    dataGridViewTaginRealTimeGroup.Rows[row].Cells["Danger"].Value = TagMatchSearch.Rows[row].ItemArray[12];
                    //LoadData_Alertinformation_Search(RealTimeTag_in_RealTimeGroup.Rows[rowIndex].ItemArray[6].ToString(), rowIndex);

                }//end forloop add Match Search
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        #endregion

        public void FilldataGridViewTagCondition()
        {
            try
            {
                

                dataGridViewTagCondition.Rows.Clear();
                for (int row = 0; row < TagConditionTable.Rows.Count; row++)
                {
                    dataGridViewTagCondition.Rows.Add();
                    dataGridViewTagCondition.Rows[row].Cells["OPerator"].Value = TagConditionTable.Rows[row].ItemArray[0].ToString();
                    dataGridViewTagCondition.Rows[row].Cells["value"].Value = TagConditionTable.Rows[row].ItemArray[1].ToString();
                    dataGridViewTagCondition.Rows[row].Cells["TimeTrue"].Value = TagConditionTable.Rows[row].ItemArray[2].ToString();
                    dataGridViewTagCondition.Rows[row].Cells["Timeunit"].Value = TagConditionTable.Rows[row].ItemArray[3].ToString();
                    dataGridViewTagCondition.Rows[row].Cells["ConditionID"].Value = TagConditionTable.Rows[row].ItemArray[5].ToString();
                    dataGridViewTagCondition.Rows[row].Cells["CompareTo"].Value = TagConditionTable.Rows[row].ItemArray[6].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FillMessagebox()
        {
            string message = RealTimeTag_in_RealTimeGroup.Rows[SelectedRowIndexdataGridViewRealTimeTag].ItemArray[11].ToString();
            if(message != null)
            {
                textBoxmessage.Text = message;
            }
            else
            {
                textBoxmessage.Text = "not set";
            }
            
        }

        public void Load_TagCondition()
        {
            try
            {
                TagConditionTable.Rows.Clear();
                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string groupselect = dataGridViewTaginRealTimeGroup.Rows[SelectedRowIndexdataGridViewRealTimeTag].Cells["TagID"].Value.ToString();
                    string queryString = "SELECT * FROM ["+DataBaseName+"].[dbo].[RealTimeTagCondition] WHERE RealTimeTagID = '"+groupselect+"'";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(TagConditionTable);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewTagCondition_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    SelectedRowIndexdataGridViewTagCondition = dataGridViewTagCondition.HitTest(e.X, e.Y).RowIndex;                   
                }
                else
                {
                    ContextMenuStrip my_menu = new ContextMenuStrip();
                    SelectedRowIndexdataGridViewTagCondition = dataGridViewTagCondition.HitTest(e.X, e.Y).RowIndex;
                    dataGridViewTagCondition.ClearSelection();                   

                    if (SelectedRowIndexdataGridViewTagCondition >= 0)
                    {
                        dataGridViewTagCondition.Rows[SelectedRowIndexdataGridViewTagCondition].Selected = true;
                        my_menu.Items.Add("Edit").Name = "Edit";
                        my_menu.Items.Add("Remove").Name = "Delete";
                    }
                    my_menu.Show(dataGridViewTagCondition, new Point(e.X, e.Y));

                    //Event menu Click
                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClickedTagCondition);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void my_menu_ItemClickedTagCondition(object sender, ToolStripItemClickedEventArgs e)
        {
            string ConditionTag_IdSelected = dataGridViewTagCondition.Rows[SelectedRowIndexdataGridViewTagCondition].Cells["ConditionID"].Value.ToString();
            
            switch (e.ClickedItem.Name.ToString())
            {
                case "Delete":
                    try
                    {

                        using (SqlConnection connection = new SqlConnection(
                       connectionString))
                        {
                            string queryString = " DELETE FROM ["+DataBaseName+"].[dbo].[RealTimeTagCondition] WHERE ID ='" + ConditionTag_IdSelected + "' ";
                            SqlCommand command = new SqlCommand(queryString, connection);
                            command.Connection.Open();
                            command.ExecuteNonQuery();

                            dataGridViewTagCondition.Rows.RemoveAt(SelectedRowIndexdataGridViewTagCondition);
                            Load_TagCondition();
                            //FilldataGridViewTagCondition();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Edit":
                    //Do Something                    
                    try
                    {
                        if(SelectedRowIndexdataGridViewRealTimeTag >= 0)
                        {
                            EditTagCondition edittag = new EditTagCondition(SelectedRowIndexdataGridViewTagCondition, SelectedRowIndexdataGridViewRealTimeTag, this, connectionString, DataBaseName);
                            edittag.Show();
                        }
                        else
                        {
                            MessageBox.Show("Select Tag Again");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        #region button start stop Group
        
        private void buttonStartGroup_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
                   connectionString))
                {

                        string queryString = "UPDATE ["+DataBaseName+"].[dbo].[RealTimeGroup] SET [Enabled] = 'True' WHERE RealTimeGroupID = '" + comboBoxRealTimeGroup.SelectedValue.ToString() + "'";
                        SqlCommand command = new SqlCommand(queryString, connection);
                        SqlDataAdapter data = new SqlDataAdapter(command);

                        command.Connection.Open();                                              
                        command.ExecuteNonQuery();
                    
                    buttonStartGroup.Enabled = false;
                    buttonStopGroup.Enabled = true;
                    MessageBox.Show("Update Done");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStopGroup_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
                   connectionString))
                {
                        string queryString = "UPDATE ["+DataBaseName+"].[dbo].[RealTimeGroup] SET [Enabled] = 'False' WHERE RealTimeGroupID = '" + comboBoxRealTimeGroup.SelectedValue.ToString() + "'";
                        SqlCommand command = new SqlCommand(queryString, connection);
                        SqlDataAdapter data = new SqlDataAdapter(command);

                        command.Connection.Open();                       
                        command.ExecuteNonQuery();
                    
                    buttonStartGroup.Enabled = true;
                    buttonStopGroup.Enabled = false;
                    MessageBox.Show("Update Done");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void buttonSaveMessage_Click(object sender, EventArgs e)
        {
            try
            {               

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string groupselect = comboBoxRealTimeGroup.SelectedValue.ToString();
                    string queryString = "UPDATE ["+DataBaseName+ "].[dbo].[RealTimeTag] SET MessageForm='"+textBoxmessage.Text.ToString()+"' WHERE RealTimeTagID='"+ dataGridViewTaginRealTimeGroup.Rows[SelectedRowIndexdataGridViewRealTimeTag].Cells["TagID"].Value.ToString() + "'"; 
                     SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Update Success", "Update ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Refresh

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData_RealTimeTag_in_RealTimeGroup();
            Fill_datagridview_Tag_in_RealTimeGroup();
        }

        #endregion

        #region Ackall

        private void buttonAckAll_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
                   connectionString))
                {
                    for (int row = 0; row < dataGridViewTaginRealTimeGroup.Rows.Count; row++)
                    {
                        bool alert;
                        Boolean.TryParse(dataGridViewTaginRealTimeGroup.Rows[row].Cells["OnAlert"].Value.ToString(),out alert);
                        bool ack;
                        Boolean.TryParse( dataGridViewTaginRealTimeGroup.Rows[row].Cells["acknowledge"].Value.ToString(),out ack);
                        if (alert  && !ack)
                        {
                            dataGridViewTaginRealTimeGroup.Rows[row].Cells["acknowledge"].Value = "true";

                            string queryString = "UPDATE [" + DataBaseName + "].[dbo].[AlertInformation] SET Acknowledge='True' WHERE RealTimeTagID='" + dataGridViewTaginRealTimeGroup.Rows[row].Cells["TagID"].Value.ToString() + "' AND RealTimeGroupID='"+ comboBoxRealTimeGroup.SelectedValue.ToString() + "'";
                            SqlCommand command = new SqlCommand(queryString, connection);
                            SqlDataAdapter data = new SqlDataAdapter(command);
                            if (row == 0)
                            {
                                command.Connection.Open();
                            }
                            command.ExecuteNonQuery();
                        }                                           

                    }
                    MessageBox.Show("Ack Success", "acknowledge");
                }
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region save Option

        private void buttonsaveoption_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
                   connectionString))
                {
                    string queryString = "UPDATE [" + DataBaseName + "].[dbo].[RealTimeGroup] SET ResendInterval='"+ textBoxresendtime.Text.ToString() + "',ResendIntervalunit='"+ comboBoxResendIntervalunit.SelectedItem.ToString() + "'"
                        + ",NonRepetitionInterval='" + textBoxNonRepetitionInterval.Text.ToString()+ "',NonRepetitionIntervalunit='"+comboBoxNonRepetitionIntervalunit.SelectedItem.ToString()+"'"
                        + ",Notifyonlyonchange='"+ checkBoxNotifyonlyonchange.Checked.ToString() + "' WHERE RealTimeGroupID='"+ comboBoxRealTimeGroup.SelectedValue.ToString() + "'"; 
                     SqlCommand command = new SqlCommand(queryString, connection); 
                     SqlDataAdapter data = new SqlDataAdapter(command);

                    command.Connection.Open();

                    command.ExecuteNonQuery();

                    MessageBox.Show("Update Option Success", "Update Option");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
