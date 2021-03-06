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

namespace ADC_AUTO_Testing.WebPages.LoginPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Login_As_Admin_And_ValidateLogin recording.
    /// </summary>
    [TestModule("adc2d0c3-af3b-4527-9b86-9a9a7e9081f5", ModuleType.Recording, 1)]
    public partial class Login_As_Admin_And_ValidateLogin : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository repository.
        /// </summary>
        public static ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository repo = ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository.Instance;

        static Login_As_Admin_And_ValidateLogin instance = new Login_As_Admin_And_ValidateLogin();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Login_As_Admin_And_ValidateLogin()
        {
            var_AdminEmail = "boris.grinberg+boris12@onelogin.com";
            var_AdminPassword = "abcd12345";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Login_As_Admin_And_ValidateLogin Instance
        {
            get { return instance; }
        }

#region Variables

        string _var_AdminEmail;

        /// <summary>
        /// Gets or sets the value of variable var_AdminEmail.
        /// </summary>
        [TestVariable("6753a1ff-b337-4a01-8662-2c992bf44246")]
        public string var_AdminEmail
        {
            get { return _var_AdminEmail; }
            set { _var_AdminEmail = value; }
        }

        string _var_AdminPassword;

        /// <summary>
        /// Gets or sets the value of variable var_AdminPassword.
        /// </summary>
        [TestVariable("f26f94d1-1f4e-44e6-9882-ad5261480f5e")]
        public string var_AdminPassword
        {
            get { return _var_AdminPassword; }
            set { _var_AdminPassword = value; }
        }

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

            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Value to '$var_AdminEmail' on item 'OneLogin.LoginPage.UserEmail'.", repo.OneLogin.LoginPage.UserEmailInfo, new RecordItemIndex(0));
            repo.OneLogin.LoginPage.UserEmail.Element.SetAttributeValue("Value", var_AdminEmail);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Value to '$var_AdminPassword' on item 'OneLogin.LoginPage.UserPassword'.", repo.OneLogin.LoginPage.UserPasswordInfo, new RecordItemIndex(1));
            repo.OneLogin.LoginPage.UserPassword.Element.SetAttributeValue("Value", var_AdminPassword);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(2));
            Delay.Duration(100, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OneLogin.LoginPage.UserSubmit' at CenterLeft.", repo.OneLogin.LoginPage.UserSubmitInfo, new RecordItemIndex(3));
            repo.OneLogin.LoginPage.UserSubmit.Click(Location.CenterLeft);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'OneLogin.UsersPage.MacLoginAdminNudge'.", repo.OneLogin.UsersPage.MacLoginAdminNudgeInfo, new RecordItemIndex(4));
            Validate.Exists(repo.OneLogin.UsersPage.MacLoginAdminNudgeInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
