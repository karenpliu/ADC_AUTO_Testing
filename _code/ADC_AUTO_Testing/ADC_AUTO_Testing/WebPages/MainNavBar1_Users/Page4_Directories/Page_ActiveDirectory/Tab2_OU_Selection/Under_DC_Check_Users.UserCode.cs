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
    public partial class Under_DC_Check_Users
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Check_Users()
        {

        }

        public void Check_TagUsers()
        {   
            
            if (repo.OneLogin.LoginPage.InputTagUsers.Checked=="False") 
                {
            	Report.Info("Checkbox Users has been checked");	
            	repo.OneLogin.LoginPage.CheckboxUsers.Click();
                }
 
        }


    }
}