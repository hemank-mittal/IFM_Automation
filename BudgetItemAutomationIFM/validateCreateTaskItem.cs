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
    ///The validateCreateTaskItem recording.
    /// </summary>
    [TestModule("75334ee3-4c9f-4150-91f6-2cb5d0be7529", ModuleType.Recording, 1)]
    public partial class validateCreateTaskItem : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static validateCreateTaskItem instance = new validateCreateTaskItem();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public validateCreateTaskItem()
        {
            itemName = "";
            testDescription = "";
            estimatedHours = "";
            assignee = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static validateCreateTaskItem Instance
        {
            get { return instance; }
        }

#region Variables

        string _itemName;

        /// <summary>
        /// Gets or sets the value of variable itemName.
        /// </summary>
        [TestVariable("e9305196-d0fe-4470-89a1-bf6e9bcdbf7d")]
        public string itemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        string _testDescription;

        /// <summary>
        /// Gets or sets the value of variable testDescription.
        /// </summary>
        [TestVariable("3b6a3c45-6cee-4a16-8064-6ee6daf7338a")]
        public string testDescription
        {
            get { return _testDescription; }
            set { _testDescription = value; }
        }

        string _estimatedHours;

        /// <summary>
        /// Gets or sets the value of variable estimatedHours.
        /// </summary>
        [TestVariable("2f742da2-e20c-4ab4-a0b6-8528814b5b10")]
        public string estimatedHours
        {
            get { return _estimatedHours; }
            set { _estimatedHours = value; }
        }

        string _assignee;

        /// <summary>
        /// Gets or sets the value of variable assignee.
        /// </summary>
        [TestVariable("1a4667f3-ec8f-4591-a6dd-f1c0049ed98d")]
        public string assignee
        {
            get { return _assignee; }
            set { _assignee = value; }
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'ApplicationUnderTest.searchBar'.", repo.ApplicationUnderTest.searchBarInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.searchBar.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.searchBar' at Center.", repo.ApplicationUnderTest.searchBarInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.searchBar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$itemName' with focus on 'ApplicationUnderTest.searchBar'.", repo.ApplicationUnderTest.searchBarInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.searchBar.PressKeys(itemName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(3));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$itemName) on item 'ApplicationUnderTest.firstElement_anyTag'.", repo.ApplicationUnderTest.firstElement_anyTagInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.ApplicationUnderTest.firstElement_anyTagInfo, "InnerText", itemName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$testDescription) on item 'ApplicationUnderTest.secondElement_anyTag'.", repo.ApplicationUnderTest.secondElement_anyTagInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.ApplicationUnderTest.secondElement_anyTagInfo, "InnerText", testDescription);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$estimatedHours) on item 'ApplicationUnderTest.thirdElement_anyTag'.", repo.ApplicationUnderTest.thirdElement_anyTagInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.ApplicationUnderTest.thirdElement_anyTagInfo, "InnerText", estimatedHours);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$assignee) on item 'ApplicationUnderTest.fourthElement_anyTag'.", repo.ApplicationUnderTest.fourthElement_anyTagInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ApplicationUnderTest.fourthElement_anyTagInfo, "InnerText", assignee);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.searchBar'.", repo.ApplicationUnderTest.searchBarInfo, new RecordItemIndex(8));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.searchBar);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'ApplicationUnderTest.searchBar'.", repo.ApplicationUnderTest.searchBarInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.searchBar.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}