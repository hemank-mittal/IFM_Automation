/*
 * Created by Ranorex
 * User: LENOVO
 * Date: 16-01-2025
 * Time: 11:39
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace Automation_CreateNewClient_IFM
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class HelperCodeCollection2
    {
    	public static Automation_CreateNewClient_IFMRepository repo = Automation_CreateNewClient_IFMRepository.Instance;
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void checkStatusOnLoop(Adapter element)
        {
        	if (element.GetAttributeValue<string>("innertext").Trim() == "Provisioning Completed")
        	{

        	}
        	else if (element.GetAttributeValue<string>("innertext").Trim() == "Provisioning Failed")
        	{

        	}
        	else
        	{
        		repo.ApplicationUnderTest.Self.ExecuteScript("location.reload(true);");
        		Automation_CreateNewClient_IFM.validateNewClient.Start();
        	}
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static string fetchPasswordFromString()
        {
        	var textToSplit = repo.YOPmailDisposableEmailAddressPage.credentialsText.InnerText;
			var listStrings = textToSplit.Split(' ');			
			var lastIndex = listStrings.Length - 1;
			
			return listStrings[lastIndex];
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static bool isLoggedIn(string currentUrl)
        {
        	if(currentUrl.Contains("login"))
        	{
        		Report.Error("Some error occured while logging in as new client. Try again later.");
        		return false;
        	}
        	else
        	{
        		Report.Success("Successfully logged In.");
        		return true;
        	}
        }
    }
}
