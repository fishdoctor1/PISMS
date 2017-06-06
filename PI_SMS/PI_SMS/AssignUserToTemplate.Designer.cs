namespace PI_SMS
{
    partial class AssignUserToTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignUserToTemplate));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBoxLastName = new System.Windows.Forms.CheckBox();
            this.checkBoxFirstName = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxTemplate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAddAll = new System.Windows.Forms.CheckBox();
            this.labelnumberUserinTemplate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxDeleteAll = new System.Windows.Forms.CheckBox();
            this.buttonselect = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonAddSelected = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewAdd = new System.Windows.Forms.DataGridView();
            this.CheckBoxADD = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UserIDAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIDAuToIncAllUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewUserInTemplate = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIDAuToInc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdd)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInTemplate)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.checkBoxLastName);
            this.panel1.Controls.Add(this.checkBoxFirstName);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBoxTemplate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 69);
            this.panel1.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonSearch.Location = new System.Drawing.Point(824, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(97, 28);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // checkBoxLastName
            // 
            this.checkBoxLastName.AutoSize = true;
            this.checkBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBoxLastName.Location = new System.Drawing.Point(463, 12);
            this.checkBoxLastName.Name = "checkBoxLastName";
            this.checkBoxLastName.Size = new System.Drawing.Size(113, 28);
            this.checkBoxLastName.TabIndex = 8;
            this.checkBoxLastName.Text = "LastName";
            this.checkBoxLastName.UseVisualStyleBackColor = true;
            this.checkBoxLastName.CheckedChanged += new System.EventHandler(this.checkBoxLastName_CheckedChanged);
            // 
            // checkBoxFirstName
            // 
            this.checkBoxFirstName.AutoSize = true;
            this.checkBoxFirstName.Checked = true;
            this.checkBoxFirstName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBoxFirstName.Location = new System.Drawing.Point(342, 12);
            this.checkBoxFirstName.Name = "checkBoxFirstName";
            this.checkBoxFirstName.Size = new System.Drawing.Size(115, 28);
            this.checkBoxFirstName.TabIndex = 7;
            this.checkBoxFirstName.Text = "FirstName";
            this.checkBoxFirstName.UseVisualStyleBackColor = true;
            this.checkBoxFirstName.CheckedChanged += new System.EventHandler(this.checkBoxFirstName_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(582, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 22);
            this.textBox1.TabIndex = 6;
            // 
            // comboBoxTemplate
            // 
            this.comboBoxTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxTemplate.FormattingEnabled = true;
            this.comboBoxTemplate.IntegralHeight = false;
            this.comboBoxTemplate.Location = new System.Drawing.Point(124, 6);
            this.comboBoxTemplate.MaxDropDownItems = 5;
            this.comboBoxTemplate.Name = "comboBoxTemplate";
            this.comboBoxTemplate.Size = new System.Drawing.Size(212, 32);
            this.comboBoxTemplate.TabIndex = 1;
            this.comboBoxTemplate.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemplate_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TemplateID";
            // 
            // checkBoxAddAll
            // 
            this.checkBoxAddAll.AutoSize = true;
            this.checkBoxAddAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBoxAddAll.Location = new System.Drawing.Point(9, 34);
            this.checkBoxAddAll.Name = "checkBoxAddAll";
            this.checkBoxAddAll.Size = new System.Drawing.Size(80, 20);
            this.checkBoxAddAll.TabIndex = 13;
            this.checkBoxAddAll.Text = "SelectAll";
            this.checkBoxAddAll.UseVisualStyleBackColor = true;
            this.checkBoxAddAll.CheckedChanged += new System.EventHandler(this.checkBoxAddAll_CheckedChanged);
            // 
            // labelnumberUserinTemplate
            // 
            this.labelnumberUserinTemplate.AutoSize = true;
            this.labelnumberUserinTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelnumberUserinTemplate.Location = new System.Drawing.Point(132, 12);
            this.labelnumberUserinTemplate.Name = "labelnumberUserinTemplate";
            this.labelnumberUserinTemplate.Size = new System.Drawing.Size(45, 16);
            this.labelnumberUserinTemplate.TabIndex = 12;
            this.labelnumberUserinTemplate.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "User in Template";
            // 
            // checkBoxDeleteAll
            // 
            this.checkBoxDeleteAll.AutoSize = true;
            this.checkBoxDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBoxDeleteAll.Location = new System.Drawing.Point(6, 34);
            this.checkBoxDeleteAll.Name = "checkBoxDeleteAll";
            this.checkBoxDeleteAll.Size = new System.Drawing.Size(80, 20);
            this.checkBoxDeleteAll.TabIndex = 10;
            this.checkBoxDeleteAll.Text = "SelectAll";
            this.checkBoxDeleteAll.UseVisualStyleBackColor = true;
            this.checkBoxDeleteAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // buttonselect
            // 
            this.buttonselect.BackColor = System.Drawing.Color.Crimson;
            this.buttonselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonselect.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonselect.ImageIndex = 2;
            this.buttonselect.ImageList = this.imageList1;
            this.buttonselect.Location = new System.Drawing.Point(92, 31);
            this.buttonselect.Name = "buttonselect";
            this.buttonselect.Size = new System.Drawing.Size(115, 40);
            this.buttonselect.TabIndex = 5;
            this.buttonselect.Text = "Remove";
            this.buttonselect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonselect.UseVisualStyleBackColor = false;
            this.buttonselect.Click += new System.EventHandler(this.buttonselect_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ADD.ico");
            this.imageList1.Images.SetKeyName(1, "refresh1.ico");
            this.imageList1.Images.SetKeyName(2, "delete.png");
            // 
            // buttonAddSelected
            // 
            this.buttonAddSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAddSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonAddSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddSelected.ImageIndex = 0;
            this.buttonAddSelected.ImageList = this.imageList1;
            this.buttonAddSelected.Location = new System.Drawing.Point(95, 28);
            this.buttonAddSelected.Name = "buttonAddSelected";
            this.buttonAddSelected.Size = new System.Drawing.Size(79, 43);
            this.buttonAddSelected.TabIndex = 4;
            this.buttonAddSelected.Text = "Add";
            this.buttonAddSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddSelected.UseVisualStyleBackColor = false;
            this.buttonAddSelected.Click += new System.EventHandler(this.buttonAddSelected_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Magenta;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 311);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Thistle;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewAdd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewUserInTemplate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(945, 311);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridViewAdd
            // 
            this.dataGridViewAdd.AllowUserToAddRows = false;
            this.dataGridViewAdd.AllowUserToDeleteRows = false;
            this.dataGridViewAdd.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridViewAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxADD,
            this.UserIDAdd,
            this.FirstNameAdd,
            this.LastNameAdd,
            this.UserIDAuToIncAllUser});
            this.dataGridViewAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAdd.EnableHeadersVisualStyles = false;
            this.dataGridViewAdd.Location = new System.Drawing.Point(3, 88);
            this.dataGridViewAdd.MultiSelect = false;
            this.dataGridViewAdd.Name = "dataGridViewAdd";
            this.dataGridViewAdd.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dataGridViewAdd.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAdd.RowTemplate.Height = 26;
            this.dataGridViewAdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdd.Size = new System.Drawing.Size(466, 220);
            this.dataGridViewAdd.TabIndex = 1;
            this.dataGridViewAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewAdd_MouseClick);
            // 
            // CheckBoxADD
            // 
            this.CheckBoxADD.HeaderText = "ADD";
            this.CheckBoxADD.MinimumWidth = 100;
            this.CheckBoxADD.Name = "CheckBoxADD";
            // 
            // UserIDAdd
            // 
            this.UserIDAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserIDAdd.HeaderText = "UserID";
            this.UserIDAdd.MinimumWidth = 150;
            this.UserIDAdd.Name = "UserIDAdd";
            this.UserIDAdd.ReadOnly = true;
            this.UserIDAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserIDAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FirstNameAdd
            // 
            this.FirstNameAdd.HeaderText = "FirstName";
            this.FirstNameAdd.MinimumWidth = 150;
            this.FirstNameAdd.Name = "FirstNameAdd";
            this.FirstNameAdd.ReadOnly = true;
            this.FirstNameAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FirstNameAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FirstNameAdd.Width = 150;
            // 
            // LastNameAdd
            // 
            this.LastNameAdd.HeaderText = "LastName";
            this.LastNameAdd.MinimumWidth = 150;
            this.LastNameAdd.Name = "LastNameAdd";
            this.LastNameAdd.ReadOnly = true;
            this.LastNameAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LastNameAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LastNameAdd.Width = 150;
            // 
            // UserIDAuToIncAllUser
            // 
            this.UserIDAuToIncAllUser.HeaderText = "UserIDAuToIncAllUser";
            this.UserIDAuToIncAllUser.Name = "UserIDAuToIncAllUser";
            this.UserIDAuToIncAllUser.ReadOnly = true;
            this.UserIDAuToIncAllUser.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.checkBoxAddAll);
            this.panel3.Controls.Add(this.buttonAddSelected);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(466, 79);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Available User";
            // 
            // dataGridViewUserInTemplate
            // 
            this.dataGridViewUserInTemplate.AllowUserToAddRows = false;
            this.dataGridViewUserInTemplate.AllowUserToDeleteRows = false;
            this.dataGridViewUserInTemplate.BackgroundColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserInTemplate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUserInTemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserInTemplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.UserID,
            this.FirstName,
            this.LastName,
            this.CellPhone,
            this.UserIDAuToInc});
            this.dataGridViewUserInTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUserInTemplate.EnableHeadersVisualStyles = false;
            this.dataGridViewUserInTemplate.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewUserInTemplate.Location = new System.Drawing.Point(475, 88);
            this.dataGridViewUserInTemplate.MultiSelect = false;
            this.dataGridViewUserInTemplate.Name = "dataGridViewUserInTemplate";
            this.dataGridViewUserInTemplate.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dataGridViewUserInTemplate.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUserInTemplate.RowTemplate.Height = 26;
            this.dataGridViewUserInTemplate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUserInTemplate.Size = new System.Drawing.Size(467, 220);
            this.dataGridViewUserInTemplate.TabIndex = 0;
            this.dataGridViewUserInTemplate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // UserID
            // 
            this.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 120;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 120;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 200;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 200;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 200;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 200;
            // 
            // CellPhone
            // 
            this.CellPhone.HeaderText = "CellPhone";
            this.CellPhone.MinimumWidth = 150;
            this.CellPhone.Name = "CellPhone";
            this.CellPhone.Width = 150;
            // 
            // UserIDAuToInc
            // 
            this.UserIDAuToInc.HeaderText = "UserIDAuToInc";
            this.UserIDAuToInc.MinimumWidth = 200;
            this.UserIDAuToInc.Name = "UserIDAuToInc";
            this.UserIDAuToInc.ReadOnly = true;
            this.UserIDAuToInc.Visible = false;
            this.UserIDAuToInc.Width = 200;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelnumberUserinTemplate);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.checkBoxDeleteAll);
            this.panel4.Controls.Add(this.buttonselect);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(475, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(467, 79);
            this.panel4.TabIndex = 2;
            // 
            // AssignUserToTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 380);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AssignUserToTemplate";
            this.Text = "GroupReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdd)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInTemplate)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewUserInTemplate;
        private System.Windows.Forms.ComboBox comboBoxTemplate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonAddSelected;
        public System.Windows.Forms.DataGridView dataGridViewAdd;
        private System.Windows.Forms.Button buttonselect;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.CheckBox checkBoxLastName;
        private System.Windows.Forms.CheckBox checkBoxFirstName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxADD;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDAuToIncAllUser;
        private System.Windows.Forms.CheckBox checkBoxDeleteAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDAuToInc;
        private System.Windows.Forms.Label labelnumberUserinTemplate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxAddAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}