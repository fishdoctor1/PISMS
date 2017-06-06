using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.IO;

namespace PISMS_Service_Realtime
{
    public partial class PISMS_Service_RealTime : ServiceBase
    {

        public PISMS_Service_RealTime()
        {
            InitializeComponent();
        }

        public void OnDebug()
        {
            OnStart(null);
        }

        public void RunAsConsole(string[] args)
        {
            OnStart(args);
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
            OnStop();
        }

        protected override void OnStart(string[] args)
        {

        }

        protected override void OnStop()
        {

        }

        private void timer3_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer3.Stop();
            Console.WriteLine("TIMER3\n");

            timer3.Start();
        }

        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer1.Stop();
            Console.WriteLine("TIMER1");
            timer1.Start();
        }
    }
}
