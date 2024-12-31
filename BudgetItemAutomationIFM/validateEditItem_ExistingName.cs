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
    ///The validateEditItem_ExistingName recording.
    /// </summary>
    [TestModule("5bef7a0f-868c-40a6-87ed-ea81c9d0da76", ModuleType.Recording, 1)]
    public partial class validateEditItem_ExistingName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static validateEditItem_ExistingName instance = new validateEditItem_ExistingName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public validateEditItem_ExistingName()
        {
            itemName = "";
            firstRecord = "";
            secondRecord = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static validateEditItem_ExistingName Instance
        {
            get { return instance; }
        }

#region Variables

        string _itemName;

        /// <summary>
        /// Gets or sets the value of variable itemName.
        /// </summary>
        [TestVariable("33bf2e67-5bac-4ec1-ae33-e9844b451ccd")]
        public string itemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        string _firstRecord;

        /// <summary>
        /// Gets or sets the value of variable firstRecord.
        /// </summary>
        [TestVariable("5bccb1fb-923b-44f7-9b34-8c9d2664149e")]
        public string firstRecord
        {
            get { return _firstRecord; }
            set { _firstRecord = value; }
        }

        string _secondRecord;

        /// <summary>
        /// Gets or sets the value of variable secondRecord.
        /// </summary>
        [TestVariable("86f00746-40f8-48db-869a-8f035675e2c8")]
        public string secondRecord
        {
            get { return _secondRecord; }
            set { _secondRecord = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.SwalModal'.", repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.SwalModalInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.SwalModalInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='This Budget Item already exists. Please revise the current entry.') on item 'ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.ErrorMessage_BudgetItemExists'.", repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.ErrorMessage_BudgetItemExistsInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.ErrorMessage_BudgetItemExistsInfo, "InnerText", "This Budget Item already exists. Please revise the current entry.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.ButtonTagOK' at Center.", repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.ButtonTagOKInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.ButtonTagOK.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.ButtonTagCancel' at Center.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.ButtonTagCancelInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.ButtonTagCancel.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'ApplicationUnderTest.searchBar'.", repo.ApplicationUnderTest.searchBarInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.searchBar.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.searchBar' at Center.", repo.ApplicationUnderTest.searchBarInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.searchBar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$itemName' with focus on 'ApplicationUnderTest.searchBar'.", repo.ApplicationUnderTest.searchBarInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.searchBar.PressKeys(itemName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(7));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.firstElement_anyTag' and assigning its value to variable 'firstRecord'.", repo.ApplicationUnderTest.firstElement_anyTagInfo, new RecordItemIndex(8));
            firstRecord = repo.ApplicationUnderTest.firstElement_anyTag.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Validate_secondRow_FirstElement(repo.ApplicationUnderTest.secondRow_FirstElementInfo, firstRecord);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.searchBar'.", repo.ApplicationUnderTest.searchBarInfo, new RecordItemIndex(10));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.searchBar);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'ApplicationUnderTest.searchBar'.", repo.ApplicationUnderTest.searchBarInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.searchBar.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
