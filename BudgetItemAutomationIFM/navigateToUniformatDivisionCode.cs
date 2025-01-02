﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace BudgetItemAutomationIFM
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The navigateToUniformatDivisionCode recording.
    /// </summary>
    [TestModule("c2a2b527-9cd0-4938-a32a-5fc6f75fb93b", ModuleType.Recording, 1)]
    public partial class navigateToUniformatDivisionCode : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static navigateToUniformatDivisionCode instance = new navigateToUniformatDivisionCode();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public navigateToUniformatDivisionCode()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static navigateToUniformatDivisionCode Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.FaFaSpinFaSpinner'", repo.ApplicationUnderTest.FaFaSpinFaSpinnerInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.FaFaSpinFaSpinnerInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 9999 units.", new RecordItemIndex(1));
            Mouse.ScrollWheel(9999);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.MatMdcTabMdcTabNgStarInserted2' at Center.", repo.ApplicationUnderTest.Content1.MatMdcTabMdcTabNgStarInserted2Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Content1.MatMdcTabMdcTabNgStarInserted2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.FaFaSpinFaSpinner'", repo.ApplicationUnderTest.FaFaSpinFaSpinnerInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.ApplicationUnderTest.FaFaSpinFaSpinnerInfo.WaitForNotExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
