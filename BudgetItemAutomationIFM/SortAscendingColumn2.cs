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
    ///The SortAscendingColumn2 recording.
    /// </summary>
    [TestModule("16e4e05f-2508-4420-89d5-ccbff54b6107", ModuleType.Recording, 1)]
    public partial class SortAscendingColumn2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static SortAscendingColumn2 instance = new SortAscendingColumn2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SortAscendingColumn2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SortAscendingColumn2 Instance
        {
            get { return instance; }
        }

#region Variables

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

            Mouse_Click_TableHeader(repo.ApplicationUnderTest.TableHeader_Column2Info);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (aria-sort='ascending') on item 'ApplicationUnderTest.TableHeader_Column2'.", repo.ApplicationUnderTest.TableHeader_Column2Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.ApplicationUnderTest.TableHeader_Column2Info, "aria-sort", "ascending");
            Delay.Milliseconds(100);
            
            HelperMethodsCollection.confirmSorting(repo.ApplicationUnderTest.tableData, "2", ValueConverter.ArgumentFromString<bool>("isDescending", "False"), ValueConverter.ArgumentFromString<bool>("isInteger", "False"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}