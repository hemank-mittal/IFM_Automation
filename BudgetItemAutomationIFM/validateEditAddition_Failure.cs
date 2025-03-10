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
    ///The validateEditAddition_Failure recording.
    /// </summary>
    [TestModule("4e94c162-aa61-40dc-9084-443adfb95243", ModuleType.Recording, 1)]
    public partial class validateEditAddition_Failure : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static validateEditAddition_Failure instance = new validateEditAddition_Failure();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public validateEditAddition_Failure()
        {
            addedItem = "";
            elementExists = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static validateEditAddition_Failure Instance
        {
            get { return instance; }
        }

#region Variables

        string _elementExists;

        /// <summary>
        /// Gets or sets the value of variable elementExists.
        /// </summary>
        [TestVariable("38679f02-1e1e-4ee1-b02d-3274b5ca9c57")]
        public string elementExists
        {
            get { return _elementExists; }
            set { _elementExists = value; }
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

        /// <summary>
        /// Gets or sets the value of variable addedItem.
        /// </summary>
        [TestVariable("194ed742-36f5-4167-9c68-0b5afd8dee74")]
        public string addedItem
        {
            get { return repo.addedItem; }
            set { repo.addedItem = value; }
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

            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.findTextInList(repo.ApplicationUnderTest.Content1.linkedItemsList, addedItem, ValueConverter.ArgumentFromString<bool>("wantMatch", "False"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.MatExpansionPanelHeader1' at Center.", repo.ApplicationUnderTest.Content1.MatExpansionPanelHeader1Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Content1.MatExpansionPanelHeader1.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
