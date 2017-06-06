using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.IO;

namespace PI_SMS
{
    public partial class PISMS : Form
    {
        public OleDbConnection connecAccess = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Directory.GetCurrentDirectory() + "\\SystemConfig.mdb;Persist Security Info=False");
        public DataTable Pub_Config = new DataTable();
        bool start = true;
        AssignUserToTemplate myFormGroupReport;
        Template myFormTemplate;
        Event myFormEvent;
        AssignTagToTemplate myFormAssignTagToTemplate;
        AssignUserToRealTimeGroup myFormAssignGroupToUser;
        RealTimeGroup myFormUserConfigurationGroup;
        UserConfigurationUser myFormUserConfigurationUser;
        SystemConfig myFormSystemConfig;
        DailySMSForm myFormDailySMSForm;
        DailySMSLog myFormDailySMSLog;
        GroupPIAlarm myFormGroupPIAlarm;
        AssignEventToTemplate myFormAssignEventToTemplate;
        TagCurrentValue myFormTagInformation;
        SendSMS myFormSendSMS1;

        bool templatestart = false;
        bool eventstart = false;
        bool assigneventtotemplatestart = false;
        bool myFormGroupReportstart = false;
        bool myFormAssignTagToTemplatestart = false;        
        bool DailySMSLogstart = false;
        bool myFormUserConfigurationUserstart = false;
        bool myFormUserConfigurationGroupstart = false;
        bool AssignRealTimeGroupToUserstart = false;
        bool myFormGroupPIAlarmstart = false;
        bool myFormTagInformationstart = false;
        bool myFormDailySMSFormstart = false;
        bool myFormSystemConfigstart = false;
        bool myFormSendSMS1start = false;

        public PISMS()
        {
            //when start program all file init component by function Treemenu_afterselect in if(start) 
            //only one time
            //and then i have problem when change data some form but another form not reload data
            //i  solve by function start in form
            InitializeComponent();
            getconfig();
            
        }                

