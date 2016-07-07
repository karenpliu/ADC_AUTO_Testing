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

namespace ADC_AUTO_Testing.Desktop_Apps.AD_MMC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Refresh_AD_Instance recording.
    /// </summary>
    [TestModule("289ca8fa-0054-4b77-ae60-9e6c44bdca7d", ModuleType.Recording, 1)]
    public partial class Refresh_AD_Instance : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository repository.
        /// </summary>
        public static ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository repo = ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository.Instance;

        static Refresh_AD_Instance instance = new Refresh_AD_Instance();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Refresh_AD_Instance()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Refresh_AD_Instance Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(0));
            Delay.Duration(100, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AD_RNRX1_ONELOGIN.Refresh' at Center.", repo.AD_RNRX1_ONELOGIN.RefreshInfo, new RecordItemIndex(1));
            repo.AD_RNRX1_ONELOGIN.Refresh.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}