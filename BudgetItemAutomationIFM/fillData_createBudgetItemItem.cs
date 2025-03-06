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
    ///The fillData_createBudgetItemItem recording.
    /// </summary>
    [TestModule("d88f5db0-f2c5-412c-aca8-d96a1e22c803", ModuleType.Recording, 1)]
    public partial class fillData_createBudgetItemItem : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static fillData_createBudgetItemItem instance = new fillData_createBudgetItemItem();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public fillData_createBudgetItemItem()
        {
            linkedCategory = "";
            newTemplateName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static fillData_createBudgetItemItem Instance
        {
            get { return instance; }
        }

#region Variables

        string _linkedCategory;

        /// <summary>
        /// Gets or sets the value of variable linkedCategory.
        /// </summary>
        [TestVariable("8d2cf288-7d78-4c4e-adbb-930abfb2313a")]
        public string linkedCategory
        {
            get { return _linkedCategory; }
            set { _linkedCategory = value; }
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
        [TestVariable("413ba24b-57b5-4b7f-afb7-ddb9297878f6")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.DropdownBtn' at Center.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.DropdownBtnInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.DropdownBtn.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.category1' and assigning its value to variable 'linkedCategory'.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.category1Info, new RecordItemIndex(1));
            linkedCategory = repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.category1.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.category1' at Center.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.category1Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.category1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text' at Center.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.TextInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$newTemplateName' with focus on 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text'.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.TextInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text.PressKeys(newTemplateName);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
