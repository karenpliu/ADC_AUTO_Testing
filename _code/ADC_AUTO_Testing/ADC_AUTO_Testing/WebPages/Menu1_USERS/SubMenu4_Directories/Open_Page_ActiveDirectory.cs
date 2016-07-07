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

namespace ADC_AUTO_Testing.WebPages.Menu1_USERS.SubMenu4_Directories
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Open_Page_ActiveDirectory recording.
    /// </summary>
    [TestModule("b5182e5e-0037-43a8-867d-06401a27757a", ModuleType.Recording, 1)]
    public partial class Open_Page_ActiveDirectory : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository repository.
        /// </summary>
        public static ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository repo = ADC_AUTO_Testing.ALL_REPOS.AD_SuiteRepository.Instance;

        static Open_Page_ActiveDirectory instance = new Open_Page_ActiveDirectory();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Open_Page_ActiveDirectory()
        {
            var_AD_Name = "Active Directory";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Open_Page_ActiveDirectory Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable var_AD_Name.
        /// </summary>
        [TestVariable("f10eaa53-a92f-425b-acda-eab26f5a6eda")]
        public string var_AD_Name
        {
            get { return repo.var_AD_Name; }
            set { repo.var_AD_Name = value; }
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

            // will use name of active directory from the file
            Report.Log(ReportLevel.Info, "Mouse", "will use name of active directory from the file\r\nMouse Left Click item 'OneLogin.DirectoriesPage.ActiveDirectory' at CenterLeft.", repo.OneLogin.DirectoriesPage.ActiveDirectoryInfo, new RecordItemIndex(0));
            repo.OneLogin.DirectoriesPage.ActiveDirectory.Click(Location.CenterLeft);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$var_AD_Name) on item 'OneLogin.ActiveDirectoryPage.ActiveDirectory'.", repo.OneLogin.ActiveDirectoryPage.ActiveDirectoryInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.OneLogin.ActiveDirectoryPage.ActiveDirectoryInfo, "InnerText", var_AD_Name);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
