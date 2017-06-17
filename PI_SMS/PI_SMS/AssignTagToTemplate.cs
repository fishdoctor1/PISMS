using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PISDKDlg;

namespace PI_SMS
{
    public partial class AssignTagToTemplate : Form
    {
        DataTable Tag_in_TemplateTable = new DataTable();
        DataTable tableTemplate = new DataTable();
        DataTable ALLTag = new DataTable();
        DataTable TagMatchSearch = new DataTable();
        DataRow rowTableSearch;

        string connectionString = "";
        int SelectedRowIndexdataGridView;
        private static PISDKDlg.ApplicationObject AppObj = new PISDKDlg.ApplicationObject();
        TagSearch TagSearch = AppObj.TagSearch;

        PISDK.PISDK g_SDK;

        PISDKDlg.ApplicationObject g_SDKDlgAppObject; // PISDK dialog app. object 
        string DataBaseName = "";
        private readonly PISMS pisms;
        public void mydispose()
        {
            comboBoxTemplate.Dispose();
            Tag_in_TemplateTable.Dispose();
            tableTemplate.Dispose();
            ALLTag.Dispose();
            TagMatchSearch.Dispose();
            panel1.Dispose();
            panel2.Dispose();
            dataGridView1.Dispose();
            textBox1.Dispose();
            textBoxSearch.Dispose();
            textBoxTagID.Dispose();
            comboBoxTemplate.Dispose();
            buttonBack.Dispose();
            buttonDelete.Dispose();
            buttonGetValue.Dispose();
            buttonNEW.Dispose();
        }

        public AssignTagToTemplate(PISMS frompisms)
        {
            InitializeComponent();
            pisms = frompisms;
            TagMatchSearch.Columns.Add("PIServer", typeof(string));
            TagMatchSearch.Columns.Add("TagName", typeof(string));
            TagMatchSearch.Columns.Add("TagAlias", typeof(string));
            TagMatchSearch.Columns.Add("TagID", typeof(string));
            
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
            Load_ALLTag();
        }
        #region Load All Tag
        //

        //Load All Tag

