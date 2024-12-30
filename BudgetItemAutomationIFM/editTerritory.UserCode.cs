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
    public partial class editTerritory
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Get_value_CustodialAreaManager_dynamic(RepoItemInfo divtagInfo, string index)
        {
        	if (int.Parse(index) > 1)
        	{
        		Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'divtagInfo' and assigning its value to variable 'editedLinkedItem'.", divtagInfo);
            	editedLinkedItem = divtagInfo.FindAdapter<DivTag>().Element.GetAttributeValueText("InnerText");        		
        	}            
        }

        public void Mouse_Click_CustodialAreaManager_dynamic(RepoItemInfo divtagInfo, string index)
        {
        	if (int.Parse(index) > 1)
        	{
        		Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'divtagInfo' at Center.", divtagInfo);
            	divtagInfo.FindAdapter<DivTag>().Click();        		
        	}            
        }

    }
}