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
    ///The createProjects_AllFields_BudgetInformation recording.
    /// </summary>
    [TestModule("acd24729-3642-4d2f-9835-45cd3a519f1a", ModuleType.Recording, 1)]
    public partial class createProjects_AllFields_BudgetInformation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static createProjects_AllFields_BudgetInformation instance = new createProjects_AllFields_BudgetInformation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public createProjects_AllFields_BudgetInformation()
        {
            fieldName = "";
            optionIndex = "";
            room = "";
            budgetItem = "";
            budgetTemplate = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static createProjects_AllFields_BudgetInformation Instance
        {
            get { return instance; }
        }

#region Variables

        string _room;

        /// <summary>
        /// Gets or sets the value of variable room.
        /// </summary>
        [TestVariable("cc87d509-1535-41da-a7b5-09e689a2dc94")]
        public string room
        {
            get { return _room; }
            set { _room = value; }
        }

        string _budgetItem;

        /// <summary>
        /// Gets or sets the value of variable budgetItem.
        /// </summary>
        [TestVariable("6e88ef5c-d849-46e3-a5a5-c8c554ba8fdf")]
        public string budgetItem
        {
            get { return _budgetItem; }
            set { _budgetItem = value; }
        }

        string _budgetTemplate;

        /// <summary>
        /// Gets or sets the value of variable budgetTemplate.
        /// </summary>
        [TestVariable("7a037512-a194-4d98-b40f-fd8d68c3e872")]
        public string budgetTemplate
        {
            get { return _budgetTemplate; }
            set { _budgetTemplate = value; }
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
        [TestVariable("bcd665f5-a0ef-4c59-b121-8fb198905bdb")]
        public string fieldName
        {
            get { return repo.fieldName; }
            set { repo.fieldName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable optionIndex.
        /// </summary>
        [TestVariable("89c71642-42bb-40bb-8c04-1eac29964068")]
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.projects_Form.uploadProjectPictureDiv'.", repo.ApplicationUnderTest.projects_Form.uploadProjectPictureDivInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.projects_Form.uploadProjectPictureDiv.EnsureVisible();
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Select Budget Item");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.addBudgetInformationDiv.dynamicdropdownField_div' at Center.", repo.ApplicationUnderTest.projects_Form.addBudgetInformationDiv.dynamicdropdownField_divInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.projects_Form.addBudgetInformationDiv.dynamicdropdownField_div.Click();
            Delay.Milliseconds(0);
            
            optionIndex = ValueConverter.ToString(HelperMethodsCollection.getDifferentOption(repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic' and assigning its value to variable 'budgetItem'.", repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamicInfo, new RecordItemIndex(4));
            budgetItem = repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic' at Center.", repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamicInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic.Click();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.addBudgetInformationDiv.dynamicdropdownField_div' at Center.", repo.ApplicationUnderTest.projects_Form.addBudgetInformationDiv.dynamicdropdownField_divInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.projects_Form.addBudgetInformationDiv.dynamicdropdownField_div.Click();
            Delay.Milliseconds(0);
            
            fieldName = HelperMethodsCollection.assignVariable("Select Budget Template");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.addBudgetInformationDiv.dynamicdropdownField_div' at Center.", repo.ApplicationUnderTest.projects_Form.addBudgetInformationDiv.dynamicdropdownField_divInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.projects_Form.addBudgetInformationDiv.dynamicdropdownField_div.Click();
            Delay.Milliseconds(0);
            
            optionIndex = ValueConverter.ToString(HelperMethodsCollection.getDifferentOption(repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic' and assigning its value to variable 'budgetTemplate'.", repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamicInfo, new RecordItemIndex(11));
            budgetTemplate = repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic' at Center.", repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamicInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.projects_Form.visibleDropdown_ul_dynamic.Click();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.projects_Form.addBudgetInformationDiv.dynamicdropdownField_div' at Center.", repo.ApplicationUnderTest.projects_Form.addBudgetInformationDiv.dynamicdropdownField_divInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.projects_Form.addBudgetInformationDiv.dynamicdropdownField_div.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
