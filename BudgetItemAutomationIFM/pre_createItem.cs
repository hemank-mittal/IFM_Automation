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
    ///The pre_createItem recording.
    /// </summary>
    [TestModule("8988b508-4785-4fdb-b6c6-3145b26e8a18", ModuleType.Recording, 1)]
    public partial class Pre_createItem : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static Pre_createItem instance = new Pre_createItem();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pre_createItem()
        {
            itemCount = "";
            newTemplateName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pre_createItem Instance
        {
            get { return instance; }
        }

#region Variables

        string _itemCount;

        /// <summary>
        /// Gets or sets the value of variable itemCount.
        /// </summary>
        [TestVariable("23d7026e-e85a-4075-9197-004d3e03d175")]
        public string itemCount
        {
            get { return _itemCount; }
            set { _itemCount = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable newTemplateName.
        /// </summary>
        [TestVariable("38d05de9-12b0-4ec9-bd3d-a86bee929731")]
        public string newTemplateName
        {
            get { return repo.newTemplateName; }
            set { repo.newTemplateName = value; }
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

            itemCount = ValueConverter.ToString(HelperMethodsCollection.getNumberOfRecordsFromFooter(repo.ApplicationUnderTest.showingNumberOfRecords));
            Delay.Milliseconds(0);
            
            newTemplateName = HelperMethodsCollection.getNewCreateItem(ValueConverter.ArgumentFromString<int>("nextCount", itemCount), "item");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.createSpanTag' at Center.", repo.ApplicationUnderTest.createSpanTagInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.createSpanTag.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.FaFaSpinFaSpinner'", repo.ApplicationUnderTest.FaFaSpinFaSpinnerInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.ApplicationUnderTest.FaFaSpinFaSpinnerInfo.WaitForNotExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
