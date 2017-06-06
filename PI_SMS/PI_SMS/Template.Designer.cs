using System.Drawing;
namespace PI_SMS
{
    partial class Template
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Template));
            this.dataGridViewTemplate = new System.Windows.Forms.DataGridView();
            this.TemplateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SMSCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TemplateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonUpdateStatusSMS = new System.Windows.Forms.Button();
            this.checkBoxDisablAll = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableAll = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdateTemplate = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxTemplate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemplate)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTemplate
            // 
            this.dataGridViewTemplate.AllowUserToAddRows = false;
            this.dataGridViewTemplate.AllowUserToDeleteRows = false;
            this.dataGridViewTemplate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewTemplate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTemplate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTemplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TemplateName,
            this.DescriptionCol,
            this.SMSCol,
            this.TemplateID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTemplate.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTemplate.EnableHeadersVisualStyles = false;
            this.dataGridViewTemplate.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewTemplate.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTemplate.MultiSelect = false;
            this.dataGridViewTemplate.Name = "dataGridViewTemplate";
            this.dataGridViewTemplate.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTemplate.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTemplate.RowHeadersVisible = false;
            this.dataGridViewTemplate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dataGridViewTemplate.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTemplate.RowTemplate.Height = 26;
            this.dataGridViewTemplate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTemplate.Size = new System.Drawing.Size(873, 304);
            this.dataGridViewTemplate.TabIndex = 0;
            this.dataGridViewTemplate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // TemplateName
            // 
            this.TemplateName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TemplateName.HeaderText = "TemplateName";
            this.TemplateName.MinimumWidth = 150;
            this.TemplateName.Name = "TemplateName";
            this.TemplateName.ReadOnly = true;
            // 
            // DescriptionCol
            // 
            this.DescriptionCol.HeaderText = "Description";
            this.DescriptionCol.MinimumWidth = 100;
            this.DescriptionCol.Name = "DescriptionCol";
            this.DescriptionCol.ReadOnly = true;
            this.DescriptionCol.Width = 350;
            // 
            // SMSCol
            // 
            this.SMSCol.HeaderText = "SMS Noti.";
            this.SMSCol.Name = "SMSCol";
            this.SMSCol.ReadOnly = true;
            this.SMSCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SMSCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TemplateID
            // 
            this.TemplateID.HeaderText = "TemplateID";
            this.TemplateID.Name = "TemplateID";
            this.TemplateID.ReadOnly = true;
            this.TemplateID.Visible = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.buttonUpdateStatusSMS);
            this.panel2.Controls.Add(this.checkBoxDisablAll);
            this.panel2.Controls.Add(this.checkBoxEnableAll);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.buttonUpdateTemplate);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxDescription);
            this.panel2.Controls.Add(this.textBoxTemplate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 153);
            this.panel2.TabIndex = 2;
            // 
            // buttonUpdateStatusSMS
            // 
            this.buttonUpdateStatusSMS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateStatusSMS.Location = new System.Drawing.Point(552, 79);
            this.buttonUpdateStatusSMS.Name = "buttonUpdateStatusSMS";
            this.buttonUpdateStatusSMS.Size = new System.Drawing.Size(75, 40);
            this.buttonUpdateStatusSMS.TabIndex = 13;
            this.buttonUpdateStatusSMS.Text = "Update";
            this.buttonUpdateStatusSMS.UseVisualStyleBackColor = true;
            this.buttonUpdateStatusSMS.Click += new System.EventHandler(this.buttonUpdateStatusSMS_Click);
            // 
            // checkBoxDisablAll
            // 
            this.checkBoxDisablAll.AutoSize = true;
            this.checkBoxDisablAll.Location = new System.Drawing.Point(474, 102);
            this.checkBoxDisablAll.Name = "checkBoxDisablAll";
            this.checkBoxDisablAll.Size = new System.Drawing.Size(72, 17);
            this.checkBoxDisablAll.TabIndex = 12;
            this.checkBoxDisablAll.Text = "DisableAll";
            this.checkBoxDisablAll.UseVisualStyleBackColor = true;
            this.checkBoxDisablAll.CheckedChanged += new System.EventHandler(this.checkBoxDisablAll_CheckedChanged);
            // 
            // checkBoxEnableAll
            // 
            this.checkBoxEnableAll.AutoSize = true;
            this.checkBoxEnableAll.Location = new System.Drawing.Point(474, 79);
            this.checkBoxEnableAll.Name = "checkBoxEnableAll";
            this.checkBoxEnableAll.Size = new System.Drawing.Size(70, 17);
            this.checkBoxEnableAll.TabIndex = 11;
            this.checkBoxEnableAll.Text = "EnableAll";
            this.checkBoxEnableAll.UseVisualStyleBackColor = true;
            this.checkBoxEnableAll.CheckedChanged += new System.EventHandler(this.checkBoxEnableAll_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(725, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Yellow;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancel.Location = new System.Drawing.Point(259, 49);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 42);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdateTemplate
            // 
            this.buttonUpdateTemplate.BackColor = System.Drawing.Color.Blue;
            this.buttonUpdateTemplate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateTemplate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateTemplate.Location = new System.Drawing.Point(97, 49);
            this.buttonUpdateTemplate.Name = "buttonUpdateTemplate";
            this.buttonUpdateTemplate.Size = new System.Drawing.Size(75, 42);
            this.buttonUpdateTemplate.TabIndex = 7;
            this.buttonUpdateTemplate.Text = "Update";
            this.buttonUpdateTemplate.UseVisualStyleBackColor = false;
            this.buttonUpdateTemplate.Visible = false;
            this.buttonUpdateTemplate.Click += new System.EventHandler(this.buttonUpdateTemplate_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(474, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "SMS Notification";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Lime;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAdd.Location = new System.Drawing.Point(178, 49);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 42);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(375, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "TemplateName:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(474, 23);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(208, 20);
            this.textBoxDescription.TabIndex = 1;
            // 
            // textBoxTemplate
            // 
            this.textBoxTemplate.Location = new System.Drawing.Point(139, 21);
            this.textBoxTemplate.Name = "textBoxTemplate";
            this.textBoxTemplate.Size = new System.Drawing.Size(195, 20);
            this.textBoxTemplate.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dataGridViewTemplate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 304);
            this.panel1.TabIndex = 3;
            // 
            // Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(873, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Template";
            this.Text = "Template";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemplate)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridViewTemplate;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxDescription;
        public System.Windows.Forms.TextBox textBoxTemplate;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button buttonUpdateTemplate;
        public System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxDisablAll;
        private System.Windows.Forms.CheckBox checkBoxEnableAll;
        private System.Windows.Forms.Button buttonUpdateStatusSMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemplateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SMSCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemplateID;
    }
}