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
    public partial class EditRealTimeTag : Form
    {
        string connectionString, DataBaseName;
        int SelectedRowIndexdataGridViewRealTimeTag;
        private readonly GroupPIAlarm grouppi;
        public EditRealTimeTag(string connectionString, int SelectedRowIndexdataGridViewRealTimeTag, GroupPIAlarm formgrouppi,string DataBaseName)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.DataBaseName = DataBaseName;
            this.SelectedRowIndexdataGridViewRealTimeTag = SelectedRowIndexdataGridViewRealTimeTag;
            this.grouppi = formgrouppi;
            prepare();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
                       connectionString))
                {
                    string queryString = "UPDATE [PISMS].[dbo].[RealTimeTag] SET Danger='" + textBoxhihi.Text.ToString() + "'," +
                        "High='" + textBoxhi.Text.ToString() + "'," + 
                        "Low='"+ textBoxlo.Text.ToString() + "',"+
                        "Mail='"+ checkBoxmail.Checked.ToString() + "',"+
                        "Phone='"+checkBoxphone.Checked.ToString()+"',"+
                        "Enabled='"+ checkBoxenable.Checked.ToString() + "' "+
                        "WHERE TagName ='"+ textBoxTagname.Text.ToString() + "'";   
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    grouppi.LoadData_RealTimeTag_in_RealTimeGroup();
                    grouppi.Fill_datagridview_Tag_in_RealTimeGroup();
                    MessageBox.Show("Update Success", "Update ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void prepare()
        {
            textBoxTagname.Text = grouppi.dataGridViewTaginRealTimeGroup.Rows[SelectedRowIndexdataGridViewRealTimeTag].Cells["TagName"].Value.ToString();
            textBoxhihi.Text = grouppi.dataGridViewTaginRealTimeGroup.Rows[SelectedRowIndexdataGridViewRealTimeTag].Cells["Danger"].Value.ToString();
            textBoxhi.Text = grouppi.dataGridViewTaginRealTimeGroup.Rows[SelectedRowIndexdataGridViewRealTimeTag].Cells["High"].Value.ToString();
            textBoxlo.Text = grouppi.dataGridViewTaginRealTimeGroup.Rows[SelectedRowIndexdataGridViewRealTimeTag].Cells["Low"].Value.ToString();
            checkBoxenable.Checked = Boolean.Parse(grouppi.dataGridViewTaginRealTimeGroup.Rows[SelectedRowIndexdataGridViewRealTimeTag].Cells["tagEnable"].Value.ToString());
            checkBoxmail.Checked = Boolean.Parse(grouppi.dataGridViewTaginRealTimeGroup.Rows[SelectedRowIndexdataGridViewRealTimeTag].Cells["Mail"].Value.ToString());
            checkBoxphone.Checked = Boolean.Parse(grouppi.dataGridViewTaginRealTimeGroup.Rows[SelectedRowIndexdataGridViewRealTimeTag].Cells["Phone"].Value.ToString());
        }
    }
}
