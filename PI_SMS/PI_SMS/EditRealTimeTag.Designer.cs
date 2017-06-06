namespace PI_SMS
{
    partial class EditRealTimeTag
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
            this.TagName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTagname = new System.Windows.Forms.TextBox();
            this.textBoxhihi = new System.Windows.Forms.TextBox();
            this.textBoxhi = new System.Windows.Forms.TextBox();
            this.textBoxlo = new System.Windows.Forms.TextBox();
            this.checkBoxmail = new System.Windows.Forms.CheckBox();
            this.checkBoxphone = new System.Windows.Forms.CheckBox();
            this.checkBoxenable = new System.Windows.Forms.CheckBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TagName
            // 
            this.TagName.AutoSize = true;
            this.TagName.Location = new System.Drawing.Point(12, 25);
            this.TagName.Name = "TagName";
            this.TagName.Size = new System.Drawing.Size(54, 13);
            this.TagName.TabIndex = 0;
            this.TagName.Text = "TagName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "HiHi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lo";
            // 
            // textBoxTagname
            // 
            this.textBoxTagname.Location = new System.Drawing.Point(72, 22);
            this.textBoxTagname.Name = "textBoxTagname";
            this.textBoxTagname.ReadOnly = true;
            this.textBoxTagname.Size = new System.Drawing.Size(146, 20);
            this.textBoxTagname.TabIndex = 7;
            // 
            // textBoxhihi
            // 
            this.textBoxhihi.Location = new System.Drawing.Point(72, 55);
            this.textBoxhihi.Name = "textBoxhihi";
            this.textBoxhihi.Size = new System.Drawing.Size(146, 20);
            this.textBoxhihi.TabIndex = 8;
            // 
            // textBoxhi
            // 
            this.textBoxhi.Location = new System.Drawing.Point(72, 88);
            this.textBoxhi.Name = "textBoxhi";
            this.textBoxhi.Size = new System.Drawing.Size(146, 20);
            this.textBoxhi.TabIndex = 9;
            // 
            // textBoxlo
            // 
            this.textBoxlo.Location = new System.Drawing.Point(72, 119);
            this.textBoxlo.Name = "textBoxlo";
            this.textBoxlo.Size = new System.Drawing.Size(146, 20);
            this.textBoxlo.TabIndex = 10;
            // 
            // checkBoxmail
            // 
            this.checkBoxmail.AutoSize = true;
            this.checkBoxmail.Location = new System.Drawing.Point(12, 145);
            this.checkBoxmail.Name = "checkBoxmail";
            this.checkBoxmail.Size = new System.Drawing.Size(45, 17);
            this.checkBoxmail.TabIndex = 11;
            this.checkBoxmail.Text = "Mail";
            this.checkBoxmail.UseVisualStyleBackColor = true;
            // 
            // checkBoxphone
            // 
            this.checkBoxphone.AutoSize = true;
            this.checkBoxphone.Location = new System.Drawing.Point(98, 145);
            this.checkBoxphone.Name = "checkBoxphone";
            this.checkBoxphone.Size = new System.Drawing.Size(57, 17);
            this.checkBoxphone.TabIndex = 12;
            this.checkBoxphone.Text = "Phone";
            this.checkBoxphone.UseVisualStyleBackColor = true;
            // 
            // checkBoxenable
            // 
            this.checkBoxenable.AutoSize = true;
            this.checkBoxenable.Location = new System.Drawing.Point(12, 168);
            this.checkBoxenable.Name = "checkBoxenable";
            this.checkBoxenable.Size = new System.Drawing.Size(65, 17);
            this.checkBoxenable.TabIndex = 13;
            this.checkBoxenable.Text = "Enabled";
            this.checkBoxenable.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(130, 168);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(88, 33);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // EditRealTimeTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 239);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.checkBoxenable);
            this.Controls.Add(this.checkBoxphone);
            this.Controls.Add(this.checkBoxmail);
            this.Controls.Add(this.textBoxlo);
            this.Controls.Add(this.textBoxhi);
            this.Controls.Add(this.textBoxhihi);
            this.Controls.Add(this.textBoxTagname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TagName);
            this.Name = "EditRealTimeTag";
            this.Text = "EditRealTimeTag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TagName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTagname;
        private System.Windows.Forms.TextBox textBoxhihi;
        private System.Windows.Forms.TextBox textBoxhi;
        private System.Windows.Forms.TextBox textBoxlo;
        private System.Windows.Forms.CheckBox checkBoxmail;
        private System.Windows.Forms.CheckBox checkBoxphone;
        private System.Windows.Forms.CheckBox checkBoxenable;
        private System.Windows.Forms.Button buttonUpdate;
    }
}