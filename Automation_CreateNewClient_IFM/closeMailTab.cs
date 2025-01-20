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

namespace Automation_CreateNewClient_IFM
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The closeMailTab recording.
    /// </summary>
    [TestModule("0a9ed084-ac74-4cd5-a6ae-de4a4be3d8d5", ModuleType.Recording, 1)]
    public partial class closeMailTab : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Automation_CreateNewClient_IFMRepository repository.
        /// </summary>
        public static Automation_CreateNewClient_IFMRepository repo = Automation_CreateNewClient_IFMRepository.Instance;

        static closeMailTab instance = new closeMailTab();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public closeMailTab()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static closeMailTab Instance
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

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'YOPmailDisposableEmailAddressPage'.", repo.YOPmailDisposableEmailAddressPage.SelfInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.YOPmailDisposableEmailAddressPage.Self, new Duration(0));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
