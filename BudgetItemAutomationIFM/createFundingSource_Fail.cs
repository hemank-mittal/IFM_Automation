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
    ///The createFundingSource_Fail recording.
    /// </summary>
    [TestModule("3bb9f756-b541-4bd3-bf37-9016f06d586e", ModuleType.Recording, 1)]
    public partial class createFundingSource_Fail : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static createFundingSource_Fail instance = new createFundingSource_Fail();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public createFundingSource_Fail()
        {
            existingName = "";
            existingLinkedItem = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static createFundingSource_Fail Instance
        {
            get { return instance; }
        }

#region Variables

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
        /// Gets or sets the value of variable existingLinkedItem.
        /// </summary>
        [TestVariable("871e0a29-6277-4a4f-9dea-ca0f8aff365b")]
        public string existingLinkedItem
        {
            get { return repo.existingLinkedItem; }
            set { repo.existingLinkedItem = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable existingName.
        /// </summary>
        [TestVariable("d904146b-181b-4bab-8d84-b29676d95a1b")]
        public string existingName
        {
            get { return repo.existingName; }
            set { repo.existingName = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.firstElement_anyTag' and assigning its value to variable 'existingName'.", repo.ApplicationUnderTest.firstElement_anyTagInfo, new RecordItemIndex(0));
            existingName = repo.ApplicationUnderTest.firstElement_anyTag.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.secondElement_anyTag' and assigning its value to variable 'existingLinkedItem'.", repo.ApplicationUnderTest.secondElement_anyTagInfo, new RecordItemIndex(1));
            existingLinkedItem = repo.ApplicationUnderTest.secondElement_anyTag.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text1' at Center.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text1Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text1'.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text1Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text1.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$existingName' with focus on 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text1'.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text1Info, new RecordItemIndex(4));
            repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text1.PressKeys(existingName);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.MatMdcSelectValueNgTnsC3393473648' at Center.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.MatMdcSelectValueNgTnsC3393473648Info, new RecordItemIndex(5));
            //repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.MatMdcSelectValueNgTnsC3393473648.Click();
            //Delay.Milliseconds(0);
            
            Mouse_Click_fundingCategory_dynamicName(repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.MatMdcSelectValueNgTnsC3393473648Info, existingLinkedItem);
            Delay.Milliseconds(0);
            
            Mouse_Click_fundingCategory_dynamicName(repo.ApplicationUnderTest.fundingCategory_dynamicNameInfo, existingLinkedItem);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
