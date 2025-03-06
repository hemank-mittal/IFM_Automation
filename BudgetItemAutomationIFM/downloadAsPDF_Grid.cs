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
    ///The downloadAsPDF_Grid recording.
    /// </summary>
    [TestModule("4b9fc15e-d31d-4cbc-a4ef-3443f0ffef38", ModuleType.Recording, 1)]
    public partial class downloadAsPDF_PunchList_Project : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static downloadAsPDF_PunchList_Project instance = new downloadAsPDF_PunchList_Project();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public downloadAsPDF_PunchList_Project()
        {
            content1 = "";
            content2 = "";
            content3 = "";
            content4 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static downloadAsPDF_PunchList_Project Instance
        {
            get { return instance; }
        }

#region Variables

        string _content1;

        /// <summary>
        /// Gets or sets the value of variable content1.
        /// </summary>
        [TestVariable("ad3b4e1b-e289-4dca-958d-7b52df0a4db4")]
        public string content1
        {
            get { return _content1; }
            set { _content1 = value; }
        }

        string _content2;

        /// <summary>
        /// Gets or sets the value of variable content2.
        /// </summary>
        [TestVariable("23ef2f2d-7f1e-4a95-8ab2-82082dd2ab1c")]
        public string content2
        {
            get { return _content2; }
            set { _content2 = value; }
        }

        string _content3;

        /// <summary>
        /// Gets or sets the value of variable content3.
        /// </summary>
        [TestVariable("7765f015-c4ac-42fd-a5dd-b44aa2f7c323")]
        public string content3
        {
            get { return _content3; }
            set { _content3 = value; }
        }

        string _content4;

        /// <summary>
        /// Gets or sets the value of variable content4.
        /// </summary>
        [TestVariable("06131c5a-60fa-4c58-af5a-c1258e0110b2")]
        public string content4
        {
            get { return _content4; }
            set { _content4 = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_headers.row1_column1_header_title' and assigning its value to variable 'content1'.", repo.ApplicationUnderTest.syncfusionGridTable_headers.row1_column1_header_titleInfo, new RecordItemIndex(0));
            content1 = repo.ApplicationUnderTest.syncfusionGridTable_headers.row1_column1_header_title.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_headers.row1_column2_header_title' and assigning its value to variable 'content2'.", repo.ApplicationUnderTest.syncfusionGridTable_headers.row1_column2_header_titleInfo, new RecordItemIndex(1));
            content2 = repo.ApplicationUnderTest.syncfusionGridTable_headers.row1_column2_header_title.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_records.row1_column1' and assigning its value to variable 'content3'.", repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column1Info, new RecordItemIndex(2));
            content3 = repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column1.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.syncfusionGridTable_records.row1_column2' and assigning its value to variable 'content4'.", repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column2Info, new RecordItemIndex(3));
            content4 = repo.ApplicationUnderTest.syncfusionGridTable_records.row1_column2.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.button_id_dropDownButton' at Center.", repo.ApplicationUnderTest.button_id_dropDownButtonInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.button_id_dropDownButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.shareDropdown_PDF' at Center.", repo.ApplicationUnderTest.shareDropdown_PDFInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.shareDropdown_PDF.Click();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.confirmFileDownloaded("pdf", content1, content2, content3, content4);
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.closeFileTab_IfOpen();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
