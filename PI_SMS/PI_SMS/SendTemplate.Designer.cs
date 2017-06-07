namespace PI_SMS
{
    partial class SendTemplate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxTemplate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.dataGridViewUserToSend = new System.Windows.Forms.DataGridView();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonGroup = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewAllUser = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridViewTemplate = new System.Windows.Forms.DataGridView();
            this.buttonManAdd = new System.Windows.Forms.Button();
            this.adduser = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FirstnameAvilableUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastnameAvilableUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneAvilableUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteUserToSend = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FirstnameToSend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameToSend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNoToSend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTemplate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Template = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemplateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserToSend)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllUser)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.buttonManAdd);
            this.panel1.Controls.Add(this.buttonGroup);
            this.panel1.Controls.Add(this.buttonUser);
            this.panel1.Controls.Add(this.buttonSend);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxTemplate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 78);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxTemplate
            // 
            this.comboBoxTemplate.FormattingEnabled = true;
            this.comboBoxTemplate.Location = new System.Drawing.Point(88, 12);
            this.comboBoxTemplate.Name = "comboBoxTemplate";
            this.comboBoxTemplate.Size = new System.Drawing.Size(135, 21);
            this.comboBoxTemplate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Template";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone No.";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(482, 42);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // dataGridViewUserToSend
            // 
            this.dataGridViewUserToSend.AllowUserToAddRows = false;
            this.dataGridViewUserToSend.AllowUserToDeleteRows = false;
            this.dataGridViewUserToSend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserToSend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeleteUserToSend,
            this.FirstnameToSend,
            this.LastNameToSend,
            this.PhoneNoToSend});
            this.dataGridViewUserToSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUserToSend.Location = new System.Drawing.Point(353, 48);
            this.dataGridViewUserToSend.Name = "dataGridViewUserToSend";
            this.dataGridViewUserToSend.RowHeadersVisible = false;
            this.dataGridViewUserToSend.Size = new System.Drawing.Size(344, 315);
            this.dataGridViewUserToSend.TabIndex = 0;
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(320, 41);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(75, 23);
            this.buttonUser.TabIndex = 5;
            this.buttonUser.Text = "User";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonGroup
            // 
            this.buttonGroup.Location = new System.Drawing.Point(401, 41);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonGroup.TabIndex = 6;
            this.buttonGroup.Text = "Group";
            this.buttonGroup.UseVisualStyleBackColor = true;
            this.buttonGroup.Click += new System.EventHandler(this.buttonGroup_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Crimson;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewUserToSend, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 78);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 274F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 366);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridViewAllUser
            // 
            this.dataGridViewAllUser.AllowUserToAddRows = false;
            this.dataGridViewAllUser.AllowUserToDeleteRows = false;
            this.dataGridViewAllUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adduser,
            this.FirstnameAvilableUser,
            this.LastnameAvilableUser,
            this.PhoneAvilableUser});
            this.dataGridViewAllUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAllUser.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAllUser.Name = "dataGridViewAllUser";
            this.dataGridViewAllUser.RowHeadersVisible = false;
            this.dataGridViewAllUser.Size = new System.Drawing.Size(344, 315);
            this.dataGridViewAllUser.TabIndex = 1;
            this.dataGridViewAllUser.Visible = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(66, 32);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.buttonRemove);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(353, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 39);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.buttonAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 39);
            this.panel3.TabIndex = 4;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(3, 3);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(66, 32);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.dataGridViewTemplate);
            this.panel4.Controls.Add(this.dataGridViewAllUser);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(344, 315);
            this.panel4.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(75, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "SelectAll";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridViewTemplate
            // 
            this.dataGridViewTemplate.AllowUserToAddRows = false;
            this.dataGridViewTemplate.AllowUserToDeleteRows = false;
            this.dataGridViewTemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTemplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addTemplate,
            this.Template,
            this.TemplateID});
            this.dataGridViewTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTemplate.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTemplate.Name = "dataGridViewTemplate";
            this.dataGridViewTemplate.RowHeadersVisible = false;
            this.dataGridViewTemplate.Size = new System.Drawing.Size(344, 315);
            this.dataGridViewTemplate.TabIndex = 2;
            this.dataGridViewTemplate.Visible = false;
            // 
            // buttonManAdd
            // 
            this.buttonManAdd.Location = new System.Drawing.Point(239, 41);
            this.buttonManAdd.Name = "buttonManAdd";
            this.buttonManAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonManAdd.TabIndex = 7;
            this.buttonManAdd.Text = "Add";
            this.buttonManAdd.UseVisualStyleBackColor = true;
            this.buttonManAdd.Click += new System.EventHandler(this.buttonManAdd_Click);
            // 
            // adduser
            // 
            this.adduser.HeaderText = "add";
            this.adduser.MinimumWidth = 35;
            this.adduser.Name = "adduser";
            this.adduser.Width = 35;
            // 
            // FirstnameAvilableUser
            // 
            this.FirstnameAvilableUser.HeaderText = "Firstname";
            this.FirstnameAvilableUser.MinimumWidth = 50;
            this.FirstnameAvilableUser.Name = "FirstnameAvilableUser";
            this.FirstnameAvilableUser.ReadOnly = true;
            // 
            // LastnameAvilableUser
            // 
            this.LastnameAvilableUser.HeaderText = "Lastname";
            this.LastnameAvilableUser.MinimumWidth = 50;
            this.LastnameAvilableUser.Name = "LastnameAvilableUser";
            this.LastnameAvilableUser.ReadOnly = true;
            // 
            // PhoneAvilableUser
            // 
            this.PhoneAvilableUser.HeaderText = "Phone";
            this.PhoneAvilableUser.MinimumWidth = 50;
            this.PhoneAvilableUser.Name = "PhoneAvilableUser";
            this.PhoneAvilableUser.ReadOnly = true;
            // 
            // DeleteUserToSend
            // 
            this.DeleteUserToSend.HeaderText = "Del";
            this.DeleteUserToSend.MinimumWidth = 35;
            this.DeleteUserToSend.Name = "DeleteUserToSend";
            this.DeleteUserToSend.Width = 35;
            // 
            // FirstnameToSend
            // 
            this.FirstnameToSend.HeaderText = "Firstname";
            this.FirstnameToSend.MinimumWidth = 50;
            this.FirstnameToSend.Name = "FirstnameToSend";
            this.FirstnameToSend.ReadOnly = true;
            this.FirstnameToSend.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FirstnameToSend.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LastNameToSend
            // 
            this.LastNameToSend.HeaderText = "LastName";
            this.LastNameToSend.MinimumWidth = 50;
            this.LastNameToSend.Name = "LastNameToSend";
            this.LastNameToSend.ReadOnly = true;
            this.LastNameToSend.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LastNameToSend.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PhoneNoToSend
            // 
            this.PhoneNoToSend.HeaderText = "Phone";
            this.PhoneNoToSend.MinimumWidth = 50;
            this.PhoneNoToSend.Name = "PhoneNoToSend";
            this.PhoneNoToSend.ReadOnly = true;
            // 
            // addTemplate
            // 
            this.addTemplate.HeaderText = "add";
            this.addTemplate.MinimumWidth = 35;
            this.addTemplate.Name = "addTemplate";
            this.addTemplate.Width = 35;
            // 
            // Template
            // 
            this.Template.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Template.HeaderText = "Template";
            this.Template.MinimumWidth = 50;
            this.Template.Name = "Template";
            this.Template.ReadOnly = true;
            // 
            // TemplateID
            // 
            this.TemplateID.HeaderText = "TemplateID";
            this.TemplateID.MinimumWidth = 50;
            this.TemplateID.Name = "TemplateID";
            this.TemplateID.Visible = false;
            // 
            // SendTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(700, 444);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "SendTemplate";
            this.Text = "SendTemplate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserToSend)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemplate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTemplate;
        private System.Windows.Forms.DataGridView dataGridViewUserToSend;
        private System.Windows.Forms.Button buttonGroup;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewAllUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridViewTemplate;
        private System.Windows.Forms.Button buttonManAdd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DeleteUserToSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstnameToSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameToSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNoToSend;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addTemplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Template;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemplateID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adduser;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstnameAvilableUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastnameAvilableUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneAvilableUser;
    }
}