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
    ///The validateBuilding_MDC recording.
    /// </summary>
    [TestModule("4403470f-de4a-4723-80f5-849b2e7b1a0e", ModuleType.Recording, 1)]
    public partial class validateBuilding_MDC : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static validateBuilding_MDC instance = new validateBuilding_MDC();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public validateBuilding_MDC()
        {
            BuildingName = "";
            visibleArchitect = "";
            visibleBuildingName = "";
            visibleBuildingNumber = "";
            visibleBuildingConstuctionCost = "";
            visibleContractor = "";
            visibleDateConstructed = "";
            visibleRenovationHistory = "";
            architect = "";
            buildingNumber = "";
            constructionCost = "";
            Contractor = "";
            dateConstructed = "";
            renovationHistory = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static validateBuilding_MDC Instance
        {
            get { return instance; }
        }

#region Variables

        string _BuildingName;

        /// <summary>
        /// Gets or sets the value of variable BuildingName.
        /// </summary>
        [TestVariable("a039ca8d-baef-4b09-8ef3-32f0eccb26e3")]
        public string BuildingName
        {
            get { return _BuildingName; }
            set { _BuildingName = value; }
        }

        string _visibleArchitect;

        /// <summary>
        /// Gets or sets the value of variable visibleArchitect.
        /// </summary>
        [TestVariable("67a7d717-6fe7-43c0-8e25-cdee3deec6da")]
        public string visibleArchitect
        {
            get { return _visibleArchitect; }
            set { _visibleArchitect = value; }
        }

        string _visibleBuildingName;

        /// <summary>
        /// Gets or sets the value of variable visibleBuildingName.
        /// </summary>
        [TestVariable("f9b2e75e-97b8-4f51-9a94-dcc24a645172")]
        public string visibleBuildingName
        {
            get { return _visibleBuildingName; }
            set { _visibleBuildingName = value; }
        }

        string _visibleBuildingNumber;

        /// <summary>
        /// Gets or sets the value of variable visibleBuildingNumber.
        /// </summary>
        [TestVariable("85c00098-8bf9-4073-919b-17166f42f8f2")]
        public string visibleBuildingNumber
        {
            get { return _visibleBuildingNumber; }
            set { _visibleBuildingNumber = value; }
        }

        string _visibleBuildingConstuctionCost;

        /// <summary>
        /// Gets or sets the value of variable visibleBuildingConstuctionCost.
        /// </summary>
        [TestVariable("4958f3dc-2d4a-4994-9c7f-71353b3067bc")]
        public string visibleBuildingConstuctionCost
        {
            get { return _visibleBuildingConstuctionCost; }
            set { _visibleBuildingConstuctionCost = value; }
        }

        string _visibleContractor;

        /// <summary>
        /// Gets or sets the value of variable visibleContractor.
        /// </summary>
        [TestVariable("56295b8b-9865-423f-bfd0-1fef9332a7d7")]
        public string visibleContractor
        {
            get { return _visibleContractor; }
            set { _visibleContractor = value; }
        }

        string _visibleDateConstructed;

        /// <summary>
        /// Gets or sets the value of variable visibleDateConstructed.
        /// </summary>
        [TestVariable("bea49d40-3833-4807-a67a-9f639f8197f0")]
        public string visibleDateConstructed
        {
            get { return _visibleDateConstructed; }
            set { _visibleDateConstructed = value; }
        }

        string _visibleRenovationHistory;

        /// <summary>
        /// Gets or sets the value of variable visibleRenovationHistory.
        /// </summary>
        [TestVariable("7f56db0d-1a68-46ca-82f3-40b4791a5495")]
        public string visibleRenovationHistory
        {
            get { return _visibleRenovationHistory; }
            set { _visibleRenovationHistory = value; }
        }

        string _architect;

        /// <summary>
        /// Gets or sets the value of variable architect.
        /// </summary>
        [TestVariable("6ded8b98-d9ba-4199-a9e9-286ea03134c8")]
        public string architect
        {
            get { return _architect; }
            set { _architect = value; }
        }

        string _buildingNumber;

        /// <summary>
        /// Gets or sets the value of variable buildingNumber.
        /// </summary>
        [TestVariable("d645dba5-590d-4df3-a64f-9c2a9e5062a9")]
        public string buildingNumber
        {
            get { return _buildingNumber; }
            set { _buildingNumber = value; }
        }

        string _constructionCost;

        /// <summary>
        /// Gets or sets the value of variable constructionCost.
        /// </summary>
        [TestVariable("88f292b7-4bfc-4376-b2cd-e9559665d4a1")]
        public string constructionCost
        {
            get { return _constructionCost; }
            set { _constructionCost = value; }
        }

        string _Contractor;

        /// <summary>
        /// Gets or sets the value of variable Contractor.
        /// </summary>
        [TestVariable("333bb2fa-06b6-4139-93a2-3b002661c20f")]
        public string Contractor
        {
            get { return _Contractor; }
            set { _Contractor = value; }
        }

        string _dateConstructed;

        /// <summary>
        /// Gets or sets the value of variable dateConstructed.
        /// </summary>
        [TestVariable("11d8fbe4-3205-47bd-b7f0-75f6aca8fda5")]
        public string dateConstructed
        {
            get { return _dateConstructed; }
            set { _dateConstructed = value; }
        }

        string _renovationHistory;

        /// <summary>
        /// Gets or sets the value of variable renovationHistory.
        /// </summary>
        [TestVariable("834a460c-ba89-417b-a932-ba14a9f68f1b")]
        public string renovationHistory
        {
            get { return _renovationHistory; }
            set { _renovationHistory = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.searchBtn_Id_searchbox' at Center.", repo.ApplicationUnderTest.searchBtn_Id_searchboxInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.searchBtn_Id_searchbox.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$BuildingName' with focus on 'ApplicationUnderTest.searchBtn_Id_searchbox'.", repo.ApplicationUnderTest.searchBtn_Id_searchboxInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.searchBtn_Id_searchbox.PressKeys(BuildingName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.firstElement_anyTag' and assigning its value to variable 'visibleArchitect'.", repo.ApplicationUnderTest.firstElement_anyTagInfo, new RecordItemIndex(2));
            visibleArchitect = repo.ApplicationUnderTest.firstElement_anyTag.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.secondElement_anyTag' and assigning its value to variable 'visibleBuildingName'.", repo.ApplicationUnderTest.secondElement_anyTagInfo, new RecordItemIndex(3));
            visibleBuildingName = repo.ApplicationUnderTest.secondElement_anyTag.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.thirdElement_anyTag' and assigning its value to variable 'visibleBuildingNumber'.", repo.ApplicationUnderTest.thirdElement_anyTagInfo, new RecordItemIndex(4));
            visibleBuildingNumber = repo.ApplicationUnderTest.thirdElement_anyTag.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.fourthElement_anyTag' and assigning its value to variable 'visibleBuildingConstuctionCost'.", repo.ApplicationUnderTest.fourthElement_anyTagInfo, new RecordItemIndex(5));
            visibleBuildingConstuctionCost = repo.ApplicationUnderTest.fourthElement_anyTag.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.fifthhElement_anyTag' and assigning its value to variable 'visibleContractor'.", repo.ApplicationUnderTest.fifthhElement_anyTagInfo, new RecordItemIndex(6));
            visibleContractor = repo.ApplicationUnderTest.fifthhElement_anyTag.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.sixthElement_anyTag' and assigning its value to variable 'visibleDateConstructed'.", repo.ApplicationUnderTest.sixthElement_anyTagInfo, new RecordItemIndex(7));
            visibleDateConstructed = repo.ApplicationUnderTest.sixthElement_anyTag.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.seventhElement_anyTag' and assigning its value to variable 'visibleRenovationHistory'.", repo.ApplicationUnderTest.seventhElement_anyTagInfo, new RecordItemIndex(8));
            visibleRenovationHistory = repo.ApplicationUnderTest.seventhElement_anyTag.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            constructionCost = HelperMethodsCollection.concatStrings("$", constructionCost, ".00", "");
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.compareStrings(visibleArchitect, architect);
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.compareStrings(visibleBuildingName, BuildingName);
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.compareStrings(visibleBuildingNumber, buildingNumber);
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.compareStrings(visibleBuildingConstuctionCost, constructionCost);
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.compareStrings(visibleContractor, Contractor);
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.compareStrings(visibleDateConstructed, dateConstructed);
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.compareStrings(visibleRenovationHistory, renovationHistory);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.searchBtn_Id_searchbox'.", repo.ApplicationUnderTest.searchBtn_Id_searchboxInfo, new RecordItemIndex(17));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.searchBtn_Id_searchbox);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'ApplicationUnderTest.searchBtn_Id_searchbox'.", repo.ApplicationUnderTest.searchBtn_Id_searchboxInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.searchBtn_Id_searchbox.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
