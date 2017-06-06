namespace PI_SMS
{
    partial class ADDRealTimeTag
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
            this.textBoxTagname = new System.Windows.Forms.TextBox();
            this.textBoxserver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxvalue = new System.Windows.Forms.TextBox();
            this.comboBoxoperator = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxtime = new System.Windows.Forms.TextBox();
            this.comboBoxunittime = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttontag = new System.Windows.Forms.Button();
            this.checkBoxMail = new System.Windows.Forms.CheckBox();
            this.checkBoxPhone = new System.Windows.Forms.CheckBox();
            this.checkBoxEnabled = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCompareTo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxTagname
            // 
            this.textBoxTagname.Location = new System.Drawing.Point(99, 6);
            this.textBoxTagname.Name = "textBoxTagname";
            this.textBoxTagname.ReadOnly = true;
            this.textBoxTagname.Size = new System.Drawing.Size(129, 20);
            this.textBoxTagname.TabIndex = 0;
            // 
            // textBoxserver
            // 
            this.textBoxserver.Location = new System.Drawing.Point(99, 32);
            this.textBoxserver.Name = "textBoxserver";
            this.textBoxserver.ReadOnly = true;
            this.textBoxserver.Size = new System.Drawing.Size(129, 20);
            this.textBoxserver.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tag name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "operator";
            // 
            // textBoxvalue
            // 
            this.textBoxvalue.Enabled = false;
            this.textBoxvalue.Location = new System.Drawing.Point(99, 113);
            this.textBoxvalue.Name = "textBoxvalue";
            this.textBoxvalue.Size = new System.Drawing.Size(129, 20);
            this.textBoxvalue.TabIndex = 5;
            // 
            // comboBoxoperator
            // 
            this.comboBoxoperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxoperator.FormattingEnabled = true;
            this.comboBoxoperator.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "!="});
            this.comboBoxoperator.Location = new System.Drawing.Point(99, 59);
            this.comboBoxoperator.Name = "comboBoxoperator";
            this.comboBoxoperator.Size = new System.Drawing.Size(129, 21);
            this.comboBoxoperator.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "TimeTrue";
            // 
            // textBoxtime
            // 
            this.textBoxtime.Location = new System.Drawing.Point(99, 142);
            this.textBoxtime.Name = "textBoxtime";
            this.textBoxtime.Size = new System.Drawing.Size(59, 20);
            this.textBoxtime.TabIndex = 9;
            // 
            // comboBoxunittime
            // 
            this.comboBoxunittime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxunittime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxunittime.FormattingEnabled = true;
            this.comboBoxunittime.Items.AddRange(new object[] {
            "Second",
            "Minute",
            "Hour"});
            this.comboBoxunittime.Location = new System.Drawing.Point(164, 142);
            this.comboBoxunittime.Name = "comboBoxunittime";
            this.comboBoxunittime.Size = new System.Drawing.Size(63, 21);
            this.comboBoxunittime.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "GroupName";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Location = new System.Drawing.Point(99, 177);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.ReadOnly = true;
            this.textBoxGroupName.Size = new System.Drawing.Size(129, 20);
            this.textBoxGroupName.TabIndex = 12;
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(218, 209);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(85, 28);
            this.buttonsave.TabIndex = 13;
            this.buttonsave.Text = "save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // buttontag
            // 
            this.buttontag.Location = new System.Drawing.Point(234, 4);
            this.buttontag.Name = "buttontag";
            this.buttontag.Size = new System.Drawing.Size(75, 23);
            this.buttontag.TabIndex = 14;
            this.buttontag.Text = "ADDTag";
            this.buttontag.UseVisualStyleBackColor = true;
            this.buttontag.Click += new System.EventHandler(this.buttontag_Click);
            // 
            // checkBoxMail
            // 
            this.checkBoxMail.AutoSize = true;
            this.checkBoxMail.Location = new System.Drawing.Point(16, 216);
            this.checkBoxMail.Name = "checkBoxMail";
            this.checkBoxMail.Size = new System.Drawing.Size(45, 17);
            this.checkBoxMail.TabIndex = 15;
            this.checkBoxMail.Text = "Mail";
            this.checkBoxMail.UseVisualStyleBackColor = true;
            // 
            // checkBoxPhone
            // 
            this.checkBoxPhone.AutoSize = true;
            this.checkBoxPhone.Location = new System.Drawing.Point(67, 216);
            this.checkBoxPhone.Name = "checkBoxPhone";
            this.checkBoxPhone.Size = new System.Drawing.Size(57, 17);
            this.checkBoxPhone.TabIndex = 16;
            this.checkBoxPhone.Text = "Phone";
            this.checkBoxPhone.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnabled
            // 
            this.checkBoxEnabled.AutoSize = true;
            this.checkBoxEnabled.Location = new System.Drawing.Point(130, 216);
            this.checkBoxEnabled.Name = "checkBoxEnabled";
            this.checkBoxEnabled.Size = new System.Drawing.Size(65, 17);
            this.checkBoxEnabled.TabIndex = 17;
            this.checkBoxEnabled.Text = "Enabled";
            this.checkBoxEnabled.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Compare To";
            // 
            // comboBoxCompareTo
            // 
            this.comboBoxCompareTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompareTo.FormattingEnabled = true;
            this.comboBoxCompareTo.Items.AddRange(new object[] {
            "Value",
            "Danger",
            "High",
            "Low"});
            this.comboBoxCompareTo.Location = new System.Drawing.Point(98, 86);
            this.comboBoxCompareTo.Name = "comboBoxCompareTo";
            this.comboBoxCompareTo.Size = new System.Drawing.Size(129, 21);
            this.comboBoxCompareTo.TabIndex = 19;
            this.comboBoxCompareTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompareTo_SelectedIndexChanged);
            // 
            // ADDRealTimeTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 245);
            this.Controls.Add(this.comboBoxCompareTo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxEnabled);
            this.Controls.Add(this.checkBoxPhone);
            this.Controls.Add(this.checkBoxMail);
            this.Controls.Add(this.buttontag);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.textBoxGroupName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxunittime);
            this.Controls.Add(this.textBoxtime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxoperator);
            this.Controls.Add(this.textBoxvalue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxserver);
            this.Controls.Add(this.textBoxTagname);
            this.Name = "ADDRealTimeTag";
            this.Text = "ADDRealTimeTag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTagname;
        private System.Windows.Forms.TextBox textBoxserver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxvalue;
        private System.Windows.Forms.ComboBox comboBoxoperator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxtime;
        private System.Windows.Forms.ComboBox comboBoxunittime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttontag;
        private System.Windows.Forms.CheckBox checkBoxMail;
        private System.Windows.Forms.CheckBox checkBoxPhone;
        private System.Windows.Forms.CheckBox checkBoxEnabled;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCompareTo;
    }
}