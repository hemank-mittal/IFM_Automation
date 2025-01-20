/*
 * Created by Ranorex
 * User: LENOVO
 * Date: 07-01-2025
 * Time: 19:34
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace BudgetItemAutomationIFM
{
    /// <summary>
    /// Description of newItemName_IfExists.
    /// </summary>
    [TestModule("D536BCFB-C597-41EF-A764-641B2AC2BB57", ModuleType.UserCode, 1)]
    public class newItemName_IfExists : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public newItemName_IfExists()
        {
            // Do not delete - a parameterless constructor is required!
        }               
        
        public bool ItemExists()
        {
        	var repo = BudgetItemAutomationIFM.BudgetItemAutomationIFMRepository.Instance;
        	
        	try
        	{
        		Validate.AttributeEqual(repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.SwalModalInfo, "Visible", "True");
        		repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.ButtonTagOK.Click();
        		
        		
        		
        		Report.Warn("Nice");
        		
        	}
        	catch(Exception e)
        	{
        		Report.Warn("Nice??");
        	}
        	
        	return false;
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            ItemExists();
        }
    }
}
