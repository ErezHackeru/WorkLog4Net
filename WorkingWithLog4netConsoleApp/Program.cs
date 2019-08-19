using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkingWithLog4netConsoleApp
{
    class Program
    {
        //Declare an instance for log4net
        private static readonly ILog log = LogManager.GetLogger("Task");
        //System.Reflection.MethodBase.GetCurrentMethod().DeclaringType

        private static void log4net_demo()
        {
            FileInfo fi = new FileInfo("log4net.xml");
            log4net.Config.XmlConfigurator.Configure(fi);
            log4net.GlobalContext.Properties["host"] = Environment.MachineName;
        }

        static void Main(string[] args)
        {
            log4net_demo();
            
            double secs = 1.5;
            log.Debug("This is a Debug message");
            Console.WriteLine("Start log Debug...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            log.Info("This is a Info message");
            Console.WriteLine("Start log Info...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            log.Warn("This is a Warning message");
            Console.WriteLine("Start log Warn...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            log.Error("This is an Error message");
            Console.WriteLine("Start log Error...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            log.Fatal("This is a Fatal message");
            Console.WriteLine("Start log FATAL...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            try
            {
                throw new Exception("This is test message...");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                Console.WriteLine("Start log test Ex...");
                Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs
            }

            //Console.Read();
        }
    }
}
