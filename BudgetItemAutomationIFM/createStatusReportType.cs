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
    ///The createStatusReportType recording.
    /// </summary>
    [TestModule("7c2ba9ca-b734-4e37-98f1-2b51b2dd535f", ModuleType.Recording, 1)]
    public partial class createStatusTypeCategory : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static createStatusTypeCategory instance = new createStatusTypeCategory();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public createStatusTypeCategory()
        {
            descriptionText = "";
            itemCount = "";
            newTemplateName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static createStatusTypeCategory Instance
        {
            get { return instance; }
        }

#region Variables

        string _descriptionText;

        /// <summary>
        /// Gets or sets the value of variable descriptionText.
        /// </summary>
        [TestVariable("fa83e1f8-1556-4d4d-b313-0e47798ffed1")]
        public string descriptionText
        {
            get { return _descriptionText; }
            set { _descriptionText = value; }
        }

        string _itemCount;

        /// <summary>
        /// Gets or sets the value of variable itemCount.
        /// </summary>
        [TestVariable("f2d70fc0-f651-41ad-bd9b-5549ebb462ce")]
        public string itemCount
        {
            get { return _itemCount; }
            set { _itemCount = value; }
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
        /// Gets or sets the value of variable newTemplateName.
        /// </summary>
        [TestVariable("05f42253-39d9-4261-bf15-4a0cc29ce7a5")]
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

            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            itemCount = ValueConverter.ToString(HelperMethodsCollection.getNumberOfRecordsFromFooter(repo.ApplicationUnderTest.showingNumberOfRecords));
            Delay.Milliseconds(0);
            
            newTemplateName = HelperMethodsCollection.getNewCreateItem(ValueConverter.ArgumentFromString<int>("nextCount", itemCount), "item");
            Delay.Milliseconds(0);
            
            Mouse_Click_createSpanTag();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text2' at 390;13.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text2Info, new RecordItemIndex(5));
            repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text2.Click("390;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$newTemplateName' with focus on 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text2'.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text2Info, new RecordItemIndex(6));
            repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text2.PressKeys(newTemplateName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text3' at 164;11.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text3Info, new RecordItemIndex(7));
            repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text3.Click("164;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$descriptionText' with focus on 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text3'.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text3Info, new RecordItemIndex(8));
            repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text3.PressKeys(descriptionText);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
