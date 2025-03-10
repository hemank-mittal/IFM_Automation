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
    ///The validateEditDeletion recording.
    /// </summary>
    [TestModule("25dacbc8-b071-44e1-8519-e95b4c812b84", ModuleType.Recording, 1)]
    public partial class validateEditDeletion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static validateEditDeletion instance = new validateEditDeletion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public validateEditDeletion()
        {
            removedItem = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static validateEditDeletion Instance
        {
            get { return instance; }
        }

#region Variables

        string _removedItem;

        /// <summary>
        /// Gets or sets the value of variable removedItem.
        /// </summary>
        [TestVariable("3b5a833e-9663-48b6-aace-4063f5872023")]
        public string removedItem
        {
            get { return _removedItem; }
            set { _removedItem = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.itemCreatedMessageToaster'", repo.ApplicationUnderTest.itemCreatedMessageToasterInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.itemCreatedMessageToasterInfo.WaitForNotExists(30000);
            
            //validationNotExist();
            //Delay.Milliseconds(0);
            
            HelperMethodsCollection.findTextInList(repo.ApplicationUnderTest.Content1.linkedItemsList, removedItem, ValueConverter.ArgumentFromString<bool>("wantMatch", "False"));
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
