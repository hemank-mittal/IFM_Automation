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
    ///The sortAscendingColunm3 recording.
    /// </summary>
    [TestModule("8b31a75d-40ee-492a-8c1c-65335478f134", ModuleType.Recording, 1)]
    public partial class sortAscendingColunm3 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static sortAscendingColunm3 instance = new sortAscendingColunm3();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public sortAscendingColunm3()
        {
            isInteger = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static sortAscendingColunm3 Instance
        {
            get { return instance; }
        }

#region Variables

        string _isInteger;

        /// <summary>
        /// Gets or sets the value of variable isInteger.
        /// </summary>
        [TestVariable("7508ba9d-7c9e-4966-a818-2d3e9835f7a9")]
        public string isInteger
        {
            get { return _isInteger; }
            set { _isInteger = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 9999 units.", new RecordItemIndex(0));
            Mouse.ScrollWheel(9999);
            Delay.Milliseconds(300);
            
            Mouse_Click_TableHeader(repo.ApplicationUnderTest.TableHeader_Column3Info);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (aria-sort='ascending') on item 'ApplicationUnderTest.TableHeader_Column3'.", repo.ApplicationUnderTest.TableHeader_Column3Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.ApplicationUnderTest.TableHeader_Column3Info, "aria-sort", "ascending");
            Delay.Milliseconds(100);
            
            HelperMethodsCollection.confirmSorting(repo.ApplicationUnderTest.tableData, "3", ValueConverter.ArgumentFromString<bool>("isDescending", "False"), ValueConverter.ArgumentFromString<bool>("isInteger", isInteger));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
