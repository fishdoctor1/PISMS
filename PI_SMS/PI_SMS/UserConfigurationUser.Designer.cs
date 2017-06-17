using System.Drawing;
namespace PI_SMS
{
    partial class UserConfigurationUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserConfigurationUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUSERID = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBoxHandPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.panelUserConfig = new System.Windows.Forms.Panel();
            this.checkBoxSelectall = new System.Windows.Forms.CheckBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.UpdateUserConfig = new System.Windows.Forms.Button();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.SaveUserConfig = new System.Windows.Forms.Button();
            this.CancelUserConfig = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HandPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIDAuToInc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxUserID = new System.Windows.Forms.CheckBox();
            this.checkBoxPhone = new System.Windows.Forms.CheckBox();
            this.checkBoxLastName = new System.Windows.Forms.CheckBox();
            this.checkBoxFirstName = new System.Windows.Forms.CheckBox();
            this.SearchUser = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelUserConfig.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Configuration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "User ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(406, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(3, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Firstname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(5, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(406, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Confirm Password";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(406, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "HandPhone No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(406, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Role";
            // 
            // textBoxUSERID
            // 
            this.textBoxUSERID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxUSERID.Location = new System.Drawing.Point(79, 46);
            this.textBoxUSERID.Name = "textBoxUSERID";
            this.textBoxUSERID.Size = new System.Drawing.Size(305, 22);
            this.textBoxUSERID.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxPassword.Location = new System.Drawing.Point(528, 72);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(269, 22);
            this.textBoxPassword.TabIndex = 10;
            this.textBoxPassword.Visible = false;
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(528, 100);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(269, 22);
            this.textBoxConfirmPassword.TabIndex = 12;
            this.textBoxConfirmPassword.Visible = false;
            // 
            // textBoxHandPhone
            // 
            this.textBoxHandPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxHandPhone.Location = new System.Drawing.Point(528, 46);
            this.textBoxHandPhone.Name = "textBoxHandPhone";
            this.textBoxHandPhone.Size = new System.Drawing.Size(269, 22);
            this.textBoxHandPhone.TabIndex = 14;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxEmail.Location = new System.Drawing.Point(79, 126);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(305, 22);
            this.textBoxEmail.TabIndex = 15;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxFirstName.Location = new System.Drawing.Point(79, 72);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(305, 22);
            this.textBoxFirstName.TabIndex = 16;
            // 
            // panelUserConfig
            // 
            this.panelUserConfig.AutoScroll = true;
            this.panelUserConfig.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelUserConfig.Controls.Add(this.checkBoxSelectall);
            this.panelUserConfig.Controls.Add(this.buttonDelete);
            this.panelUserConfig.Controls.Add(this.textBoxLastName);
            this.panelUserConfig.Controls.Add(this.label12);
            this.panelUserConfig.Controls.Add(this.UpdateUserConfig);
            this.panelUserConfig.Controls.Add(this.comboBoxRole);
            this.panelUserConfig.Controls.Add(this.SaveUserConfig);
            this.panelUserConfig.Controls.Add(this.CancelUserConfig);
            this.panelUserConfig.Controls.Add(this.label1);
            this.panelUserConfig.Controls.Add(this.textBoxHandPhone);
            this.panelUserConfig.Controls.Add(this.textBoxConfirmPassword);
            this.panelUserConfig.Controls.Add(this.textBoxEmail);
            this.panelUserConfig.Controls.Add(this.textBoxFirstName);
            this.panelUserConfig.Controls.Add(this.textBoxPassword);
            this.panelUserConfig.Controls.Add(this.label3);
            this.panelUserConfig.Controls.Add(this.label5);
            this.panelUserConfig.Controls.Add(this.label6);
            this.panelUserConfig.Controls.Add(this.label8);
            this.panelUserConfig.Controls.Add(this.label4);
            this.panelUserConfig.Controls.Add(this.label7);
            this.panelUserConfig.Controls.Add(this.label9);
            this.panelUserConfig.Controls.Add(this.textBoxUSERID);
            this.panelUserConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserConfig.Location = new System.Drawing.Point(0, 0);
            this.panelUserConfig.Name = "panelUserConfig";
            this.panelUserConfig.Size = new System.Drawing.Size(895, 239);
            this.panelUserConfig.TabIndex = 17;
            // 
            // checkBoxSelectall
            // 
            this.checkBoxSelectall.AutoSize = true;
            this.checkBoxSelectall.Location = new System.Drawing.Point(12, 209);
            this.checkBoxSelectall.Name = "checkBoxSelectall";
            this.checkBoxSelectall.Size = new System.Drawing.Size(67, 17);
            this.checkBoxSelectall.TabIndex = 24;
            this.checkBoxSelectall.Text = "SelectAll";
            this.checkBoxSelectall.UseVisualStyleBackColor = true;
            this.checkBoxSelectall.CheckedChanged += new System.EventHandler(this.checkBoxSelectall_CheckedChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.ImageIndex = 1;
            this.buttonDelete.ImageList = this.imageList1;
            this.buttonDelete.Location = new System.Drawing.Point(6, 160);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(108, 44);
            this.buttonDelete.TabIndex = 23;
            this.buttonDelete.Text = "Remove";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ADD.ico");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            this.imageList1.Images.SetKeyName(2, "edit.ico");
            this.imageList1.Images.SetKeyName(3, "refresh1.ico");
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxLastName.Location = new System.Drawing.Point(79, 100);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(305, 22);
            this.textBoxLastName.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(3, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Lastname";
            // 
            // UpdateUserConfig
            // 
            this.UpdateUserConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.UpdateUserConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateUserConfig.ImageIndex = 2;
            this.UpdateUserConfig.ImageList = this.imageList1;
            this.UpdateUserConfig.Location = new System.Drawing.Point(140, 160);
            this.UpdateUserConfig.Name = "UpdateUserConfig";
            this.UpdateUserConfig.Size = new System.Drawing.Size(102, 44);
            this.UpdateUserConfig.TabIndex = 20;
            this.UpdateUserConfig.Text = "Update";
            this.UpdateUserConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateUserConfig.UseVisualStyleBackColor = true;
            this.UpdateUserConfig.Visible = false;
            this.UpdateUserConfig.Click += new System.EventHandler(this.UpdateUserConfig_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Admin",
            "User",
            "Supervisor"});
            this.comboBoxRole.Location = new System.Drawing.Point(528, 126);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(269, 24);
            this.comboBoxRole.TabIndex = 19;
            // 
            // SaveUserConfig
            // 
            this.SaveUserConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SaveUserConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveUserConfig.ImageIndex = 0;
            this.SaveUserConfig.ImageList = this.imageList1;
            this.SaveUserConfig.Location = new System.Drawing.Point(140, 160);
            this.SaveUserConfig.Name = "SaveUserConfig";
            this.SaveUserConfig.Size = new System.Drawing.Size(81, 44);
            this.SaveUserConfig.TabIndex = 18;
            this.SaveUserConfig.Text = "Add";
            this.SaveUserConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveUserConfig.UseVisualStyleBackColor = true;
            this.SaveUserConfig.Click += new System.EventHandler(this.SaveUserConfig_Click);
            // 
            // CancelUserConfig
            // 
            this.CancelUserConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CancelUserConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelUserConfig.ImageIndex = 3;
            this.CancelUserConfig.ImageList = this.imageList1;
            this.CancelUserConfig.Location = new System.Drawing.Point(248, 160);
            this.CancelUserConfig.Name = "CancelUserConfig";
            this.CancelUserConfig.Size = new System.Drawing.Size(92, 44);
            this.CancelUserConfig.TabIndex = 17;
            this.CancelUserConfig.Text = "Cancel";
            this.CancelUserConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelUserConfig.UseVisualStyleBackColor = true;
            this.CancelUserConfig.Click += new System.EventHandler(this.CancelUserConfig_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.77964F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.22036F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(889, 194);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDelete,
            this.UserID,
            this.FirstName,
            this.LastName,
            this.Email,
            this.HandPhoneNo,
            this.UserIDAuToInc,
            this.Role});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(649, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Delete";
            this.ColumnDelete.MinimumWidth = 20;
            this.ColumnDelete.Name = "ColumnDelete";
            // 
            // UserID
            // 
            this.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 120;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 120;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 120;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 170;
            // 
            // HandPhoneNo
            // 
            this.HandPhoneNo.HeaderText = "HandPhone";
            this.HandPhoneNo.Name = "HandPhoneNo";
            this.HandPhoneNo.ReadOnly = true;
            this.HandPhoneNo.Width = 120;
            // 
            // UserIDAuToInc
            // 
            this.UserIDAuToInc.HeaderText = "UserIDAuToInc";
            this.UserIDAuToInc.Name = "UserIDAuToInc";
            this.UserIDAuToInc.ReadOnly = true;
            this.UserIDAuToInc.Visible = false;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.checkBoxUserID);
            this.panel3.Controls.Add(this.checkBoxPhone);
            this.panel3.Controls.Add(this.checkBoxLastName);
            this.panel3.Controls.Add(this.checkBoxFirstName);
            this.panel3.Controls.Add(this.SearchUser);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(658, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 188);
            this.panel3.TabIndex = 1;
            // 
            // checkBoxUserID
            // 
            this.checkBoxUserID.AutoSize = true;
            this.checkBoxUserID.Location = new System.Drawing.Point(86, 30);
            this.checkBoxUserID.Name = "checkBoxUserID";
            this.checkBoxUserID.Size = new System.Drawing.Size(59, 17);
            this.checkBoxUserID.TabIndex = 7;
            this.checkBoxUserID.Text = "UserID";
            this.checkBoxUserID.UseVisualStyleBackColor = true;
            this.checkBoxUserID.Visible = false;
            this.checkBoxUserID.CheckedChanged += new System.EventHandler(this.checkBoxUserID_CheckedChanged);
            // 
            // checkBoxPhone
            // 
            this.checkBoxPhone.AutoSize = true;
            this.checkBoxPhone.Location = new System.Drawing.Point(7, 30);
            this.checkBoxPhone.Name = "checkBoxPhone";
            this.checkBoxPhone.Size = new System.Drawing.Size(57, 17);
            this.checkBoxPhone.TabIndex = 6;
            this.checkBoxPhone.Text = "Phone";
            this.checkBoxPhone.UseVisualStyleBackColor = true;
            this.checkBoxPhone.Visible = false;
            this.checkBoxPhone.CheckedChanged += new System.EventHandler(this.checkBoxPhone_CheckedChanged);
            // 
            // checkBoxLastName
            // 
            this.checkBoxLastName.AutoSize = true;
            this.checkBoxLastName.Location = new System.Drawing.Point(86, 49);
            this.checkBoxLastName.Name = "checkBoxLastName";
            this.checkBoxLastName.Size = new System.Drawing.Size(74, 17);
            this.checkBoxLastName.TabIndex = 5;
            this.checkBoxLastName.Text = "LastName";
            this.checkBoxLastName.UseVisualStyleBackColor = true;
            this.checkBoxLastName.Visible = false;
            this.checkBoxLastName.CheckedChanged += new System.EventHandler(this.checkBoxLastName_CheckedChanged);
            // 
            // checkBoxFirstName
            // 
            this.checkBoxFirstName.AutoSize = true;
            this.checkBoxFirstName.Checked = true;
            this.checkBoxFirstName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFirstName.Location = new System.Drawing.Point(7, 49);
            this.checkBoxFirstName.Name = "checkBoxFirstName";
            this.checkBoxFirstName.Size = new System.Drawing.Size(73, 17);
            this.checkBoxFirstName.TabIndex = 4;
            this.checkBoxFirstName.Text = "FirstName";
            this.checkBoxFirstName.UseVisualStyleBackColor = true;
            this.checkBoxFirstName.CheckedChanged += new System.EventHandler(this.checkBoxFirstName_CheckedChanged);
            // 
            // SearchUser
            // 
            this.SearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SearchUser.Location = new System.Drawing.Point(3, 100);
            this.SearchUser.Name = "SearchUser";
            this.SearchUser.Size = new System.Drawing.Size(75, 32);
            this.SearchUser.TabIndex = 2;
            this.SearchUser.Text = "Search";
            this.SearchUser.UseVisualStyleBackColor = true;
            this.SearchUser.Click += new System.EventHandler(this.SearchUser_Click);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox5.Location = new System.Drawing.Point(3, 72);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(202, 22);
            this.textBox5.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 27);
            this.label10.TabIndex = 0;
            this.label10.Text = "Search";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panelUserConfig);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(895, 468);
            this.panel4.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 229);
            this.panel1.TabIndex = 18;
            // 
            // UserConfigurationUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(895, 468);
            this.Controls.Add(this.panel4);
            this.Name = "UserConfigurationUser";
            this.Text = "UserConfigurationUser";
            this.panelUserConfig.ResumeLayout(false);
            this.panelUserConfig.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUSERID;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.TextBox textBoxHandPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Panel panelUserConfig;
        private System.Windows.Forms.Button SaveUserConfig;
        private System.Windows.Forms.Button CancelUserConfig;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SearchUser;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpdateUserConfig;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxLastName;
        private System.Windows.Forms.CheckBox checkBoxFirstName;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn HandPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDAuToInc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.CheckBox checkBoxPhone;
        private System.Windows.Forms.CheckBox checkBoxUserID;
        private System.Windows.Forms.CheckBox checkBoxSelectall;
    }
}