        public void getconfig()
        {
            try
            {
                String qsetting = "";
                qsetting = "SELECT  ServerIP,SMSHeader,DataBaseName,UserID,Passwordd FROM TSetting";

                connecAccess.Open();

                OleDbCommand cmd = new OleDbCommand(qsetting, connecAccess);
                OleDbDataAdapter c = new OleDbDataAdapter(cmd);

                Pub_Config = new DataTable();
                Pub_Config.Clear();
                c.SelectCommand = cmd;
                c.Fill(Pub_Config);

                connecAccess.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR :" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        public void TreeMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {

            try
            {                
                if (start)
                {
                    //myFormGroupReport = new AssignUserToTemplate();
                    //myFormTemplate = new Template();
                    //myFormEvent = new Event();
                    //myFormAssignTagToTemplate = new AssignTagToTemplate();
                    //myFormAssignGroupToUser = new AssignRealTimeGroupToUser();
                    //myFormUserConfigurationGroup = new UserConfigurationRealTimeGroup();
                    //myFormUserConfigurationUser = new UserConfigurationUser();
                    //myFormSystemConfig = new SystemConfig();
                    //myFormDailySMSForm = new DailySMSForm();
                    //myFormDailySMSLog = new DailySMSLog();
                    //myFormGroupPIAlarm = new GroupPIAlarm();
                    //myFormAssignEventToTemplate = new AssignEventToTemplate();
                    //myFormTagInformation = new TagInformation();
                    //myFormSendSMS1 = new SendSMS();
                    start = false;
                }

                string selectedNodeText = e.Node.Text.ToString();
                
                if (selectedNodeText == "Template")
                {
                    if (templatestart)
                    {
                        myFormTemplate.mydispose();
                        myFormTemplate.Dispose();
                    }
                    myFormTemplate = new Template(this);
                    label2.Text = "Template";
                    myFormTemplate.Dock = DockStyle.Fill;
                    myFormTemplate.TopLevel = false;
                    myFormTemplate.AutoScroll = true;
                    myFormTemplate.FormBorderStyle = FormBorderStyle.None;
                    lv2BottomRightPanel.Controls.Clear();
                    lv2BottomRightPanel.Controls.Add(myFormTemplate);
                    myFormTemplate.Show();
                    templatestart = true;
                }
                

                else if (selectedNodeText == "Event")
                {
                    if (eventstart)
                    {
                        myFormEvent.mydispose();
                        myFormEvent.Dispose();
                    }
                    myFormEvent = new Event(this);
                    label2.Text = "Event";
                    myFormEvent.Dock = DockStyle.Fill;
                    myFormEvent.TopLevel = false;
                    myFormEvent.AutoScroll = true;
                    myFormEvent.FormBorderStyle = FormBorderStyle.None;
                    lv2BottomRightPanel.Controls.Clear();
                    lv2BottomRightPanel.Controls.Add(myFormEvent);
                    myFormEvent.Show();
                    eventstart = true;
                }

                else if (selectedNodeText == "AssignUserToTemplate")
                {
                    if (myFormGroupReportstart)
                    {
                        myFormGroupReport.Dispose();
                        myFormGroupReport.mydispose();
                    }
                    myFormGroupReport = new AssignUserToTemplate(this);
                    label2.Text = "AssignUserToTemplate";                   
                    myFormGroupReport.Dock = DockStyle.Fill;
                    myFormGroupReport.TopLevel = false;
                    myFormGroupReport.AutoScroll = true;
                    myFormGroupReport.FormBorderStyle = FormBorderStyle.None;
                    lv2BottomRightPanel.Controls.Clear();
                    lv2BottomRightPanel.Controls.Add(myFormGroupReport);
                    myFormGroupReport.Show();
                    myFormGroupReportstart = true;
                }

                else if (selectedNodeText == "AssignTagToTemplate")
                {
                    if (myFormAssignTagToTemplatestart)
                    {
                        myFormAssignTagToTemplate.mydispose();
                        myFormAssignTagToTemplate.Dispose();
                    }
                    myFormAssignTagToTemplate = new AssignTagToTemplate(this);
                    label2.Text = "AssignTagToTemplate";
                    myFormAssignTagToTemplate.Dock = DockStyle.Fill;
                    myFormAssignTagToTemplate.TopLevel = false;
                    myFormAssignTagToTemplate.AutoScroll = true;
                    myFormAssignTagToTemplate.FormBorderStyle = FormBorderStyle.None;
                    lv2BottomRightPanel.Controls.Clear();
                    lv2BottomRightPanel.Controls.Add(myFormAssignTagToTemplate);
                    myFormAssignTagToTemplate.Show();
                    myFormAssignTagToTemplatestart = true;
                }

                else if (selectedNodeText == "User")
                {
                    if (myFormUserConfigurationUserstart)
                    {
                        myFormUserConfigurationUser.Dispose();
                    }
                    myFormUserConfigurationUser = new UserConfigurationUser(this);
                    label2.Text = "User";                  
                    myFormUserConfigurationUser.Dock = DockStyle.Fill;
                    myFormUserConfigurationUser.TopLevel = false;
                    myFormUserConfigurationUser.AutoScroll = true;
                    myFormUserConfigurationUser.FormBorderStyle = FormBorderStyle.None;
                    lv2BottomRightPanel.Controls.Clear();
                    lv2BottomRightPanel.Controls.Add(myFormUserConfigurationUser);
                    myFormUserConfigurationUser.Show();
                    myFormUserConfigurationUserstart = true;
                }

                else if (selectedNodeText == "RealTimeGroup")
                {
                    if (myFormUserConfigurationGroupstart)
                    {
                        myFormUserConfigurationGroup.Dispose();
                    }
                    label2.Text = "RealTimeGroup";
                    myFormUserConfigurationGroup = new RealTimeGroup(this);
                    myFormUserConfigurationGroup.Refresh();
                    myFormUserConfigurationGroup.Dock = DockStyle.Fill;
                    myFormUserConfigurationGroup.TopLevel = false;
                    myFormUserConfigurationGroup.AutoScroll = true;
                    myFormUserConfigurationGroup.FormBorderStyle = FormBorderStyle.None;
                    lv2BottomRightPanel.Controls.Clear();
                    lv2BottomRightPanel.Controls.Add(myFormUserConfigurationGroup);
                    myFormUserConfigurationGroup.Show();
                    myFormUserConfigurationGroupstart = true;
                }

                else if (selectedNodeText == "AssignUserToRealTimeGroup")
                {
                    label2.Text = "AssignUserToRealTimeGroup";
                    if (AssignRealTimeGroupToUserstart)
                    {
                        myFormAssignGroupToUser.Dispose();
                    }
                    myFormAssignGroupToUser = new AssignUserToRealTimeGroup(this);
                    myFormAssignGroupToUser.Refresh();
                    myFormAssignGroupToUser.Dock = DockStyle.Fill;
                    myFormAssignGroupToUser.TopLevel = false;
                    myFormAssignGroupToUser.AutoScroll = true;
                    myFormAssignGroupToUser.FormBorderStyle = FormBorderStyle.None;
                    lv2BottomRightPanel.Controls.Clear();
                    lv2BottomRightPanel.Controls.Add(myFormAssignGroupToUser);
                    myFormAssignGroupToUser.Show();
                    AssignRealTimeGroupToUserstart = true;
                }
                
                else if (selectedNodeText == "AssignEventToTemplate")
                {
                    if (assigneventtotemplatestart)
                    {
                        myFormAssignEventToTemplate.Dispose();
                    }
                    label2.Text = "AssignEventToTemplate";
                    myFormAssignEventToTemplate = new AssignEventToTemplate(this);
                    myFormAssignEventToTemplate.Dock = DockStyle.Fill;
                    myFormAssignEventToTemplate.TopLevel = false;
                    myFormAssignEventToTemplate.AutoScroll = true;
                    myFormAssignEventToTemplate.FormBorderStyle = FormBorderStyle.None;
                    lv2BottomRightPanel.Controls.Clear();
                    lv2BottomRightPanel.Controls.Add(myFormAssignEventToTemplate);
                    myFormAssignEventToTemplate.Show();
                    assigneventtotemplatestart = true;
                }

                else if (selectedNodeText == "GroupPIAlarm")
                {
                    if (myFormGroupPIAlarmstart)
                    {
                        myFormGroupPIAlarm.Dispose();
                    }
                    label2.Text = "GroupPIAlarm";
                    //myFormGroupPIAlarm.start(); //for refresh data
                    myFormGroupPIAlarm = new GroupPIAlarm(this);
                    myFormGroupPIAlarm.Dock = DockStyle.Fill;
                    myFormGroupPIAlarm.TopLevel = false;
                    myFormGroupPIAlarm.AutoScroll = true;
                    myFormGroupPIAlarm.FormBorderStyle = FormBorderStyle.None;
                    lv2BottomRightPanel.Controls.Clear();
                    lv2BottomRightPanel.Controls.Add(myFormGroupPIAlarm);
                    myFormGroupPIAlarm.Show();
                    myFormGroupPIAlarmstart = true;
                }

                else if (selectedNodeText == "TagCurrentValue")
                {
                    if (myFormTagInformationstart)
                    {
                        myFormTagInformation.Dispose();
                    }
                    myFormTagInformation = new TagCurrentValue(this);
                    //myFormTagInformation.start(); //for refresh data
                    label2.Text = "TagCurrentValue";
                    myFormTagInformation.Dock = DockStyle.Fill;
                    myFormTagInformation.TopLevel = false;
                    myFormTagInformation.AutoScroll = true;
                    myFormTagInformation.FormBorderStyle = FormBorderStyle.None;
                    lv2BottomRightPanel.Controls.Clear();
                    lv2BottomRightPanel.Controls.Add(myFormTagInformation);
                    myFormTagInformation.Show();
                    myFormTagInformationstart = true;
                }

                else if (selectedNodeText == "DailySMSForm")
                {
                    if (myFormDailySMSFormstart)
                    {
                        myFormDailySMSForm.Dispose();
                    }
                    label2.Text = "DailySMSForm";
                    myFormDailySMSForm = new DailySMSForm();
                    myFormDailySMSForm.Dock = DockStyle.Fill;
                    myFormDailySMSForm.TopLevel = false;
                    myFormDailySMSForm.AutoScroll = true;
                    myFormDailySMSForm.FormBorderStyle = FormBorderStyle.None;
                    lv2BottomRightPanel.Controls.Clear();
                    lv2BottomRightPanel.Controls.Add(myFormDailySMSForm);
                    myFormDailySMSForm.Show();
                    myFormDailySMSFormstart = true;
                }

                else if (selectedNodeText == "DailySMSLog")
                {

                    label2.Text = "DailySMSLog";
                    if (DailySMSLogstart)
                    {
                        myFormDailySMSLog.mydispose();
                        myFormDailySMSLog.Dispose();
                    }
                    myFormDailySMSLog = new DailySMSLog(this);
                    myFormDailySMSLog.Dock = DockStyle.Fill;
                    myFormDailySMSLog.TopLevel = false;
                    myFormDailySMSLog.AutoScroll = true;
                    myFormDailySMSLog.FormBorderStyle = FormBorderStyle.None;
                    lv2BottomRightPanel.Controls.Clear();
                    lv2BottomRightPanel.Controls.Add(myFormDailySMSLog);
                    myFormDailySMSLog.Show();
                    DailySMSLogstart = true;
                }

                else if (selectedNodeText == "SystemConfig")
                {
                    if (myFormSystemConfigstart)
                    {
                        myFormSystemConfig.Dispose();
                    }
                    label2.Text = "SystemConfig";
                    myFormSystemConfig = new SystemConfig(this);
                    myFormSystemConfig.Dock = DockStyle.Fill;
                    myFormSystemConfig.TopLevel = false;
                    myFormSystemConfig.AutoScroll = true;
                    myFormSystemConfig.FormBorderStyle = FormBorderStyle.None;
                    lv2BottomRightPanel.Controls.Clear();
                    lv2BottomRightPanel.Controls.Add(myFormSystemConfig);
                    myFormSystemConfig.Show();
                    myFormSystemConfigstart = true;
                }

                else if (selectedNodeText == "SendSMS")
                {
                    if (myFormSendSMS1start)
                    {
                        myFormSendSMS1.Dispose();
                    }
                    label2.Text = "SendSMS";
                    myFormSendSMS1 = new SendSMS();
                    myFormSendSMS1.Dock = DockStyle.Fill;
                    myFormSendSMS1.TopLevel = false;
                    myFormSendSMS1.AutoScroll = true;
                    myFormSendSMS1.FormBorderStyle = FormBorderStyle.None;
                    lv2BottomRightPanel.Controls.Clear();
                    lv2BottomRightPanel.Controls.Add(myFormSendSMS1);
                    myFormSendSMS1.Show();
                    myFormSendSMS1start = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }//end tree afterselect
    }
}
