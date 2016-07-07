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

namespace ADC_AUTO_Testing.Utils
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Logout recording.
    /// </summary>
    [TestModule("29aef836-84ef-4f01-be67-676c64f4bc63", ModuleType.Recording, 1)]
    public partial class Logout : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository repository.
        /// </summary>
        public static ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository repo = ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository.Instance;

        static Logout instance = new Logout();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Logout()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Logout Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'OneLogin.UsersPage.FaFaUser' at Center.", repo.OneLogin.UsersPage.FaFaUserInfo, new RecordItemIndex(0));
            repo.OneLogin.UsersPage.FaFaUser.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(1));
            Delay.Duration(100, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'OneLogin.UsersPage.LogOut' at Center.", repo.OneLogin.UsersPage.LogOutInfo, new RecordItemIndex(2));
            repo.OneLogin.UsersPage.LogOut.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OneLogin.UsersPage.LogOut' at CenterRight.", repo.OneLogin.UsersPage.LogOutInfo, new RecordItemIndex(3));
            repo.OneLogin.UsersPage.LogOut.Click(Location.CenterRight);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for item 'OneLogin.UsersPage.MacLoginAdminNudge' to not exist.", repo.OneLogin.UsersPage.MacLoginAdminNudgeInfo, new ActionTimeout(10000), new RecordItemIndex(4));
            repo.OneLogin.UsersPage.MacLoginAdminNudgeInfo.WaitForNotExists(10000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
