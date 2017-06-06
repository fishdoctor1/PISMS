using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Drawing;
using PISDKDlg;
using System.Data.SqlClient;
using System.Threading;

namespace PI_SMS_Service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {

#if DEBUG
            //Thread threadSendSMS = new Thread(new (ThreadStart());
            PI_SMS_Service myservice = new PI_SMS_Service();
            
            myservice.OnDebug();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);

#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new PI_SMS_Service()
            };
            ServiceBase.Run(ServicesToRun);

#endif

        }
    }
}
