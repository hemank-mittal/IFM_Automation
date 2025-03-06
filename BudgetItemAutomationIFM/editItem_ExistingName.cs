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
    ///The editItem_ExistingName recording.
    /// </summary>
    [TestModule("c9024732-fb9f-4183-9be3-1027f117c0e5", ModuleType.Recording, 1)]
    public partial class editItem_ExistingName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static editItem_ExistingName instance = new editItem_ExistingName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public editItem_ExistingName()
        {
            existingName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static editItem_ExistingName Instance
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
        /// Gets or sets the value of variable existingName.
        /// </summary>
        [TestVariable("30e085d9-5bd3-4648-a1d4-6e372bbd515d")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ButtonTagEdit_Row2' at Center.", repo.ApplicationUnderTest.ButtonTagEdit_Row2Info, new RecordItemIndex(0));
            repo.ApplicationUnderTest.ButtonTagEdit_Row2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text' at Center.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.TextInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text'.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.TextInfo, new RecordItemIndex(2));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text'.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.TextInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.lastRecord_secondColumnData' at Center.", repo.ApplicationUnderTest.lastRecord_secondColumnDataInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.lastRecord_secondColumnData.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.lastRecord_secondColumnData' and assigning its value to variable 'existingName'.", repo.ApplicationUnderTest.lastRecord_secondColumnDataInfo, new RecordItemIndex(5));
            existingName = repo.ApplicationUnderTest.lastRecord_secondColumnData.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$existingName' with focus on 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text'.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.TextInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.Text.PressKeys(existingName);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
