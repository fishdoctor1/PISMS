﻿namespace PISMS_Service_Realtime
{
    partial class PISMS_Service_RealTime
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timer3 = new System.Timers.Timer();
            this.timer1 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.timer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            // 
            // timer3
            // 
            this.timer3.AutoReset = false;
            this.timer3.Enabled = true;
            this.timer3.Interval = 20000D;
            this.timer3.Elapsed += new System.Timers.ElapsedEventHandler(this.timer3_Elapsed);
            // 
            // timer1
            // 
            this.timer1.AutoReset = false;
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000D;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // PISMS_Service_RealTime
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.timer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();

        }

        #endregion

        private System.Timers.Timer timer3;
        private System.Timers.Timer timer1;
    }
}
