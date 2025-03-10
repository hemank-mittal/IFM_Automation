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
    ///The OpenBrowser_InvoiceCategory recording.
    /// </summary>
    [TestModule("5838d9e3-078d-4f6e-9e39-237100087950", ModuleType.Recording, 1)]
    public partial class OpenBrowser_InvoiceCategory : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static OpenBrowser_InvoiceCategory instance = new OpenBrowser_InvoiceCategory();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenBrowser_InvoiceCategory()
        {
            browserName = "";
            domain = "";
            url = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenBrowser_InvoiceCategory Instance
        {
            get { return instance; }
        }

#region Variables

        string _browserName;

        /// <summary>
        /// Gets or sets the value of variable browserName.
        /// </summary>
        [TestVariable("37966e58-9642-495d-ab01-26e5d6692127")]
        public string browserName
        {
            get { return _browserName; }
            set { _browserName = value; }
        }

        string _url;

        /// <summary>
        /// Gets or sets the value of variable url.
        /// </summary>
        [TestVariable("6df9b04b-eb20-4f49-af72-0f23a1b35a45")]
        public string url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable domain.
        /// </summary>
        [TestVariable("6cb656e2-5eba-44e9-a66c-e41dc32f07c1")]
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
            
            url = HelperMethodsCollection.concatStrings(domain, "/invoiceCategory", "", "");
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
