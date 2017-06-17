namespace PI_SMS
{
    partial class AddTrigger
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
            this.buttonsave = new System.Windows.Forms.Button();
            this.comboBoxunittime = new System.Windows.Forms.ComboBox();
            this.textBoxtime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxoperator = new System.Windows.Forms.ComboBox();
            this.textBoxvalue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTagname = new System.Windows.Forms.TextBox();
            this.comboBoxCompareTo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(156, 163);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(85, 28);
            this.buttonsave.TabIndex = 31;
            this.buttonsave.Text = "save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // comboBoxunittime
            // 
            this.comboBoxunittime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxunittime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxunittime.FormattingEnabled = true;
            this.comboBoxunittime.Items.AddRange(new object[] {
            "Minute",
            "Hour"});
            this.comboBoxunittime.Location = new System.Drawing.Point(178, 136);
            this.comboBoxunittime.Name = "comboBoxunittime";
            this.comboBoxunittime.Size = new System.Drawing.Size(63, 21);
            this.comboBoxunittime.TabIndex = 28;
            // 
            // textBoxtime
            // 
            this.textBoxtime.Location = new System.Drawing.Point(113, 136);
            this.textBoxtime.Name = "textBoxtime";
            this.textBoxtime.Size = new System.Drawing.Size(59, 20);
            this.textBoxtime.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "TimeTrue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "value";
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
            this.comboBoxoperator.Location = new System.Drawing.Point(113, 54);
            this.comboBoxoperator.Name = "comboBoxoperator";
            this.comboBoxoperator.Size = new System.Drawing.Size(129, 21);
            this.comboBoxoperator.TabIndex = 24;
            // 
            // textBoxvalue
            // 
            this.textBoxvalue.Location = new System.Drawing.Point(113, 107);
            this.textBoxvalue.Name = "textBoxvalue";
            this.textBoxvalue.Size = new System.Drawing.Size(129, 20);
            this.textBoxvalue.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "operator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tag name";
            // 
            // textBoxTagname
            // 
            this.textBoxTagname.Location = new System.Drawing.Point(113, 28);
            this.textBoxTagname.Name = "textBoxTagname";
            this.textBoxTagname.ReadOnly = true;
            this.textBoxTagname.Size = new System.Drawing.Size(129, 20);
            this.textBoxTagname.TabIndex = 18;
            // 
            // comboBoxCompareTo
            // 
            this.comboBoxCompareTo.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxCompareTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompareTo.FormattingEnabled = true;
            this.comboBoxCompareTo.Items.AddRange(new object[] {
            "Value",
            "Low",
            "High",
            "Danger"});
            this.comboBoxCompareTo.Location = new System.Drawing.Point(112, 80);
            this.comboBoxCompareTo.Name = "comboBoxCompareTo";
            this.comboBoxCompareTo.Size = new System.Drawing.Size(129, 21);
            this.comboBoxCompareTo.TabIndex = 33;
            this.comboBoxCompareTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompareTo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Compare To";
            // 
            // AddTrigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 201);
            this.Controls.Add(this.comboBoxCompareTo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.comboBoxunittime);
            this.Controls.Add(this.textBoxtime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxoperator);
            this.Controls.Add(this.textBoxvalue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTagname);
            this.Name = "AddTrigger";
            this.Text = "AddTrigger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.ComboBox comboBoxunittime;
        private System.Windows.Forms.TextBox textBoxtime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxoperator;
        private System.Windows.Forms.TextBox textBoxvalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTagname;
        private System.Windows.Forms.ComboBox comboBoxCompareTo;
        private System.Windows.Forms.Label label7;
    }
}