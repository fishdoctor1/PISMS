using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PI_SMS
{
    public partial class SendSMS : Form
    {
        public SendSMS()
        {
            InitializeComponent();
            PISMS pisms = new PISMS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SMSGateway.CTSMSDTACSoapClient client = new SMSGateway.CTSMSDTACSoapClient())
            {
                try
                {
                    string phonenumber = textBox2.Text.ToString();
                    string header = textBox3.Text.ToString();
                    string message = textBox1.Text.ToString();
                    char type = 'E';

                    SMSGateway.SMS_Result result = client.sendSMS2DTAC(phonenumber, header, message, type);
                    MessageBox.Show("send : " + result.result.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
