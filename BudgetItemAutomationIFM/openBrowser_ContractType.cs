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
    ///The openBrowser_ContractType recording.
    /// </summary>
    [TestModule("71b43d88-dcc6-4b58-b604-a7f1ea055f08", ModuleType.Recording, 1)]
    public partial class openBrowser_ContractType : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static openBrowser_ContractType instance = new openBrowser_ContractType();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public openBrowser_ContractType()
        {
            browserName = "";
            domain = "";
            url = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static openBrowser_ContractType Instance
        {
            get { return instance; }
        }

#region Variables

        string _browserName;

        /// <summary>
        /// Gets or sets the value of variable browserName.
        /// </summary>
        [TestVariable("ae727fc9-b005-436a-b08a-e3591a7dd11e")]
        public string browserName
        {
            get { return _browserName; }
            set { _browserName = value; }
        }

        string _url;

        /// <summary>
        /// Gets or sets the value of variable url.
        /// </summary>
        [TestVariable("36361133-a49f-4ca0-946e-8f26cbd43781")]
        public string url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable domain.
        /// </summary>
        [TestVariable("013c382c-2c65-4733-ac88-56fe94cf80b8")]
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
            
            url = HelperMethodsCollection.concatStrings(domain, "/contracttypes", "", "");
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
