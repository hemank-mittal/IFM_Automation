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
    ///The OpenBrowser_ProjectType recording.
    /// </summary>
    [TestModule("25c75c77-8d41-4cca-9792-4537252cd7ae", ModuleType.Recording, 1)]
    public partial class OpenBrowser_ProjectType : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static OpenBrowser_ProjectType instance = new OpenBrowser_ProjectType();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenBrowser_ProjectType()
        {
            browserName = "";
            domain = "";
            url = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenBrowser_ProjectType Instance
        {
            get { return instance; }
        }

#region Variables

        string _browserName;

        /// <summary>
        /// Gets or sets the value of variable browserName.
        /// </summary>
        [TestVariable("a81a2a2f-4176-4aad-b07d-42f578d70973")]
        public string browserName
        {
            get { return _browserName; }
            set { _browserName = value; }
        }

        string _url;

        /// <summary>
        /// Gets or sets the value of variable url.
        /// </summary>
        [TestVariable("e550531d-a84b-48ee-90bb-492d49578366")]
        public string url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable domain.
        /// </summary>
        [TestVariable("e7614500-80c6-4014-af6f-6ce946ae1684")]
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
            
            url = HelperMethodsCollection.concatStrings(domain, "/projecttypes", "", "");
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
