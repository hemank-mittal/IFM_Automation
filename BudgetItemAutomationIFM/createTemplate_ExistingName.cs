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
    ///The createTemplate_ExistingName recording.
    /// </summary>
    [TestModule("832eb3be-b21b-427f-a245-981f15f4d938", ModuleType.Recording, 1)]
    public partial class createTemplate_ExistingName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static createTemplate_ExistingName instance = new createTemplate_ExistingName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public createTemplate_ExistingName()
        {
            existingName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static createTemplate_ExistingName Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable existingName.
        /// </summary>
        [TestVariable("4837551e-7b56-4a94-8ab0-4ea7f3a7d4e8")]
        public string existingName
        {
            get { return repo.existingName; }
            set { repo.existingName = value; }
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

            Mouse_Click_createSpanTag();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.Content1.MatContentNgTnsC269005172116' and assigning its value to variable 'existingName'.", repo.ApplicationUnderTest.Content1.MatContentNgTnsC269005172116Info, new RecordItemIndex(1));
            existingName = repo.ApplicationUnderTest.Content1.MatContentNgTnsC269005172116.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            existingName = HelperMethodsCollection.trimStrings(existingName, "both");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.Text' at Center.", repo.ApplicationUnderTest.Content1.TextInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Content1.Text.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$existingName' with focus on 'ApplicationUnderTest.Content1.Text'.", repo.ApplicationUnderTest.Content1.TextInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Content1.Text.PressKeys(existingName);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
