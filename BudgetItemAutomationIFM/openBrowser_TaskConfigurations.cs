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
    ///The openBrowser_TaskConfigurations recording.
    /// </summary>
    [TestModule("ac4d75bb-0134-457b-9929-a9ea98c5f9ed", ModuleType.Recording, 1)]
    public partial class openBrowser_TaskConfigurations : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static openBrowser_TaskConfigurations instance = new openBrowser_TaskConfigurations();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public openBrowser_TaskConfigurations()
        {
            browserName = "";
            domain = "";
            url = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static openBrowser_TaskConfigurations Instance
        {
            get { return instance; }
        }

#region Variables

        string _browserName;

        /// <summary>
        /// Gets or sets the value of variable browserName.
        /// </summary>
        [TestVariable("323eaad0-5a40-4a6d-a9e7-bd44f137877e")]
        public string browserName
        {
            get { return _browserName; }
            set { _browserName = value; }
        }

        string _url;

        /// <summary>
        /// Gets or sets the value of variable url.
        /// </summary>
        [TestVariable("4e6cee48-7fe2-42df-810f-3b930cec3aae")]
        public string url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable domain.
        /// </summary>
        [TestVariable("537bea3d-a54a-4c6f-a831-8cd64d1b2a73")]
        public string domain
        {
            get { return repo.domain; }
            set { repo.domain = value; }
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
            
            domain = HelperMethodsCollection.getURL_IFM();
            Delay.Milliseconds(0);
            
            concatStrings2(domain, "/taskConfiguration");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $url with browser specified by variable $browserName in normal mode.", new RecordItemIndex(3));
            Host.Current.OpenBrowser(url, browserName, "", false, false, false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
