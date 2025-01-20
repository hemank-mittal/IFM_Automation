/*
 * Created by Ranorex
 * User: LENOVO
 * Date: 17-01-2025
 * Time: 12:49
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */

using System;
using System.Threading;
using System.Drawing;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Reporting;
using Ranorex.Core.Testing;

namespace MasterProject
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {            
            RunTestSuite(typeof(Automation_CreateNewClient_IFM.Program));
            RunTestSuite(typeof(BudgetItemAutomationIFM.Program));
        }
        
        public static int RunTestSuite(Type projectToRun)
        {
        	
        	// Uncomment the following 2 lines if you want to automate Windows apps
            // by starting the test executable directly
            //if (Util.IsRestartRequiredForWinAppAccess)
            //    return Util.RestartWithUiAccess();
            
        	Keyboard.AbortKey = System.Windows.Forms.Keys.Pause;
            int error = 0;           

            try
            {
            	TestReport.Setup(ReportLevel.Debug, "MasterReport.rxlog", true);
            	error = TestSuiteRunner.Run(projectToRun, Environment.CommandLine);
            }
            catch (Exception e)
            {
                Report.Error("Unexpected exception occurred: " + e.ToString());
                error = -1;
            }
            return error;
        }
    }
}
