namespace PI_SMS
{
    partial class Event
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EventCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sun = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Mon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Tue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Wed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Thu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Fri = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repeat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RepeatTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepeatTimeUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTimeRepeatUnit = new System.Windows.Forms.ComboBox();
            this.textBoxtimeRepeat = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonNEWEvent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMin = new System.Windows.Forms.ComboBox();
            this.comboBoxHour = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.checkBoxSat = new System.Windows.Forms.CheckBox();
            this.checkBoxFri = new System.Windows.Forms.CheckBox();
            this.checkBoxThu = new System.Windows.Forms.CheckBox();
            this.checkBoxWed = new System.Windows.Forms.CheckBox();
            this.checkBoxTue = new System.Windows.Forms.CheckBox();
            this.checkBoxMon = new System.Windows.Forms.CheckBox();
            this.checkBoxSun = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventCol,
            this.Sun,
            this.Mon,
            this.Tue,
            this.Wed,
            this.Thu,
            this.Fri,
            this.Sat,
            this.Time,
            this.EventID,
            this.Repeat,
            this.RepeatTime,
            this.RepeatTimeUnit});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(780, 217);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // EventCol
            // 
            this.EventCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EventCol.HeaderText = "EventName";
            this.EventCol.MinimumWidth = 200;
            this.EventCol.Name = "EventCol";
            this.EventCol.ReadOnly = true;
            // 
            // Sun
            // 
            this.Sun.HeaderText = "Sun";
            this.Sun.MinimumWidth = 35;
            this.Sun.Name = "Sun";
            this.Sun.ReadOnly = true;
            this.Sun.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sun.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sun.Width = 35;
            // 
            // Mon
            // 
            this.Mon.HeaderText = "Mon";
            this.Mon.MinimumWidth = 37;
            this.Mon.Name = "Mon";
            this.Mon.ReadOnly = true;
            this.Mon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Mon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Mon.Width = 37;
            // 
            // Tue
            // 
            this.Tue.HeaderText = "Tue";
            this.Tue.MinimumWidth = 35;
            this.Tue.Name = "Tue";
            this.Tue.ReadOnly = true;
            this.Tue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Tue.Width = 35;
            // 
            // Wed
            // 
            this.Wed.HeaderText = "Wed";
            this.Wed.MinimumWidth = 37;
            this.Wed.Name = "Wed";
            this.Wed.ReadOnly = true;
            this.Wed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Wed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Wed.Width = 37;
            // 
            // Thu
            // 
            this.Thu.HeaderText = "Thu";
            this.Thu.MinimumWidth = 35;
            this.Thu.Name = "Thu";
            this.Thu.ReadOnly = true;
            this.Thu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Thu.Width = 35;
            // 
            // Fri
            // 
            this.Fri.HeaderText = "Fri";
            this.Fri.MinimumWidth = 35;
            this.Fri.Name = "Fri";
            this.Fri.ReadOnly = true;
            this.Fri.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Fri.Width = 35;
            // 
            // Sat
            // 
            this.Sat.HeaderText = "Sat";
            this.Sat.MinimumWidth = 35;
            this.Sat.Name = "Sat";
            this.Sat.ReadOnly = true;
            this.Sat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sat.Width = 35;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 74;
            // 
            // EventID
            // 
            this.EventID.HeaderText = "EventID";
            this.EventID.Name = "EventID";
            this.EventID.ReadOnly = true;
            this.EventID.Visible = false;
            // 
            // Repeat
            // 
            this.Repeat.HeaderText = "Repeat";
            this.Repeat.MinimumWidth = 55;
            this.Repeat.Name = "Repeat";
            this.Repeat.ReadOnly = true;
            this.Repeat.Width = 55;
            // 
            // RepeatTime
            // 
            this.RepeatTime.HeaderText = "RepeatTime";
            this.RepeatTime.MinimumWidth = 35;
            this.RepeatTime.Name = "RepeatTime";
            this.RepeatTime.ReadOnly = true;
            this.RepeatTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RepeatTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RepeatTime.Width = 95;
            // 
            // RepeatTimeUnit
            // 
            this.RepeatTimeUnit.HeaderText = "RepeatTimeUnit";
            this.RepeatTimeUnit.MinimumWidth = 35;
            this.RepeatTimeUnit.Name = "RepeatTimeUnit";
            this.RepeatTimeUnit.ReadOnly = true;
            this.RepeatTimeUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RepeatTimeUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RepeatTimeUnit.Width = 120;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBoxTimeRepeatUnit);
            this.panel2.Controls.Add(this.textBoxtimeRepeat);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.buttonNEWEvent);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBoxMin);
            this.panel2.Controls.Add(this.comboBoxHour);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.buttonUpdate);
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.buttonadd);
            this.panel2.Controls.Add(this.checkBoxSat);
            this.panel2.Controls.Add(this.checkBoxFri);
            this.panel2.Controls.Add(this.checkBoxThu);
            this.panel2.Controls.Add(this.checkBoxWed);
            this.panel2.Controls.Add(this.checkBoxTue);
            this.panel2.Controls.Add(this.checkBoxMon);
            this.panel2.Controls.Add(this.checkBoxSun);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 160);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "above 5 Minutes";
            this.label1.Visible = false;
            // 
            // comboBoxTimeRepeatUnit
            // 
            this.comboBoxTimeRepeatUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimeRepeatUnit.Enabled = false;
            this.comboBoxTimeRepeatUnit.FormattingEnabled = true;
            this.comboBoxTimeRepeatUnit.Items.AddRange(new object[] {
            "Minute",
            "Hour"});
            this.comboBoxTimeRepeatUnit.Location = new System.Drawing.Point(590, 24);
            this.comboBoxTimeRepeatUnit.Name = "comboBoxTimeRepeatUnit";
            this.comboBoxTimeRepeatUnit.Size = new System.Drawing.Size(76, 21);
            this.comboBoxTimeRepeatUnit.TabIndex = 28;
            this.comboBoxTimeRepeatUnit.Visible = false;
            // 
            // textBoxtimeRepeat
            // 
            this.textBoxtimeRepeat.Enabled = false;
            this.textBoxtimeRepeat.Location = new System.Drawing.Point(526, 26);
            this.textBoxtimeRepeat.Name = "textBoxtimeRepeat";
            this.textBoxtimeRepeat.Size = new System.Drawing.Size(58, 20);
            this.textBoxtimeRepeat.TabIndex = 27;
            this.textBoxtimeRepeat.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(452, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Repeat";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonNEWEvent
            // 
            this.buttonNEWEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonNEWEvent.Location = new System.Drawing.Point(3, 0);
            this.buttonNEWEvent.Name = "buttonNEWEvent";
            this.buttonNEWEvent.Size = new System.Drawing.Size(134, 46);
            this.buttonNEWEvent.TabIndex = 25;
            this.buttonNEWEvent.Text = "ADD Event";
            this.buttonNEWEvent.UseVisualStyleBackColor = true;
            this.buttonNEWEvent.Click += new System.EventHandler(this.buttonNEWEvent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "EventName:";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "M";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "H";
            this.label2.Visible = false;
            // 
            // comboBoxMin
            // 
            this.comboBoxMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxMin.FormattingEnabled = true;
            this.comboBoxMin.IntegralHeight = false;
            this.comboBoxMin.Items.AddRange(new object[] {
            "00",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxMin.Location = new System.Drawing.Point(525, 55);
            this.comboBoxMin.MaxDropDownItems = 5;
            this.comboBoxMin.Name = "comboBoxMin";
            this.comboBoxMin.Size = new System.Drawing.Size(44, 24);
            this.comboBoxMin.TabIndex = 21;
            this.comboBoxMin.Visible = false;
            // 
            // comboBoxHour
            // 
            this.comboBoxHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxHour.FormattingEnabled = true;
            this.comboBoxHour.IntegralHeight = false;
            this.comboBoxHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBoxHour.Location = new System.Drawing.Point(452, 55);
            this.comboBoxHour.MaxDropDownItems = 5;
            this.comboBoxHour.Name = "comboBoxHour";
            this.comboBoxHour.Size = new System.Drawing.Size(43, 24);
            this.comboBoxHour.TabIndex = 20;
            this.comboBoxHour.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(91, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 22);
            this.textBox1.TabIndex = 19;
            this.textBox1.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Black;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.ImageIndex = 3;
            this.buttonUpdate.ImageList = this.imageList1;
            this.buttonUpdate.Location = new System.Drawing.Point(452, 83);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(88, 37);
            this.buttonUpdate.TabIndex = 15;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ADD.ico");
            this.imageList1.Images.SetKeyName(1, "DeleteRed.ico");
            this.imageList1.Images.SetKeyName(2, "refresh1.ico");
            this.imageList1.Images.SetKeyName(3, "edit.ico");
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.ImageIndex = 2;
            this.buttonCancel.ImageList = this.imageList1;
            this.buttonCancel.Location = new System.Drawing.Point(546, 83);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(71, 37);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Back";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonadd.ForeColor = System.Drawing.Color.White;
            this.buttonadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonadd.ImageIndex = 0;
            this.buttonadd.ImageList = this.imageList1;
            this.buttonadd.Location = new System.Drawing.Point(452, 83);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(75, 37);
            this.buttonadd.TabIndex = 13;
            this.buttonadd.Text = "Add";
            this.buttonadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Visible = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // checkBoxSat
            // 
            this.checkBoxSat.AutoSize = true;
            this.checkBoxSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkBoxSat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSat.ForeColor = System.Drawing.Color.White;
            this.checkBoxSat.Location = new System.Drawing.Point(262, 112);
            this.checkBoxSat.Name = "checkBoxSat";
            this.checkBoxSat.Size = new System.Drawing.Size(78, 21);
            this.checkBoxSat.TabIndex = 11;
            this.checkBoxSat.Text = "Saturday";
            this.checkBoxSat.UseVisualStyleBackColor = false;
            this.checkBoxSat.Visible = false;
            // 
            // checkBoxFri
            // 
            this.checkBoxFri.AutoSize = true;
            this.checkBoxFri.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkBoxFri.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFri.ForeColor = System.Drawing.Color.White;
            this.checkBoxFri.Location = new System.Drawing.Point(172, 112);
            this.checkBoxFri.Name = "checkBoxFri";
            this.checkBoxFri.Size = new System.Drawing.Size(62, 21);
            this.checkBoxFri.TabIndex = 10;
            this.checkBoxFri.Text = "Friday";
            this.checkBoxFri.UseVisualStyleBackColor = false;
            this.checkBoxFri.Visible = false;
            // 
            // checkBoxThu
            // 
            this.checkBoxThu.AutoSize = true;
            this.checkBoxThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBoxThu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxThu.ForeColor = System.Drawing.Color.White;
            this.checkBoxThu.Location = new System.Drawing.Point(84, 112);
            this.checkBoxThu.Name = "checkBoxThu";
            this.checkBoxThu.Size = new System.Drawing.Size(80, 21);
            this.checkBoxThu.TabIndex = 9;
            this.checkBoxThu.Text = "Thursday";
            this.checkBoxThu.UseVisualStyleBackColor = false;
            this.checkBoxThu.Visible = false;
            // 
            // checkBoxWed
            // 
            this.checkBoxWed.AutoSize = true;
            this.checkBoxWed.BackColor = System.Drawing.Color.Lime;
            this.checkBoxWed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWed.Location = new System.Drawing.Point(352, 83);
            this.checkBoxWed.Name = "checkBoxWed";
            this.checkBoxWed.Size = new System.Drawing.Size(94, 21);
            this.checkBoxWed.TabIndex = 8;
            this.checkBoxWed.Text = "Wednesday";
            this.checkBoxWed.UseVisualStyleBackColor = false;
            this.checkBoxWed.Visible = false;
            // 
            // checkBoxTue
            // 
            this.checkBoxTue.AutoSize = true;
            this.checkBoxTue.BackColor = System.Drawing.Color.Magenta;
            this.checkBoxTue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTue.Location = new System.Drawing.Point(262, 83);
            this.checkBoxTue.Name = "checkBoxTue";
            this.checkBoxTue.Size = new System.Drawing.Size(75, 21);
            this.checkBoxTue.TabIndex = 7;
            this.checkBoxTue.Text = "Tuesday";
            this.checkBoxTue.UseVisualStyleBackColor = false;
            this.checkBoxTue.Visible = false;
            // 
            // checkBoxMon
            // 
            this.checkBoxMon.AutoSize = true;
            this.checkBoxMon.BackColor = System.Drawing.Color.Yellow;
            this.checkBoxMon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMon.Location = new System.Drawing.Point(172, 83);
            this.checkBoxMon.Name = "checkBoxMon";
            this.checkBoxMon.Size = new System.Drawing.Size(75, 21);
            this.checkBoxMon.TabIndex = 6;
            this.checkBoxMon.Text = "Monday";
            this.checkBoxMon.UseVisualStyleBackColor = false;
            this.checkBoxMon.Visible = false;
            // 
            // checkBoxSun
            // 
            this.checkBoxSun.AutoSize = true;
            this.checkBoxSun.BackColor = System.Drawing.Color.Red;
            this.checkBoxSun.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSun.ForeColor = System.Drawing.Color.White;
            this.checkBoxSun.Location = new System.Drawing.Point(84, 85);
            this.checkBoxSun.Name = "checkBoxSun";
            this.checkBoxSun.Size = new System.Drawing.Size(69, 21);
            this.checkBoxSun.TabIndex = 5;
            this.checkBoxSun.Text = "Sunday";
            this.checkBoxSun.UseVisualStyleBackColor = false;
            this.checkBoxSun.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 235);
            this.panel1.TabIndex = 3;
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Event";
            this.Text = "Event";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ComboBox comboBoxMin;
        public System.Windows.Forms.ComboBox comboBoxHour;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button buttonNEWEvent;
        public System.Windows.Forms.CheckBox checkBoxSat;
        public System.Windows.Forms.CheckBox checkBoxFri;
        public System.Windows.Forms.CheckBox checkBoxThu;
        public System.Windows.Forms.CheckBox checkBoxWed;
        public System.Windows.Forms.CheckBox checkBoxTue;
        public System.Windows.Forms.CheckBox checkBoxMon;
        public System.Windows.Forms.CheckBox checkBoxSun;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTimeRepeatUnit;
        private System.Windows.Forms.TextBox textBoxtimeRepeat;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sun;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Mon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Tue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Wed;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Thu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Fri;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Repeat;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepeatTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepeatTimeUnit;
    }
}