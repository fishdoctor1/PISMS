using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace PI_SMS
{
    public partial class SystemConfig : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Directory.GetCurrentDirectory() + "\\SystemConfig.mdb;Persist Security Info=False");
        DataTable Pub_Config = new DataTable();

        private readonly PISMS pisms;

        public SystemConfig(PISMS frompisms)
        {
            InitializeComponent();
            pisms = frompisms;
            getconfig();
        }

        private void getconfig()
        {
            try
            {
                String qsetting = "";
                qsetting = "SELECT  ServerIP,SMSHeader,DataBaseName,UserID,Passwordd FROM TSetting";

                con.Open();

                OleDbCommand cmd = new OleDbCommand(qsetting, con);
                OleDbDataAdapter c = new OleDbDataAdapter(cmd);

                Pub_Config = new DataTable();
                Pub_Config.Clear();
                c.SelectCommand = cmd;
                c.Fill(Pub_Config);

                textBox1.Text = Pub_Config.Rows[0].ItemArray[0].ToString(); //IP
                textBox2.Text = Pub_Config.Rows[0].ItemArray[1].ToString(); //Header
                textBox3.Text = Pub_Config.Rows[0].ItemArray[2].ToString(); //databaseName
                textBox4.Text = Pub_Config.Rows[0].ItemArray[3].ToString(); //UserID
                textBox5.Text = Pub_Config.Rows[0].ItemArray[4].ToString(); //Password
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR :" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qsetting = "";
                string password = textBox5.Text.ToString();
                qsetting = "UPDATE TSetting SET ServerIP = '" + textBox1.Text.ToString() 
                    + "',SMSHeader = '" + textBox2.Text.ToString() +"',DataBaseName = '"
                    + textBox3.Text.ToString() +"',UserID = '"
                    + textBox4.Text.ToString() +"'"
                    + ", Passwordd = '" + password
                    + "' WHERE ID = 1;";

                //qsetting = "UPDATE TSetting SET  WHERE ID=1";

                OleDbCommand cmd = new OleDbCommand(qsetting, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("UPDATE success" ,"UPDATE OK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //PISMS pisms = new PISMS();
                pisms.getconfig();
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show("ERROR :" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
