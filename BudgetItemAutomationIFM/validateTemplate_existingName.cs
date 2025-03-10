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
    ///The validateTemplate_existingName recording.
    /// </summary>
    [TestModule("bb9b61dd-1624-4309-b7f8-53816bb86ec8", ModuleType.Recording, 1)]
    public partial class validateTemplate_existingName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static validateTemplate_existingName instance = new validateTemplate_existingName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public validateTemplate_existingName()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static validateTemplate_existingName Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.SwalModal'.", repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.SwalModalInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.SwalModalInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='This name is being used for an existing Budget Template. Please revise the entry.') on item 'ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.ThisNameIsBeingUsedForAnExisting'.", repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.ThisNameIsBeingUsedForAnExistingInfo, new RecordItemIndex(1));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.ThisNameIsBeingUsedForAnExistingInfo, "InnerText", "This name is being used for an existing Budget Template. Please revise the entry.");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.ButtonTagOK' at Center.", repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.ButtonTagOKInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.SwalOverlaySwalOverlayShowModal.ButtonTagOK.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content1.ButtonTagCancel1' at Center.", repo.ApplicationUnderTest.Content1.ButtonTagCancel1Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Content1.ButtonTagCancel1.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
