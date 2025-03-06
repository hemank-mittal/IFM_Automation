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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace BudgetItemAutomationIFM
{
    public partial class createAssetType_MDC
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Mouse_Click_createSpanTag()
        {
        	Mouse.ScrollWheel(9999);
        	
        	if (repo.ApplicationUnderTest.createSpanTagInfo.Exists(1000))
        	{
        		var buttonToClick = repo.ApplicationUnderTest.createSpanTagInfo;
        		buttonToClick.FindAdapter<SpanTag>().Click();
        	}
        	else if (repo.ApplicationUnderTest.createButtonTagInfo.Exists(1000))
            {
            	var buttonToClick = repo.ApplicationUnderTest.createButtonTagInfo;
        		buttonToClick.FindAdapter<ButtonTag>().Click();
            }
        	else
        	{
        		Report.Error("Something seems wrong. The 'Create' button not found.");
        	}
        }

    }
}
