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
    ///The createContacts_Project recording.
    /// </summary>
    [TestModule("4a8f53a1-f8d9-4ca8-9029-7537b70e0b71", ModuleType.Recording, 1)]
    public partial class createContacts_Project : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BudgetItemAutomationIFMRepository repository.
        /// </summary>
        public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;

        static createContacts_Project instance = new createContacts_Project();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public createContacts_Project()
        {
            optionIndex = "";
            contact_FullName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static createContacts_Project Instance
        {
            get { return instance; }
        }

#region Variables

        string _contact_FullName;

        /// <summary>
        /// Gets or sets the value of variable contact_FullName.
        /// </summary>
        [TestVariable("a849b88f-6b94-42f3-9b73-be031b280919")]
        public string contact_FullName
        {
            get { return _contact_FullName; }
            set { _contact_FullName = value; }
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

        /// <summary>
        /// Gets or sets the value of variable optionIndex.
        /// </summary>
        [TestVariable("a117621c-0f5d-44a3-aa87-138e868dc95d")]
        public string optionIndex
        {
            get { return repo.optionIndex; }
            set { repo.optionIndex = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buttonId_add' at Center.", repo.ApplicationUnderTest.buttonId_addInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.buttonId_add.Click();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.project_ContactsPage.projectContact_dropdown' at Center.", repo.ApplicationUnderTest.project_ContactsPage.projectContact_dropdownInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.project_ContactsPage.projectContact_dropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.searchBar_typeplaceholder' at Center.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$contact_FullName' with focus on 'ApplicationUnderTest.searchBar_typeplaceholder'.", repo.ApplicationUnderTest.searchBar_typeplaceholderInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.searchBar_typeplaceholder.PressKeys(contact_FullName);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.project_ContactsPage.projectContact_dropdown_firstInstance' at Center.", repo.ApplicationUnderTest.project_ContactsPage.projectContact_dropdown_firstInstanceInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.project_ContactsPage.projectContact_dropdown_firstInstance.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.project_ContactsPage.projectContact_dropdown' at Center.", repo.ApplicationUnderTest.project_ContactsPage.projectContact_dropdownInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.project_ContactsPage.projectContact_dropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.buttonTagSave' at Center.", repo.ApplicationUnderTest.buttonTagSaveInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.buttonTagSave.Click();
            Delay.Milliseconds(0);
            
            HelperMethodsCollection.waitForLoading();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
