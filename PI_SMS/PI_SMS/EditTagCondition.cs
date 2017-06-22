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
    public partial class EditTagCondition : Form
    {
        private readonly GroupPIAlarm grouppialarm;
        int rowindexdatagridview_TagInGroup, rowgridview_tagcondition;
        string connectionString = "";
        string DataBaseName;
        public EditTagCondition(int rowgridviewtagcondition,int rowindexdatagridview_TagInGroup,GroupPIAlarm fromgrouppialarm,string anotherFormconnectionstring, string DataBaseName)
        {
            InitializeComponent();
            this.DataBaseName = DataBaseName;
            grouppialarm = fromgrouppialarm;
            connectionString = anotherFormconnectionstring;
            this.rowindexdatagridview_TagInGroup = rowindexdatagridview_TagInGroup;
            rowgridview_tagcondition = rowgridviewtagcondition;
            preparedata();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string conditionid = grouppialarm.dataGridViewTagCondition.Rows[rowgridview_tagcondition].Cells["ConditionID"].Value.ToString();
                    string queryString = "UPDATE ["+DataBaseName+"].[dbo].[RealTimeTagCondition] SET [operator]='"+comboBoxoperator.SelectedItem.ToString()+"',"+
                        "[value]='"+textBoxvalue.Text.ToString()+
                        "',[TimeTrue]='"+textBoxtimetrue.Text.ToString()+"'"+
                        ",[TimeUnit]='"+comboBoxTimeUnit.SelectedItem.ToString()+"'" +
                        ",[CompareTo]='"+comboBoxCompareTo.SelectedItem.ToString()+"' " +
                        " WHERE RealTimeTagConditionID='" + conditionid+"'";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    
                    MessageBox.Show("UPDATE Success", "UPDATE",MessageBoxButtons.OK,MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1);
                    this.Close();
                    grouppialarm.Load_TagCondition();
                    grouppialarm.FilldataGridViewTagCondition();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxCompareTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxvalue.Enabled = true;
            if (comboBoxCompareTo.SelectedItem.ToString() == "Danger")
            {
                textBoxvalue.Enabled = false;
                textBoxvalue.Text = grouppialarm.dataGridViewTaginRealTimeGroup.Rows[rowindexdatagridview_TagInGroup].Cells["Danger"].Value.ToString();
            }
            else if (comboBoxCompareTo.SelectedItem.ToString() == "High")
            {
                textBoxvalue.Enabled = false;
                textBoxvalue.Text = grouppialarm.dataGridViewTaginRealTimeGroup.Rows[rowindexdatagridview_TagInGroup].Cells["High"].Value.ToString();
            }
            else if (comboBoxCompareTo.SelectedItem.ToString() == "Low")
            {
                textBoxvalue.Enabled = false;
                textBoxvalue.Text = grouppialarm.dataGridViewTaginRealTimeGroup.Rows[rowindexdatagridview_TagInGroup].Cells["Low"].Value.ToString();
            }
            else
            {
                textBoxvalue.Enabled = true;
            }
        }

        private void preparedata()
        {
            try
            {
                textBox1.Text = grouppialarm.dataGridViewTaginRealTimeGroup.Rows[rowindexdatagridview_TagInGroup].Cells["TagName"].Value.ToString();
                string tagid = grouppialarm.dataGridViewTaginRealTimeGroup.Rows[rowindexdatagridview_TagInGroup].Cells["TagID"].Value.ToString();
                comboBoxoperator.SelectedItem = grouppialarm.dataGridViewTagCondition.Rows[rowgridview_tagcondition].Cells["Operator"].Value.ToString();
                textBoxvalue.Text = grouppialarm.dataGridViewTagCondition.Rows[rowgridview_tagcondition].Cells["value"].Value.ToString();
                textBoxtimetrue.Text =  grouppialarm.dataGridViewTagCondition.Rows[rowgridview_tagcondition].Cells["TimeTrue"].Value.ToString();
                comboBoxTimeUnit.SelectedItem = grouppialarm.dataGridViewTagCondition.Rows[rowgridview_tagcondition].Cells["TimeUnit"].Value.ToString();
                comboBoxCompareTo.SelectedItem = grouppialarm.dataGridViewTagCondition.Rows[rowgridview_tagcondition].Cells["CompareTo"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }

    }
}
