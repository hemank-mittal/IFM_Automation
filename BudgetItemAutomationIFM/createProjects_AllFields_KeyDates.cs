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
    ///The createProjects_AllFields_KeyDates recording.
    /// </summary>
    [TestModule("35031057-ea1d-43e1-bf5d-e077f7d0c06d", ModuleType.Recording, 1)]
    public partial class createProjects_AllFields_KeyDates : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static createProjects_AllFields_KeyDates instance = new createProjects_AllFields_KeyDates();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public createProjects_AllFields_KeyDates()
        {
            fieldName = "";
            finalCompletion = "";
            projectStartDate = "";
            designStartDate = "";
            constructionStartDate = "";
            constructionCompletionDate = "";
            optionIndex = "";
            keyDateLabel = "";
            keyDateTemplate = "";
            aeNtp = "";
            phase1_30 = "";
            phase2_60 = "";
            phase3_90 = "";
            permitSet = "";
            ownerBoardApproval = "";
            gcSubBidOpening = "";
            gmp = "";
            constNtp = "";
            substantialCompletion = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static createProjects_AllFields_KeyDates Instance
        {
            get { return instance; }
        }

#region Variables

        string _finalCompletion;

        /// <summary>
        /// Gets or sets the value of variable finalCompletion.
        /// </summary>
        [TestVariable("6046eee9-b6c0-4726-9c69-6ce0ced52208")]
        public string finalCompletion
        {
            get { return _finalCompletion; }
            set { _finalCompletion = value; }
        }

        string _projectStartDate;

        /// <summary>
        /// Gets or sets the value of variable projectStartDate.
        /// </summary>
        [TestVariable("65f1f0f8-ff15-4ba6-8c1b-66ca61c8ba54")]
        public string projectStartDate
        {
            get { return _projectStartDate; }
            set { _projectStartDate = value; }
        }

        string _designStartDate;

        /// <summary>
        /// Gets or sets the value of variable designStartDate.
        /// </summary>
        [TestVariable("b21dc5a7-55aa-451e-ab44-7b98d75cc920")]
        public string designStartDate
        {
            get { return _designStartDate; }
            set { _designStartDate = value; }
        }

        string _constructionStartDate;

        /// <summary>
        /// Gets or sets the value of variable constructionStartDate.
        /// </summary>
        [TestVariable("2c120549-eadd-4899-ba93-f912f3cdbfef")]
        public string constructionStartDate
        {
            get { return _constructionStartDate; }
            set { _constructionStartDate = value; }
        }

        string _constructionCompletionDate;

        /// <summary>
        /// Gets or sets the value of variable constructionCompletionDate.
        /// </summary>
        [TestVariable("5b3ba459-fcc4-4dc5-ad32-67bfd3c84225")]
        public string constructionCompletionDate
        {
            get { return _constructionCompletionDate; }
            set { _constructionCompletionDate = value; }
        }

        string _keyDateLabel;

        /// <summary>
        /// Gets or sets the value of variable keyDateLabel.
        /// </summary>
        [TestVariable("90671625-73d9-47d3-a0b7-b66690dee010")]
        public string keyDateLabel
        {
            get { return _keyDateLabel; }
            set { _keyDateLabel = value; }
        }

        string _keyDateTemplate;

        /// <summary>
        /// Gets or sets the value of variable keyDateTemplate.
        /// </summary>
        [TestVariable("5148c2c8-6c50-4ad6-aff0-1d7056f12fea")]
        public string keyDateTemplate
        {
            get { return _keyDateTemplate; }
            set { _keyDateTemplate = value; }
        }

        string _aeNtp;

        /// <summary>
        /// Gets or sets the value of variable aeNtp.
        /// </summary>
        [TestVariable("ea0fae54-8ccc-4622-be2c-2dac1b3895b3")]
        public string aeNtp
        {
            get { return _aeNtp; }
            set { _aeNtp = value; }
        }

        string _phase1_30;

        /// <summary>
        /// Gets or sets the value of variable phase1_30.
        /// </summary>
        [TestVariable("64eaa68d-2d78-407f-8607-5d4c19b5735d")]
        public string phase1_30
        {
            get { return _phase1_30; }
            set { _phase1_30 = value; }
        }

        string _phase2_60;

        /// <summary>
        /// Gets or sets the value of variable phase2_60.
        /// </summary>
        [TestVariable("8f5304fe-af5e-41fb-a084-962f07ff4f22")]
        public string phase2_60
        {
            get { return _phase2_60; }
            set { _phase2_60 = value; }
        }

        string _phase3_90;

        /// <summary>
        /// Gets or sets the value of variable phase3_90.
        /// </summary>
        [TestVariable("10546e1f-20c9-4079-906f-231f3e45d8fb")]
        public string phase3_90
        {
            get { return _phase3_90; }
            set { _phase3_90 = value; }
        }

        string _permitSet;

        /// <summary>
        /// Gets or sets the value of variable permitSet.
        /// </summary>
        [TestVariable("4a428b86-9461-49c5-baec-b0a4199879a7")]
        public string permitSet
        {
            get { return _permitSet; }
            set { _permitSet = value; }
        }

        string _ownerBoardApproval;

        /// <summary>
        /// Gets or sets the value of variable ownerBoardApproval.
        /// </summary>
        [TestVariable("0bd3bf31-648c-468a-8bf5-bd9939a84575")]
        public string ownerBoardApproval
        {
            get { return _ownerBoardApproval; }
            set { _ownerBoardApproval = value; }
        }

        string _gcSubBidOpening;

        /// <summary>
        /// Gets or sets the value of variable gcSubBidOpening.
        /// </summary>
        [TestVariable("5cd2b2bf-cf41-4868-b09a-9fe46953eac2")]
        public string gcSubBidOpening
        {
            get { return _gcSubBidOpening; }
            set { _gcSubBidOpening = value; }
        }

        string _gmp;

        /// <summary>
        /// Gets or sets the value of variable gmp.
        /// </summary>
        [TestVariable("12dd12a9-acc3-48ad-9ef2-722dbed83610")]
        public string gmp
        {
            get { return _gmp; }
            set { _gmp = value; }
        }

        string _constNtp;

        /// <summary>
        /// Gets or sets the value of variable constNtp.
        /// </summary>
        [TestVariable("5741bb18-f844-445d-82a0-840fa6cce56c")]
        public string constNtp
        {
            get { return _constNtp; }
            set { _constNtp = value; }
        }

        string _substantialCompletion;

        /// <summary>
        /// Gets or sets the value of variable substantialCompletion.
        /// </summary>
        [TestVariable("5fab47e8-04d4-4f75-8c3a-12914e649256")]
        public string substantialCompletion
        {
            get { return _substantialCompletion; }
            set { _substantialCompletion = value; }
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
        /// Gets or sets the value of variable fieldName.
        /// </summary>
        [TestVariable("b57915f1-5c1a-47b5-9e43-cf78f7c8897b")]
        public string fieldName
        {
            get { return repo.fieldName; }
            set { repo.fieldName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable optionIndex.
        /// </summary>
        [TestVariable("7952eff7-a802-49c7-914d-e35a913f697d")]
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.projects_Form.keyDatesDiv'.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.SelfInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.Self.EnsureVisible();
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Project Start Date");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' at Center.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.calendarElement_date1' at Center.", repo.ApplicationUnderTest.calendarElement_date1Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.calendarElement_date1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' and assigning its value to variable 'projectStartDate'.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(4));
            projectStartDate = repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Design Start Date");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' at Center.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.calendarElement_date1' at Center.", repo.ApplicationUnderTest.calendarElement_date1Info, new RecordItemIndex(7));
            repo.ApplicationUnderTest.calendarElement_date1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' and assigning its value to variable 'designStartDate'.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(8));
            designStartDate = repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Construction Start Date");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' at Center.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.calendarElement_date2' at Center.", repo.ApplicationUnderTest.calendarElement_date2Info, new RecordItemIndex(11));
            repo.ApplicationUnderTest.calendarElement_date2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' and assigning its value to variable 'constructionStartDate'.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(12));
            constructionStartDate = repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Construction Completion Date");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' at Center.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.calendarElement_date3' at Center.", repo.ApplicationUnderTest.calendarElement_date3Info, new RecordItemIndex(15));
            repo.ApplicationUnderTest.calendarElement_date3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' and assigning its value to variable 'constructionCompletionDate'.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(16));
            constructionCompletionDate = repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Add Key Date Label");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicdropdownField_div' at Center.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicdropdownField_divInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicdropdownField_div.Click();
            Delay.Milliseconds(0);
            
            optionIndex = ValueConverter.ToString(HelperMethodsCollection.getDifferentOption(repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic' and assigning its value to variable 'keyDateLabel'.", repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamicInfo, new RecordItemIndex(20));
            keyDateLabel = repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic' at Center.", repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamicInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic.Click();
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Add Key Date Template");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicdropdownField_div' at Center.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicdropdownField_divInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicdropdownField_div.Click();
            Delay.Milliseconds(0);
            
            optionIndex = ValueConverter.ToString(HelperMethodsCollection.getDifferentOption(repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic' and assigning its value to variable 'keyDateTemplate'.", repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamicInfo, new RecordItemIndex(25));
            keyDateTemplate = repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic' at Center.", repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamicInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic.Click();
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("AE NTP");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' at Center.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.calendarElement_date1' at Center.", repo.ApplicationUnderTest.calendarElement_date1Info, new RecordItemIndex(29));
            repo.ApplicationUnderTest.calendarElement_date1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' and assigning its value to variable 'aeNtp'.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(30));
            aeNtp = repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Phase 1 (30%)");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' at Center.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(32));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.calendarElement_date1' at Center.", repo.ApplicationUnderTest.calendarElement_date1Info, new RecordItemIndex(33));
            repo.ApplicationUnderTest.calendarElement_date1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' and assigning its value to variable 'phase1_30'.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(34));
            phase1_30 = repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Phase 2 (60%)");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' at Center.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(36));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.calendarElement_date1' at Center.", repo.ApplicationUnderTest.calendarElement_date1Info, new RecordItemIndex(37));
            repo.ApplicationUnderTest.calendarElement_date1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' and assigning its value to variable 'phase2_60'.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(38));
            phase2_60 = repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Phase 3 (90%)");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' at Center.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(40));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.calendarElement_date1' at Center.", repo.ApplicationUnderTest.calendarElement_date1Info, new RecordItemIndex(41));
            repo.ApplicationUnderTest.calendarElement_date1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' and assigning its value to variable 'phase3_90'.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(42));
            phase3_90 = repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Permit Set");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' at Center.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(44));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.calendarElement_date1' at Center.", repo.ApplicationUnderTest.calendarElement_date1Info, new RecordItemIndex(45));
            repo.ApplicationUnderTest.calendarElement_date1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' and assigning its value to variable 'permitSet'.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(46));
            permitSet = repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Owner/Board Approval");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' at Center.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(48));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.calendarElement_date1' at Center.", repo.ApplicationUnderTest.calendarElement_date1Info, new RecordItemIndex(49));
            repo.ApplicationUnderTest.calendarElement_date1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' and assigning its value to variable 'ownerBoardApproval'.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(50));
            ownerBoardApproval = repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("GC Sub Bid Opening");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' at Center.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(52));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.calendarElement_date1' at Center.", repo.ApplicationUnderTest.calendarElement_date1Info, new RecordItemIndex(53));
            repo.ApplicationUnderTest.calendarElement_date1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' and assigning its value to variable 'gcSubBidOpening'.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(54));
            gcSubBidOpening = repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("GMP");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' at Center.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(56));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.calendarElement_date1' at Center.", repo.ApplicationUnderTest.calendarElement_date1Info, new RecordItemIndex(57));
            repo.ApplicationUnderTest.calendarElement_date1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' and assigning its value to variable 'gmp'.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(58));
            gmp = repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Const NTP");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' at Center.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(60));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.calendarElement_date1' at Center.", repo.ApplicationUnderTest.calendarElement_date1Info, new RecordItemIndex(61));
            repo.ApplicationUnderTest.calendarElement_date1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' and assigning its value to variable 'constNtp'.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(62));
            constNtp = repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Substantial Completion");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' at Center.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(64));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.calendarElement_date1' at Center.", repo.ApplicationUnderTest.calendarElement_date1Info, new RecordItemIndex(65));
            repo.ApplicationUnderTest.calendarElement_date1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' and assigning its value to variable 'substantialCompletion'.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(66));
            substantialCompletion = repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Final Completion");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' at Center.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(68));
            repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.calendarElement_date1' at Center.", repo.ApplicationUnderTest.calendarElement_date1Info, new RecordItemIndex(69));
            repo.ApplicationUnderTest.calendarElement_date1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField' and assigning its value to variable 'finalCompletion'.", repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputFieldInfo, new RecordItemIndex(70));
            finalCompletion = repo.ApplicationUnderTest.projects_Form.keyDatesDiv.dynamicInputField.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
