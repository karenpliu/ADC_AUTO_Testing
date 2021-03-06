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

namespace ADC_AUTO_Testing.WebPages.NavBar1_USERS.Page4_Directories
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Verify_MinUserCount_AD2 recording.
    /// </summary>
    [TestModule("6f8890fb-f1e4-4155-9028-12156f2c0001", ModuleType.Recording, 1)]
    public partial class Verify_MinUserCount_AD2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository repository.
        /// </summary>
        public static ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository repo = ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository.Instance;

        static Verify_MinUserCount_AD2 instance = new Verify_MinUserCount_AD2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_MinUserCount_AD2()
        {
            var_Min_User2 = "1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_MinUserCount_AD2 Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable var_Min_User2.
        /// </summary>
        [TestVariable("aa7f452a-6e84-426e-b3c7-5ecddb2d771d")]
        public string var_Min_User2
        {
            get { return repo.var_Min_User2; }
            set { repo.var_Min_User2 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$var_Min_User2) on item 'OneLogin.DirectoriesPage.MinUserCount_AD2'.", repo.OneLogin.DirectoriesPage.MinUserCount_AD2Info, new RecordItemIndex(0));
            Validate.Attribute(repo.OneLogin.DirectoriesPage.MinUserCount_AD2Info, "InnerText", var_Min_User2);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
