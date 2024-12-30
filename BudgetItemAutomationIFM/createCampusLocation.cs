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
    ///The createCampusLocation recording.
    /// </summary>
    [TestModule("b855cd9a-069a-4e86-8a83-01d805679244", ModuleType.Recording, 1)]
    public partial class createCampusLocation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static createCampusLocation instance = new createCampusLocation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public createCampusLocation()
        {
            newTemplateName = "";
            CL_addressLine1 = "";
            CL_addressLine2 = "";
            campusCity = "";
            CL_zipcode = "";
            CL_county = "";
            CL_country = "";
            CL_State = "";
            CL_Territory1 = "";
            CL_Type = "";
            CL_Territory2 = "";
            CL_Territories = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static createCampusLocation Instance
        {
            get { return instance; }
        }

#region Variables

        string _CL_addressLine1;

        /// <summary>
        /// Gets or sets the value of variable CL_addressLine1.
        /// </summary>
        [TestVariable("fe5b22e5-7db9-4b9c-a552-3b690e4e86da")]
        public string CL_addressLine1
        {
            get { return _CL_addressLine1; }
            set { _CL_addressLine1 = value; }
        }

        string _CL_addressLine2;

        /// <summary>
        /// Gets or sets the value of variable CL_addressLine2.
        /// </summary>
        [TestVariable("5c114412-65ef-44d1-8636-c4cddc60969f")]
        public string CL_addressLine2
        {
            get { return _CL_addressLine2; }
            set { _CL_addressLine2 = value; }
        }

        string _campusCity;

        /// <summary>
        /// Gets or sets the value of variable campusCity.
        /// </summary>
        [TestVariable("356991e5-bd2b-4a81-8237-58522d4b68b7")]
        public string campusCity
        {
            get { return _campusCity; }
            set { _campusCity = value; }
        }

        string _CL_zipcode;

        /// <summary>
        /// Gets or sets the value of variable CL_zipcode.
        /// </summary>
        [TestVariable("30e22f76-de54-4ddd-bfca-43e16a30477d")]
        public string CL_zipcode
        {
            get { return _CL_zipcode; }
            set { _CL_zipcode = value; }
        }

        string _CL_county;

        /// <summary>
        /// Gets or sets the value of variable CL_county.
        /// </summary>
        [TestVariable("2eccacd1-6808-496b-83d3-11fdeba969fc")]
        public string CL_county
        {
            get { return _CL_county; }
            set { _CL_county = value; }
        }

        string _CL_State;

        /// <summary>
        /// Gets or sets the value of variable CL_State.
        /// </summary>
        [TestVariable("6c09f1ed-e9ed-4834-81f1-58dce06e4e03")]
        public string CL_State
        {
            get { return _CL_State; }
            set { _CL_State = value; }
        }

        string _CL_Territory1;

        /// <summary>
        /// Gets or sets the value of variable CL_Territory1.
        /// </summary>
        [TestVariable("9e002486-bf4f-48d6-9869-f73da798432c")]
        public string CL_Territory1
        {
            get { return _CL_Territory1; }
            set { _CL_Territory1 = value; }
        }

        string _CL_Type;

        /// <summary>
        /// Gets or sets the value of variable CL_Type.
        /// </summary>
        [TestVariable("cc98ea5e-4d96-44f9-9b14-e591bd385cb8")]
        public string CL_Type
        {
            get { return _CL_Type; }
            set { _CL_Type = value; }
        }

        string _CL_Territory2;

        /// <summary>
        /// Gets or sets the value of variable CL_Territory2.
        /// </summary>
        [TestVariable("cd7f6f49-a95a-4169-a02d-edd0cb073179")]
        public string CL_Territory2
        {
            get { return _CL_Territory2; }
            set { _CL_Territory2 = value; }
        }

        string _CL_Territories;

        /// <summary>
        /// Gets or sets the value of variable CL_Territories.
        /// </summary>
        [TestVariable("b61b6893-4d31-4277-910a-35f9b4b92ec1")]
        public string CL_Territories
        {
            get { return _CL_Territories; }
            set { _CL_Territories = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CL_country.
        /// </summary>
        [TestVariable("90c05d60-d885-470b-bef6-d245459999d5")]
        public string CL_country
        {
            get { return repo.CL_country; }
            set { repo.CL_country = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable newTemplateName.
        /// </summary>
        [TestVariable("499513eb-bb88-4c5c-b6ba-bc1b66f7f27c")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.campusNameField' at Center.", repo.ApplicationUnderTest.CampusLocationForm.campusNameFieldInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.CampusLocationForm.campusNameField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$newTemplateName' with focus on 'ApplicationUnderTest.CampusLocationForm.campusNameField'.", repo.ApplicationUnderTest.CampusLocationForm.campusNameFieldInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.CampusLocationForm.campusNameField.PressKeys(newTemplateName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.DropdownBtn' at Center.", repo.ApplicationUnderTest.CampusLocationForm.DropdownBtnInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.CampusLocationForm.DropdownBtn.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.CampusLocationForm.CLType_firstInstance' and assigning its value to variable 'CL_Type'.", repo.ApplicationUnderTest.CampusLocationForm.CLType_firstInstanceInfo, new RecordItemIndex(3));
            CL_Type = repo.ApplicationUnderTest.CampusLocationForm.CLType_firstInstance.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.CLType_firstInstance' at Center.", repo.ApplicationUnderTest.CampusLocationForm.CLType_firstInstanceInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.CampusLocationForm.CLType_firstInstance.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.DropdownBtn' at Center.", repo.ApplicationUnderTest.CampusLocationForm.DropdownBtnInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.CampusLocationForm.DropdownBtn.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.AddressLine1Field' at Center.", repo.ApplicationUnderTest.CampusLocationForm.AddressLine1FieldInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.CampusLocationForm.AddressLine1Field.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CL_addressLine1' with focus on 'ApplicationUnderTest.CampusLocationForm.AddressLine1Field'.", repo.ApplicationUnderTest.CampusLocationForm.AddressLine1FieldInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.CampusLocationForm.AddressLine1Field.PressKeys(CL_addressLine1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.AddressLine2Field' at Center.", repo.ApplicationUnderTest.CampusLocationForm.AddressLine2FieldInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.CampusLocationForm.AddressLine2Field.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CL_addressLine2' with focus on 'ApplicationUnderTest.CampusLocationForm.AddressLine2Field'.", repo.ApplicationUnderTest.CampusLocationForm.AddressLine2FieldInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.CampusLocationForm.AddressLine2Field.PressKeys(CL_addressLine2);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.cityField' at Center.", repo.ApplicationUnderTest.CampusLocationForm.cityFieldInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.CampusLocationForm.cityField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$campusCity' with focus on 'ApplicationUnderTest.CampusLocationForm.cityField'.", repo.ApplicationUnderTest.CampusLocationForm.cityFieldInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.CampusLocationForm.cityField.EnsureVisible();
            Keyboard.Press(campusCity);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.CampusZipcode' at Center.", repo.ApplicationUnderTest.CampusLocationForm.CampusZipcodeInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.CampusLocationForm.CampusZipcode.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CL_zipcode' with focus on 'ApplicationUnderTest.CampusLocationForm.CampusZipcode'.", repo.ApplicationUnderTest.CampusLocationForm.CampusZipcodeInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.CampusLocationForm.CampusZipcode.PressKeys(CL_zipcode);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.campusCountyField' at Center.", repo.ApplicationUnderTest.CampusLocationForm.campusCountyFieldInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.CampusLocationForm.campusCountyField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CL_county' with focus on 'ApplicationUnderTest.CampusLocationForm.campusCountyField'.", repo.ApplicationUnderTest.CampusLocationForm.campusCountyFieldInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.CampusLocationForm.campusCountyField.PressKeys(CL_county);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.campusCountryDropdown' at Center.", repo.ApplicationUnderTest.CampusLocationForm.campusCountryDropdownInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.CampusLocationForm.campusCountryDropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.searchItem_Dropdown' at Center.", repo.ApplicationUnderTest.CampusLocationForm.searchItem_DropdownInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.CampusLocationForm.searchItem_Dropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CL_country' with focus on 'ApplicationUnderTest.CampusLocationForm.searchItem_Dropdown'.", repo.ApplicationUnderTest.CampusLocationForm.searchItem_DropdownInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.CampusLocationForm.searchItem_Dropdown.PressKeys(CL_country);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.campusCountry_FirstInstance' at Center.", repo.ApplicationUnderTest.CampusLocationForm.campusCountry_FirstInstanceInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.CampusLocationForm.campusCountry_FirstInstance.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.campusStateDropdown' at Center.", repo.ApplicationUnderTest.CampusLocationForm.campusStateDropdownInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.CampusLocationForm.campusStateDropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.CampusLocationForm.campusState_FirstInstance' and assigning its value to variable 'CL_State'.", repo.ApplicationUnderTest.CampusLocationForm.campusState_FirstInstanceInfo, new RecordItemIndex(21));
            CL_State = repo.ApplicationUnderTest.CampusLocationForm.campusState_FirstInstance.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.campusState_FirstInstance' at Center.", repo.ApplicationUnderTest.CampusLocationForm.campusState_FirstInstanceInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.CampusLocationForm.campusState_FirstInstance.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.campusStateDropdown' at Center.", repo.ApplicationUnderTest.CampusLocationForm.campusStateDropdownInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.CampusLocationForm.campusStateDropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.campusTerritoryDropdown' at Center.", repo.ApplicationUnderTest.CampusLocationForm.campusTerritoryDropdownInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.CampusLocationForm.campusTerritoryDropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.CampusLocationForm.campusTerritory_FirstInstance' and assigning its value to variable 'CL_Territory1'.", repo.ApplicationUnderTest.CampusLocationForm.campusTerritory_FirstInstanceInfo, new RecordItemIndex(25));
            CL_Territory1 = repo.ApplicationUnderTest.CampusLocationForm.campusTerritory_FirstInstance.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.CampusLocationForm.campusTerritory_secondInstance' and assigning its value to variable 'CL_Territory2'.", repo.ApplicationUnderTest.CampusLocationForm.campusTerritory_secondInstanceInfo, new RecordItemIndex(26));
            CL_Territory2 = repo.ApplicationUnderTest.CampusLocationForm.campusTerritory_secondInstance.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            CL_Territories = HelperMethodsCollection.concatStrings2(CL_Territory1, CL_Territory2);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.campusTerritory_FirstInstance' at Center.", repo.ApplicationUnderTest.CampusLocationForm.campusTerritory_FirstInstanceInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.CampusLocationForm.campusTerritory_FirstInstance.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.campusTerritory_secondInstance' at Center.", repo.ApplicationUnderTest.CampusLocationForm.campusTerritory_secondInstanceInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.CampusLocationForm.campusTerritory_secondInstance.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.campusTerritoryDropdown' at Center.", repo.ApplicationUnderTest.CampusLocationForm.campusTerritoryDropdownInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.CampusLocationForm.campusTerritoryDropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CampusLocationForm.submitButton' at Center.", repo.ApplicationUnderTest.CampusLocationForm.submitButtonInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.CampusLocationForm.submitButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.FaFaSpinFaSpinner'", repo.ApplicationUnderTest.FaFaSpinFaSpinnerInfo, new ActionTimeout(30000), new RecordItemIndex(32));
            repo.ApplicationUnderTest.FaFaSpinFaSpinnerInfo.WaitForNotExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
