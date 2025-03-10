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
    ///The editRoom_MDC recording.
    /// </summary>
    [TestModule("65cd769d-a9f8-4b97-ba29-972bc1b3d26b", ModuleType.Recording, 1)]
    public partial class editRoom_MDC : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static editRoom_MDC instance = new editRoom_MDC();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public editRoom_MDC()
        {
            optionIndex = "";
            roomBuilding = "";
            roomNumber = "";
            roomFloor = "";
            roomDepartment = "";
            roomDescription = "";
            roomName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static editRoom_MDC Instance
        {
            get { return instance; }
        }

#region Variables

        string _roomBuilding;

        /// <summary>
        /// Gets or sets the value of variable roomBuilding.
        /// </summary>
        [TestVariable("42c008fb-37fd-4fcb-a3d3-bb419b2c6bde")]
        public string roomBuilding
        {
            get { return _roomBuilding; }
            set { _roomBuilding = value; }
        }

        string _roomNumber;

        /// <summary>
        /// Gets or sets the value of variable roomNumber.
        /// </summary>
        [TestVariable("93a91e1d-ceba-48b4-93ed-611a633570ea")]
        public string roomNumber
        {
            get { return _roomNumber; }
            set { _roomNumber = value; }
        }

        string _roomFloor;

        /// <summary>
        /// Gets or sets the value of variable roomFloor.
        /// </summary>
        [TestVariable("7256043c-4b70-4bc2-acd8-9deb1e042760")]
        public string roomFloor
        {
            get { return _roomFloor; }
            set { _roomFloor = value; }
        }

        string _roomDepartment;

        /// <summary>
        /// Gets or sets the value of variable roomDepartment.
        /// </summary>
        [TestVariable("57051e8f-860a-42c7-9702-e8a49ed34549")]
        public string roomDepartment
        {
            get { return _roomDepartment; }
            set { _roomDepartment = value; }
        }

        string _roomDescription;

        /// <summary>
        /// Gets or sets the value of variable roomDescription.
        /// </summary>
        [TestVariable("7bb7f323-08d3-47e3-83f3-b5b1fde633c0")]
        public string roomDescription
        {
            get { return _roomDescription; }
            set { _roomDescription = value; }
        }

        string _roomName;

        /// <summary>
        /// Gets or sets the value of variable roomName.
        /// </summary>
        [TestVariable("a2784621-1421-453b-97b4-b43aee2080e0")]
        public string roomName
        {
            get { return _roomName; }
            set { _roomName = value; }
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
        [TestVariable("dc660364-ae11-4a3d-9a1b-bd65c0a881f3")]
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ButtonTagEdit_Row2' at Center.", repo.ApplicationUnderTest.ButtonTagEdit_Row2Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.ButtonTagEdit_Row2.Click();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.roomCreateEditPage.room_RoomName' and assigning its value to variable 'roomName'.", repo.ApplicationUnderTest.roomCreateEditPage.room_RoomNameInfo, new RecordItemIndex(3));
            roomName = repo.ApplicationUnderTest.roomCreateEditPage.room_RoomName.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            roomName = HelperMethodsCollection.getEdittedName(roomName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'ApplicationUnderTest.roomCreateEditPage.room_RoomName'.", repo.ApplicationUnderTest.roomCreateEditPage.room_RoomNameInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.roomCreateEditPage.room_RoomName.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.roomCreateEditPage.room_RoomName' at Center.", repo.ApplicationUnderTest.roomCreateEditPage.room_RoomNameInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.roomCreateEditPage.room_RoomName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$roomName' with focus on 'ApplicationUnderTest.roomCreateEditPage.room_RoomName'.", repo.ApplicationUnderTest.roomCreateEditPage.room_RoomNameInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.roomCreateEditPage.room_RoomName.PressKeys(roomName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.roomCreateEditPage.room_BuildingDropdown' at Center.", repo.ApplicationUnderTest.roomCreateEditPage.room_BuildingDropdownInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.roomCreateEditPage.room_BuildingDropdown.Click();
            Delay.Milliseconds(0);
            
            optionIndex = ValueConverter.ToString(HelperMethodsCollection.getDifferentOption(repo.ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'innertext' from item 'ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamic' and assigning its value to variable 'roomBuilding'.", repo.ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamicInfo, new RecordItemIndex(10));
            roomBuilding = repo.ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamic.Element.GetAttributeValueText("innertext");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamic' at Center.", repo.ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamicInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamic.Click();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.roomCreateEditPage.room_BuildingDropdown' at Center.", repo.ApplicationUnderTest.roomCreateEditPage.room_BuildingDropdownInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.roomCreateEditPage.room_BuildingDropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.roomCreateEditPage.room_RoomNumber' and assigning its value to variable 'roomNumber'.", repo.ApplicationUnderTest.roomCreateEditPage.room_RoomNumberInfo, new RecordItemIndex(14));
            roomNumber = repo.ApplicationUnderTest.roomCreateEditPage.room_RoomNumber.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            roomNumber = HelperMethodsCollection.getEdittedName(roomNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'ApplicationUnderTest.roomCreateEditPage.room_RoomNumber'.", repo.ApplicationUnderTest.roomCreateEditPage.room_RoomNumberInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.roomCreateEditPage.room_RoomNumber.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.roomCreateEditPage.room_RoomNumber' at Center.", repo.ApplicationUnderTest.roomCreateEditPage.room_RoomNumberInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.roomCreateEditPage.room_RoomNumber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$roomNumber' with focus on 'ApplicationUnderTest.roomCreateEditPage.room_RoomNumber'.", repo.ApplicationUnderTest.roomCreateEditPage.room_RoomNumberInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.roomCreateEditPage.room_RoomNumber.PressKeys(roomNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.roomCreateEditPage.room_FloorDropdown' at Center.", repo.ApplicationUnderTest.roomCreateEditPage.room_FloorDropdownInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.roomCreateEditPage.room_FloorDropdown.Click();
            Delay.Milliseconds(0);
            
            optionIndex = ValueConverter.ToString(HelperMethodsCollection.getDifferentOption(repo.ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown));
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Get Value", "(Optional Action)\r\nGetting attribute 'innertext' from item 'ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamic' and assigning its value to variable 'roomFloor'.", repo.ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamicInfo, new RecordItemIndex(21));
                roomFloor = repo.ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamic.Element.GetAttributeValueText("innertext");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(21)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamic' at Center.", repo.ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamicInfo, new RecordItemIndex(22));
                repo.ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamic.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(22)); }
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.roomCreateEditPage.room_FloorDropdown' at Center.", repo.ApplicationUnderTest.roomCreateEditPage.room_FloorDropdownInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.roomCreateEditPage.room_FloorDropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.roomCreateEditPage.room_DepartmentDropdown' at Center.", repo.ApplicationUnderTest.roomCreateEditPage.room_DepartmentDropdownInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.roomCreateEditPage.room_DepartmentDropdown.Click();
            Delay.Milliseconds(0);
            
            optionIndex = ValueConverter.ToString(HelperMethodsCollection.getDifferentOption(repo.ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown));
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Get Value", "(Optional Action)\r\nGetting attribute 'innertext' from item 'ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamic' and assigning its value to variable 'roomDepartment'.", repo.ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamicInfo, new RecordItemIndex(27));
                roomDepartment = repo.ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamic.Element.GetAttributeValueText("innertext");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(27)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamic' at Center.", repo.ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamicInfo, new RecordItemIndex(28));
                repo.ApplicationUnderTest.roomCreateEditPage.room_visibleDropdown_dynamic.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(28)); }
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.roomCreateEditPage.room_DepartmentDropdown' at Center.", repo.ApplicationUnderTest.roomCreateEditPage.room_DepartmentDropdownInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.roomCreateEditPage.room_DepartmentDropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.roomCreateEditPage.room_Description' and assigning its value to variable 'roomDescription'.", repo.ApplicationUnderTest.roomCreateEditPage.room_DescriptionInfo, new RecordItemIndex(31));
            roomDescription = repo.ApplicationUnderTest.roomCreateEditPage.room_Description.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            roomDescription = HelperMethodsCollection.getEdittedName(roomDescription);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'ApplicationUnderTest.roomCreateEditPage.room_Description'.", repo.ApplicationUnderTest.roomCreateEditPage.room_DescriptionInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.roomCreateEditPage.room_Description.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.roomCreateEditPage.room_Description' at Center.", repo.ApplicationUnderTest.roomCreateEditPage.room_DescriptionInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.roomCreateEditPage.room_Description.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$roomDescription' with focus on 'ApplicationUnderTest.roomCreateEditPage.room_Description'.", repo.ApplicationUnderTest.roomCreateEditPage.room_DescriptionInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.roomCreateEditPage.room_Description.PressKeys(roomDescription);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buttonTagSave' at Center.", repo.ApplicationUnderTest.buttonTagSaveInfo, new RecordItemIndex(36));
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
