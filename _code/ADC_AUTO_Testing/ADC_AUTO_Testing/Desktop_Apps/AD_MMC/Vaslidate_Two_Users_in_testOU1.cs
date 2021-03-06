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
    ///The Vaslidate_Two_Users_in_testOU1 recording.
    /// </summary>
    [TestModule("8202953a-541e-4c6b-b4af-3cab69d1ecd0", ModuleType.Recording, 1)]
    public partial class Vaslidate_Two_Users_in_testOU1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository repository.
        /// </summary>
        public static ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository repo = ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository.Instance;

        static Vaslidate_Two_Users_in_testOU1 instance = new Vaslidate_Two_Users_in_testOU1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Vaslidate_Two_Users_in_testOU1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Vaslidate_Two_Users_in_testOU1 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AD_RNRX1_ONELOGIN.TestOU1' at Center.", repo.AD_RNRX1_ONELOGIN.TestOU1Info, new RecordItemIndex(0));
            repo.AD_RNRX1_ONELOGIN.TestOU1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='testUser1') on item 'AD_RNRX1_ONELOGIN.TestUser1'.", repo.AD_RNRX1_ONELOGIN.TestUser1Info, new RecordItemIndex(1));
            Validate.Attribute(repo.AD_RNRX1_ONELOGIN.TestUser1Info, "Text", "testUser1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='testUser2') on item 'AD_RNRX1_ONELOGIN.TestUser2'.", repo.AD_RNRX1_ONELOGIN.TestUser2Info, new RecordItemIndex(2));
            Validate.Attribute(repo.AD_RNRX1_ONELOGIN.TestUser2Info, "Text", "testUser2");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
