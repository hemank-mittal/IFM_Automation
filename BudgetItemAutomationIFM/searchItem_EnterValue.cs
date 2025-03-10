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
    ///The searchItem_EnterValue recording.
    /// </summary>
    [TestModule("d88fcab7-5a80-4332-84a2-13a8500eb233", ModuleType.Recording, 1)]
    public partial class searchItem_EnterValue : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static searchItem_EnterValue instance = new searchItem_EnterValue();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public searchItem_EnterValue()
        {
            searchItem = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static searchItem_EnterValue Instance
        {
            get { return instance; }
        }

#region Variables

        string _searchItem;

        /// <summary>
        /// Gets or sets the value of variable searchItem.
        /// </summary>
        [TestVariable("81715196-c098-4405-abff-2445df9467aa")]
        public string searchItem
        {
            get { return _searchItem; }
            set { _searchItem = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.searchBar_typeplaceholder' at Center.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.searchBar_typeplaceholder);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$searchItem' with focus on 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.PressKeys(searchItem);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
