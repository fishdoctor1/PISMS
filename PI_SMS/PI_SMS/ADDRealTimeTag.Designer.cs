﻿namespace PI_SMS
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
            this.buttontag = new System.Windows.Forms.Button();
            this.textBoxlow = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.buttonsave = new System.Windows.Forms.Button();
            this.checkBoxMail = new System.Windows.Forms.CheckBox();
            this.checkBoxPhone = new System.Windows.Forms.CheckBox();
            this.checkBoxEnabled = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxhihi = new System.Windows.Forms.TextBox();
            this.textBoxhigh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTagname
            // 
            this.textBoxTagname.Location = new System.Drawing.Point(99, 6);
            this.textBoxTagname.Name = "textBoxTagname";
            this.textBoxTagname.Size = new System.Drawing.Size(129, 20);
            this.textBoxTagname.TabIndex = 0;
            this.textBoxTagname.Text = "Demo2";
            // 
            // textBoxserver
            // 
            this.textBoxserver.Location = new System.Drawing.Point(99, 32);
            this.textBoxserver.Name = "textBoxserver";
            this.textBoxserver.ReadOnly = true;
            this.textBoxserver.Size = new System.Drawing.Size(129, 20);
            this.textBoxserver.TabIndex = 1;
            this.textBoxserver.Text = "piserver";
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
            // textBoxlow
            // 
            this.textBoxlow.Location = new System.Drawing.Point(98, 112);
            this.textBoxlow.Name = "textBoxlow";
            this.textBoxlow.Size = new System.Drawing.Size(129, 20);
            this.textBoxlow.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "GroupName";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Location = new System.Drawing.Point(99, 140);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.ReadOnly = true;
            this.textBoxGroupName.Size = new System.Drawing.Size(129, 20);
            this.textBoxGroupName.TabIndex = 12;
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(218, 172);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(85, 28);
            this.buttonsave.TabIndex = 13;
            this.buttonsave.Text = "save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // checkBoxMail
            // 
            this.checkBoxMail.AutoSize = true;
            this.checkBoxMail.Location = new System.Drawing.Point(16, 179);
            this.checkBoxMail.Name = "checkBoxMail";
            this.checkBoxMail.Size = new System.Drawing.Size(45, 17);
            this.checkBoxMail.TabIndex = 15;
            this.checkBoxMail.Text = "Mail";
            this.checkBoxMail.UseVisualStyleBackColor = true;
            // 
            // checkBoxPhone
            // 
            this.checkBoxPhone.AutoSize = true;
            this.checkBoxPhone.Location = new System.Drawing.Point(67, 179);
            this.checkBoxPhone.Name = "checkBoxPhone";
            this.checkBoxPhone.Size = new System.Drawing.Size(57, 17);
            this.checkBoxPhone.TabIndex = 16;
            this.checkBoxPhone.Text = "Phone";
            this.checkBoxPhone.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnabled
            // 
            this.checkBoxEnabled.AutoSize = true;
            this.checkBoxEnabled.Location = new System.Drawing.Point(130, 179);
            this.checkBoxEnabled.Name = "checkBoxEnabled";
            this.checkBoxEnabled.Size = new System.Drawing.Size(65, 17);
            this.checkBoxEnabled.TabIndex = 17;
            this.checkBoxEnabled.Text = "Enabled";
            this.checkBoxEnabled.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Danger--------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "High------------------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Low-------------------";
            // 
            // textBoxhihi
            // 
            this.textBoxhihi.Location = new System.Drawing.Point(99, 58);
            this.textBoxhihi.Name = "textBoxhihi";
            this.textBoxhihi.Size = new System.Drawing.Size(129, 20);
            this.textBoxhihi.TabIndex = 23;
            // 
            // textBoxhigh
            // 
            this.textBoxhigh.Location = new System.Drawing.Point(98, 86);
            this.textBoxhigh.Name = "textBoxhigh";
            this.textBoxhigh.Size = new System.Drawing.Size(129, 20);
            this.textBoxhigh.TabIndex = 24;
            // 
            // ADDRealTimeTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 215);
            this.Controls.Add(this.textBoxlow);
            this.Controls.Add(this.textBoxhigh);
            this.Controls.Add(this.textBoxhihi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxEnabled);
            this.Controls.Add(this.checkBoxPhone);
            this.Controls.Add(this.checkBoxMail);
            this.Controls.Add(this.buttontag);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.textBoxGroupName);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Button buttontag;
        private System.Windows.Forms.TextBox textBoxlow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.CheckBox checkBoxMail;
        private System.Windows.Forms.CheckBox checkBoxPhone;
        private System.Windows.Forms.CheckBox checkBoxEnabled;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxhihi;
        private System.Windows.Forms.TextBox textBoxhigh;
    }
}