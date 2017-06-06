using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace PISMS_Service_Realtime
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
#if DEBUG
            //Thread threadSendSMS = new Thread(new (ThreadStart());
            PISMS_Service_RealTime myservice = new PISMS_Service_RealTime();

            //myservice.OnDebug();
            if (Environment.UserInteractive)
            {
                myservice.RunAsConsole(args);
            }
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);

#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new PISMS_Service_RealTime()
            };
            ServiceBase.Run(ServicesToRun);
        
#endif

        }
    }
}
