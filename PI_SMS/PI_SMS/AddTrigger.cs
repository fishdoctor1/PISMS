﻿using System;
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
    public partial class AddTrigger : Form
    {
        private readonly GroupPIAlarm grouppialarm;
        int SelectedRowIndexdataGridViewRealTimeTag;
        string connectionString="";
        string DataBaseName;
        public AddTrigger(string connectionString, int SelectedRowIndexdataGridViewRealTimeTag, GroupPIAlarm grouppialarm, string DataBaseName)
        {
            InitializeComponent();
            this.DataBaseName = DataBaseName;
            this.SelectedRowIndexdataGridViewRealTimeTag = SelectedRowIndexdataGridViewRealTimeTag;
            this.grouppialarm = grouppialarm;
            this.connectionString = connectionString;
            preparedata();
        }

        private void preparedata()
        {
            textBoxTagname.Text = grouppialarm.dataGridViewTaginRealTimeGroup.Rows[SelectedRowIndexdataGridViewRealTimeTag].Cells["TagName"].Value.ToString();

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            try
            {
                string tagid = grouppialarm.dataGridViewTaginRealTimeGroup.Rows[SelectedRowIndexdataGridViewRealTimeTag].Cells["TagID"].Value.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string queryString = "INSERT INTO ["+DataBaseName+"].[dbo].[RealTimeTagCondition] ([operator],[value],[TimeTrue],[TimeUnit],[RealTimeTagID]) VALUES('" + comboBoxoperator.SelectedItem.ToString()+"','"+textBoxvalue.Text.ToString()+"','"+textBoxtime.Text.ToString()+"','"+comboBoxunittime.SelectedItem.ToString()+ "','"+tagid+"')";
                    
                    
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    grouppialarm.FilldataGridViewTagCondition();
                    MessageBox.Show("OK!!", "Success",MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    this.Close();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
