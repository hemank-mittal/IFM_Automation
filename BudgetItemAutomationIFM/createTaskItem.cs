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
    ///The createTaskItem recording.
    /// </summary>
    [TestModule("5542e18c-27c7-4a44-906c-df003e82954f", ModuleType.Recording, 1)]
    public partial class createTaskItem : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static createTaskItem instance = new createTaskItem();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public createTaskItem()
        {
            itemCount = "";
            newTemplateName = "";
            testDescription = "";
            estimateHours = "";
            assignee = "";
            isProject = "";
            TaskItemName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static createTaskItem Instance
        {
            get { return instance; }
        }

#region Variables

        string _itemCount;

        /// <summary>
        /// Gets or sets the value of variable itemCount.
        /// </summary>
        [TestVariable("ded0e799-de03-4a20-8595-bc7a07052caf")]
        public string itemCount
        {
            get { return _itemCount; }
            set { _itemCount = value; }
        }

        string _testDescription;

        /// <summary>
        /// Gets or sets the value of variable testDescription.
        /// </summary>
        [TestVariable("11738667-4fd0-41ea-a884-b17a2f562a88")]
        public string testDescription
        {
            get { return _testDescription; }
            set { _testDescription = value; }
        }

        string _estimateHours;

        /// <summary>
        /// Gets or sets the value of variable estimateHours.
        /// </summary>
        [TestVariable("2fd66916-a69b-4062-a288-783825328bed")]
        public string estimateHours
        {
            get { return _estimateHours; }
            set { _estimateHours = value; }
        }

        string _assignee;

        /// <summary>
        /// Gets or sets the value of variable assignee.
        /// </summary>
        [TestVariable("4ce463ba-d1f4-4932-b173-0a8f614046d1")]
        public string assignee
        {
            get { return _assignee; }
            set { _assignee = value; }
        }

        string _isProject;

        /// <summary>
        /// Gets or sets the value of variable isProject.
        /// </summary>
        [TestVariable("88fa61d6-c64c-4850-ae1f-4b7c59a623cd")]
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
        /// Gets or sets the value of variable newTemplateName.
        /// </summary>
        [TestVariable("5a582a80-f1d0-460a-b4ab-563ab680ed2e")]
        public string newTemplateName
        {
            get { return repo.newTemplateName; }
            set { repo.newTemplateName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TaskItemName.
        /// </summary>
        [TestVariable("018d893f-7691-4f7e-9c8e-fd1fe716d046")]
        public string TaskItemName
        {
            get { return repo.TaskItemName; }
            set { repo.TaskItemName = value; }
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
            
            itemCount = ValueConverter.ToString(HelperMethodsCollection.getNumberOfRecordsFromFooter(repo.ApplicationUnderTest.showingNumberOfRecords));
            Delay.Milliseconds(0);
            
            newTemplateName = HelperMethodsCollection.getNewCreateItem(ValueConverter.ArgumentFromString<int>("nextCount", itemCount), "category");
            Delay.Milliseconds(0);
            
            Mouse_Click_createSpanTag();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TitleInputBar' at Center.", repo.ApplicationUnderTest.TitleInputBarInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.TitleInputBar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$newTemplateName' with focus on 'ApplicationUnderTest.TitleInputBar'.", repo.ApplicationUnderTest.TitleInputBarInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.TitleInputBar.PressKeys(newTemplateName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.TitleInputBar' and assigning its value to variable 'TaskItemName'.", repo.ApplicationUnderTest.TitleInputBarInfo, new RecordItemIndex(7));
            TaskItemName = repo.ApplicationUnderTest.TitleInputBar.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.taskItemForm.taskItem_Description' at Center.", repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_DescriptionInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_Description.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$testDescription' with focus on 'ApplicationUnderTest.Content1.taskItemForm.taskItem_Description'.", repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_DescriptionInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_Description.PressKeys(testDescription);
            Delay.Milliseconds(0);
            
            Mouse_Click_isProjectTask(repo.ApplicationUnderTest.Content1.taskItemForm.isProjectTaskInfo, ValueConverter.ArgumentFromString<bool>("isProjectType", isProject));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.taskItemForm.taskItem_AssigneeDropdown' at Center.", repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_AssigneeDropdownInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_AssigneeDropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.Content1.taskItemForm.taskItem_Assignee_FirstInstance' and assigning its value to variable 'assignee'.", repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_Assignee_FirstInstanceInfo, new RecordItemIndex(12));
            assignee = repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_Assignee_FirstInstance.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.taskItemForm.taskItem_Assignee_FirstInstance' at Center.", repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_Assignee_FirstInstanceInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_Assignee_FirstInstance.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.taskItemForm.taskItem_AssigneeDropdown' at Center.", repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_AssigneeDropdownInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_AssigneeDropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.taskItemForm.taskItem_EstimatedHour' at Center.", repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_EstimatedHourInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_EstimatedHour.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$estimateHours' with focus on 'ApplicationUnderTest.Content1.taskItemForm.taskItem_EstimatedHour'.", repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_EstimatedHourInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_EstimatedHour.PressKeys(estimateHours);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.taskItemForm.taskItem_Priority' at Center.", repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_PriorityInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.Content1.taskItemForm.taskItem_Priority.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CdkOverlayContainer.selectDropdown_FirstInstance' at Center.", repo.ApplicationUnderTest.CdkOverlayContainer.selectDropdown_FirstInstanceInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.CdkOverlayContainer.selectDropdown_FirstInstance.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.taskItemForm.Save' at Center.", repo.ApplicationUnderTest.Content1.taskItemForm.SaveInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.Content1.taskItemForm.Save.Click();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
