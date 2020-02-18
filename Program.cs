using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading;
namespace _20200131_asp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Diagnostics.Trace.WriteLine("writeTraceLog_Nishikawa_1_console");

            // EventLog myLog = new EventLog();
            // myLog.Source = "Application";
        
            // // Write an informational entry to the event log.    
            // myLog.WriteEntry("Writing to event log._console");

            // System.Diagnostics.Trace.WriteLine("writeTraceLog_Nishikawa_2");
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
