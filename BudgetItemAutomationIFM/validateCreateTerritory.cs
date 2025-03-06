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
    ///The validateCreateTerritory recording.
    /// </summary>
    [TestModule("fc71fce1-d4a3-481d-861a-af6b5d07f4f7", ModuleType.Recording, 1)]
    public partial class validateCreateTerritory : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static validateCreateTerritory instance = new validateCreateTerritory();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public validateCreateTerritory()
        {
            itemName = "";
            visibleName = "";
            visibleCAM = "";
            linkedCAM = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static validateCreateTerritory Instance
        {
            get { return instance; }
        }

#region Variables

        string _itemName;

        /// <summary>
        /// Gets or sets the value of variable itemName.
        /// </summary>
        [TestVariable("a08f819e-e7fd-4ce9-ab80-fd4a0a5b0d9c")]
        public string itemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        string _visibleName;

        /// <summary>
        /// Gets or sets the value of variable visibleName.
        /// </summary>
        [TestVariable("0776ca9f-e36f-44c4-82c8-481662b82adf")]
        public string visibleName
        {
            get { return _visibleName; }
            set { _visibleName = value; }
        }

        string _visibleCAM;

        /// <summary>
        /// Gets or sets the value of variable visibleCAM.
        /// </summary>
        [TestVariable("354207e7-bfe3-4ed8-9630-35aa3931b68a")]
        public string visibleCAM
        {
            get { return _visibleCAM; }
            set { _visibleCAM = value; }
        }

        string _linkedCAM;

        /// <summary>
        /// Gets or sets the value of variable linkedCAM.
        /// </summary>
        [TestVariable("506ce4f4-7520-4b76-b135-ab98d6a18847")]
        public string linkedCAM
        {
            get { return _linkedCAM; }
            set { _linkedCAM = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.itemCreatedMessageToaster'", repo.ApplicationUnderTest.itemCreatedMessageToasterInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.itemCreatedMessageToasterInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.searchBar_typeplaceholder' at Center.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$itemName' with focus on 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.PressKeys(itemName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(4));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.firstElement_anyTag' and assigning its value to variable 'visibleName'.", repo.ApplicationUnderTest.firstElement_anyTagInfo, new RecordItemIndex(5));
            visibleName = repo.ApplicationUnderTest.firstElement_anyTag.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.compareStrings(itemName, visibleName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.secondElement_anyTag' and assigning its value to variable 'visibleCAM'.", repo.ApplicationUnderTest.secondElement_anyTagInfo, new RecordItemIndex(7));
            visibleCAM = repo.ApplicationUnderTest.secondElement_anyTag.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.compareStrings(linkedCAM, visibleCAM);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(9));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.searchBar_typeplaceholder);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
