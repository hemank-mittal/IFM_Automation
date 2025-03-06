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
    ///The validateProject_Module recording.
    /// </summary>
    [TestModule("2da0a914-716c-4c01-b3e6-858199a0f697", ModuleType.Recording, 1)]
    public partial class validateProject_Module : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static validateProject_Module instance = new validateProject_Module();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public validateProject_Module()
        {
            projectNumber = "";
            projectName = "";
            projectManager = "";
            Status = "";
            type = "";
            CEs = "";
            issues = "";
            potentialCost = "";
            date = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static validateProject_Module Instance
        {
            get { return instance; }
        }

#region Variables

        string _projectNumber;

        /// <summary>
        /// Gets or sets the value of variable projectNumber.
        /// </summary>
        [TestVariable("d10786d4-481f-4128-9bb2-d08886c82854")]
        public string projectNumber
        {
            get { return _projectNumber; }
            set { _projectNumber = value; }
        }

        string _projectName;

        /// <summary>
        /// Gets or sets the value of variable projectName.
        /// </summary>
        [TestVariable("b5a08cdb-2776-41ec-92a8-00070f4aa505")]
        public string projectName
        {
            get { return _projectName; }
            set { _projectName = value; }
        }

        string _projectManager;

        /// <summary>
        /// Gets or sets the value of variable projectManager.
        /// </summary>
        [TestVariable("11cc416b-4cb0-4dff-a608-39919e2c6779")]
        public string projectManager
        {
            get { return _projectManager; }
            set { _projectManager = value; }
        }

        string _Status;

        /// <summary>
        /// Gets or sets the value of variable Status.
        /// </summary>
        [TestVariable("e70adb56-5725-47e1-8a13-aa6b2cfce703")]
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        string _type;

        /// <summary>
        /// Gets or sets the value of variable type.
        /// </summary>
        [TestVariable("47be2cee-f14c-4011-be11-afe3963592ba")]
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }

        string _CEs;

        /// <summary>
        /// Gets or sets the value of variable CEs.
        /// </summary>
        [TestVariable("f995d9da-0202-47cc-9586-c1947784714b")]
        public string CEs
        {
            get { return _CEs; }
            set { _CEs = value; }
        }

        string _issues;

        /// <summary>
        /// Gets or sets the value of variable issues.
        /// </summary>
        [TestVariable("4d3cb368-8da6-4d18-925b-29ca28e8c53f")]
        public string issues
        {
            get { return _issues; }
            set { _issues = value; }
        }

        string _potentialCost;

        /// <summary>
        /// Gets or sets the value of variable potentialCost.
        /// </summary>
        [TestVariable("400b157b-3488-4388-a91d-751568597f27")]
        public string potentialCost
        {
            get { return _potentialCost; }
            set { _potentialCost = value; }
        }

        string _date;

        /// <summary>
        /// Gets or sets the value of variable date.
        /// </summary>
        [TestVariable("2a739264-730d-4564-bc7c-fcb0923b7405")]
        public string date
        {
            get { return _date; }
            set { _date = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_records.row1_column1' and assigning its value to variable 'projectNumber'.", repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column1Info, new RecordItemIndex(0));
            projectNumber = repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column1.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_records.row1_column2' and assigning its value to variable 'projectName'.", repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column2Info, new RecordItemIndex(1));
            projectName = repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column2.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_records.row1_column3' and assigning its value to variable 'projectManager'.", repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column3Info, new RecordItemIndex(2));
            projectManager = repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column3.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_records.row1_column4' and assigning its value to variable 'Status'.", repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column4Info, new RecordItemIndex(3));
            Status = repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column4.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_records.row1_column5' and assigning its value to variable 'type'.", repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column5Info, new RecordItemIndex(4));
            type = repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column5.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_records.row1_column6' and assigning its value to variable 'CEs'.", repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column6Info, new RecordItemIndex(5));
            CEs = repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column6.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_records.row1_column7' and assigning its value to variable 'issues'.", repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column7Info, new RecordItemIndex(6));
            issues = repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column7.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_records.row1_column8' and assigning its value to variable 'potentialCost'.", repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column8Info, new RecordItemIndex(7));
            potentialCost = repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column8.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_records.row1_column9' and assigning its value to variable 'date'.", repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column9Info, new RecordItemIndex(8));
            date = repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column9.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Warn, "User", projectNumber, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Warn, "User", projectName, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Warn, "User", projectManager, new RecordItemIndex(11));
            
            Report.Log(ReportLevel.Warn, "User", Status, new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Warn, "User", type, new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Warn, "User", CEs, new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Warn, "User", issues, new RecordItemIndex(15));
            
            Report.Log(ReportLevel.Warn, "User", potentialCost, new RecordItemIndex(16));
            
            Report.Log(ReportLevel.Warn, "User", date, new RecordItemIndex(17));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
