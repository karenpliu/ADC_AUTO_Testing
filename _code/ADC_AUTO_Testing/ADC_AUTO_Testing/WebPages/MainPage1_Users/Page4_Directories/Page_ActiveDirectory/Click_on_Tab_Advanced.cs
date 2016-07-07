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

namespace ADC_AUTO_Testing.WebPages.MainPage1_Users.Page4_Directories.Page_ActiveDirectory
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Click_on_Tab_Advanced recording.
    /// </summary>
    [TestModule("4af274aa-fcc4-4f20-9601-338d79c74dd4", ModuleType.Recording, 1)]
    public partial class TC_Click_on_Tab_Advanced : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository repository.
        /// </summary>
        public static ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository repo = ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository.Instance;

        static TC_Click_on_Tab_Advanced instance = new TC_Click_on_Tab_Advanced();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TC_Click_on_Tab_Advanced()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TC_Click_on_Tab_Advanced Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OneLogin.ActiveDirectoryPage.Tabs.Advanced' at Center.", repo.OneLogin.ActiveDirectoryPage.Tabs.AdvancedInfo, new RecordItemIndex(0));
            repo.OneLogin.ActiveDirectoryPage.Tabs.Advanced.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(1));
            Delay.Duration(100, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}