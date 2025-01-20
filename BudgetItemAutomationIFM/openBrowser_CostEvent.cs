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
    ///The openBrowser_CostEvent recording.
    /// </summary>
    [TestModule("73f4683b-e593-4bae-af03-dde1f77316eb", ModuleType.Recording, 1)]
    public partial class openBrowser_CostEvent : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static openBrowser_CostEvent instance = new openBrowser_CostEvent();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public openBrowser_CostEvent()
        {
            browserName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static openBrowser_CostEvent Instance
        {
            get { return instance; }
        }

#region Variables

        string _browserName;

        /// <summary>
        /// Gets or sets the value of variable browserName.
        /// </summary>
        [TestVariable("a2450ac2-0093-4ebb-a13f-9c4db57e0b27")]
        public string browserName
        {
            get { return _browserName; }
            set { _browserName = value; }
        }

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

            browserName = HelperMethodsCollection.getBrowserName();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://app.ifm360.com/costevent' with browser specified by variable $browserName in normal mode.", new RecordItemIndex(1));
            Host.Current.OpenBrowser("https://app.ifm360.com/costevent", browserName, "", false, false, false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
