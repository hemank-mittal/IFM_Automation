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
    ///The createTaskTemplate recording.
    /// </summary>
    [TestModule("20a7ff25-66dd-4d68-94a9-e502a7b6bbe6", ModuleType.Recording, 1)]
    public partial class createTaskTemplate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static createTaskTemplate instance = new createTaskTemplate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public createTaskTemplate()
        {
            itemCount = "";
            newTemplateName = "";
            isProject = "";
            optionIndex = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static createTaskTemplate Instance
        {
            get { return instance; }
        }

#region Variables

        string _itemCount;

        /// <summary>
        /// Gets or sets the value of variable itemCount.
        /// </summary>
        [TestVariable("e16e3b07-d383-4887-bb18-efc6a66888e8")]
        public string itemCount
        {
            get { return _itemCount; }
            set { _itemCount = value; }
        }

        string _isProject;

        /// <summary>
        /// Gets or sets the value of variable isProject.
        /// </summary>
        [TestVariable("58b648fe-850e-476c-882d-dcc5f5df6b52")]
        public string isProject
        {
            get { return _isProject; }
            set { _isProject = value; }
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
        /// Gets or sets the value of variable TaskItemName.
        /// </summary>
        [TestVariable("a5ab52d7-b861-4dbb-8aad-b5fcc352ba74")]
        public string TaskItemName
        {
            get { return repo.TaskItemName; }
            set { repo.TaskItemName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable newTemplateName.
        /// </summary>
        [TestVariable("3be65b95-9355-4312-b3e0-92276ef440d5")]
        public string newTemplateName
        {
            get { return repo.newTemplateName; }
            set { repo.newTemplateName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable optionIndex.
        /// </summary>
        [TestVariable("70f5b9e7-2e9c-4467-96fc-4ab3f9203fae")]
        public string optionIndex
        {
            get { return repo.optionIndex; }
            set { repo.optionIndex = value; }
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
            
            itemCount = ValueConverter.ToString(HelperMethodsCollection.getItemsCount(repo.ApplicationUnderTest.Content1.MatAccordion));
            Delay.Milliseconds(0);
            
            newTemplateName = HelperMethodsCollection.getNewCreateItem(ValueConverter.ArgumentFromString<int>("nextCount", itemCount), "template");
            Delay.Milliseconds(0);
            
            Mouse_Click_createSpanTag();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.Text' at Center.", repo.ApplicationUnderTest.Content1.TextInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Content1.Text.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.Content1.Text'.", repo.ApplicationUnderTest.Content1.TextInfo, new RecordItemIndex(5));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.Content1.Text);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'ApplicationUnderTest.Content1.Text'.", repo.ApplicationUnderTest.Content1.TextInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Content1.Text.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$newTemplateName' with focus on 'ApplicationUnderTest.Content1.Text'.", repo.ApplicationUnderTest.Content1.TextInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.Content1.Text.PressKeys(newTemplateName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.MatMdcSelectValueNgTnsC3393473648' at Center.", repo.ApplicationUnderTest.Content1.MatMdcSelectValueNgTnsC3393473648Info, new RecordItemIndex(8));
            repo.ApplicationUnderTest.Content1.MatMdcSelectValueNgTnsC3393473648.Click();
            Delay.Milliseconds(0);
            
            Mouse_Click_selectDropdown_FirstInstance(ValueConverter.ArgumentFromString<bool>("isProjectType", isProject));
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.MatMdcSelectMinLineMatMdcSelectP' at Center.", repo.ApplicationUnderTest.Content1.MatMdcSelectMinLineMatMdcSelectPInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.Content1.MatMdcSelectMinLineMatMdcSelectP.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CdkOverlayContainer.selectDropdown_dynamicName' at Center.", repo.ApplicationUnderTest.CdkOverlayContainer.selectDropdown_dynamicNameInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.CdkOverlayContainer.selectDropdown_dynamicName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Escape}' with focus on 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.Self.EnsureVisible();
            Keyboard.Press("{Escape}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.ButtonTagSave1' at Center.", repo.ApplicationUnderTest.Content1.ButtonTagSave1Info, new RecordItemIndex(14));
            repo.ApplicationUnderTest.Content1.ButtonTagSave1.Click();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
