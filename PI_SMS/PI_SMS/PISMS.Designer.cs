using System.Drawing;
//this.lv2RightTopPanel.BackColor =  System.Drawing.ColorTranslator.FromHtml("#f5722e");
namespace PI_SMS
{
    partial class PISMS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Template");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Event");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("AssignUserToTemplate");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("AssignTagToTemplate");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("AssignEventToTemplate");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("DailySMSForm");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("DailySMSLog");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("TagCurrentValue");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("SMSReport", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("GroupPIAlarm");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("RealTimeGroup");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("AssignUserToRealTimeGroup");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("AlarmManagement", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("User");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("UserConfiguration", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("SystemConfig");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("SendSMS");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PISMS));
            this.LV1LEFTpanel = new System.Windows.Forms.Panel();
            this.TreeMenu = new System.Windows.Forms.TreeView();
            this.LV1Rightpanel = new System.Windows.Forms.Panel();
            this.lv2BottomRightPanel = new System.Windows.Forms.Panel();
            this.lv2RightTopPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LV0Bottompanel = new System.Windows.Forms.Panel();
            this.LV0Toppanel = new System.Windows.Forms.Panel();
            this.LV1LEFTpanel.SuspendLayout();
            this.LV1Rightpanel.SuspendLayout();
            this.lv2RightTopPanel.SuspendLayout();
            this.LV0Bottompanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV1LEFTpanel
            // 
            this.LV1LEFTpanel.AutoScroll = true;
            this.LV1LEFTpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LV1LEFTpanel.Controls.Add(this.TreeMenu);
            this.LV1LEFTpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LV1LEFTpanel.Location = new System.Drawing.Point(0, 0);
            this.LV1LEFTpanel.Name = "LV1LEFTpanel";
            this.LV1LEFTpanel.Size = new System.Drawing.Size(234, 571);
            this.LV1LEFTpanel.TabIndex = 0;
            // 
            // TreeMenu
            // 
            this.TreeMenu.BackColor = System.Drawing.Color.SpringGreen;
            this.TreeMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreeMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TreeMenu.Location = new System.Drawing.Point(0, 0);
            this.TreeMenu.Name = "TreeMenu";
            treeNode1.Name = "Template";
            treeNode1.Text = "Template";
            treeNode2.Name = "Event";
            treeNode2.Text = "Event";
            treeNode3.Name = "AssignUserToTemplate";
            treeNode3.Text = "AssignUserToTemplate";
            treeNode4.Name = "AssignTagToTemplate";
            treeNode4.Text = "AssignTagToTemplate";
            treeNode5.Name = "AssignEventToTemplate";
            treeNode5.Text = "AssignEventToTemplate";
            treeNode6.Name = "DailySMSForm";
            treeNode6.Text = "DailySMSForm";
            treeNode7.Name = "DailySMSLog";
            treeNode7.Text = "DailySMSLog";
            treeNode8.Name = "TagCurrentValue";
            treeNode8.Text = "TagCurrentValue";
            treeNode9.Name = "node0";
            treeNode9.Text = "SMSReport";
            treeNode10.Name = "GroupPIAlarm";
            treeNode10.Text = "GroupPIAlarm";
            treeNode11.Name = "RealTimeGroup";
            treeNode11.Text = "RealTimeGroup";
            treeNode12.Name = "AssignUserToRealTimeGroup";
            treeNode12.Text = "AssignUserToRealTimeGroup";
            treeNode13.Name = "AlarmManagement";
            treeNode13.Text = "AlarmManagement";
            treeNode14.Name = "User";
            treeNode14.Text = "User";
            treeNode15.Name = "Root2";
            treeNode15.Text = "UserConfiguration";
            treeNode16.Name = "SystemConfig";
            treeNode16.Text = "SystemConfig";
            treeNode17.Name = "SendSMS";
            treeNode17.Text = "SendSMS";
            this.TreeMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode13,
            treeNode15,
            treeNode16,
            treeNode17});
            this.TreeMenu.Size = new System.Drawing.Size(232, 569);
            this.TreeMenu.TabIndex = 0;
            this.TreeMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeMenu_AfterSelect);
            // 
            // LV1Rightpanel
            // 
            this.LV1Rightpanel.AutoScroll = true;
            this.LV1Rightpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LV1Rightpanel.Controls.Add(this.lv2BottomRightPanel);
            this.LV1Rightpanel.Controls.Add(this.lv2RightTopPanel);
            this.LV1Rightpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV1Rightpanel.Location = new System.Drawing.Point(234, 0);
            this.LV1Rightpanel.Name = "LV1Rightpanel";
            this.LV1Rightpanel.Size = new System.Drawing.Size(587, 571);
            this.LV1Rightpanel.TabIndex = 1;
            // 
            // lv2BottomRightPanel
            // 
            this.lv2BottomRightPanel.AutoScroll = true;
            this.lv2BottomRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv2BottomRightPanel.Location = new System.Drawing.Point(0, 39);
            this.lv2BottomRightPanel.Name = "lv2BottomRightPanel";
            this.lv2BottomRightPanel.Size = new System.Drawing.Size(585, 530);
            this.lv2BottomRightPanel.TabIndex = 2;
            // 
            // lv2RightTopPanel
            // 
            this.lv2RightTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(249)))), ((int)(((byte)(235)))));
            this.lv2RightTopPanel.Controls.Add(this.label2);
            this.lv2RightTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv2RightTopPanel.Location = new System.Drawing.Point(0, 0);
            this.lv2RightTopPanel.Name = "lv2RightTopPanel";
            this.lv2RightTopPanel.Size = new System.Drawing.Size(585, 39);
            this.lv2RightTopPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "-";
            // 
            // LV0Bottompanel
            // 
            this.LV0Bottompanel.Controls.Add(this.LV1Rightpanel);
            this.LV0Bottompanel.Controls.Add(this.LV1LEFTpanel);
            this.LV0Bottompanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV0Bottompanel.Location = new System.Drawing.Point(0, 48);
            this.LV0Bottompanel.Name = "LV0Bottompanel";
            this.LV0Bottompanel.Size = new System.Drawing.Size(821, 571);
            this.LV0Bottompanel.TabIndex = 2;
            // 
            // LV0Toppanel
            // 
            this.LV0Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LV0Toppanel.Location = new System.Drawing.Point(0, 0);
            this.LV0Toppanel.Name = "LV0Toppanel";
            this.LV0Toppanel.Size = new System.Drawing.Size(821, 48);
            this.LV0Toppanel.TabIndex = 1;
            // 
            // PISMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 619);
            this.Controls.Add(this.LV0Bottompanel);
            this.Controls.Add(this.LV0Toppanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PISMS";
            this.Text = "PISMS";
            this.LV1LEFTpanel.ResumeLayout(false);
            this.LV1Rightpanel.ResumeLayout(false);
            this.lv2RightTopPanel.ResumeLayout(false);
            this.lv2RightTopPanel.PerformLayout();
            this.LV0Bottompanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LV1LEFTpanel;
        private System.Windows.Forms.Panel LV1Rightpanel;
        private System.Windows.Forms.Panel lv2RightTopPanel;
        private System.Windows.Forms.Panel LV0Bottompanel;
        public System.Windows.Forms.Panel lv2BottomRightPanel;
        public System.Windows.Forms.TreeView TreeMenu;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel LV0Toppanel;
    }
}

