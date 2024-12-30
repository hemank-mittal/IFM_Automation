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
    ///The searchCategory_Find recording.
    /// </summary>
    [TestModule("58b96334-ad71-42cc-bbe0-f3757c435233", ModuleType.Recording, 1)]
    public partial class SearchCategory_Find : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static SearchCategory_Find instance = new SearchCategory_Find();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SearchCategory_Find()
        {
            searchItem = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SearchCategory_Find Instance
        {
            get { return instance; }
        }

#region Variables

        string _searchItem;

        /// <summary>
        /// Gets or sets the value of variable searchItem.
        /// </summary>
        [TestVariable("d819ec6c-2825-40db-a149-61682386704c")]
        public string searchItem
        {
            get { return _searchItem; }
            set { _searchItem = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.SomeTdTag_firstElement' and assigning its value to variable 'searchItem'.", repo.ApplicationUnderTest.SomeTdTag_firstElementInfo, new RecordItemIndex(0));
            searchItem = repo.ApplicationUnderTest.SomeTdTag_firstElement.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
