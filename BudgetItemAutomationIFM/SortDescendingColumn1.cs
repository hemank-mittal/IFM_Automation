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
    ///The SortDescendingColumn1 recording.
    /// </summary>
    [TestModule("b0e74052-1c9e-4cb5-a982-4a935e3410da", ModuleType.Recording, 1)]
    public partial class SortDescendingColumn1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static SortDescendingColumn1 instance = new SortDescendingColumn1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SortDescendingColumn1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SortDescendingColumn1 Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 9999 units.", new RecordItemIndex(0));
            Mouse.ScrollWheel(9999);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TableHeader_Column1' at Center.", repo.ApplicationUnderTest.TableHeader_Column1Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.TableHeader_Column1.Click();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (aria-sort='descending') on item 'ApplicationUnderTest.TableHeader_Column1'.", repo.ApplicationUnderTest.TableHeader_Column1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.TableHeader_Column1Info, "aria-sort", "descending");
            Delay.Milliseconds(100);
            
            HelperMethodsCollection.confirmSorting(repo.ApplicationUnderTest.tableData, "1", ValueConverter.ArgumentFromString<bool>("isDescending", "True"), ValueConverter.ArgumentFromString<bool>("isInteger", "False"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TableHeader_Column1' at Center.", repo.ApplicationUnderTest.TableHeader_Column1Info, new RecordItemIndex(5));
            repo.ApplicationUnderTest.TableHeader_Column1.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
