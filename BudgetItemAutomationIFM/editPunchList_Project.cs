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
    ///The editPunchList_Project recording.
    /// </summary>
    [TestModule("30c93174-375c-4df4-a42e-aeb16e458b8e", ModuleType.Recording, 1)]
    public partial class editPunchList_Project : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static editPunchList_Project instance = new editPunchList_Project();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public editPunchList_Project()
        {
            itemName = "";
            location = "";
            description = "";
            editedItemName = "";
            editedLocation = "";
            editedDescription = "";
            visibleItemName = "";
            visibleCreatorName = "";
            visibleCreatedDate = "";
            visibleStatus = "";
            visibleApprovedStatus = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static editPunchList_Project Instance
        {
            get { return instance; }
        }

#region Variables

        string _itemName;

        /// <summary>
        /// Gets or sets the value of variable itemName.
        /// </summary>
        [TestVariable("625aa43b-42ed-47be-bd56-18dbe1b20502")]
        public string itemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        string _location;

        /// <summary>
        /// Gets or sets the value of variable location.
        /// </summary>
        [TestVariable("b5ab32be-4712-46b8-9cd2-672466adbc00")]
        public string location
        {
            get { return _location; }
            set { _location = value; }
        }

        string _description;

        /// <summary>
        /// Gets or sets the value of variable description.
        /// </summary>
        [TestVariable("6cdb50c4-2f8a-4c2d-b1cc-19d452c66ca3")]
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }

        string _editedItemName;

        /// <summary>
        /// Gets or sets the value of variable editedItemName.
        /// </summary>
        [TestVariable("aac03cd7-cd9f-409b-9cb2-168fbb64cb42")]
        public string editedItemName
        {
            get { return _editedItemName; }
            set { _editedItemName = value; }
        }

        string _editedLocation;

        /// <summary>
        /// Gets or sets the value of variable editedLocation.
        /// </summary>
        [TestVariable("fa2c5915-080d-47fa-a6bc-68aa060b2da7")]
        public string editedLocation
        {
            get { return _editedLocation; }
            set { _editedLocation = value; }
        }

        string _editedDescription;

        /// <summary>
        /// Gets or sets the value of variable editedDescription.
        /// </summary>
        [TestVariable("60791fe5-25a3-45cd-bc94-722bd954a05f")]
        public string editedDescription
        {
            get { return _editedDescription; }
            set { _editedDescription = value; }
        }

        string _visibleItemName;

        /// <summary>
        /// Gets or sets the value of variable visibleItemName.
        /// </summary>
        [TestVariable("cbb8ff7a-5cd7-4aae-9b07-956e90c5a142")]
        public string visibleItemName
        {
            get { return _visibleItemName; }
            set { _visibleItemName = value; }
        }

        string _visibleCreatorName;

        /// <summary>
        /// Gets or sets the value of variable visibleCreatorName.
        /// </summary>
        [TestVariable("a03ad4ce-f21c-405a-8943-3128de6b62e7")]
        public string visibleCreatorName
        {
            get { return _visibleCreatorName; }
            set { _visibleCreatorName = value; }
        }

        string _visibleCreatedDate;

        /// <summary>
        /// Gets or sets the value of variable visibleCreatedDate.
        /// </summary>
        [TestVariable("7a1a3329-fb12-4455-b937-57cb7054e0b9")]
        public string visibleCreatedDate
        {
            get { return _visibleCreatedDate; }
            set { _visibleCreatedDate = value; }
        }

        string _visibleStatus;

        /// <summary>
        /// Gets or sets the value of variable visibleStatus.
        /// </summary>
        [TestVariable("1d15ac5d-bc57-4ceb-ae49-2ba186cf4b0a")]
        public string visibleStatus
        {
            get { return _visibleStatus; }
            set { _visibleStatus = value; }
        }

        string _visibleApprovedStatus;

        /// <summary>
        /// Gets or sets the value of variable visibleApprovedStatus.
        /// </summary>
        [TestVariable("f15ab368-4840-402c-872a-431cf6779726")]
        public string visibleApprovedStatus
        {
            get { return _visibleApprovedStatus; }
            set { _visibleApprovedStatus = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_records.row1_column1' and assigning its value to variable 'visibleItemName'.", repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column1Info, new RecordItemIndex(0));
            visibleItemName = repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column1.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_records.row1_column2' and assigning its value to variable 'visibleCreatorName'.", repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column2Info, new RecordItemIndex(1));
            visibleCreatorName = repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column2.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_records.row1_column3' and assigning its value to variable 'visibleCreatedDate'.", repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column3Info, new RecordItemIndex(2));
            visibleCreatedDate = repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column3.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_records.row1_column4' and assigning its value to variable 'visibleStatus'.", repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column4Info, new RecordItemIndex(3));
            visibleStatus = repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column4.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_records.row1_column5' and assigning its value to variable 'visibleApprovedStatus'.", repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column5Info, new RecordItemIndex(4));
            visibleApprovedStatus = repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column5.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(8480);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.syncfusionGridTable_records.row1_editIcon' at Center.", repo.ApplicationUnderTest.syncfusionGridTable_records.row1_editIconInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.syncfusionGridTable_records.row1_editIcon.Click();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.project_PunchList_itemName' and assigning its value to variable 'itemName'.", repo.ApplicationUnderTest.project_PunchList_itemNameInfo, new RecordItemIndex(7));
            itemName = repo.ApplicationUnderTest.project_PunchList_itemName.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            editedItemName = HelperMethodsCollection.getEdittedName(itemName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '' on item 'ApplicationUnderTest.project_PunchList_itemName'.", repo.ApplicationUnderTest.project_PunchList_itemNameInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.project_PunchList_itemName.Element.SetAttributeValue("Value", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.project_PunchList_itemName' at Center.", repo.ApplicationUnderTest.project_PunchList_itemNameInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.project_PunchList_itemName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$editedItemName' with focus on 'ApplicationUnderTest.project_PunchList_itemName'.", repo.ApplicationUnderTest.project_PunchList_itemNameInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.project_PunchList_itemName.PressKeys(editedItemName);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.project_PunchList_Location' and assigning its value to variable 'location'.", repo.ApplicationUnderTest.project_PunchList_LocationInfo, new RecordItemIndex(12));
            location = repo.ApplicationUnderTest.project_PunchList_Location.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            editedLocation = HelperMethodsCollection.getEdittedName(location);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '' on item 'ApplicationUnderTest.project_PunchList_Location'.", repo.ApplicationUnderTest.project_PunchList_LocationInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.project_PunchList_Location.Element.SetAttributeValue("Value", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.project_PunchList_Location' at Center.", repo.ApplicationUnderTest.project_PunchList_LocationInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.project_PunchList_Location.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$editedLocation' with focus on 'ApplicationUnderTest.project_PunchList_Location'.", repo.ApplicationUnderTest.project_PunchList_LocationInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.project_PunchList_Location.PressKeys(editedLocation);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.project_PunchList_Description' and assigning its value to variable 'description'.", repo.ApplicationUnderTest.project_PunchList_DescriptionInfo, new RecordItemIndex(17));
            description = repo.ApplicationUnderTest.project_PunchList_Description.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            editedDescription = HelperMethodsCollection.getEdittedName(description);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '' on item 'ApplicationUnderTest.project_PunchList_Description'.", repo.ApplicationUnderTest.project_PunchList_DescriptionInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.project_PunchList_Description.Element.SetAttributeValue("Value", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.project_PunchList_Description' at Center.", repo.ApplicationUnderTest.project_PunchList_DescriptionInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.project_PunchList_Description.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$editedDescription' with focus on 'ApplicationUnderTest.project_PunchList_Description'.", repo.ApplicationUnderTest.project_PunchList_DescriptionInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.project_PunchList_Description.PressKeys(editedDescription);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buttonTagSave' at Center.", repo.ApplicationUnderTest.buttonTagSaveInfo, new RecordItemIndex(22));
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
