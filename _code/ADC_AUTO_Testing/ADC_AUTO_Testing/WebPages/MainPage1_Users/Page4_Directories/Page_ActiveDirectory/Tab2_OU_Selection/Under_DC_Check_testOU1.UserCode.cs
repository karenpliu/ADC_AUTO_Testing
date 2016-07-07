﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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

namespace ADC_AUTO_Testing.WebPages.MainPage1_Users.Page4_Directories.Page_ActiveDirectory.Tab2_OU_Selection
{
    public partial class Under_DC_Check_testOU1
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Check_testOU1()
        {
       	
        }

        public void Check_TagtestOU1()
        {
           // Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'OneLogin.LoginPage.InputTagtestOU1'.", repo.OneLogin.LoginPage.InputTagtestOU1Info);
           // Validate.Attribute(repo.OneLogin.LoginPage.InputTagtestOU1Info, "Checked", "False");
            
            if (repo.OneLogin.LoginPage.InputTagtestOU1.Checked=="False") 
                {
            	Report.Info("Checkbox testOU1 has been checked");	
            	repo.OneLogin.LoginPage.CheckboxtestOU1.Click(); 
            	Delay.Milliseconds(200);
                }            
            
        }

    }
}