        //
        private void Load_ALLTag()
        {
            try
            {
                ALLTag.Clear();
                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT TagName,TagIDAuToInc From ["+DataBaseName+"].[dbo].[Tag]";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(ALLTag);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Load Tag in Template To Table

        private void Load_TaginTemplate_To_DataTable()
        {
            try
            {
                Tag_in_TemplateTable.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT ["+DataBaseName+"].[dbo].[Tag].PIServer,["+DataBaseName+"].[dbo].[Tag].TagName,["+DataBaseName+"].[dbo].[Tag].TagAlias,["+DataBaseName+"].[dbo].[Tag].TagIDAuToInc"
+ " FROM["+DataBaseName+"].[dbo].[template_tag_relation]"
+ " JOIN NotificationTemplate ON["+DataBaseName+"].[dbo].[template_tag_relation].TemplateIDAuToInc = ["+DataBaseName+"].[dbo].[NotificationTemplate].TemplateIDAuToInc"
+ " JOIN Tag ON["+DataBaseName+"].[dbo].[template_tag_relation].TagIDAuTOInc = ["+DataBaseName+"].[dbo].[Tag].TagIDAuToInc"
+ " WHERE [NotificationTemplate].TemplateIDAuToInc = '" + comboBoxTemplate.SelectedValue.ToString() + "' ORDER BY TagName";

                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(Tag_in_TemplateTable);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region Fill ComboBox

        private void FillComboBox()
        {
            try
            {
                Tag_in_TemplateTable.Clear();
                SqlDataReader datareader;
                tableTemplate.Clear();
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

        #region Filldatagridview

        private void Filldatagridview()
        {
            dataGridView1.Rows.Clear();
            for (int row = 0; row < Tag_in_TemplateTable.Rows.Count; row++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells["Delete"].Value = false;
                dataGridView1.Rows[row].Cells["TagName"].Value = Tag_in_TemplateTable.Rows[row].ItemArray[1].ToString();
                dataGridView1.Rows[row].Cells["TagAlias"].Value = Tag_in_TemplateTable.Rows[row].ItemArray[2].ToString();
                dataGridView1.Rows[row].Cells["TagID"].Value = Tag_in_TemplateTable.Rows[row].ItemArray[3].ToString();
                dataGridView1.Rows[row].Cells["PIServer"].Value = Tag_in_TemplateTable.Rows[row].ItemArray[0].ToString();
            }

        }

        #endregion

        #region NEW

        private void buttonNEW_Click(object sender, EventArgs e)
        {
            try
            {
                AddAndCheck();               
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void AddAndCheck()
        {
            int II;
            //PISDK.PIPoint Pt;
            PISDK.PointList PtList;
            PtList = TagSearch.Show();

            
            
            string templateID = comboBoxTemplate.SelectedValue.ToString();
            object valInx = 1;
            for (II = 1; (II <= PtList.Count); II++)
            {
                int checkDuplicateTag = 0;
                int checkDuplicateTaginDatabase = 0;
                //

                // Check AllTag in TagDataBase

                //
                for (int tag_in_database = 0; tag_in_database < ALLTag.Rows.Count; tag_in_database++)
                {
                    //check Duplicate TagName in DataBase
                    if (PtList[II].Name.ToString() == ALLTag.Rows[tag_in_database].ItemArray[0].ToString())
                    {                        
                        checkDuplicateTaginDatabase = 1;
                        break;
                    }

                }
                //

                // (0) While don't have TagName in TagDataBase Then Add

                //
                if (checkDuplicateTaginDatabase == 0)
                {
                    try
                    {
                        string queryString = "INSERT INTO ["+DataBaseName+"].[dbo].[Tag] ([PIServer],[TagName]) VALUES('" + PtList.get_Item(ref valInx).Parent.Name + "','" + PtList[II].Name.ToString() + "')";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            SqlCommand command = new SqlCommand(queryString, connection);
                            SqlDataAdapter data = new SqlDataAdapter(command);
                            command.Connection.Open();
                            command.ExecuteNonQuery();

                            Load_ALLTag();
                            string queryString2 = "";
                            for (int i = 0; i < ALLTag.Rows.Count; i++)
                            {
                                if (ALLTag.Rows[i].ItemArray[0].ToString() == PtList[II].Name.ToString())
                                {
                                    queryString2 = "INSERT INTO ["+DataBaseName+"].[dbo].[Template_Tag_Relation] ([TemplateIDAuToInc],[TagIDAuToInc]) VALUES('" + templateID + "','" + ALLTag.Rows[i].ItemArray[1].ToString() + "')";
                                }
                            }

                            SqlCommand command2 = new SqlCommand(queryString2, connection);
                            command2.ExecuteNonQuery();
                            Load_TaginTemplate_To_DataTable();
                            Filldatagridview();
                            dataGridView1.Update();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                //

                // (1) While Tag inside Tag Database

                //
                else
                {
                    //

                    // (1) Check duplicate Tag in Template

                    //
                    for (int row = 0; row < dataGridView1.Rows.Count; row++)
                    {
                        string TagName_indatagridview = dataGridView1.Rows[row].Cells["TagName"].Value.ToString();

                        //check duplicate TagName
                        if (PtList[II].Name.ToString() == TagName_indatagridview)
                        {
                            MessageBox.Show("Error Tag Duplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            checkDuplicateTag = 1;
                            break;
                        }
                    }

                    //

                    // (0) if Don't have Tag in Template Then Add

                    //
                    if (checkDuplicateTag == 0)
                    {
                        //Tag_in_TemplateTable.Clear();
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string queryString = "";
                            for (int i = 0; i < ALLTag.Rows.Count; i++)
                            {
                                if (ALLTag.Rows[i].ItemArray[0].ToString() == PtList[II].Name.ToString())
                                {
                                    queryString = "INSERT INTO ["+DataBaseName+"].[dbo].[Template_Tag_Relation] ([TemplateIDAuToInc],[TagIDAuToInc]) VALUES('" + templateID + "','" + ALLTag.Rows[i].ItemArray[1].ToString() + "')";
                                }
                            }

                            SqlCommand command = new SqlCommand(queryString, connection);
                            command.Connection.Open();
                            command.ExecuteNonQuery();

                            Load_TaginTemplate_To_DataTable();
                            Filldatagridview();
                            dataGridView1.Update();
                        }
                    }//end if decide insert
                }

            }//End For loop Tag from TagSearch

        }

        #endregion

        private void comboBoxTemplateID_SelectedIndexChanged(object sender, EventArgs e)
        {
                Load_TaginTemplate_To_DataTable();
                Filldatagridview();
                buttonNEW.Visible = true;           
            
        }

        #region Delete selected

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int SumCheckBoxTrue = 0;
                int[] RowIndexDelete = new int[dataGridView1.Rows.Count]; //max index = rowDatagridview

                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    bool checkboxDel;

                    checkboxDel = Boolean.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
                    if (checkboxDel)//checkBox True
                    {
                        RowIndexDelete[SumCheckBoxTrue] = row; //Keep Index True
                        ++SumCheckBoxTrue; //Count CheckBoxDelete True

                        string Tag_IdSelected = dataGridView1.Rows[row].Cells["TagID"].Value.ToString();

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string queryString = " DELETE FROM ["+DataBaseName+"].[dbo].[Template_Tag_Relation] WHERE TagIDAuTOInc ='" + Tag_IdSelected + "' AND TemplateIDAuTOInc = '" + comboBoxTemplate.SelectedValue.ToString() + "' ";
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

                checkBoxSelectAll.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Mouse Click Edit & Delete

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
                    
                    //MessageBox.Show("right click");
                    //MessageBox.Show(SelectedRowIndexdataGridView.ToString());

                    if (SelectedRowIndexdataGridView >= 0)
                    {
                        my_menu.Items.Add("Edit").Name = "Edit";
                        my_menu.Items.Add("Remove").Name = "Delete";
                        dataGridView1.Rows[SelectedRowIndexdataGridView].Selected = true;
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
            //int position_xy_mouse_row = dataGridView1.CurrentCell.RowIndex;
            string Tag_IdSelected = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["TagID"].Value.ToString();
            switch (e.ClickedItem.Name.ToString())
            {
                case "Delete":
                    //Console.WriteLine("Delete case");
                    try
                    {                       

                        using (SqlConnection connection = new SqlConnection(
                       connectionString))
                        {
                            string queryString =" DELETE FROM ["+DataBaseName+"].[dbo].[Template_Tag_Relation] WHERE TagIDAuTOInc ='" + Tag_IdSelected + "' AND TemplateIDAuTOInc = '" + comboBoxTemplate.SelectedValue.ToString() + "' ";
                            SqlCommand command = new SqlCommand(queryString, connection);
                            command.Connection.Open();
                            command.ExecuteNonQuery();

                            dataGridView1.Rows.RemoveAt(SelectedRowIndexdataGridView);
                            Load_TaginTemplate_To_DataTable();
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
                    label2.Visible = true;
                    textBox1.Visible = true;
                    buttonUpdate.Visible = true;
                    buttonBack.Visible = true;

                    textBoxTagID.Text = Tag_IdSelected;
                    try
                    {
                        textBox1.Text = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["TagAlias"].Value.ToString();
                        textBoxSearch.Text = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["TagName"].Value.ToString();
                        
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Visible = false;
                textBox1.Visible = false;
                buttonUpdate.Visible = false;
                buttonBack.Visible = false;


                using (SqlConnection connection = new SqlConnection(
                   connectionString))
                {
                    string queryString = " UPDATE ["+DataBaseName+"].[dbo].[Tag] SET TagAlias='" + textBox1.Text.ToString() + "' WHERE TagIDAuTOInc ='" + textBoxTagID.Text.ToString() + "'";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    Load_TaginTemplate_To_DataTable();
                    Filldatagridview();
                    dataGridView1.Update();
                    textBoxSearch.Clear();
                    textBox1.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Search Tag in Template

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text;
            int strIndex = 0;
            
            TagMatchSearch.Clear();

            try
            {
                int rowIndex = 0;
                foreach (DataRow row in Tag_in_TemplateTable.Rows)
                {
                    strIndex = row.ItemArray[1].ToString().IndexOf(searchValue);

                    //

                    // if Match then add to TagMatchSearch(Table) dataSource From Tag_in_TemplateTable(Table)

                    //
                    if (strIndex >= 0)
                    {
                        //dataGridView1.ClearSelection();                        
                        //dataGridView1.Rows[rowIndex].Selected = true;
                        //dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                        //dataGridView1.Focus();

                        rowTableSearch = TagMatchSearch.NewRow();
                        rowTableSearch["PIServer"] = Tag_in_TemplateTable.Rows[rowIndex].ItemArray[0].ToString();
                        rowTableSearch["TagName"] = Tag_in_TemplateTable.Rows[rowIndex].ItemArray[1].ToString();
                        rowTableSearch["TagAlias"] = Tag_in_TemplateTable.Rows[rowIndex].ItemArray[2].ToString();
                        rowTableSearch["TagID"] = Tag_in_TemplateTable.Rows[rowIndex].ItemArray[3].ToString();
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
                dataGridView1.Rows.Clear();
                // Set a DataGrid control's DataSource to the DataView.
                for (int row = 0; row < TagMatchSearch.Rows.Count; row++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[row].Cells["Delete"].Value = false;
                    dataGridView1.Rows[row].Cells["PIServer"].Value = TagMatchSearch.Rows[row].ItemArray[0];
                    dataGridView1.Rows[row].Cells["TagName"].Value = TagMatchSearch.Rows[row].ItemArray[1];
                    dataGridView1.Rows[row].Cells["TagAlias"].Value = TagMatchSearch.Rows[row].ItemArray[2];
                    dataGridView1.Rows[row].Cells["TagID"].Value = TagMatchSearch.Rows[row].ItemArray[3];

                }//end forloop add Match Search
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion

        private void buttonBack_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox1.Visible = false;
            textBoxSearch.Clear();
            textBox1.Clear();
            buttonUpdate.Visible = false;
            buttonBack.Visible = false;
        }

        private void buttonGetValue_Click(object sender, EventArgs e)
        {

            g_SDK = new PISDK.PISDKClass();

            g_SDKDlgAppObject = new PISDKDlg.ApplicationObjectClass();

            try
            {
                PISDK.Server myServer; // server object from the name in textBox1 

                PISDK.PIPoints myPoints; // PIPoints collection of server 

                PISDK.PIPoint snapPoint; // point from the name in textBox2 

                PISDK.PIValue myValue; // snapshot value 

                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    string server = dataGridView1.Rows[row].Cells["PIServer"].Value.ToString();
                    myServer = g_SDK.Servers[server];

                    myPoints = myServer.PIPoints;

                    snapPoint = myPoints[dataGridView1.Rows[row].Cells["TagName"].Value.ToString()];

                    myValue = snapPoint.Data.Snapshot;

                    dataGridView1.Rows[row].Cells["TimeStamp"].Value = myValue.TimeStamp.LocalDate.ToString();

                    // 

                    // Check to see if we got a digital state back 

                    // 

                    if (myValue.Value.GetType().IsCOMObject)
                    {

                        PISDK.DigitalState myDigState;

                        myDigState = (PISDK.DigitalState)myValue.Value;

                        dataGridView1.Rows[row].Cells["TagValue"].Value = myDigState.Name;

                    }
                    else
                    {

                        dataGridView1.Rows[row].Cells["TagValue"].Value = myValue.Value.ToString();

                    }
                }

            }
            catch (System.Runtime.InteropServices.COMException comExc)
            {

                MessageBox.Show(comExc.Message, comExc.ErrorCode + " Error",

                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSelectAll.Checked)
            {
                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    dataGridView1.Rows[row].Cells[0].Value = true;
                }
            }
            else
            {
                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    dataGridView1.Rows[row].Cells[0].Value = false;
                }
            }

        }

    }

}
