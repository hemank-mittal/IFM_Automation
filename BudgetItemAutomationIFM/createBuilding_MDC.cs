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
    ///The createBuilding_MDC recording.
    /// </summary>
    [TestModule("16557317-d4dc-42aa-b350-4f4843732c52", ModuleType.Recording, 1)]
    public partial class createBuilding_MDC : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static createBuilding_MDC instance = new createBuilding_MDC();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public createBuilding_MDC()
        {
            itemCount = "";
            newTemplateName = "";
            dateContructed = "";
            architect = "";
            contractor = "";
            renovationHistory = "";
            constructionCost = "";
            description = "";
            buildingNumber = "";
            optionIndex = "";
            noOfFloors = "";
            campus = "";
            zone = "";
            wing = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static createBuilding_MDC Instance
        {
            get { return instance; }
        }

#region Variables

        string _itemCount;

        /// <summary>
        /// Gets or sets the value of variable itemCount.
        /// </summary>
        [TestVariable("85087945-31a9-4f0b-99fd-62ff61966da7")]
        public string itemCount
        {
            get { return _itemCount; }
            set { _itemCount = value; }
        }

        string _dateContructed;

        /// <summary>
        /// Gets or sets the value of variable dateContructed.
        /// </summary>
        [TestVariable("559edea3-389d-4aea-9e3a-9a47406ca612")]
        public string dateContructed
        {
            get { return _dateContructed; }
            set { _dateContructed = value; }
        }

        string _architect;

        /// <summary>
        /// Gets or sets the value of variable architect.
        /// </summary>
        [TestVariable("26f7a7de-588e-4638-ab4b-21a381de2841")]
        public string architect
        {
            get { return _architect; }
            set { _architect = value; }
        }

        string _contractor;

        /// <summary>
        /// Gets or sets the value of variable contractor.
        /// </summary>
        [TestVariable("2210705c-40c7-4e2f-99a5-7f21905df321")]
        public string contractor
        {
            get { return _contractor; }
            set { _contractor = value; }
        }

        string _renovationHistory;

        /// <summary>
        /// Gets or sets the value of variable renovationHistory.
        /// </summary>
        [TestVariable("be013f65-77a0-40b5-b7dc-d5ab85f778b5")]
        public string renovationHistory
        {
            get { return _renovationHistory; }
            set { _renovationHistory = value; }
        }

        string _constructionCost;

        /// <summary>
        /// Gets or sets the value of variable constructionCost.
        /// </summary>
        [TestVariable("33e6d6e1-c80e-4f5c-8eef-fbba038c6be2")]
        public string constructionCost
        {
            get { return _constructionCost; }
            set { _constructionCost = value; }
        }

        string _description;

        /// <summary>
        /// Gets or sets the value of variable description.
        /// </summary>
        [TestVariable("d0139cd5-1d41-4d54-8834-f41605c97662")]
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }

        string _buildingNumber;

        /// <summary>
        /// Gets or sets the value of variable buildingNumber.
        /// </summary>
        [TestVariable("12e3fa6a-fdaa-4753-a031-732f683d6d29")]
        public string buildingNumber
        {
            get { return _buildingNumber; }
            set { _buildingNumber = value; }
        }

        string _noOfFloors;

        /// <summary>
        /// Gets or sets the value of variable noOfFloors.
        /// </summary>
        [TestVariable("05f234bd-60b5-4806-a868-8e89a471c72e")]
        public string noOfFloors
        {
            get { return _noOfFloors; }
            set { _noOfFloors = value; }
        }

        string _campus;

        /// <summary>
        /// Gets or sets the value of variable campus.
        /// </summary>
        [TestVariable("35a01467-e534-43f9-bac9-fed9994ba102")]
        public string campus
        {
            get { return _campus; }
            set { _campus = value; }
        }

        string _zone;

        /// <summary>
        /// Gets or sets the value of variable zone.
        /// </summary>
        [TestVariable("9af52b29-c128-49f5-9285-e8c5fb0db6bc")]
        public string zone
        {
            get { return _zone; }
            set { _zone = value; }
        }

        string _wing;

        /// <summary>
        /// Gets or sets the value of variable wing.
        /// </summary>
        [TestVariable("5422ff1c-81fa-4dfa-9e78-58e61ea7e155")]
        public string wing
        {
            get { return _wing; }
            set { _wing = value; }
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
        /// Gets or sets the value of variable optionIndex.
        /// </summary>
        [TestVariable("54b21fa0-de94-496e-9f30-ad004dc255d9")]
        public string optionIndex
        {
            get { return repo.optionIndex; }
            set { repo.optionIndex = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable newTemplateName.
        /// </summary>
        [TestVariable("05493d9f-bae4-44ab-b9f7-1a5c2b994131")]
        public string newTemplateName
        {
            get { return repo.newTemplateName; }
            set { repo.newTemplateName = value; }
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

            itemCount = ValueConverter.ToString(HelperMethodsCollection.getNumberOfRecordsFromFooter(repo.ApplicationUnderTest.showingNumberOfRecords));
            Delay.Milliseconds(0);
            
            newTemplateName = HelperMethodsCollection.getNewCreateItem(ValueConverter.ArgumentFromString<int>("nextCount", itemCount), "category");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.addBuildingButtonTag' at Center.", repo.ApplicationUnderTest.addBuildingButtonTagInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.addBuildingButtonTag.Click();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_BuildingName' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_BuildingNameInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.buildingCreateEdit.building_BuildingName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$newTemplateName' with focus on 'ApplicationUnderTest.buildingCreateEdit.building_BuildingName'.", repo.ApplicationUnderTest.buildingCreateEdit.building_BuildingNameInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.buildingCreateEdit.building_BuildingName.PressKeys(newTemplateName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_BuildingNumber' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_BuildingNumberInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.buildingCreateEdit.building_BuildingNumber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$buildingNumber' with focus on 'ApplicationUnderTest.buildingCreateEdit.building_BuildingNumber'.", repo.ApplicationUnderTest.buildingCreateEdit.building_BuildingNumberInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.buildingCreateEdit.building_BuildingNumber.PressKeys(buildingNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_DateCalendarPicker' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_DateCalendarPickerInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.buildingCreateEdit.building_DateCalendarPicker.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.calendarElement_date1' at Center.", repo.ApplicationUnderTest.calendarElement_date1Info, new RecordItemIndex(9));
            repo.ApplicationUnderTest.calendarElement_date1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.buildingCreateEdit.building_DateConstructedInput' and assigning its value to variable 'dateContructed'.", repo.ApplicationUnderTest.buildingCreateEdit.building_DateConstructedInputInfo, new RecordItemIndex(10));
            dateContructed = repo.ApplicationUnderTest.buildingCreateEdit.building_DateConstructedInput.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_Architect' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_ArchitectInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.buildingCreateEdit.building_Architect.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$architect' with focus on 'ApplicationUnderTest.buildingCreateEdit.building_Architect'.", repo.ApplicationUnderTest.buildingCreateEdit.building_ArchitectInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.buildingCreateEdit.building_Architect.PressKeys(architect);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_Contractor' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_ContractorInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.buildingCreateEdit.building_Contractor.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$contractor' with focus on 'ApplicationUnderTest.buildingCreateEdit.building_Contractor'.", repo.ApplicationUnderTest.buildingCreateEdit.building_ContractorInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.buildingCreateEdit.building_Contractor.PressKeys(contractor);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_CampusDropdown' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_CampusDropdownInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.buildingCreateEdit.building_CampusDropdown.Click();
            Delay.Milliseconds(0);
            
            optionIndex = ValueConverter.ToString(HelperMethodsCollection.getDifferentOption(repo.ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_CompleteDropdown));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'innertext' from item 'ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamic' and assigning its value to variable 'campus'.", repo.ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamicInfo, new RecordItemIndex(17));
            campus = repo.ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamic.Element.GetAttributeValueText("innertext");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamic' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamicInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamic.Click();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_CampusDropdown' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_CampusDropdownInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.buildingCreateEdit.building_CampusDropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_RenovationHistory' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_RenovationHistoryInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.buildingCreateEdit.building_RenovationHistory.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$renovationHistory' with focus on 'ApplicationUnderTest.buildingCreateEdit.building_RenovationHistory'.", repo.ApplicationUnderTest.buildingCreateEdit.building_RenovationHistoryInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.buildingCreateEdit.building_RenovationHistory.PressKeys(renovationHistory);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_ZoneDropdown' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_ZoneDropdownInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.buildingCreateEdit.building_ZoneDropdown.Click();
            Delay.Milliseconds(0);
            
            optionIndex = ValueConverter.ToString(HelperMethodsCollection.getDifferentOption(repo.ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_CompleteDropdown));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'innertext' from item 'ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamic' and assigning its value to variable 'zone'.", repo.ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamicInfo, new RecordItemIndex(25));
            zone = repo.ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamic.Element.GetAttributeValueText("innertext");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamic' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamicInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamic.Click();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_ZoneDropdown' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_ZoneDropdownInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.buildingCreateEdit.building_ZoneDropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_ConstructionCost' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_ConstructionCostInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.buildingCreateEdit.building_ConstructionCost.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$constructionCost' with focus on 'ApplicationUnderTest.buildingCreateEdit.building_ConstructionCost'.", repo.ApplicationUnderTest.buildingCreateEdit.building_ConstructionCostInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.buildingCreateEdit.building_ConstructionCost.PressKeys(constructionCost);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_WingDropdown' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_WingDropdownInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.buildingCreateEdit.building_WingDropdown.Click();
            Delay.Milliseconds(0);
            
            optionIndex = ValueConverter.ToString(HelperMethodsCollection.getDifferentOption(repo.ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_CompleteDropdown));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'innertext' from item 'ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamic' and assigning its value to variable 'wing'.", repo.ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamicInfo, new RecordItemIndex(33));
            wing = repo.ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamic.Element.GetAttributeValueText("innertext");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamic' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamicInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.buildingCreateEdit.building_visibleDropdown_dynamic.Click();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_WingDropdown' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_WingDropdownInfo, new RecordItemIndex(36));
            repo.ApplicationUnderTest.buildingCreateEdit.building_WingDropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_Description' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_DescriptionInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.buildingCreateEdit.building_Description.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$description' with focus on 'ApplicationUnderTest.buildingCreateEdit.building_Description'.", repo.ApplicationUnderTest.buildingCreateEdit.building_DescriptionInfo, new RecordItemIndex(38));
            repo.ApplicationUnderTest.buildingCreateEdit.building_Description.PressKeys(description);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_NoOfFloors' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_NoOfFloorsInfo, new RecordItemIndex(39));
            repo.ApplicationUnderTest.buildingCreateEdit.building_NoOfFloors.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$noOfFloors' with focus on 'ApplicationUnderTest.buildingCreateEdit.building_NoOfFloors'.", repo.ApplicationUnderTest.buildingCreateEdit.building_NoOfFloorsInfo, new RecordItemIndex(40));
            repo.ApplicationUnderTest.buildingCreateEdit.building_NoOfFloors.PressKeys(noOfFloors);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buildingCreateEdit.building_ConfigureFloorsButton' at Center.", repo.ApplicationUnderTest.buildingCreateEdit.building_ConfigureFloorsButtonInfo, new RecordItemIndex(41));
            repo.ApplicationUnderTest.buildingCreateEdit.building_ConfigureFloorsButton.Click();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            // Call other folder to iteratively create "Floors".
            Report.Log(ReportLevel.Info, "Section", "Call other folder to iteratively create \"Floors\".", new RecordItemIndex(43));
            
            callAddFloorsInLoop(ValueConverter.ArgumentFromString<int>("iterations", noOfFloors));
            Delay.Milliseconds(0);
            
            // Creation of "Floors" done.
            Report.Log(ReportLevel.Info, "Section", "Creation of \"Floors\" done.", new RecordItemIndex(45));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.spanTagSave' at Center.", repo.ApplicationUnderTest.spanTagSaveInfo, new RecordItemIndex(46));
            repo.ApplicationUnderTest.spanTagSave.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.buttonTagSave'.", repo.ApplicationUnderTest.buttonTagSaveInfo, new RecordItemIndex(47));
            repo.ApplicationUnderTest.buttonTagSave.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buttonTagSave' at Center.", repo.ApplicationUnderTest.buttonTagSaveInfo, new RecordItemIndex(48));
            repo.ApplicationUnderTest.buttonTagSave.Click();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
