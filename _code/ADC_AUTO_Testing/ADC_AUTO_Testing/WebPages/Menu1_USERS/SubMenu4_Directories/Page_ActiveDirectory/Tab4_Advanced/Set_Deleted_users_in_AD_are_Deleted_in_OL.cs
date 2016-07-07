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

namespace ADC_AUTO_Testing.WebPages.Menu1_USERS.SubMenu4_Directories.Page_ActiveDirectory.Tab4_Advanced
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Set_Deleted_users_in_AD_are_Deleted_in_OL recording.
    /// </summary>
    [TestModule("1a78fa60-d399-4e29-b5c4-94ee5fdc73a2", ModuleType.Recording, 1)]
    public partial class Set_Deleted_users_in_AD_are_Deleted_in_OL : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository repository.
        /// </summary>
        public static ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository repo = ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository.Instance;

        static Set_Deleted_users_in_AD_are_Deleted_in_OL instance = new Set_Deleted_users_in_AD_are_Deleted_in_OL();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Set_Deleted_users_in_AD_are_Deleted_in_OL()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Set_Deleted_users_in_AD_are_Deleted_in_OL Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OneLogin.LoginPage.SomeBTag1' at Center.", repo.OneLogin.LoginPage.SomeBTag1Info, new RecordItemIndex(0));
            repo.OneLogin.LoginPage.SomeBTag1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(1));
            Delay.Duration(100, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OneLogin.LoginPage.AreDeletedInOneLogin' at Center.", repo.OneLogin.LoginPage.AreDeletedInOneLoginInfo, new RecordItemIndex(2));
            repo.OneLogin.LoginPage.AreDeletedInOneLogin.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
