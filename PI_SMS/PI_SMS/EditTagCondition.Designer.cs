namespace PI_SMS
{
    partial class EditTagCondition
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxvalue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxtimetrue = new System.Windows.Forms.TextBox();
            this.comboBoxTimeUnit = new System.Windows.Forms.ComboBox();
            this.comboBoxoperator = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxCompareTo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBoxvalue
            // 
            this.textBoxvalue.Location = new System.Drawing.Point(112, 86);
            this.textBoxvalue.Name = "textBoxvalue";
            this.textBoxvalue.Size = new System.Drawing.Size(140, 20);
            this.textBoxvalue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TagName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "operator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TimeTrue";
            // 
            // textBoxtimetrue
            // 
            this.textBoxtimetrue.Location = new System.Drawing.Point(112, 112);
            this.textBoxtimetrue.Name = "textBoxtimetrue";
            this.textBoxtimetrue.Size = new System.Drawing.Size(64, 20);
            this.textBoxtimetrue.TabIndex = 8;
            // 
            // comboBoxTimeUnit
            // 
            this.comboBoxTimeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimeUnit.FormattingEnabled = true;
            this.comboBoxTimeUnit.Items.AddRange(new object[] {
            "Second",
            "Minute",
            "Hour"});
            this.comboBoxTimeUnit.Location = new System.Drawing.Point(182, 111);
            this.comboBoxTimeUnit.Name = "comboBoxTimeUnit";
            this.comboBoxTimeUnit.Size = new System.Drawing.Size(70, 21);
            this.comboBoxTimeUnit.TabIndex = 9;
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
            this.comboBoxoperator.Location = new System.Drawing.Point(112, 32);
            this.comboBoxoperator.MaxDropDownItems = 6;
            this.comboBoxoperator.Name = "comboBoxoperator";
            this.comboBoxoperator.Size = new System.Drawing.Size(140, 21);
            this.comboBoxoperator.TabIndex = 10;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(173, 138);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(79, 32);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
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
            this.comboBoxCompareTo.Location = new System.Drawing.Point(112, 59);
            this.comboBoxCompareTo.Name = "comboBoxCompareTo";
            this.comboBoxCompareTo.Size = new System.Drawing.Size(140, 21);
            this.comboBoxCompareTo.TabIndex = 21;
            this.comboBoxCompareTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompareTo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Compare To";
            // 
            // EditTagCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 183);
            this.Controls.Add(this.comboBoxCompareTo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxoperator);
            this.Controls.Add(this.comboBoxTimeUnit);
            this.Controls.Add(this.textBoxtimetrue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxvalue);
            this.Controls.Add(this.textBox1);
            this.Name = "EditTagCondition";
            this.Text = "EditTagCondition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxtimetrue;
        private System.Windows.Forms.ComboBox comboBoxTimeUnit;
        private System.Windows.Forms.ComboBox comboBoxoperator;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBoxCompareTo;
        private System.Windows.Forms.Label label7;
    }
}