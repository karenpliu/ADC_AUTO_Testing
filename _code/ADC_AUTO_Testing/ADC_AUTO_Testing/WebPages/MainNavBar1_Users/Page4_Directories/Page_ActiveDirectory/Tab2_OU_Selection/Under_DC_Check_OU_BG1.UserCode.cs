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

namespace ADC_AUTO_Testing.WebPages.MainNavBar1_Users.Page4_Directories.Page_ActiveDirectory.Tab2_OU_Selection
{
    public partial class Under_DC_Check_OU_BG1
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Check_OU_BG1()
        {
            // If Checkboc for BG_OU1 checked, do nothing. Otherwise click (check) on it.
    
        	if (repo.OneLogin.LoginPage.InputTag_OU_BG1.Checked=="False")
            {
            	repo.OneLogin.LoginPage.ICheck3749977.Click();
           		Delay.Milliseconds(200);
            }
        	
        	
        	//Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'OneLogin.LoginPage.InputTag3749977'.", repo.OneLogin.LoginPage.InputTag3749977Info);
            //Validate.Attribute(repo.OneLogin.LoginPage.InputTag3749977Info, "Checked", "False");
        }

    }
}