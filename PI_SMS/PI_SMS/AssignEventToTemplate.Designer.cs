namespace PI_SMS
{
    partial class AssignEventToTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignEventToTemplate));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxTemplate = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridViewAvilableEvent = new System.Windows.Forms.DataGridView();
            this.ADD = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EventNameAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventIDAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewevent_in_template = new System.Windows.Forms.DataGridView();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Tue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Wed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Thu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Fri = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sun = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelnumberEventinTemplate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxAdd = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvilableEvent)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewevent_in_template)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTemplate
            // 
            this.comboBoxTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxTemplate.FormattingEnabled = true;
            this.comboBoxTemplate.IntegralHeight = false;
            this.comboBoxTemplate.Location = new System.Drawing.Point(114, 18);
            this.comboBoxTemplate.MaxDropDownItems = 5;
            this.comboBoxTemplate.Name = "comboBoxTemplate";
            this.comboBoxTemplate.Size = new System.Drawing.Size(308, 24);
            this.comboBoxTemplate.TabIndex = 18;
            this.comboBoxTemplate.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemplate_SelectedIndexChanged);
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
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonadd.ForeColor = System.Drawing.Color.White;
            this.buttonadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonadd.ImageIndex = 0;
            this.buttonadd.ImageList = this.imageList1;
            this.buttonadd.Location = new System.Drawing.Point(109, 22);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(67, 37);
            this.buttonadd.TabIndex = 13;
            this.buttonadd.Text = "Add";
            this.buttonadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "TemplateName:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 348);
            this.panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.YellowGreen;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 279F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 581F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 510F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 348);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.dataGridViewAvilableEvent);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 93);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(273, 504);
            this.panel6.TabIndex = 2;
            // 
            // dataGridViewAvilableEvent
            // 
            this.dataGridViewAvilableEvent.AllowUserToAddRows = false;
            this.dataGridViewAvilableEvent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAvilableEvent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAvilableEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvilableEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ADD,
            this.EventNameAdd,
            this.EventIDAdd});
            this.dataGridViewAvilableEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAvilableEvent.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAvilableEvent.MultiSelect = false;
            this.dataGridViewAvilableEvent.Name = "dataGridViewAvilableEvent";
            this.dataGridViewAvilableEvent.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dataGridViewAvilableEvent.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAvilableEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAvilableEvent.Size = new System.Drawing.Size(273, 504);
            this.dataGridViewAvilableEvent.TabIndex = 1;
            this.dataGridViewAvilableEvent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseClick);
            // 
            // ADD
            // 
            this.ADD.HeaderText = "ADD";
            this.ADD.MinimumWidth = 50;
            this.ADD.Name = "ADD";
            this.ADD.Width = 50;
            // 
            // EventNameAdd
            // 
            this.EventNameAdd.HeaderText = "EventName";
            this.EventNameAdd.MinimumWidth = 230;
            this.EventNameAdd.Name = "EventNameAdd";
            this.EventNameAdd.ReadOnly = true;
            this.EventNameAdd.Width = 230;
            // 
            // EventIDAdd
            // 
            this.EventIDAdd.HeaderText = "EventID";
            this.EventIDAdd.MinimumWidth = 20;
            this.EventIDAdd.Name = "EventIDAdd";
            this.EventIDAdd.ReadOnly = true;
            this.EventIDAdd.Visible = false;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.dataGridViewevent_in_template);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(282, 93);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(575, 504);
            this.panel5.TabIndex = 2;
            // 
            // dataGridViewevent_in_template
            // 
            this.dataGridViewevent_in_template.AllowUserToAddRows = false;
            this.dataGridViewevent_in_template.AllowUserToDeleteRows = false;
            this.dataGridViewevent_in_template.BackgroundColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewevent_in_template.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewevent_in_template.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewevent_in_template.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventName,
            this.Mon,
            this.Tue,
            this.Wed,
            this.Thu,
            this.Fri,
            this.Sat,
            this.Sun,
            this.Time,
            this.EventID});
            this.dataGridViewevent_in_template.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewevent_in_template.EnableHeadersVisualStyles = false;
            this.dataGridViewevent_in_template.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewevent_in_template.Name = "dataGridViewevent_in_template";
            this.dataGridViewevent_in_template.ReadOnly = true;
            this.dataGridViewevent_in_template.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dataGridViewevent_in_template.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewevent_in_template.RowTemplate.Height = 24;
            this.dataGridViewevent_in_template.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewevent_in_template.Size = new System.Drawing.Size(575, 504);
            this.dataGridViewevent_in_template.TabIndex = 0;
            this.dataGridViewevent_in_template.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewevent_in_template_MouseClick);
            // 
            // EventName
            // 
            this.EventName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EventName.HeaderText = "EventName";
            this.EventName.MinimumWidth = 150;
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            // 
            // Mon
            // 
            this.Mon.HeaderText = "Mon";
            this.Mon.MinimumWidth = 50;
            this.Mon.Name = "Mon";
            this.Mon.ReadOnly = true;
            this.Mon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Mon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Mon.Width = 50;
            // 
            // Tue
            // 
            this.Tue.HeaderText = "Tue";
            this.Tue.MinimumWidth = 50;
            this.Tue.Name = "Tue";
            this.Tue.ReadOnly = true;
            this.Tue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Tue.Width = 50;
            // 
            // Wed
            // 
            this.Wed.HeaderText = "Wed";
            this.Wed.MinimumWidth = 50;
            this.Wed.Name = "Wed";
            this.Wed.ReadOnly = true;
            this.Wed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Wed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Wed.Width = 50;
            // 
            // Thu
            // 
            this.Thu.HeaderText = "Thu";
            this.Thu.MinimumWidth = 50;
            this.Thu.Name = "Thu";
            this.Thu.ReadOnly = true;
            this.Thu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Thu.Width = 50;
            // 
            // Fri
            // 
            this.Fri.HeaderText = "Fri";
            this.Fri.MinimumWidth = 50;
            this.Fri.Name = "Fri";
            this.Fri.ReadOnly = true;
            this.Fri.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Fri.Width = 50;
            // 
            // Sat
            // 
            this.Sat.HeaderText = "Sat";
            this.Sat.MinimumWidth = 50;
            this.Sat.Name = "Sat";
            this.Sat.ReadOnly = true;
            this.Sat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sat.Width = 50;
            // 
            // Sun
            // 
            this.Sun.HeaderText = "Sun";
            this.Sun.MinimumWidth = 50;
            this.Sun.Name = "Sun";
            this.Sun.ReadOnly = true;
            this.Sun.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sun.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sun.Width = 50;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 50;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // EventID
            // 
            this.EventID.HeaderText = "EventID";
            this.EventID.Name = "EventID";
            this.EventID.ReadOnly = true;
            this.EventID.Visible = false;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.PaleGreen;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.labelnumberEventinTemplate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(282, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(575, 84);
            this.panel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Event in Template";
            // 
            // labelnumberEventinTemplate
            // 
            this.labelnumberEventinTemplate.AutoSize = true;
            this.labelnumberEventinTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelnumberEventinTemplate.Location = new System.Drawing.Point(125, 59);
            this.labelnumberEventinTemplate.Name = "labelnumberEventinTemplate";
            this.labelnumberEventinTemplate.Size = new System.Drawing.Size(45, 16);
            this.labelnumberEventinTemplate.TabIndex = 0;
            this.labelnumberEventinTemplate.Text = "label4";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.PaleGreen;
            this.panel3.Controls.Add(this.checkBoxAdd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.buttonadd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 84);
            this.panel3.TabIndex = 15;
            // 
            // checkBoxAdd
            // 
            this.checkBoxAdd.AutoSize = true;
            this.checkBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBoxAdd.Location = new System.Drawing.Point(12, 39);
            this.checkBoxAdd.Name = "checkBoxAdd";
            this.checkBoxAdd.Size = new System.Drawing.Size(80, 20);
            this.checkBoxAdd.TabIndex = 15;
            this.checkBoxAdd.Text = "SelectAll";
            this.checkBoxAdd.UseVisualStyleBackColor = true;
            this.checkBoxAdd.CheckedChanged += new System.EventHandler(this.checkBoxAdd_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Avilable Event";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.comboBoxTemplate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 71);
            this.panel2.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(666, 15);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(114, 29);
            this.buttonSearch.TabIndex = 28;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(482, 20);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(178, 20);
            this.textBoxSearch.TabIndex = 26;
            // 
            // AssignEventToTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AssignEventToTemplate";
            this.Text = "AssignEventToTemplate";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvilableEvent)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewevent_in_template)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxTemplate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewevent_in_template;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewAvilableEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Mon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Tue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Wed;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Thu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Fri;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBoxAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelnumberEventinTemplate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ADD;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventNameAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventIDAdd;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
    }
}