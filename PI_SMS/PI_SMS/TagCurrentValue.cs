using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PISDKDlg;
using System.Data.SqlClient;
using System.Threading;

namespace PI_SMS
{
    public partial class TagCurrentValue : Form
    {
        PISDK.PISDK g_SDK;

        PISDKDlg.ApplicationObject g_SDKDlgAppObject; // PISDK dialog app. object 
        DataTable TagNameTable = new DataTable();
        DataTable TagMatchSearch = new DataTable();
        string connectionString = "";
        string DataBaseName = "";
        private readonly PISMS pisms;
        public TagCurrentValue(PISMS frompisms)
        {
            InitializeComponent();
            pisms = frompisms;
            InitialDataTableForSearch();
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

            DateTime.Now.ToString("yyyyMMddHHmmss");
            LoadTag();
            Filldatagridview();
        }

        private void LoadTag()
        {
            try
            {
                TagNameTable.Clear();

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT * FROM ["+DataBaseName+"].[dbo].[Tag] ORDER BY TagName";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(TagNameTable);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region FilldataGrid

        private void Filldatagridview()
        {
            try
            {
                dataGridView1.Rows.Clear();
                for (int row = 0; row < TagNameTable.Rows.Count; row++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[row].Cells["TagName"].Value = TagNameTable.Rows[row].ItemArray[0];
                    dataGridView1.Rows[row].Cells["Server"].Value = TagNameTable.Rows[row].ItemArray[3];                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion 

        private void buttonGetValue_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Visible = true;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 110;
                progressBar1.Value = 0;
                progressBar1.Update();
                PISDK.Server myServer; // server object from the name in textBox1 

                PISDK.PIPoints myPoints; // PIPoints collection of server 

                PISDK.PIPoint snapPoint; // point from the name in textBox2 

                PISDK.PIValue myValue; // snapshot value 
                
                for(int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    progressBar1.Value = 10+((row*100) / dataGridView1.Rows.Count);
                    progressBar1.Update();
                    Thread.Sleep(100);
                    string server = dataGridView1.Rows[row].Cells["Server"].Value.ToString();
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

                        dataGridView1.Rows[row].Cells["Value"].Value = myDigState.Name;

                    }
                    else
                    {

                        dataGridView1.Rows[row].Cells["Value"].Value = myValue.Value.ToString();

                    }
                    
                    
                    
                }
                progressBar1.Visible = false;

            }
            catch (System.Runtime.InteropServices.COMException comExc)
            {

                MessageBox.Show(comExc.Message, comExc.ErrorCode + " Error",

                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
            column.ColumnName = "PIServer";
            TagMatchSearch.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "TagName";
            TagMatchSearch.Columns.Add(column);

            column.Dispose();
        }

        #endregion

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            int strIndex = 0;
            DataRow rowTableSearch;
            TagMatchSearch.Clear();

            try
            {
                int rowIndex = 0;
                foreach (DataRow row in TagNameTable.Rows)
                {
                    strIndex = row.ItemArray[0].ToString().IndexOf(searchValue);
                    if (strIndex >= 0)
                    {
                        //dataGridView1.ClearSelection();                        
                        //dataGridView1.Rows[rowIndex].Selected = true;
                        //dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                        //dataGridView1.Focus();

                        rowTableSearch = TagMatchSearch.NewRow();
                        rowTableSearch["PIServer"] = TagNameTable.Rows[rowIndex].ItemArray[3].ToString();
                        rowTableSearch["TagName"] = TagNameTable.Rows[rowIndex].ItemArray[0].ToString();

                        TagMatchSearch.Rows.Add(rowTableSearch);
                    }
                    rowIndex++;

                }
                dataGridView1.Rows.Clear();
                // Set a DataGrid control's DataSource to the DataView.
                for (int row = 0; row < TagMatchSearch.Rows.Count; row++)
                {
                    dataGridView1.Rows.Add();

                    dataGridView1.Rows[row].Cells["Server"].Value = TagMatchSearch.Rows[row].ItemArray[0];
                    dataGridView1.Rows[row].Cells["TagName"].Value = TagMatchSearch.Rows[row].ItemArray[1];
                }//end forloop add Match Search
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void TagCurrentValue_Load(object sender, EventArgs e)
        {
            try
            {

                g_SDK = new PISDK.PISDKClass();

                g_SDKDlgAppObject = new PISDKDlg.ApplicationObjectClass();

            }
            catch (System.Runtime.InteropServices.COMException comExc)
            {

                MessageBox.Show(comExc.Message, comExc.ErrorCode + " Error",

                MessageBoxButtons.OK,

                MessageBoxIcon.Exclamation);

            }
        }
    }
}
