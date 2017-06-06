namespace PI_SMS
{
    partial class AssignUserToRealTimeGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignUserToRealTimeGroup));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBoxDeleteAll = new System.Windows.Forms.CheckBox();
            this.labelnumberUserinTemplate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewUserinGroup = new System.Windows.Forms.DataGridView();
            this.del = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UserIDIngroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIDAuToIncInGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAvilableuser = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UserIDadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIDAuToIncadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserinGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvilableuser)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.IntegralHeight = false;
            this.comboBoxGroup.Location = new System.Drawing.Point(164, 56);
            this.comboBoxGroup.MaxDropDownItems = 5;
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(236, 24);
            this.comboBoxGroup.TabIndex = 7;
            this.comboBoxGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroup_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.comboBoxGroup);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxUserID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 114);
            this.panel1.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(406, 17);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 30);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "RealTimeGroup";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxUserID.Location = new System.Drawing.Point(164, 20);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(236, 22);
            this.textBoxUserID.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 301);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Cyan;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewUserinGroup, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewAvilableuser, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 301);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkBoxDeleteAll);
            this.panel4.Controls.Add(this.labelnumberUserinTemplate);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.buttonRemove);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(392, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(383, 86);
            this.panel4.TabIndex = 3;
            // 
            // checkBoxDeleteAll
            // 
            this.checkBoxDeleteAll.AutoSize = true;
            this.checkBoxDeleteAll.Location = new System.Drawing.Point(6, 33);
            this.checkBoxDeleteAll.Name = "checkBoxDeleteAll";
            this.checkBoxDeleteAll.Size = new System.Drawing.Size(67, 17);
            this.checkBoxDeleteAll.TabIndex = 4;
            this.checkBoxDeleteAll.Text = "SelectAll";
            this.checkBoxDeleteAll.UseVisualStyleBackColor = true;
            this.checkBoxDeleteAll.CheckedChanged += new System.EventHandler(this.checkBoxDeleteAll_CheckedChanged);
            // 
            // labelnumberUserinTemplate
            // 
            this.labelnumberUserinTemplate.AutoSize = true;
            this.labelnumberUserinTemplate.Location = new System.Drawing.Point(142, 15);
            this.labelnumberUserinTemplate.Name = "labelnumberUserinTemplate";
            this.labelnumberUserinTemplate.Size = new System.Drawing.Size(13, 13);
            this.labelnumberUserinTemplate.TabIndex = 3;
            this.labelnumberUserinTemplate.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "User In RealTimeGroup";
            // 
            // buttonRemove
            // 
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemove.ImageIndex = 1;
            this.buttonRemove.ImageList = this.imageList1;
            this.buttonRemove.Location = new System.Drawing.Point(77, 33);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(44, 43);
            this.buttonRemove.TabIndex = 0;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ADD.ico");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            // 
            // dataGridViewUserinGroup
            // 
            this.dataGridViewUserinGroup.AllowUserToAddRows = false;
            this.dataGridViewUserinGroup.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dataGridViewUserinGroup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserinGroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewUserinGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserinGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.del,
            this.UserIDIngroup,
            this.UserIDAuToIncInGroup});
            this.dataGridViewUserinGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUserinGroup.Location = new System.Drawing.Point(392, 95);
            this.dataGridViewUserinGroup.MultiSelect = false;
            this.dataGridViewUserinGroup.Name = "dataGridViewUserinGroup";
            this.dataGridViewUserinGroup.RowHeadersVisible = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dataGridViewUserinGroup.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewUserinGroup.RowTemplate.Height = 26;
            this.dataGridViewUserinGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUserinGroup.Size = new System.Drawing.Size(383, 203);
            this.dataGridViewUserinGroup.TabIndex = 0;
            this.dataGridViewUserinGroup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewUserinGroup_MouseClick);
            // 
            // del
            // 
            this.del.HeaderText = "del";
            this.del.Name = "del";
            this.del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.del.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UserIDIngroup
            // 
            this.UserIDIngroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserIDIngroup.HeaderText = "UserID";
            this.UserIDIngroup.MinimumWidth = 150;
            this.UserIDIngroup.Name = "UserIDIngroup";
            this.UserIDIngroup.ReadOnly = true;
            // 
            // UserIDAuToIncInGroup
            // 
            this.UserIDAuToIncInGroup.HeaderText = "UserIDAuToInc";
            this.UserIDAuToIncInGroup.Name = "UserIDAuToIncInGroup";
            this.UserIDAuToIncInGroup.Visible = false;
            // 
            // dataGridViewAvilableuser
            // 
            this.dataGridViewAvilableuser.AllowUserToAddRows = false;
            this.dataGridViewAvilableuser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dataGridViewAvilableuser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAvilableuser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewAvilableuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvilableuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.add,
            this.UserIDadd,
            this.UserIDAuToIncadd});
            this.dataGridViewAvilableuser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAvilableuser.Location = new System.Drawing.Point(3, 95);
            this.dataGridViewAvilableuser.MultiSelect = false;
            this.dataGridViewAvilableuser.Name = "dataGridViewAvilableuser";
            this.dataGridViewAvilableuser.RowHeadersVisible = false;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dataGridViewAvilableuser.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewAvilableuser.RowTemplate.Height = 26;
            this.dataGridViewAvilableuser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAvilableuser.Size = new System.Drawing.Size(383, 203);
            this.dataGridViewAvilableuser.TabIndex = 1;
            this.dataGridViewAvilableuser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewAvilableuser_MouseClick);
            // 
            // add
            // 
            this.add.HeaderText = "add";
            this.add.Name = "add";
            this.add.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UserIDadd
            // 
            this.UserIDadd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserIDadd.HeaderText = "UserID";
            this.UserIDadd.MinimumWidth = 150;
            this.UserIDadd.Name = "UserIDadd";
            this.UserIDadd.ReadOnly = true;
            // 
            // UserIDAuToIncadd
            // 
            this.UserIDAuToIncadd.HeaderText = "UserIDAuToInc";
            this.UserIDAuToIncadd.Name = "UserIDAuToIncadd";
            this.UserIDAuToIncadd.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.buttonAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 86);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Avilable User";
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.ImageIndex = 0;
            this.buttonAdd.ImageList = this.imageList1;
            this.buttonAdd.Location = new System.Drawing.Point(12, 33);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(41, 43);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AssignUserToRealTimeGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 415);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AssignUserToRealTimeGroup";
            this.Text = "AssignUserToRealTimeGroup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserinGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvilableuser)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewUserinGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewAvilableuser;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelnumberUserinTemplate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn add;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDAuToIncadd;
        private System.Windows.Forms.CheckBox checkBoxDeleteAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn del;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDIngroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDAuToIncInGroup;
    }
}