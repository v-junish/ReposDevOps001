using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _20200131_asp.Models;

namespace _20200131_asp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            System.Diagnostics.Trace.WriteLine("writeTraceLog_Nishikawa_Index");

            try {
                EventLog myLog0 = new EventLog();
                myLog0.Source = "Application";
                // Write an informational entry to the event log.    
                myLog0.WriteEntry("Writing to event Index0 Application");
            } catch(Exception ex) {
            };

            try {
                EventLog myLog0 = new EventLog();
                myLog0.Source = "YSFAONLINE";
                // Write an informational entry to the event log.    
                myLog0.WriteEntry("Writing to event YSFAONLINE");
            } catch(Exception ex) {
            };
        
            // try {
            //     EventLog myLog = new EventLog();
            //     myLog.Source = "Application";
            //     myLog.MachineName = "nishikawaTestAsp";
            
            //     // Write an informational entry to the event log.    
            //     myLog.WriteEntry("Writing to event Index1");
            // } catch(Exception ex) {
            // };

            // try {
	        //     EventLog myLog2 = new EventLog();
	        //     myLog2.Source = "Application";
	        //     myLog2.MachineName = ".";
	        
	        //     // Write an informational entry to the event log.    
	        //     myLog2.WriteEntry("Writing to event Index2");
            // } catch(Exception ex) {
            // };

            // try{
            //     EventLog myLog3 = new EventLog();
            //     myLog3.Source = "Application";
            //     myLog3.MachineName = "nishikawaTestAsp.azurewebsites.net";
            
            //     // Write an informational entry to the event log.    
            //     myLog3.WriteEntry("Writing to event Index3");
            // } catch(Exception ex) {
            // }

            return View();
        }

        public IActionResult Privacy()
        {
            // System.Diagnostics.Trace.WriteLine("writeTraceLog_Nishikawa_Privacy");

            // EventLog myLog0 = new EventLog();
            // myLog0.Source = "Application";
            // myLog0.MachineName = "nishikawaTestAsp.azurewebsites.net";
        
            // // Write an informational entry to the event log.    
            // myLog0.WriteEntry("Writing to event Privacy0");

            // EventLog myLog = new EventLog();
            // myLog.Source = "Application";
            // myLog.MachineName = "nishikawaTestAsp";
        
            // // Write an informational entry to the event log.    
            // myLog.WriteEntry("Writing to event Privacy1");

            // EventLog myLog2 = new EventLog();
            // myLog2.Source = "Application";
            // myLog2.MachineName = ".";
        
            // // Write an informational entry to the event log.    
            // myLog2.WriteEntry("Writing to event Privacy2");

            // EventLog myLog3 = new EventLog();
            // myLog3.Source = "Application";
        
            // // Write an informational entry to the event log.    
            // myLog3.WriteEntry("Writing to event Privacy3");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
