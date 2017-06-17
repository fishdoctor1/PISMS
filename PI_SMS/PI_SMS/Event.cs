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
    public partial class Event : Form
    {
        DataTable TemplateName_data = new DataTable();
        DataTable Event_data = new DataTable();
        string connectionString = "";
        int SelectedRowIndexdataGridView;
        string DataBaseName = "";

        private readonly PISMS pisms;
        public Event(PISMS frompisms)
        {
            InitializeComponent();
            pisms = frompisms;
            //PISMS pisms = new PISMS();
            string IP = pisms.Pub_Config.Rows[0].ItemArray[0].ToString();
            DataBaseName = pisms.Pub_Config.Rows[0].ItemArray[2].ToString();
            string UserID = pisms.Pub_Config.Rows[0].ItemArray[3].ToString();
            string Password = pisms.Pub_Config.Rows[0].ItemArray[4].ToString();
            connectionString = "Data Source = " + IP + "; Initial Catalog =" + DataBaseName + "; User ID =" + UserID + "; Password =" + Password;

            comboBoxHour.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMin.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadDataToTable_Event_data();
            for(int i = 0; i < Event_data.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
            }
            Filldatagridview();
        }

        #region LoadEvent

        private void LoadDataToTable_Event_data()
        {
            try
            {
               Event_data.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT * FROM ["+DataBaseName+"].[dbo].[Event] ORDER BY EventName";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(Event_data);
                    
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
                for (int row = 0; row < Event_data.Rows.Count; row++)
                {
                    dataGridView1.Rows[row].Cells["EventCol"].Value = Event_data.Rows[row].ItemArray[0];
                    dataGridView1.Rows[row].Cells["Mon"].Value = Event_data.Rows[row].ItemArray[1];
                    dataGridView1.Rows[row].Cells["Tue"].Value = Event_data.Rows[row].ItemArray[2];
                    dataGridView1.Rows[row].Cells["Wed"].Value = Event_data.Rows[row].ItemArray[3];
                    dataGridView1.Rows[row].Cells["Thu"].Value = Event_data.Rows[row].ItemArray[4];
                    dataGridView1.Rows[row].Cells["Fri"].Value = Event_data.Rows[row].ItemArray[5];
                    dataGridView1.Rows[row].Cells["Sat"].Value = Event_data.Rows[row].ItemArray[6];
                    dataGridView1.Rows[row].Cells["Sun"].Value = Event_data.Rows[row].ItemArray[7];
                    dataGridView1.Rows[row].Cells["Time"].Value = Event_data.Rows[row].ItemArray[8];
                    dataGridView1.Rows[row].Cells["EventID"].Value = Event_data.Rows[row].ItemArray[9];
                    dataGridView1.Rows[row].Cells["Repeat"].Value = Event_data.Rows[row].ItemArray[10];
                    dataGridView1.Rows[row].Cells["RepeatTime"].Value = Event_data.Rows[row].ItemArray[11]; 
                    dataGridView1.Rows[row].Cells["RepeatTimeUnit"].Value = Event_data.Rows[row].ItemArray[12];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion       

        #region NEW Button

        private void buttonNEWEvent_Click(object sender, EventArgs e)
        {
            comboBoxMin.SelectedIndex = 0;
            comboBoxHour.SelectedIndex = 0;
            comboBoxTimeRepeatUnit.SelectedIndex = 0;
            label4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            comboBoxHour.Visible = true;
            comboBoxMin.Visible = true;
            checkBoxSun.Visible = true;
            checkBoxMon.Visible = true;
            checkBoxTue.Visible = true;
            checkBoxWed.Visible = true;
            checkBoxThu.Visible = true;
            checkBoxFri.Visible = true;
            checkBoxSat.Visible = true;
            buttonadd.Visible = true;
            buttonCancel.Visible = true;
            buttonNEWEvent.Visible = false;
            label1.Visible = true;
            textBoxtimeRepeat.Visible = true;
            checkBox1.Visible = true;
            comboBoxTimeRepeatUnit.Visible = true;
        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Cancel

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonNEWEvent.Visible = true;
            label4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            buttonUpdate.Visible = false;
            textBox1.Visible = false;
            //comboBoxEvent.Visible = false;
            comboBoxHour.Visible = false;
            comboBoxMin.Visible = false;
            checkBoxSun.Visible = false;
            checkBoxSun.Checked = false;
            checkBoxMon.Visible = false;
            checkBoxMon.Checked = false;
            checkBoxTue.Visible = false;
            checkBoxTue.Checked = false;
            checkBoxWed.Visible = false;
            checkBoxWed.Checked = false;
            checkBoxThu.Visible = false;
            checkBoxThu.Checked = false;
            checkBoxFri.Visible = false;
            checkBoxFri.Checked = false;
            checkBoxSat.Visible = false;
            checkBoxSat.Checked = false;
            buttonadd.Visible = false;
            buttonCancel.Visible = false;
            label1.Visible = false;
            textBoxtimeRepeat.Visible = false;
            checkBox1.Visible = false;
            comboBoxTimeRepeatUnit.Visible = false;
        }
        #endregion

        #region datagrid mouse click

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
                        dataGridView1.Rows[SelectedRowIndexdataGridView].Selected = true;
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

            switch (e.ClickedItem.Name.ToString())
            {
                case "Delete":
                    try
                    {                       
                        using (SqlConnection connection = new SqlConnection(
                       connectionString))
                        {
                            //int mouse_row = dataGridView1.CurrentRow.Index;
                            string Event_Selected = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["EventCol"].Value.ToString();
                            string EventID_Selected = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["EventID"].Value.ToString();

                            string queryString2 = " DELETE FROM ["+DataBaseName+"].[dbo].[Template_Event_RelationTable] WHERE EventID ='" + EventID_Selected + "'";
                            SqlCommand command2 = new SqlCommand(queryString2, connection);
                            command2.Connection.Open();
                            command2.ExecuteNonQuery();
                            string queryString = " DELETE FROM ["+DataBaseName+"].[dbo].[Event] WHERE EventID ='" + EventID_Selected + "'";
                            SqlCommand command = new SqlCommand(queryString, connection);
                            command.ExecuteNonQuery();
                            dataGridView1.Rows.RemoveAt(SelectedRowIndexdataGridView);
                            LoadDataToTable_Event_data();
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

                    buttonUpdate.Visible = true;
                    try
                    {
                        //int mouse_row = dataGridView1;
                        textBox1.Text = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["EventCol"].Value.ToString();
                        string checkbox_statusSun = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells[1].Value.ToString();
                        string checkbox_statusMon = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells[2].Value.ToString();
                        string checkbox_statusTue = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells[3].Value.ToString();
                        string checkbox_statusWed = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells[4].Value.ToString();
                        string checkbox_statusThu = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells[5].Value.ToString();
                        string checkbox_statusFri = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells[6].Value.ToString();
                        string checkbox_statusSat = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells[7].Value.ToString();
                        string StringTime = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells[8].Value.ToString();
                        string[] Timevalues = StringTime.Split(':');
                        textBoxtimeRepeat.Text = dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["RepeatTime"].Value.ToString();
                        comboBoxHour.SelectedIndex = comboBoxHour.FindString(Timevalues[0]);
                        comboBoxMin.SelectedIndex = comboBoxMin.FindString(Timevalues[1]);
                        comboBoxTimeRepeatUnit.SelectedIndex = comboBoxTimeRepeatUnit.FindString(dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["RepeatTimeUnit"].Value.ToString());
                        if (checkbox_statusSun == "True")
                        {
                            checkBoxSun.Checked = true;
                        }
                        if (checkbox_statusMon == "True")
                        {
                            checkBoxMon.Checked = true;
                        }
                        if (checkbox_statusTue == "True")
                        {
                            checkBoxTue.Checked = true;
                        }
                        if (checkbox_statusWed == "True")
                        {
                            checkBoxWed.Checked = true;
                        }
                        if (checkbox_statusThu == "True")
                        {
                            checkBoxThu.Checked = true;
                        }
                        if (checkbox_statusFri == "True")
                        {
                            checkBoxFri.Checked = true;
                        }
                        if (checkbox_statusSat == "True")
                        {
                            checkBoxSat.Checked = true;
                        }
                        textBox1.Visible = true;
                        label4.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;

                        label1.Visible = true;
                        textBoxtimeRepeat.Visible = true;
                        checkBox1.Visible = true;
                        comboBoxTimeRepeatUnit.Visible = true;

                        comboBoxHour.Visible = true;
                        comboBoxMin.Visible = true;
                        checkBoxSun.Visible = true;
                        checkBoxMon.Visible = true;
                        checkBoxTue.Visible = true;
                        checkBoxWed.Visible = true;
                        checkBoxThu.Visible = true;
                        checkBoxFri.Visible = true;
                        checkBoxSat.Visible = true;
                        buttonadd.Visible = false;
                        buttonCancel.Visible = true;
                        //comboBoxEvent.SelectedIndex = comboBoxEvent.FindString(dataGridView1.Rows[mouse_row].Cells[0].Value.ToString());
                        textBox1.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    
                    break;
            }
        }

        #endregion

        #region Update Click

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //int rowindex = dataGridView1.CurrentCell.RowIndex;
                //string TemplateSelected = dataGridView1.Rows[rowindex].Cells["TemplateID"].Value.ToString();
                string Event = textBox1.Text;
                string mon = checkBoxMon.Checked.ToString();
                string tue = checkBoxTue.Checked.ToString();
                string wed = checkBoxWed.Checked.ToString();
                string thu = checkBoxThu.Checked.ToString();
                string fri = checkBoxFri.Checked.ToString();
                string sat = checkBoxSat.Checked.ToString();
                string sun = checkBoxSun.Checked.ToString();
                string timeHH = comboBoxHour.SelectedItem.ToString();
                string timeMM = comboBoxMin.SelectedItem.ToString();
                string Timeconcat = timeHH + ":" + timeMM;
                Event_data.Clear();
                int checksameTemplate = 0;

                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    if (row == SelectedRowIndexdataGridView)
                    {
                        continue;
                    }
                    string Event_Ondatagridview = dataGridView1.Rows[row].Cells["EventCol"].Value.ToString();
                    //check same Template
                    if (Event == Event_Ondatagridview)
                    {
                        MessageBox.Show("Error EventName used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        checksameTemplate = 1;
                        break;
                    }
                }
                if (checksameTemplate == 0)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string queryString = "UPDATE [" + DataBaseName + "].[dbo].[Event] " +
                            "SET Monday='" + mon
                            + "',EventName='" + Event
                            + "',Tuesday='" + tue
                            + "',Wednesday='" + wed
                            + "',Thursday='" + thu
                            + "',Friday='" + fri
                            + "',Saturday='" + sat
                            + "',Sunday='" + sun
                            + "',Time='" + Timeconcat
                            + "',Repeat='" + checkBox1.Checked.ToString()
                            + "',RepeatTime='" + textBoxtimeRepeat.Text.ToString()
                            + "',RepeatTimeUnit='" + comboBoxTimeRepeatUnit.SelectedItem.ToString()
                            + "' WHERE EventID='" + dataGridView1.Rows[SelectedRowIndexdataGridView].Cells["EventID"].Value.ToString() + "'";
                        SqlCommand command = new SqlCommand(queryString, connection); ;
                        command.Connection.Open();
                        command.ExecuteNonQuery();

                        LoadDataToTable_Event_data();
                        Filldatagridview();
                        dataGridView1.Update();

                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        buttonUpdate.Visible = false;
                        textBox1.Visible = false;
                        textBoxtimeRepeat.Visible = false;
                        checkBox1.Visible = false;
                        comboBoxTimeRepeatUnit.Visible = false;
                        comboBoxHour.Visible = false;
                        comboBoxMin.Visible = false;
                        checkBoxSun.Visible = false;
                        checkBoxSun.Checked = false;
                        checkBoxMon.Visible = false;
                        checkBoxMon.Checked = false;
                        checkBoxTue.Visible = false;
                        checkBoxTue.Checked = false;
                        checkBoxWed.Visible = false;
                        checkBoxWed.Checked = false;
                        checkBoxThu.Visible = false;
                        checkBoxThu.Checked = false;
                        checkBoxFri.Visible = false;
                        checkBoxFri.Checked = false;
                        checkBoxSat.Visible = false;
                        checkBoxSat.Checked = false;
                        buttonadd.Visible = false;
                        buttonCancel.Visible = false;
                        buttonNEWEvent.Visible = true;
                    }
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region SAVE

        private void buttonadd_Click(object sender, EventArgs e)
        {
            try
            {
                                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    int checkDuplicateEvent = 0;
                    for (int row = 0; row < Event_data.Rows.Count; row++)
                    {
                        string Event_Ondatagridview = dataGridView1.Rows[row].Cells["EventCol"].Value.ToString();
                        //check same Event
                        if (textBox1.Text.ToString() == Event_Ondatagridview)
                        {
                            MessageBox.Show("Error Event duplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            checkDuplicateEvent = 1;
                            break;
                        }
                    }

                    if (checkDuplicateEvent == 0)
                    {
                        Event_data.Clear();
                        string TimeHour = comboBoxHour.SelectedItem.ToString();
                        string TimeMin = comboBoxMin.SelectedItem.ToString();
                        string Time = TimeHour + ":" + TimeMin;
                        string queryString = "INSERT INTO ["+DataBaseName+"].[dbo].[Event] ([EventName],[Monday],[Tuesday],[Wednesday],[Thursday],[Friday],[Time],[Sunday],[Saturday],[Repeat],[RepeatTime],[RepeatTimeUnit])VALUES('"
                            + textBox1.Text.ToString() + "','"
                            + checkBoxMon.Checked +"','"
                            + checkBoxTue.Checked + "','"
                            + checkBoxWed.Checked + "','"
                            + checkBoxThu.Checked + "','"
                            + checkBoxFri.Checked + "','"
                            + Time + "','"
                            + checkBoxSun.Checked + "','"
                            + checkBoxSat.Checked + "','"
                            + checkBox1.Checked.ToString()+"','"
                            + textBoxtimeRepeat.Text.ToString()+"','"
                            + comboBoxTimeRepeatUnit.SelectedItem.ToString()+"')";

                        SqlCommand command = new SqlCommand(queryString, connection);
                        command.Connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Rows.Add();
                        LoadDataToTable_Event_data();
                        Filldatagridview();
                        dataGridView1.Update();
                    }//end if decide insert

                }//end using
                buttonNEWEvent.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        #endregion

        private void comboBoxEvent_SelectedValueChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(comboBoxEvent.SelectedItem.ToString());
        }

        #region Selected Change

        private void comboBoxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDataToTable_Event_data();               
                dataGridView1.Rows.Clear();
                for (int row = 0; row < Event_data.Rows.Count; row++)
                {
                    dataGridView1.Rows.Add();
                }
                Filldatagridview();
                buttonNEWEvent.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        public void mydispose()
        {
            TemplateName_data.Dispose();
            Event_data.Dispose();
            panel1.Dispose();
            panel2.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxtimeRepeat.Enabled = true;
                comboBoxTimeRepeatUnit.Enabled = true;
            }
            else
            {
                textBoxtimeRepeat.Enabled = false;
                comboBoxTimeRepeatUnit.Enabled = false;
            }
        }
    }
}
