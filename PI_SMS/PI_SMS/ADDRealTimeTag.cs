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
    public partial class ADDRealTimeTag : Form
    {
        private static PISDKDlg.ApplicationObject AppObj = new PISDKDlg.ApplicationObject();
        TagSearch TagSearch = AppObj.TagSearch;

        //PISDK.PISDK g_SDK;

        //PISDKDlg.ApplicationObject g_SDKDlgAppObject; // PISDK dialog app. object 

        DataTable tableRealTimeGroup = new DataTable();
        DataTable ALLRealTimeTag = new DataTable();

        string connectionString = "";
        string groupid ="";
        int checkDuplicateTag = 0;
        int checkDuplicateTaginDatabase = 0;
        int rowindexTaginREalTime;
        string DataBaseName;
        private readonly GroupPIAlarm grouppi;

        public ADDRealTimeTag(string groupselectname, string groupselectid, GroupPIAlarm Fromgrouppi,string anotherFormconnectionString,int rowindexTaginREalTime,string DataBaseName)
        {
            InitializeComponent();
            this.DataBaseName = DataBaseName;
            grouppi = Fromgrouppi;
            connectionString = anotherFormconnectionString;
            Load_ALLTag();
            groupid = groupselectid;
            textBoxGroupName.Text = groupselectname;
            this.rowindexTaginREalTime = rowindexTaginREalTime;
            
        }

        #region Load All Tag
        //

        //Load All Tag

        //
        private void Load_ALLTag()
        {
            try
            {
                ALLRealTimeTag.Clear();
                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string queryString = "SELECT TagName,RealTimeTagID From ["+DataBaseName+"].[dbo].[RealTimeTag]";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    data.Fill(ALLRealTimeTag);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void buttontag_Click(object sender, EventArgs e)
        {
            PISDK.PointList PtList;
            PtList = TagSearch.Show();
            try
            {
                object valInx = 1;
                
                if (PtList.Count == 1)
                {
                    textBoxTagname.Text = PtList[1].Name.ToString();
                    textBoxserver.Text = PtList.get_Item(ref valInx).Parent.Name;
                                       
                }
                else if(PtList.Count > 1)
                {
                    MessageBox.Show("You must select single Tag");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            for (int tag_in_database = 0; tag_in_database < ALLRealTimeTag.Rows.Count; tag_in_database++)
            {
                //check Duplicate TagName in DataBase
                if (textBoxTagname.Text.ToString() == ALLRealTimeTag.Rows[tag_in_database].ItemArray[0].ToString())
                {
                    checkDuplicateTaginDatabase = 1;
                    break;
                }
            }
            //

            // (0) When don't have TagName in TagDataBase Then Add

            //
            string message = "[vtagname] Value = [vtagname]";
            if (checkDuplicateTaginDatabase == 0)
                {
                    try
                    {
                    
                    using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                        
                        string queryString = "INSERT INTO [" + DataBaseName + "].[dbo].[RealTimeTag] ([PIServer],[TagName]) VALUES('" + textBoxserver.Text.ToString() + "','" + textBoxTagname.Text.ToString() + "') ";
                            
                            SqlCommand command = new SqlCommand(queryString, connection);
                            SqlDataAdapter data = new SqlDataAdapter(command);
                            command.Connection.Open();
                            command.ExecuteNonQuery();

                            Load_ALLTag();
                            string queryString2 = "";
                            //string queryString3 = "";

                            for (int i = 0; i < ALLRealTimeTag.Rows.Count; i++)
                            {
                                if (ALLRealTimeTag.Rows[i].ItemArray[0].ToString() == textBoxTagname.Text.ToString())
                                {
                                queryString2 = "INSERT INTO [" + DataBaseName + "].[dbo].[RealTimeTag_RealTimeGroup_Relation] ([RealTimeGroupID],[RealTimeTagID],[Mail],[Phone],[Enabled],[MessageForm],[High],[Low],[Danger],[OnAlert],[Acknowledge]) "+
                                    "VALUES('" + groupid + "','" + ALLRealTimeTag.Rows[i].ItemArray[1].ToString() + "','" + checkBoxMail.Checked.ToString() + "','" + checkBoxPhone.Checked.ToString() + "','" + checkBoxEnabled.Checked.ToString() + "','" + message + "'," +
                        "'" + textBoxhigh.Text.ToString() + "','" + textBoxlow.Text.ToString() + "','" + textBoxhihi.Text.ToString() + "','false','false') ";
                                
                                //queryString3 = "INSERT INTO ["+DataBaseName+"].[dbo].[RealTimeTagCondition] ([CompareTo],[operator],[value],[TimeTrue],[TimeUnit],[RealTimeTagID]) VALUES('"+comboBoxCompareTo.SelectedItem.ToString()+"','" + comboBoxoperator.SelectedItem.ToString() + "','" + textBoxvalue.Text.ToString() + "','" + textBoxtime.Text.ToString() + "','" + comboBoxunittime.SelectedItem.ToString() + "','" + ALLRealTimeTag.Rows[i].ItemArray[1].ToString() + "')";
                                break;
                                }
                            }

                            SqlCommand command2 = new SqlCommand(queryString2, connection);
                            command2.ExecuteNonQuery();

                            //SqlCommand command3 = new SqlCommand(queryString3, connection);
                            //command3.ExecuteNonQuery();

                        grouppi.LoadData_RealTimeTag_in_RealTimeGroup();
                        grouppi.Fill_datagridview_Tag_in_RealTimeGroup();
                        grouppi.dataGridViewTaginRealTimeGroup.Update();
                        MessageBox.Show("OK!!", "Success");
                        this.Close();
                            
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

                try
                {
                    for (int row = 0; row < grouppi.RealTimeTag_in_RealTimeGroup.Rows.Count; row++)
                    {
                        string TagName_indatagridview = grouppi.RealTimeTag_in_RealTimeGroup.Rows[row].ItemArray[0].ToString();

                        //check duplicate TagName
                        if (textBoxTagname.Text.ToString() == TagName_indatagridview)
                        {
                            MessageBox.Show("Error Tag Duplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            checkDuplicateTag = 1;
                            break;
                        }
                    }
                    //

                    // (0) if Don't have Tag in Group Then Add

                    //
                    if (checkDuplicateTag == 0)
                    {
                        
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string queryString = "";
                            //string queryString2 = "";
                            for (int i = 0; i < ALLRealTimeTag.Rows.Count; i++)
                            {
                                if (ALLRealTimeTag.Rows[i].ItemArray[0].ToString() == textBoxTagname.Text.ToString())
                                {
                                    queryString = "INSERT INTO [" + DataBaseName + "].[dbo].[RealTimeTag_RealTimeGroup_Relation] ([RealTimeGroupID],[RealTimeTagID],[Mail],[Phone],[Enabled],[MessageForm],[High],[Low],[Danger],[OnAlert],[Acknowledge]) " +
                                    "VALUES('" + groupid + "','" + ALLRealTimeTag.Rows[i].ItemArray[1].ToString() + "','" + checkBoxMail.Checked.ToString() + "','" + checkBoxPhone.Checked.ToString() + "','" + checkBoxEnabled.Checked.ToString() + "','" + message + "'," +
                        "'" + textBoxhigh.Text.ToString() + "','" + textBoxlow.Text.ToString() + "','" + textBoxhihi.Text.ToString() + "','false','false') ";
                                    break;
                                }
                            }

                            SqlCommand command = new SqlCommand(queryString, connection);
                            command.Connection.Open();
                            command.ExecuteNonQuery();

                            grouppi.LoadData_RealTimeTag_in_RealTimeGroup();
                            grouppi.Fill_datagridview_Tag_in_RealTimeGroup();
                            grouppi.dataGridViewTaginRealTimeGroup.Update();
                            MessageBox.Show("OK!!", "Success");
                            this.Close();
                            
                        }
                    }//end if decide insert
                    

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error "+ ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                }

        }
        
    }
}

