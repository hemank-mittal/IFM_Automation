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
    ///The validateEditItem_Category_Success recording.
    /// </summary>
    [TestModule("ac82b10c-4fef-49d7-94f4-12c4eb7a2aae", ModuleType.Recording, 1)]
    public partial class validateEditItem_Category_Success : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static validateEditItem_Category_Success instance = new validateEditItem_Category_Success();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public validateEditItem_Category_Success()
        {
            linkedCategory = "";
            itemName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static validateEditItem_Category_Success Instance
        {
            get { return instance; }
        }

#region Variables

        string _linkedCategory;

        /// <summary>
        /// Gets or sets the value of variable linkedCategory.
        /// </summary>
        [TestVariable("b6f98589-6d31-485d-bdf4-19fa2ff5878f")]
        public string linkedCategory
        {
            get { return _linkedCategory; }
            set { _linkedCategory = value; }
        }

        string _itemName;

        /// <summary>
        /// Gets or sets the value of variable itemName.
        /// </summary>
        [TestVariable("153d61e4-0ffc-4040-ae8a-59431bd238a9")]
        public string itemName
        {
            get { return _itemName; }
            set { _itemName = value; }
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
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to ' ' on item 'ApplicationUnderTest.searchBar'.", repo.ApplicationUnderTest.searchBarInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.searchBar.Element.SetAttributeValue("TagValue", " ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$itemName' with focus on 'ApplicationUnderTest.searchBar'.", repo.ApplicationUnderTest.searchBarInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.searchBar.PressKeys(itemName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$linkedCategory) on item 'ApplicationUnderTest.SomeTdTag_firstElement'.", repo.ApplicationUnderTest.SomeTdTag_firstElementInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SomeTdTag_firstElementInfo, "InnerText", linkedCategory);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.searchBar'.", repo.ApplicationUnderTest.searchBarInfo, new RecordItemIndex(4));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.searchBar);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'ApplicationUnderTest.searchBar'.", repo.ApplicationUnderTest.searchBarInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.searchBar.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
