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
    ///The editItem_sameName recording.
    /// </summary>
    [TestModule("16e82ac2-328a-4b66-b8aa-445da3bfaa88", ModuleType.Recording, 1)]
    public partial class editItem_sameName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static editItem_sameName instance = new editItem_sameName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public editItem_sameName()
        {
            itemName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static editItem_sameName Instance
        {
            get { return instance; }
        }

#region Variables

        string _itemName;

        /// <summary>
        /// Gets or sets the value of variable itemName.
        /// </summary>
        [TestVariable("864c18e5-1477-47d1-950c-5b74b6c2c384")]
        public string itemName
        {
            get { return _itemName; }
            set { _itemName = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ButtonTagEdit1' at Center.", repo.ApplicationUnderTest.ButtonTagEdit1Info, new RecordItemIndex(0));
            repo.ApplicationUnderTest.ButtonTagEdit1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.Content1.Text1' and assigning its value to variable 'itemName'.", repo.ApplicationUnderTest.Content1.Text1Info, new RecordItemIndex(1));
            itemName = repo.ApplicationUnderTest.Content1.Text1.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FundingWrapperNgStarInsertedRow.ButtonTagSave' at Center.", repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.ButtonTagSaveInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.FundingWrapperNgStarInsertedRow.ButtonTagSave.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
