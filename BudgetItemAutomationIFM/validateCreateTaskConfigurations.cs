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
    ///The validateCreateTaskConfigurations recording.
    /// </summary>
    [TestModule("ec46c0bf-00ee-445d-9f58-a76a01e66c97", ModuleType.Recording, 1)]
    public partial class validateCreateTaskConfigurations : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static validateCreateTaskConfigurations instance = new validateCreateTaskConfigurations();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public validateCreateTaskConfigurations()
        {
            itemName = "";
            HEXCode = "";
            visibleHEXCode = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static validateCreateTaskConfigurations Instance
        {
            get { return instance; }
        }

#region Variables

        string _itemName;

        /// <summary>
        /// Gets or sets the value of variable itemName.
        /// </summary>
        [TestVariable("2e0e0537-da0d-4fcc-833a-660f02da49be")]
        public string itemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        string _HEXCode;

        /// <summary>
        /// Gets or sets the value of variable HEXCode.
        /// </summary>
        [TestVariable("179110c0-b160-4b36-9224-61c44e075abe")]
        public string HEXCode
        {
            get { return _HEXCode; }
            set { _HEXCode = value; }
        }

        string _visibleHEXCode;

        /// <summary>
        /// Gets or sets the value of variable visibleHEXCode.
        /// </summary>
        [TestVariable("a3cdd564-a0bb-4ef2-8305-b498946275fa")]
        public string visibleHEXCode
        {
            get { return _visibleHEXCode; }
            set { _visibleHEXCode = value; }
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
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.searchBar_typeplaceholder' at Center.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$itemName' with focus on 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.PressKeys(itemName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(4));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$itemName) on item 'ApplicationUnderTest.secondElement_anyTag'.", repo.ApplicationUnderTest.secondElement_anyTagInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.ApplicationUnderTest.secondElement_anyTagInfo, "InnerText", itemName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ButtonTagEdit_Row1' at Center.", repo.ApplicationUnderTest.ButtonTagEdit_Row1Info, new RecordItemIndex(6));
            repo.ApplicationUnderTest.ButtonTagEdit_Row1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$itemName) on item 'ApplicationUnderTest.TitleInputBar'.", repo.ApplicationUnderTest.TitleInputBarInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ApplicationUnderTest.TitleInputBarInfo, "TagValue", itemName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.EBtnEControlEDropdownBtnEIconBt' at Center.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.EBtnEControlEDropdownBtnEIconBtInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.EBtnEControlEDropdownBtnEIconBt.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.HEXCodeInput' and assigning its value to variable 'visibleHEXCode'.", repo.ApplicationUnderTest.HEXCodeInputInfo, new RecordItemIndex(9));
            visibleHEXCode = repo.ApplicationUnderTest.HEXCodeInput.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.compareStrings(visibleHEXCode, HEXCode);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Cancel' at Center.", repo.ApplicationUnderTest.CancelInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.Cancel.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.ButtonTagCancel3' at Center.", repo.ApplicationUnderTest.Content1.ButtonTagCancel3Info, new RecordItemIndex(12));
            repo.ApplicationUnderTest.Content1.ButtonTagCancel3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(13));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.searchBar_typeplaceholder);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
