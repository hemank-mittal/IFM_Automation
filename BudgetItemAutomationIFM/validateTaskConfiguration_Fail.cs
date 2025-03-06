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
    ///The validateTaskConfiguration_Fail recording.
    /// </summary>
    [TestModule("a7646de4-b8d6-4ff6-b823-af6c8d19e6ab", ModuleType.Recording, 1)]
    public partial class validateTaskConfiguration_Fail : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static validateTaskConfiguration_Fail instance = new validateTaskConfiguration_Fail();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public validateTaskConfiguration_Fail()
        {
            itemName = "";
            firstRecord = "";
            secondRecord = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static validateTaskConfiguration_Fail Instance
        {
            get { return instance; }
        }

#region Variables

        string _itemName;

        /// <summary>
        /// Gets or sets the value of variable itemName.
        /// </summary>
        [TestVariable("e1f8bffd-1af2-42b9-bca1-36491431df20")]
        public string itemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        string _firstRecord;

        /// <summary>
        /// Gets or sets the value of variable firstRecord.
        /// </summary>
        [TestVariable("e93ec0a2-eb42-4826-a474-d6e976474d0d")]
        public string firstRecord
        {
            get { return _firstRecord; }
            set { _firstRecord = value; }
        }

        string _secondRecord;

        /// <summary>
        /// Gets or sets the value of variable secondRecord.
        /// </summary>
        [TestVariable("12ca68fc-4e91-4ea4-b687-0780a02aaee6")]
        public string secondRecord
        {
            get { return _secondRecord; }
            set { _secondRecord = value; }
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

            //validationNotExist(repo.ApplicationUnderTest.DivTagBudgetCategotyHasBeenUpdated);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'ApplicationUnderTest.DivTagBudgetCategotyHasBeenUpdated'.", repo.ApplicationUnderTest.DivTagBudgetCategotyHasBeenUpdatedInfo, new RecordItemIndex(1));
            //Validate.NotExists(repo.ApplicationUnderTest.DivTagBudgetCategotyHasBeenUpdatedInfo);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.SwalModal'.", repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.SwalModalInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.SwalModalInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='The Budget Category already exists. Please revise the current entry.') on item 'ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.TheBudgetCategoryAlreadyExistsPlea'.", repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.TheBudgetCategoryAlreadyExistsPleaInfo, new RecordItemIndex(3));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.TheBudgetCategoryAlreadyExistsPleaInfo, "InnerText", "The Budget Category already exists. Please revise the current entry.");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.ButtonTagOK' at Center.", repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.ButtonTagOKInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.ButtonTagOK.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.cancelButtonTag' at Center.", repo.ApplicationUnderTest.cancelButtonTagInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.cancelButtonTag.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.searchBar_typeplaceholder' at Center.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$itemName' with focus on 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.PressKeys(itemName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(9));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.secondElement_anyTag' and assigning its value to variable 'firstRecord'.", repo.ApplicationUnderTest.secondElement_anyTagInfo, new RecordItemIndex(10));
            firstRecord = repo.ApplicationUnderTest.secondElement_anyTag.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.compareSecondRecord_IfExist(firstRecord, ".//table/tbody/tr[2]/td[1]/?");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(12));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.searchBar_typeplaceholder);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
