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
    ///The searchItem_Validate recording.
    /// </summary>
    [TestModule("61b08d33-3a70-4f24-8a2c-901bd8caba3d", ModuleType.Recording, 1)]
    public partial class searchItem_Validate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static searchItem_Validate instance = new searchItem_Validate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public searchItem_Validate()
        {
            searchItem = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static searchItem_Validate Instance
        {
            get { return instance; }
        }

#region Variables

        string _searchItem;

        /// <summary>
        /// Gets or sets the value of variable searchItem.
        /// </summary>
        [TestVariable("9e8859d4-5ffd-4cc0-9c65-ee78789e6c4d")]
        public string searchItem
        {
            get { return _searchItem; }
            set { _searchItem = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.lastRecord_secondColumnData' at Center.", repo.ApplicationUnderTest.lastRecord_secondColumnDataInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.lastRecord_secondColumnData.MoveTo();
            Delay.Milliseconds(0);
            
            // Checking for the search item in the first column of the table, in case where the searched element belongs to the first column.
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nChecking for the search item in the first column of the table, in case where the searched element belongs to the first column.\r\nValidating AttributeEqual (InnerText=$searchItem) on item 'ApplicationUnderTest.SomeTdTag_firstElement'.", repo.ApplicationUnderTest.SomeTdTag_firstElementInfo, new RecordItemIndex(1));
                Validate.AttributeEqual(repo.ApplicationUnderTest.SomeTdTag_firstElementInfo, "InnerText", searchItem, null, new Validate.Options(){ReportLevelOnFailure=ReportLevel.Warn});
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            // Checking for the search item in second column of the table, if there are more than 2 columns in table.
            // Valid in case the first validation fails.
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nChecking for the search item in second column of the table, if there are more than 2 columns in table.\r\nValid in case the first validation fails.\r\nValidating AttributeEqual (InnerText=$searchItem) on item 'ApplicationUnderTest.lastRecord_secondColumnData'.", repo.ApplicationUnderTest.lastRecord_secondColumnDataInfo, new RecordItemIndex(2));
                Validate.AttributeEqual(repo.ApplicationUnderTest.lastRecord_secondColumnDataInfo, "InnerText", searchItem, null, new Validate.Options(){ReportLevelOnFailure=ReportLevel.Warn});
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(3));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.searchBar_typeplaceholder);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
