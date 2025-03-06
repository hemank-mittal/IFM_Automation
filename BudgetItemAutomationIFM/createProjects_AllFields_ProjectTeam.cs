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
    ///The createProjects_AllFields_ProjectTeam recording.
    /// </summary>
    [TestModule("a254e000-9c81-4efe-b38e-c6a24b9ef956", ModuleType.Recording, 1)]
    public partial class createProjects_AllFields_ProjectTeam : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static createProjects_AllFields_ProjectTeam instance = new createProjects_AllFields_ProjectTeam();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public createProjects_AllFields_ProjectTeam()
        {
            fieldName = "";
            optionIndex = "";
            projectManager = "";
            associateProjectManager = "";
            closeoutSpecialist = "";
            director = "";
            invoiceManager = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static createProjects_AllFields_ProjectTeam Instance
        {
            get { return instance; }
        }

#region Variables

        string _projectManager;

        /// <summary>
        /// Gets or sets the value of variable projectManager.
        /// </summary>
        [TestVariable("c2d9a0bd-f53b-4152-8501-459ae3622969")]
        public string projectManager
        {
            get { return _projectManager; }
            set { _projectManager = value; }
        }

        string _associateProjectManager;

        /// <summary>
        /// Gets or sets the value of variable associateProjectManager.
        /// </summary>
        [TestVariable("2159bc31-cbf7-450c-941a-bd6ba61a76bc")]
        public string associateProjectManager
        {
            get { return _associateProjectManager; }
            set { _associateProjectManager = value; }
        }

        string _closeoutSpecialist;

        /// <summary>
        /// Gets or sets the value of variable closeoutSpecialist.
        /// </summary>
        [TestVariable("6693516f-79c1-4e24-a840-5c556fab5b0e")]
        public string closeoutSpecialist
        {
            get { return _closeoutSpecialist; }
            set { _closeoutSpecialist = value; }
        }

        string _director;

        /// <summary>
        /// Gets or sets the value of variable director.
        /// </summary>
        [TestVariable("988369a0-b874-4b04-9151-a68859314bbb")]
        public string director
        {
            get { return _director; }
            set { _director = value; }
        }

        string _invoiceManager;

        /// <summary>
        /// Gets or sets the value of variable invoiceManager.
        /// </summary>
        [TestVariable("d8cb372c-3278-4381-b2f7-4182748dee4a")]
        public string invoiceManager
        {
            get { return _invoiceManager; }
            set { _invoiceManager = value; }
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
        [TestVariable("f16b0abd-5da0-4310-97f6-dc525d469d82")]
        public string fieldName
        {
            get { return repo.fieldName; }
            set { repo.fieldName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable optionIndex.
        /// </summary>
        [TestVariable("9813c2d5-caaa-4588-8e08-7dc2b22f6b44")]
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.projects_Form.associatedOrganisationDiv'.", repo.ApplicationUnderTest.projects_Form.associatedOrganisationDiv.SelfInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.projects_Form.associatedOrganisationDiv.Self.EnsureVisible();
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Project Manager");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField' at Center.", repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownFieldInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField.Click();
            Delay.Milliseconds(0);
            
            optionIndex = ValueConverter.ToString(HelperMethodsCollection.getDifferentOption(repo.ApplicationUnderTest.listbox_DropdownList));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.listbox_dynamicOption' and assigning its value to variable 'projectManager'.", repo.ApplicationUnderTest.listbox_dynamicOptionInfo, new RecordItemIndex(4));
            projectManager = repo.ApplicationUnderTest.listbox_dynamicOption.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.listbox_dynamicOption' at Center.", repo.ApplicationUnderTest.listbox_dynamicOptionInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.listbox_dynamicOption.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Escape}' with focus on 'ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField'.", repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownFieldInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField.EnsureVisible();
            Keyboard.Press("{Escape}");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Associate Project Manager");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField' at Center.", repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownFieldInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField.Click();
            Delay.Milliseconds(0);
            
            optionIndex = ValueConverter.ToString(HelperMethodsCollection.getDifferentOption(repo.ApplicationUnderTest.listbox_DropdownList));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.listbox_dynamicOption' and assigning its value to variable 'associateProjectManager'.", repo.ApplicationUnderTest.listbox_dynamicOptionInfo, new RecordItemIndex(10));
            associateProjectManager = repo.ApplicationUnderTest.listbox_dynamicOption.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.listbox_dynamicOption' at Center.", repo.ApplicationUnderTest.listbox_dynamicOptionInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.listbox_dynamicOption.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Escape}' with focus on 'ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField'.", repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownFieldInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField.EnsureVisible();
            Keyboard.Press("{Escape}");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Closeout Specialist");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField_div' at Center.", repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField_divInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField_div.Click();
            Delay.Milliseconds(0);
            
            optionIndex = ValueConverter.ToString(HelperMethodsCollection.getDifferentOption(repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic' and assigning its value to variable 'closeoutSpecialist'.", repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamicInfo, new RecordItemIndex(16));
            closeoutSpecialist = repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic' at Center.", repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamicInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Escape}' with focus on 'ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField_div'.", repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField_divInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField_div.EnsureVisible();
            Keyboard.Press("{Escape}");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Director");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField_div' at Center.", repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField_divInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField_div.Click();
            Delay.Milliseconds(0);
            
            optionIndex = ValueConverter.ToString(HelperMethodsCollection.getDifferentOption(repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic' and assigning its value to variable 'director'.", repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamicInfo, new RecordItemIndex(22));
            director = repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic' at Center.", repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamicInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Escape}' with focus on 'ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField_div'.", repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField_divInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField_div.EnsureVisible();
            Keyboard.Press("{Escape}");
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Invoice Manager");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField' at Center.", repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownFieldInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField.Click();
            Delay.Milliseconds(0);
            
            optionIndex = ValueConverter.ToString(HelperMethodsCollection.getDifferentOption(repo.ApplicationUnderTest.listbox_DropdownList));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.listbox_dynamicOption' and assigning its value to variable 'invoiceManager'.", repo.ApplicationUnderTest.listbox_dynamicOptionInfo, new RecordItemIndex(28));
            invoiceManager = repo.ApplicationUnderTest.listbox_dynamicOption.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.listbox_dynamicOption' at Center.", repo.ApplicationUnderTest.listbox_dynamicOptionInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.listbox_dynamicOption.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Escape}' with focus on 'ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField'.", repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownFieldInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.projects_Form.projectTeamDiv.dynamicdropdownField.EnsureVisible();
            Keyboard.Press("{Escape}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
