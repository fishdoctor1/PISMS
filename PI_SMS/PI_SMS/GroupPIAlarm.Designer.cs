namespace PI_SMS
{
    partial class GroupPIAlarm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupPIAlarm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxDisable = new System.Windows.Forms.CheckBox();
            this.checkBoxEnable = new System.Windows.Forms.CheckBox();
            this.comboBoxmanagestatus = new System.Windows.Forms.ComboBox();
            this.UpdateStatusTag = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonsaveoption = new System.Windows.Forms.Button();
            this.textBoxNonRepetitionInterval = new System.Windows.Forms.TextBox();
            this.textBoxresendtime = new System.Windows.Forms.TextBox();
            this.comboBoxNonRepetitionIntervalunit = new System.Windows.Forms.ComboBox();
            this.comboBoxResendIntervalunit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxNotifyonlyonchange = new System.Windows.Forms.CheckBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonAckAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStopGroup = new System.Windows.Forms.Button();
            this.buttonStartGroup = new System.Windows.Forms.Button();
            this.comboBoxRealTimeGroup = new System.Windows.Forms.ComboBox();
            this.buttonAddTag = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridViewTaginRealTimeGroup = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewTagCondition = new System.Windows.Forms.DataGridView();
            this.CompareTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeTrue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timeunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConditionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSaveMessage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxmessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagAlias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Enable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OnAlert = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.acknowledge = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Danger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.High = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Low = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaginRealTimeGroup)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTagCondition)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1072F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1072, 386);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.AutoScroll = true;
            this.panel10.BackColor = System.Drawing.Color.Aqua;
            this.panel10.Controls.Add(this.groupBox2);
            this.panel10.Controls.Add(this.groupBox1);
            this.panel10.Controls.Add(this.buttonRefresh);
            this.panel10.Controls.Add(this.buttonAckAll);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Controls.Add(this.buttonStopGroup);
            this.panel10.Controls.Add(this.buttonStartGroup);
            this.panel10.Controls.Add(this.comboBoxRealTimeGroup);
            this.panel10.Controls.Add(this.buttonAddTag);
            this.panel10.Controls.Add(this.buttonSearch);
            this.panel10.Controls.Add(this.textBoxSearch);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1066, 144);
            this.panel10.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxDisable);
            this.groupBox2.Controls.Add(this.checkBoxEnable);
            this.groupBox2.Controls.Add(this.comboBoxmanagestatus);
            this.groupBox2.Controls.Add(this.UpdateStatusTag);
            this.groupBox2.Location = new System.Drawing.Point(194, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 75);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage Status";
            // 
            // checkBoxDisable
            // 
            this.checkBoxDisable.AutoSize = true;
            this.checkBoxDisable.Enabled = false;
            this.checkBoxDisable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBoxDisable.Location = new System.Drawing.Point(6, 46);
            this.checkBoxDisable.Name = "checkBoxDisable";
            this.checkBoxDisable.Size = new System.Drawing.Size(72, 17);
            this.checkBoxDisable.TabIndex = 11;
            this.checkBoxDisable.Text = "DisableAll";
            this.checkBoxDisable.UseVisualStyleBackColor = true;
            this.checkBoxDisable.CheckedChanged += new System.EventHandler(this.checkBoxDisable_CheckedChanged);
            // 
            // checkBoxEnable
            // 
            this.checkBoxEnable.AutoSize = true;
            this.checkBoxEnable.Enabled = false;
            this.checkBoxEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBoxEnable.Location = new System.Drawing.Point(84, 46);
            this.checkBoxEnable.Name = "checkBoxEnable";
            this.checkBoxEnable.Size = new System.Drawing.Size(70, 17);
            this.checkBoxEnable.TabIndex = 10;
            this.checkBoxEnable.Text = "EnableAll";
            this.checkBoxEnable.UseVisualStyleBackColor = true;
            this.checkBoxEnable.CheckedChanged += new System.EventHandler(this.checkBoxEnable_CheckedChanged);
            // 
            // comboBoxmanagestatus
            // 
            this.comboBoxmanagestatus.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxmanagestatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxmanagestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxmanagestatus.FormattingEnabled = true;
            this.comboBoxmanagestatus.Items.AddRange(new object[] {
            "Mail",
            "Phone",
            "Enable"});
            this.comboBoxmanagestatus.Location = new System.Drawing.Point(6, 19);
            this.comboBoxmanagestatus.Name = "comboBoxmanagestatus";
            this.comboBoxmanagestatus.Size = new System.Drawing.Size(121, 24);
            this.comboBoxmanagestatus.TabIndex = 21;
            this.comboBoxmanagestatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UpdateStatusTag
            // 
            this.UpdateStatusTag.BackColor = System.Drawing.Color.Wheat;
            this.UpdateStatusTag.Enabled = false;
            this.UpdateStatusTag.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.UpdateStatusTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateStatusTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.UpdateStatusTag.Location = new System.Drawing.Point(147, 11);
            this.UpdateStatusTag.Name = "UpdateStatusTag";
            this.UpdateStatusTag.Size = new System.Drawing.Size(71, 35);
            this.UpdateStatusTag.TabIndex = 9;
            this.UpdateStatusTag.Text = "Update";
            this.UpdateStatusTag.UseVisualStyleBackColor = false;
            this.UpdateStatusTag.Click += new System.EventHandler(this.UpdateEnableStatus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonsaveoption);
            this.groupBox1.Controls.Add(this.textBoxNonRepetitionInterval);
            this.groupBox1.Controls.Add(this.textBoxresendtime);
            this.groupBox1.Controls.Add(this.comboBoxNonRepetitionIntervalunit);
            this.groupBox1.Controls.Add(this.comboBoxResendIntervalunit);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkBoxNotifyonlyonchange);
            this.groupBox1.Location = new System.Drawing.Point(549, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 115);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "option";
            // 
            // buttonsaveoption
            // 
            this.buttonsaveoption.Location = new System.Drawing.Point(218, 20);
            this.buttonsaveoption.Name = "buttonsaveoption";
            this.buttonsaveoption.Size = new System.Drawing.Size(56, 24);
            this.buttonsaveoption.TabIndex = 7;
            this.buttonsaveoption.Text = "Save";
            this.buttonsaveoption.UseVisualStyleBackColor = true;
            this.buttonsaveoption.Click += new System.EventHandler(this.buttonsaveoption_Click);
            // 
            // textBoxNonRepetitionInterval
            // 
            this.textBoxNonRepetitionInterval.Location = new System.Drawing.Point(155, 78);
            this.textBoxNonRepetitionInterval.Name = "textBoxNonRepetitionInterval";
            this.textBoxNonRepetitionInterval.Size = new System.Drawing.Size(57, 20);
            this.textBoxNonRepetitionInterval.TabIndex = 6;
            // 
            // textBoxresendtime
            // 
            this.textBoxresendtime.Location = new System.Drawing.Point(155, 53);
            this.textBoxresendtime.Name = "textBoxresendtime";
            this.textBoxresendtime.Size = new System.Drawing.Size(57, 20);
            this.textBoxresendtime.TabIndex = 5;
            // 
            // comboBoxNonRepetitionIntervalunit
            // 
            this.comboBoxNonRepetitionIntervalunit.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxNonRepetitionIntervalunit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNonRepetitionIntervalunit.FormattingEnabled = true;
            this.comboBoxNonRepetitionIntervalunit.Items.AddRange(new object[] {
            "Second",
            "Minute",
            "Hour",
            "Day"});
            this.comboBoxNonRepetitionIntervalunit.Location = new System.Drawing.Point(218, 78);
            this.comboBoxNonRepetitionIntervalunit.Name = "comboBoxNonRepetitionIntervalunit";
            this.comboBoxNonRepetitionIntervalunit.Size = new System.Drawing.Size(57, 21);
            this.comboBoxNonRepetitionIntervalunit.TabIndex = 4;
            // 
            // comboBoxResendIntervalunit
            // 
            this.comboBoxResendIntervalunit.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxResendIntervalunit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResendIntervalunit.FormattingEnabled = true;
            this.comboBoxResendIntervalunit.Items.AddRange(new object[] {
            "Second",
            "Minute",
            "Hour",
            "Day"});
            this.comboBoxResendIntervalunit.Location = new System.Drawing.Point(218, 52);
            this.comboBoxResendIntervalunit.Name = "comboBoxResendIntervalunit";
            this.comboBoxResendIntervalunit.Size = new System.Drawing.Size(57, 21);
            this.comboBoxResendIntervalunit.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Non-Repetition Interval";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Resend Interval";
            // 
            // checkBoxNotifyonlyonchange
            // 
            this.checkBoxNotifyonlyonchange.AutoSize = true;
            this.checkBoxNotifyonlyonchange.Location = new System.Drawing.Point(20, 23);
            this.checkBoxNotifyonlyonchange.Name = "checkBoxNotifyonlyonchange";
            this.checkBoxNotifyonlyonchange.Size = new System.Drawing.Size(175, 17);
            this.checkBoxNotifyonlyonchange.TabIndex = 0;
            this.checkBoxNotifyonlyonchange.Text = "Notify Only on change in Status";
            this.checkBoxNotifyonlyonchange.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Violet;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.ImageIndex = 2;
            this.buttonRefresh.ImageList = this.imageList1;
            this.buttonRefresh.Location = new System.Drawing.Point(103, 55);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(47, 41);
            this.buttonRefresh.TabIndex = 27;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Play1Hot.ico");
            this.imageList1.Images.SetKeyName(1, "Stop1NormalRed.ico");
            this.imageList1.Images.SetKeyName(2, "refresh1.ico");
            // 
            // buttonAckAll
            // 
            this.buttonAckAll.BackColor = System.Drawing.Color.Wheat;
            this.buttonAckAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonAckAll.Location = new System.Drawing.Point(424, 40);
            this.buttonAckAll.Name = "buttonAckAll";
            this.buttonAckAll.Size = new System.Drawing.Size(88, 29);
            this.buttonAckAll.TabIndex = 26;
            this.buttonAckAll.Text = "Ack. ALL";
            this.buttonAckAll.UseVisualStyleBackColor = false;
            this.buttonAckAll.Click += new System.EventHandler(this.buttonAckAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "RealTimeGroup";
            // 
            // buttonStopGroup
            // 
            this.buttonStopGroup.BackColor = System.Drawing.Color.Red;
            this.buttonStopGroup.Enabled = false;
            this.buttonStopGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStopGroup.ImageIndex = 1;
            this.buttonStopGroup.ImageList = this.imageList1;
            this.buttonStopGroup.Location = new System.Drawing.Point(57, 56);
            this.buttonStopGroup.Name = "buttonStopGroup";
            this.buttonStopGroup.Size = new System.Drawing.Size(40, 38);
            this.buttonStopGroup.TabIndex = 24;
            this.buttonStopGroup.UseVisualStyleBackColor = false;
            this.buttonStopGroup.Click += new System.EventHandler(this.buttonStopGroup_Click);
            // 
            // buttonStartGroup
            // 
            this.buttonStartGroup.BackColor = System.Drawing.Color.Turquoise;
            this.buttonStartGroup.Enabled = false;
            this.buttonStartGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStartGroup.ImageIndex = 0;
            this.buttonStartGroup.ImageList = this.imageList1;
            this.buttonStartGroup.Location = new System.Drawing.Point(12, 56);
            this.buttonStartGroup.Name = "buttonStartGroup";
            this.buttonStartGroup.Size = new System.Drawing.Size(39, 38);
            this.buttonStartGroup.TabIndex = 23;
            this.buttonStartGroup.UseVisualStyleBackColor = false;
            this.buttonStartGroup.Click += new System.EventHandler(this.buttonStartGroup_Click);
            // 
            // comboBoxRealTimeGroup
            // 
            this.comboBoxRealTimeGroup.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxRealTimeGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRealTimeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxRealTimeGroup.FormattingEnabled = true;
            this.comboBoxRealTimeGroup.IntegralHeight = false;
            this.comboBoxRealTimeGroup.Location = new System.Drawing.Point(12, 29);
            this.comboBoxRealTimeGroup.MaxDropDownItems = 5;
            this.comboBoxRealTimeGroup.Name = "comboBoxRealTimeGroup";
            this.comboBoxRealTimeGroup.Size = new System.Drawing.Size(163, 24);
            this.comboBoxRealTimeGroup.TabIndex = 22;
            this.comboBoxRealTimeGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxRealTimeGroup_SelectedIndexChanged);
            // 
            // buttonAddTag
            // 
            this.buttonAddTag.BackColor = System.Drawing.Color.Wheat;
            this.buttonAddTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddTag.Location = new System.Drawing.Point(194, 3);
            this.buttonAddTag.Name = "buttonAddTag";
            this.buttonAddTag.Size = new System.Drawing.Size(65, 26);
            this.buttonAddTag.TabIndex = 4;
            this.buttonAddTag.Text = "Add Tag";
            this.buttonAddTag.UseVisualStyleBackColor = false;
            this.buttonAddTag.Click += new System.EventHandler(this.buttonAddTag_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Wheat;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonSearch.FlatAppearance.BorderSize = 2;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonSearch.Location = new System.Drawing.Point(486, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(57, 29);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(341, 9);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(139, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(265, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "TagName";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 663F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 403F));
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1066, 230);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.BackColor = System.Drawing.Color.Plum;
            this.panel7.Controls.Add(this.dataGridViewTaginRealTimeGroup);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(657, 224);
            this.panel7.TabIndex = 8;
            // 
            // dataGridViewTaginRealTimeGroup
            // 
            this.dataGridViewTaginRealTimeGroup.AllowUserToAddRows = false;
            this.dataGridViewTaginRealTimeGroup.AllowUserToDeleteRows = false;
            this.dataGridViewTaginRealTimeGroup.BackgroundColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTaginRealTimeGroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTaginRealTimeGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaginRealTimeGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.PIServer,
            this.TagName,
            this.TagAlias,
            this.Type,
            this.Mail,
            this.Phone,
            this.Enable,
            this.OnAlert,
            this.acknowledge,
            this.unit,
            this.Trip,
            this.MachineNo,
            this.Danger,
            this.High,
            this.Low,
            this.TagID});
            this.dataGridViewTaginRealTimeGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTaginRealTimeGroup.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTaginRealTimeGroup.MultiSelect = false;
            this.dataGridViewTaginRealTimeGroup.Name = "dataGridViewTaginRealTimeGroup";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTaginRealTimeGroup.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTaginRealTimeGroup.RowHeadersVisible = false;
            this.dataGridViewTaginRealTimeGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewTaginRealTimeGroup.Size = new System.Drawing.Size(657, 224);
            this.dataGridViewTaginRealTimeGroup.TabIndex = 0;
            this.dataGridViewTaginRealTimeGroup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewTaginRealTimeGroup_MouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(666, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(397, 224);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewTagCondition);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(389, 198);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trigger";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTagCondition
            // 
            this.dataGridViewTagCondition.AllowUserToAddRows = false;
            this.dataGridViewTagCondition.AllowUserToDeleteRows = false;
            this.dataGridViewTagCondition.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewTagCondition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTagCondition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompareTo,
            this.Operator,
            this.value,
            this.TimeTrue,
            this.Timeunit,
            this.ConditionID});
            this.dataGridViewTagCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTagCondition.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTagCondition.MultiSelect = false;
            this.dataGridViewTagCondition.Name = "dataGridViewTagCondition";
            this.dataGridViewTagCondition.ReadOnly = true;
            this.dataGridViewTagCondition.RowHeadersVisible = false;
            this.dataGridViewTagCondition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTagCondition.Size = new System.Drawing.Size(383, 192);
            this.dataGridViewTagCondition.TabIndex = 9;
            this.dataGridViewTagCondition.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewTagCondition_MouseClick);
            // 
            // CompareTo
            // 
            this.CompareTo.HeaderText = "CompareTo";
            this.CompareTo.MinimumWidth = 20;
            this.CompareTo.Name = "CompareTo";
            this.CompareTo.ReadOnly = true;
            this.CompareTo.Width = 70;
            // 
            // Operator
            // 
            this.Operator.HeaderText = "Operator";
            this.Operator.MinimumWidth = 60;
            this.Operator.Name = "Operator";
            this.Operator.ReadOnly = true;
            this.Operator.Width = 60;
            // 
            // value
            // 
            this.value.HeaderText = "value";
            this.value.MinimumWidth = 50;
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.Width = 50;
            // 
            // TimeTrue
            // 
            this.TimeTrue.HeaderText = "Time True";
            this.TimeTrue.MinimumWidth = 70;
            this.TimeTrue.Name = "TimeTrue";
            this.TimeTrue.ReadOnly = true;
            this.TimeTrue.Width = 70;
            // 
            // Timeunit
            // 
            this.Timeunit.HeaderText = "Timeunit";
            this.Timeunit.MinimumWidth = 70;
            this.Timeunit.Name = "Timeunit";
            this.Timeunit.ReadOnly = true;
            this.Timeunit.Width = 70;
            // 
            // ConditionID
            // 
            this.ConditionID.HeaderText = "ConditionID";
            this.ConditionID.Name = "ConditionID";
            this.ConditionID.ReadOnly = true;
            this.ConditionID.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonSaveMessage);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxmessage);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(389, 198);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Message";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSaveMessage
            // 
            this.buttonSaveMessage.Location = new System.Drawing.Point(223, 151);
            this.buttonSaveMessage.Name = "buttonSaveMessage";
            this.buttonSaveMessage.Size = new System.Drawing.Size(67, 32);
            this.buttonSaveMessage.TabIndex = 4;
            this.buttonSaveMessage.Text = "Save";
            this.buttonSaveMessage.UseVisualStyleBackColor = true;
            this.buttonSaveMessage.Click += new System.EventHandler(this.buttonSaveMessage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "NewLine => [\\n]";
            // 
            // textBoxmessage
            // 
            this.textBoxmessage.Location = new System.Drawing.Point(19, 18);
            this.textBoxmessage.MaxLength = 500;
            this.textBoxmessage.Multiline = true;
            this.textBoxmessage.Name = "textBoxmessage";
            this.textBoxmessage.Size = new System.Drawing.Size(198, 165);
            this.textBoxmessage.TabIndex = 2;
            this.textBoxmessage.Text = "[vtagname] Value = [vtagname]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "TagValue => [vtagvalue]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "TagName => [vtagname]";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 386);
            this.panel2.TabIndex = 2;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 40;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // PIServer
            // 
            this.PIServer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PIServer.HeaderText = "Server";
            this.PIServer.MinimumWidth = 20;
            this.PIServer.Name = "PIServer";
            this.PIServer.ReadOnly = true;
            this.PIServer.Width = 60;
            // 
            // TagName
            // 
            this.TagName.HeaderText = "Tag";
            this.TagName.Name = "TagName";
            // 
            // TagAlias
            // 
            this.TagAlias.HeaderText = "TagAlias";
            this.TagAlias.MinimumWidth = 90;
            this.TagAlias.Name = "TagAlias";
            this.TagAlias.ReadOnly = true;
            this.TagAlias.Visible = false;
            this.TagAlias.Width = 90;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 60;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Visible = false;
            this.Type.Width = 60;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.MinimumWidth = 45;
            this.Mail.Name = "Mail";
            this.Mail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Mail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Mail.Width = 50;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 55;
            this.Phone.Name = "Phone";
            this.Phone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Phone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Phone.Width = 60;
            // 
            // Enable
            // 
            this.Enable.HeaderText = "Enable";
            this.Enable.MinimumWidth = 20;
            this.Enable.Name = "Enable";
            this.Enable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Enable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Enable.Width = 55;
            // 
            // OnAlert
            // 
            this.OnAlert.HeaderText = "Alert";
            this.OnAlert.MinimumWidth = 30;
            this.OnAlert.Name = "OnAlert";
            this.OnAlert.ReadOnly = true;
            this.OnAlert.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OnAlert.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OnAlert.Width = 45;
            // 
            // acknowledge
            // 
            this.acknowledge.HeaderText = "Ack";
            this.acknowledge.MinimumWidth = 30;
            this.acknowledge.Name = "acknowledge";
            this.acknowledge.ReadOnly = true;
            this.acknowledge.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acknowledge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.acknowledge.Width = 50;
            // 
            // unit
            // 
            this.unit.HeaderText = "unit";
            this.unit.MinimumWidth = 15;
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Visible = false;
            this.unit.Width = 45;
            // 
            // Trip
            // 
            this.Trip.HeaderText = "Trip";
            this.Trip.MinimumWidth = 15;
            this.Trip.Name = "Trip";
            this.Trip.ReadOnly = true;
            this.Trip.Visible = false;
            this.Trip.Width = 45;
            // 
            // MachineNo
            // 
            this.MachineNo.HeaderText = "MachineNo";
            this.MachineNo.MinimumWidth = 15;
            this.MachineNo.Name = "MachineNo";
            this.MachineNo.ReadOnly = true;
            this.MachineNo.Visible = false;
            // 
            // Danger
            // 
            this.Danger.HeaderText = "HiHi";
            this.Danger.MinimumWidth = 20;
            this.Danger.Name = "Danger";
            this.Danger.Width = 37;
            // 
            // High
            // 
            this.High.HeaderText = "Hi";
            this.High.MinimumWidth = 20;
            this.High.Name = "High";
            this.High.Width = 30;
            // 
            // Low
            // 
            this.Low.HeaderText = "Lo";
            this.Low.MinimumWidth = 20;
            this.Low.Name = "Low";
            this.Low.Width = 30;
            // 
            // TagID
            // 
            this.TagID.HeaderText = "TagID";
            this.TagID.Name = "TagID";
            this.TagID.ReadOnly = true;
            this.TagID.Visible = false;
            // 
            // GroupPIAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 386);
            this.Controls.Add(this.panel2);
            this.Name = "GroupPIAlarm";
            this.Text = "GroupPIAlarm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaginRealTimeGroup)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTagCondition)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox checkBoxDisable;
        private System.Windows.Forms.CheckBox checkBoxEnable;
        private System.Windows.Forms.Button UpdateStatusTag;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonAddTag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.DataGridView dataGridViewTaginRealTimeGroup;
        private System.Windows.Forms.ComboBox comboBoxmanagestatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.DataGridView dataGridViewTagCondition;
        private System.Windows.Forms.ComboBox comboBoxRealTimeGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStopGroup;
        private System.Windows.Forms.Button buttonStartGroup;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonAckAll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxmessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSaveMessage;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNonRepetitionInterval;
        private System.Windows.Forms.TextBox textBoxresendtime;
        private System.Windows.Forms.ComboBox comboBoxNonRepetitionIntervalunit;
        private System.Windows.Forms.ComboBox comboBoxResendIntervalunit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxNotifyonlyonchange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonsaveoption;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompareTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeTrue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timeunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConditionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagAlias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Mail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Phone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Enable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OnAlert;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acknowledge;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trip;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Danger;
        private System.Windows.Forms.DataGridViewTextBoxColumn High;
        private System.Windows.Forms.DataGridViewTextBoxColumn Low;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagID;
    }
}