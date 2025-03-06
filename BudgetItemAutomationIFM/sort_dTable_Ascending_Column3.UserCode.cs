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
    public partial class sort_dTable_Ascending_Column3
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Mouse_Click_TableHeader(RepoItemInfo thtagInfo)
        {
        	var option = new Validate.Options(ReportLevel.Info);
        	option.ExceptionOnFail = false;        	        
        	
        	while (!(Validate.AttributeEqual(thtagInfo, "aria-sort", "ascending", "Checking if sorting is set to 'ascending'.", option)))
    	    {    	    
        		Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'thtagInfo' at Center.", thtagInfo);
            	thtagInfo.FindAdapter<ThTag>().Click();
        	}
        }

    }
}
