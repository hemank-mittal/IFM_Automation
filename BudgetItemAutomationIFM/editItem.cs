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
    ///The editItem recording.
    /// </summary>
    [TestModule("7c3c270f-c9d4-46e9-8bf1-eca91c9eeae3", ModuleType.Recording, 1)]
    public partial class editItem : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static editItem instance = new editItem();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public editItem()
        {
            oldName = "";
            edittedName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static editItem Instance
        {
            get { return instance; }
        }

#region Variables

        string _oldName;

        /// <summary>
        /// Gets or sets the value of variable oldName.
        /// </summary>
        [TestVariable("4ac43a86-696a-4f5c-a948-e425261332d1")]
        public string oldName
        {
            get { return _oldName; }
            set { _oldName = value; }
        }

        string _edittedName;

        /// <summary>
        /// Gets or sets the value of variable edittedName.
        /// </summary>
        [TestVariable("6c3d395f-6e25-4a2f-a257-1636e02c333f")]
        public string edittedName
        {
            get { return _edittedName; }
            set { _edittedName = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to not exist. Associated repository item: 'ApplicationUnderTest.FaFaSpinFaSpinner'", repo.ApplicationUnderTest.FaFaSpinFaSpinnerInfo, new ActionTimeout(60000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.FaFaSpinFaSpinnerInfo.WaitForNotExists(60000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ButtonTagEdit_Row2' at Center.", repo.ApplicationUnderTest.ButtonTagEdit_Row2Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.ButtonTagEdit_Row2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.Text1' at Center.", repo.ApplicationUnderTest.Content1.Text1Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Content1.Text1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.Content1.Text1' and assigning its value to variable 'oldName'.", repo.ApplicationUnderTest.Content1.Text1Info, new RecordItemIndex(3));
            oldName = repo.ApplicationUnderTest.Content1.Text1.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            edittedName = HelperMethodsCollection.getEdittedName(oldName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'ApplicationUnderTest.Content1.Text1'.", repo.ApplicationUnderTest.Content1.Text1Info, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Content1.Text1.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$edittedName' with focus on 'ApplicationUnderTest.Content1.Text1'.", repo.ApplicationUnderTest.Content1.Text1Info, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Content1.Text1.PressKeys(edittedName);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
