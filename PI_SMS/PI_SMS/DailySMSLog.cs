using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PI_SMS
{
    public partial class DailySMSLog : Form
    {
        DataTable RowMatchSearch = new DataTable();
        DataTable importdatatableReadonly = new DataTable();
        bool startprogram = true;
        string path = AppDomain.CurrentDomain.BaseDirectory + "\\SendLog\\"+ DateTime.Now.ToString("yyyy-MM-dd") + ".csv";

        private readonly PISMS pisms;
        public DailySMSLog(PISMS frompisms)
        {
            InitializeComponent();
            pisms = frompisms;
            InitialDataTableForSearch();
            getlog(path);
        }

        private void getlog(string path)
        {
            try
            {
                //string filenameWithoutExtension = Path.GetFileNameWithoutExtension(path);//get filenameWithout type

                string dateselect = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd") + ".csv";
                string pathsearch = AppDomain.CurrentDomain.BaseDirectory + "SendLog\\";
                
                //Console.WriteLine("The number of files starting with c is {0}.", dirs.Length);
                if (!Directory.Exists(pathsearch))
                {
                    Directory.CreateDirectory(pathsearch);
                }

                string[] dirs = Directory.GetFiles(pathsearch, dateselect);
                importdatatableReadonly.Clear();
                dataGridView1.Rows.Clear();

                if (dirs.Length == 0)
                {
                    dataGridView1.Rows.Clear();
                }

                foreach (string path2 in dirs)
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string[] headers = sr.ReadLine().Split(',');
                        if (startprogram)
                        {
                            foreach (string header in headers)
                            {
                                importdatatableReadonly.Columns.Add(header);
                            }
                            startprogram = false;
                        }
                        while (!sr.EndOfStream)
                        {
                            string[] rows = sr.ReadLine().Split(',');
                            DataRow drReadonly = importdatatableReadonly.NewRow();
                            DataRow dr = importdatatableReadonly.NewRow();
                            for (int i = 0; i < headers.Length; i++)
                            {
                                drReadonly[i] = rows[i];
                            }
                            importdatatableReadonly.Rows.Add(drReadonly);

                        }

                    }

                    for (int row = 0; row < importdatatableReadonly.Rows.Count; row++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[row].Cells["Time"].Value = importdatatableReadonly.Rows[row].ItemArray[0].ToString();
                        dataGridView1.Rows[row].Cells["UserID"].Value = importdatatableReadonly.Rows[row].ItemArray[1].ToString();
                        dataGridView1.Rows[row].Cells["CellPhone"].Value = importdatatableReadonly.Rows[row].ItemArray[2].ToString();
                        dataGridView1.Rows[row].Cells["Message"].Value = importdatatableReadonly.Rows[row].ItemArray[3].ToString();
                        dataGridView1.Rows[row].Cells["Status"].Value = importdatatableReadonly.Rows[row].ItemArray[4].ToString();
                    }
                }

                    
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            int strIndex = 0;
            DataRow rowTableSearch;
            RowMatchSearch.Clear();

            try
            {
                int rowIndex = 0;
                foreach (DataRow row in importdatatableReadonly.Rows)
                {

                    if (checkBoxStatusFalse.Checked)
                    {
                        strIndex = row.ItemArray[4].ToString().IndexOf(searchValue);
                    }
                    else if (checkBoxPhone.Checked)
                    {
                        strIndex = row.ItemArray[2].ToString().IndexOf(searchValue);
                    }
                    else if (checkBoxUserID.Checked)
                    {
                        strIndex = row.ItemArray[1].ToString().IndexOf(searchValue);
                    }
                    if (strIndex >= 0)
                    {

                        rowTableSearch = RowMatchSearch.NewRow();
                        rowTableSearch["UserID"] = importdatatableReadonly.Rows[rowIndex].ItemArray[1].ToString();
                        rowTableSearch["Time"] = importdatatableReadonly.Rows[rowIndex].ItemArray[0].ToString();
                        rowTableSearch["CellPhone"] = importdatatableReadonly.Rows[rowIndex].ItemArray[2].ToString();
                        rowTableSearch["Message"] = importdatatableReadonly.Rows[rowIndex].ItemArray[3].ToString();
                        rowTableSearch["Status"] = importdatatableReadonly.Rows[rowIndex].ItemArray[4].ToString();                   
                        RowMatchSearch.Rows.Add(rowTableSearch);
                    }
                    rowIndex++;

                }
                dataGridView1.Rows.Clear();
                // Set a DataGrid control's DataSource to the DataView.
                for (int row = 0; row < RowMatchSearch.Rows.Count; row++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[row].Cells["No"].Value = row + 1;
                    dataGridView1.Rows[row].Cells["UserID"].Value = RowMatchSearch.Rows[row].ItemArray[1];
                    dataGridView1.Rows[row].Cells["Time"].Value = RowMatchSearch.Rows[row].ItemArray[0];
                    dataGridView1.Rows[row].Cells["CellPhone"].Value = RowMatchSearch.Rows[row].ItemArray[2];
                    dataGridView1.Rows[row].Cells["Message"].Value = RowMatchSearch.Rows[row].ItemArray[3];
                    dataGridView1.Rows[row].Cells["Status"].Value = RowMatchSearch.Rows[row].ItemArray[4];
                    
                }//end forloop add Match Search
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            column.ColumnName = "Time";
            RowMatchSearch.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "UserID";
            RowMatchSearch.Columns.Add(column);

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "CellPhone";
            RowMatchSearch.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Message";
            RowMatchSearch.Columns.Add(column);

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Status";
            RowMatchSearch.Columns.Add(column);

            column.Dispose();
        }

        #endregion

        #region checkbox checkedchange

        private void checkBoxUserID_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUserID.Checked)
            {
                buttonsearch.Enabled = true;                
                checkBoxPhone.Checked = false;
                checkBoxStatusFalse.Checked = false;
                checkBoxStatusSuccess.Checked = false;
            }
            else
            {
                //buttonsearch.Enabled = false;
            }
        }


        private void checkBoxPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPhone.Checked)
            {
                buttonsearch.Enabled = true;
                checkBoxUserID.Checked = false;
                //checkBoxDAY.Enabled = false;
                checkBoxStatusFalse.Checked = false;
                checkBoxStatusSuccess.Checked = false;
            }
            else
            {
                //buttonsearch.Enabled = false;
            }
        }

        private void checkBoxStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStatusFalse.Checked)
            {
                textBox1.Text = "False";
                buttonsearch.Enabled = true;
                checkBoxUserID.Checked = false;

                checkBoxPhone.Checked = false;
                checkBoxStatusSuccess.Checked = false;
            }
            else
            {
                textBox1.Clear();
                //buttonsearch.Enabled = false;

            }
        }

        private void checkBoxStatusSuccess_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStatusSuccess.Checked)
            {
                textBox1.Text = "True";
                buttonsearch.Enabled = true;
                checkBoxUserID.Checked = false;

                checkBoxPhone.Checked = false;
                checkBoxStatusFalse.Checked = false;
            }
            else
            {
                textBox1.Clear();
                //buttonsearch.Enabled = false;

            }
            

        }

        #endregion

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string dateselect = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd")+".csv";
            string pathsearch = AppDomain.CurrentDomain.BaseDirectory + "SendLog\\";
            try
            {
                if (radioButtonPeriod.Checked)
                {
                    Log_duration();
                }
                else
                {
                    // Only get files that begin with the letter "c."
                    string[] dirs = Directory.GetFiles(pathsearch, dateselect);

                    //Console.WriteLine("The number of files starting with c is {0}.", dirs.Length);
                    if (dirs.Length == 0)
                    {
                        dataGridView1.Rows.Clear();
                    }

                    foreach (string path2 in dirs)
                    {
                        importdatatableReadonly.Clear();

                        using (StreamReader sr = new StreamReader(path2))
                        {
                            string[] headers = sr.ReadLine().Split(',');
                            if (importdatatableReadonly.Columns.Count == 0)
                            {
                                foreach (string header in headers)
                                {
                                    importdatatableReadonly.Columns.Add(header);

                                }
                            }
                                
                            while (!sr.EndOfStream)
                            {
                                string[] rows = sr.ReadLine().Split(',');
                                DataRow drReadonly = importdatatableReadonly.NewRow();
                                DataRow dr = importdatatableReadonly.NewRow();
                                for (int i = 0; i < headers.Length; i++)
                                {
                                    drReadonly[i] = rows[i];

                                }
                                importdatatableReadonly.Rows.Add(drReadonly);

                            }

                        }
                        dataGridView1.Rows.Clear();
                        for (int row = 0; row < importdatatableReadonly.Rows.Count; row++)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[row].Cells["No"].Value = row + 1;
                            dataGridView1.Rows[row].Cells["Time"].Value = importdatatableReadonly.Rows[row].ItemArray[0].ToString();
                            dataGridView1.Rows[row].Cells["UserID"].Value = importdatatableReadonly.Rows[row].ItemArray[1].ToString();
                            dataGridView1.Rows[row].Cells["CellPhone"].Value = importdatatableReadonly.Rows[row].ItemArray[2].ToString();
                            dataGridView1.Rows[row].Cells["Message"].Value = importdatatableReadonly.Rows[row].ItemArray[3].ToString();
                            dataGridView1.Rows[row].Cells["Status"].Value = importdatatableReadonly.Rows[row].ItemArray[4].ToString();
                        }
                    }

                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
            }


        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                Log_duration();
            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
            }

        }

        private void Log_duration()
        {
            string dateselect = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd");
            string dateselect2 = monthCalendar2.SelectionEnd.ToString("yyyy-MM-dd");
            DateTime dt1 = DateTime.Parse(dateselect);
            DateTime dt2 = DateTime.Parse(dateselect2);
            int result = DateTime.Compare(dt1, dt2);
            string pathsearch = AppDomain.CurrentDomain.BaseDirectory + "SendLog\\";

            dataGridView1.Rows.Clear();
            importdatatableReadonly.Clear();
            string searchfile = "";
            try
            {
                if (result > 0)//left calendar dayfuture on right calendar
                {
                    MessageBox.Show("Date incorrect");
                }
                while (result <= 0)//compare result < 0 if left calendar day past on right calendar
                {
                    searchfile = dt1.ToString("yyyy-MM-dd") + ".csv";
                    string[] dirs = Directory.GetFiles(pathsearch, searchfile);

                    foreach (string path2 in dirs)
                    {
                        using (StreamReader sr = new StreamReader(path2))
                        {
                            string[] headers = sr.ReadLine().Split(',');
                            //foreach (string header in headers)
                            //{
                            //    importdatatableReadonly.Columns.Add(header);
                            //}
                            while (!sr.EndOfStream)
                            {
                                string[] rows = sr.ReadLine().Split(',');
                                DataRow drReadonly = importdatatableReadonly.NewRow();
                                DataRow dr = importdatatableReadonly.NewRow();
                                for (int i = 0; i < headers.Length; i++)
                                {
                                    drReadonly[i] = rows[i];

                                }
                                importdatatableReadonly.Rows.Add(drReadonly);
                            }
                        }
                    }
                    dt1 = dt1.AddDays(1);
                    result = DateTime.Compare(dt1, dt2);
                }

                for (int row = 0; row < importdatatableReadonly.Rows.Count; row++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[row].Cells["No"].Value = row+1;
                    dataGridView1.Rows[row].Cells["Time"].Value = importdatatableReadonly.Rows[row].ItemArray[0].ToString();
                    dataGridView1.Rows[row].Cells["UserID"].Value = importdatatableReadonly.Rows[row].ItemArray[1].ToString();
                    dataGridView1.Rows[row].Cells["CellPhone"].Value = importdatatableReadonly.Rows[row].ItemArray[2].ToString();
                    dataGridView1.Rows[row].Cells["Message"].Value = importdatatableReadonly.Rows[row].ItemArray[3].ToString();
                    dataGridView1.Rows[row].Cells["Status"].Value = importdatatableReadonly.Rows[row].ItemArray[4].ToString();
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
            }
        }

        private void radioButtonSingleDay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSingleDay.Checked)
            {
                monthCalendar2.Visible = false;
                radioButtonPeriod.Checked = false;
            }          

        }

        private void radioButtonPeriod_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPeriod.Checked)
            {
                monthCalendar2.Visible = true;
                radioButtonSingleDay.Checked = false;
            }
        }

        public void mydispose()
        {
            tableLayoutPanel1.Dispose();
            RowMatchSearch.Dispose();
            importdatatableReadonly.Dispose();
            dataGridView1.Dispose();
        }
    }
}
