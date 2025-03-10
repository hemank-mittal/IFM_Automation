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
    ///The editRemoveItem_cancel recording.
    /// </summary>
    [TestModule("fb64a219-5d32-45e4-9091-736d7795ec5e", ModuleType.Recording, 1)]
    public partial class editRemoveItem_cancel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static editRemoveItem_cancel instance = new editRemoveItem_cancel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public editRemoveItem_cancel()
        {
            deletingItem = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static editRemoveItem_cancel Instance
        {
            get { return instance; }
        }

#region Variables

        string _deletingItem;

        /// <summary>
        /// Gets or sets the value of variable deletingItem.
        /// </summary>
        [TestVariable("c4ca9219-0b89-4624-a212-815c2f59dc1a")]
        public string deletingItem
        {
            get { return _deletingItem; }
            set { _deletingItem = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable domain.
        /// </summary>
        [TestVariable("0e49bfa6-0c8f-4999-ad77-5babbb4e74af")]
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.Content1.LiTag01Foundations' and assigning its value to variable 'deletingItem'.", repo.ApplicationUnderTest.Content1.LiTag01FoundationsInfo, new RecordItemIndex(2));
            deletingItem = repo.ApplicationUnderTest.Content1.LiTag01Foundations.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.ButtonTagRemove1' at Center.", repo.ApplicationUnderTest.Content1.ButtonTagRemove1Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Content1.ButtonTagRemove1.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
