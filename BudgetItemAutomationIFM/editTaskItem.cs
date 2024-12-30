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
    ///The editTaskItem recording.
    /// </summary>
    [TestModule("381bf380-3dd6-44be-b56d-2c907fd4ba43", ModuleType.Recording, 1)]
    public partial class editTaskItem : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static editTaskItem instance = new editTaskItem();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public editTaskItem()
        {
            oldName = "";
            edittedName = "";
            optionIndex = "";
            estimateHours = "";
            editedDescription = "";
            editedAssignee = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static editTaskItem Instance
        {
            get { return instance; }
        }

#region Variables

        string _oldName;

        /// <summary>
        /// Gets or sets the value of variable oldName.
        /// </summary>
        [TestVariable("f90ce3d1-99d6-4a47-a40d-0b4739487d5c")]
        public string oldName
        {
            get { return _oldName; }
            set { _oldName = value; }
        }

        string _edittedName;

        /// <summary>
        /// Gets or sets the value of variable edittedName.
        /// </summary>
        [TestVariable("c8c277e2-2de6-4f0e-9be5-9287580ff735")]
        public string edittedName
        {
            get { return _edittedName; }
            set { _edittedName = value; }
        }

        string _estimateHours;

        /// <summary>
        /// Gets or sets the value of variable estimateHours.
        /// </summary>
        [TestVariable("396e897a-04f1-4f1d-b5b2-4a84b8d65f35")]
        public string estimateHours
        {
            get { return _estimateHours; }
            set { _estimateHours = value; }
        }

        string _editedDescription;

        /// <summary>
        /// Gets or sets the value of variable editedDescription.
        /// </summary>
        [TestVariable("6c407113-f617-47a7-b178-6b5263daeee7")]
        public string editedDescription
        {
            get { return _editedDescription; }
            set { _editedDescription = value; }
        }

        string _editedAssignee;

        /// <summary>
        /// Gets or sets the value of variable editedAssignee.
        /// </summary>
        [TestVariable("df552e06-c285-486f-8bc5-4baed9d2938e")]
        public string editedAssignee
        {
            get { return _editedAssignee; }
            set { _editedAssignee = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable optionIndex.
        /// </summary>
        [TestVariable("6214e3ac-7de1-4256-b501-b9de83aa54b7")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ButtonTagEdit_Row2' at Center.", repo.ApplicationUnderTest.ButtonTagEdit_Row2Info, new RecordItemIndex(0));
            repo.ApplicationUnderTest.ButtonTagEdit_Row2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.FaFaSpinFaSpinner'", repo.ApplicationUnderTest.FaFaSpinFaSpinnerInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.ApplicationUnderTest.FaFaSpinFaSpinnerInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TitleInputBar' at Center.", repo.ApplicationUnderTest.TitleInputBarInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.TitleInputBar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.TitleInputBar' and assigning its value to variable 'oldName'.", repo.ApplicationUnderTest.TitleInputBarInfo, new RecordItemIndex(3));
            oldName = repo.ApplicationUnderTest.TitleInputBar.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            edittedName = HelperMethodsCollection.getEdittedName(oldName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'ApplicationUnderTest.TitleInputBar'.", repo.ApplicationUnderTest.TitleInputBarInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.TitleInputBar.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$edittedName' with focus on 'ApplicationUnderTest.TitleInputBar'.", repo.ApplicationUnderTest.TitleInputBarInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.TitleInputBar.PressKeys(edittedName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TitleInputBar' at Center.", repo.ApplicationUnderTest.TitleInputBarInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.TitleInputBar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.taskItem_Description' at Center.", repo.ApplicationUnderTest.Content1.taskItem_DescriptionInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.Content1.taskItem_Description.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.Content1.taskItem_Description' and assigning its value to variable 'oldName'.", repo.ApplicationUnderTest.Content1.taskItem_DescriptionInfo, new RecordItemIndex(9));
            oldName = repo.ApplicationUnderTest.Content1.taskItem_Description.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            editedDescription = HelperMethodsCollection.getEdittedName(oldName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'ApplicationUnderTest.Content1.taskItem_Description'.", repo.ApplicationUnderTest.Content1.taskItem_DescriptionInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.Content1.taskItem_Description.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$editedDescription' with focus on 'ApplicationUnderTest.Content1.taskItem_Description'.", repo.ApplicationUnderTest.Content1.taskItem_DescriptionInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.Content1.taskItem_Description.PressKeys(editedDescription);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.taskItem_AssigneeDropdown' at Center.", repo.ApplicationUnderTest.Content1.taskItem_AssigneeDropdownInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.Content1.taskItem_AssigneeDropdown.Click();
            Delay.Milliseconds(0);
            
            optionIndex = ValueConverter.ToString(HelperMethodsCollection.getDifferentOption(repo.ApplicationUnderTest.Content1.taskItem_Assignee_Dropdown));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.taskItem_Assignee_selected' at Center.", repo.ApplicationUnderTest.Content1.taskItem_Assignee_selectedInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.Content1.taskItem_Assignee_selected.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.Content1.taskItem_Assignee_dynamic' and assigning its value to variable 'editedAssignee'.", repo.ApplicationUnderTest.Content1.taskItem_Assignee_dynamicInfo, new RecordItemIndex(16));
            editedAssignee = repo.ApplicationUnderTest.Content1.taskItem_Assignee_dynamic.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.taskItem_Assignee_dynamic' at Center.", repo.ApplicationUnderTest.Content1.taskItem_Assignee_dynamicInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.Content1.taskItem_Assignee_dynamic.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.taskItem_AssigneeDropdown' at Center.", repo.ApplicationUnderTest.Content1.taskItem_AssigneeDropdownInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.Content1.taskItem_AssigneeDropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.taskItem_EstimatedHour' at Center.", repo.ApplicationUnderTest.Content1.taskItem_EstimatedHourInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.Content1.taskItem_EstimatedHour.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.Content1.taskItem_EstimatedHour' and assigning its value to variable 'estimateHours'.", repo.ApplicationUnderTest.Content1.taskItem_EstimatedHourInfo, new RecordItemIndex(20));
            estimateHours = repo.ApplicationUnderTest.Content1.taskItem_EstimatedHour.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            estimateHours = ValueConverter.ToString(HelperMethodsCollection.getEditedNumber(ValueConverter.ArgumentFromString<int>("oldNumber", estimateHours)));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'ApplicationUnderTest.Content1.taskItem_EstimatedHour'.", repo.ApplicationUnderTest.Content1.taskItem_EstimatedHourInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.Content1.taskItem_EstimatedHour.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$estimateHours' with focus on 'ApplicationUnderTest.Content1.taskItem_EstimatedHour'.", repo.ApplicationUnderTest.Content1.taskItem_EstimatedHourInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.Content1.taskItem_EstimatedHour.PressKeys(estimateHours);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.taskItem_Priority' at Center.", repo.ApplicationUnderTest.Content1.taskItem_PriorityInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.Content1.taskItem_Priority.Click();
            Delay.Milliseconds(0);
            
            optionIndex = ValueConverter.ToString(HelperMethodsCollection.getDifferentOption(repo.ApplicationUnderTest.CdkOverlayContainer.selectDropdown_options));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CdkOverlayContainer.selectDropdown_dynamicIndex' at Center.", repo.ApplicationUnderTest.CdkOverlayContainer.selectDropdown_dynamicIndexInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.CdkOverlayContainer.selectDropdown_dynamicIndex.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.Save' at Center.", repo.ApplicationUnderTest.Content1.SaveInfo, new RecordItemIndex(27));
            repo.ApplicationUnderTest.Content1.Save.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to not exist. Associated repository item: 'ApplicationUnderTest.FaFaSpinFaSpinner'", repo.ApplicationUnderTest.FaFaSpinFaSpinnerInfo, new ActionTimeout(60000), new RecordItemIndex(28));
            repo.ApplicationUnderTest.FaFaSpinFaSpinnerInfo.WaitForNotExists(60000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}