/*
 * Created by Ranorex
 * User: LENOVO
 * Date: 20-11-2024
 * Time: 19:02
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

using System.Linq;
using System.IO;

namespace BudgetItemAutomationIFM
{
    [UserCodeCollection]
    public class HelperMethodsCollection
    {
    	public static BudgetItemAutomationIFMRepository repo = BudgetItemAutomationIFMRepository.Instance;
    	
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        /// <summary>
        /// This method simply fetched the value of "browserName" global parameter for further use.
        /// </summary>
        [UserCodeMethod]
        public static string getBrowserName()
        {
//        	Report.Warn(globalParameters.browserName);
        	return globalParameters.browserName;
        }
        
        /// <summary>
        /// The method checks for the count of items in the list, and provides a string (Name) with the index 
        /// of item to be inserted.
        /// </summary>
        [UserCodeMethod]
        public static string getNewCreateItem(int nextCount, string itemType)
        {
        	string newItem = null;
        	
        	if(itemType.ToLower() == "email")
        	{
        		newItem = "testEmail" + nextCount.ToString() + ".IFM@yopmail.com";
        	}
        	else if(itemType.ToLower() == "item")
        	{
        		newItem = "test item " + nextCount.ToString();
        	}
        	else if(itemType.ToLower() == "template")
        	{
        		newItem = "test template " + nextCount.ToString();
        	}
        	else
        	{
        		newItem = "test element " + nextCount.ToString();
        	}
        	
//        	Report.Warn(newItem);
        	return newItem;
        }
        
        /// <summary>
        /// This method return number of records when the number is not explicitly mentioned anywhere in the table.
        /// </summary>
        [UserCodeMethod]
        public static int getItemsCount(Adapter element)
        {
			var elementChildren = element.FindChildren<Ranorex.Unknown>();
//			Report.Warn(elementChildren.Count.ToString());
			return (elementChildren.Count + 1);
        }
        
        /// <summary>
        /// This method is used to compare strings when the strings may need some trimming before comparing.
        /// </summary>
        [UserCodeMethod]
        public static void compareStrings(string compareWith, string compareTo)
        {
        	if (string.IsNullOrEmpty(compareTo) || string.IsNullOrEmpty(compareWith))
        	{
        		Report.Info("No data passed to compare.");
        	}
        	if(compareWith.ToLower().Trim() == compareTo.ToLower().Trim())
        	{
        		Report.Success("Literals matched!");
        	}
        	else
        	{
        		Report.Warn(compareWith.ToLower().Trim());
        		Report.Warn(compareTo.ToLower().Trim());
        		Report.Error("Expected value : " + compareTo + " and actual value : " + compareWith + ".");
//        		Report.Failure("Some issue occured in verifying the item creation.");
        	}
        }
        
        /// <summary>
        /// This method is created to confirm if the passed strings are not equal.
        /// </summary>
        [UserCodeMethod]
        public static void compareStringsNotEqual(string compareWith, string compareTo)
        {
        	if(compareWith.ToLower().Trim() == compareTo.ToLower().Trim())
        	{
        		Report.Warn(compareWith.ToLower().Trim());
        		Report.Warn(compareTo.ToLower().Trim());
        		Report.Error("Given strings matched!");
        	}
        	else
        	{        		
        		Report.Success("The given values are not equal, as expected.");
//        		Report.Failure("Some issue occured in verifying the item creation.");
        	}
        }
        
        /// <summary>
        /// This method is used to trim strings, created an user method since it is not possible without coding.
        /// </summary>
        [UserCodeMethod]
        public static string trimStrings(string str, string side)
        {
        	if (side == "left")
        	{
        		return str.TrimStart();
        	}
        	if (side == "right")
        	{
        		return str.TrimEnd();
        	}
        	
        	return str.Trim();
        }       
                
        /// <summary>
        /// The method takes in an SpanTag Element, and from its innertext, fetches the largest number.
        /// </summary>
        [UserCodeMethod]
        public static int getNumberOfRecordsFromFooter(Adapter element)
        {        	        
        	var text = element.GetAttributeValue<string>("InnerText");						
			var matches = System.Text.RegularExpressions.Regex.Matches(text, @"\d+");
    
		    // Convert matches to a list of integers
		    var numbers = matches.Cast<System.Text.RegularExpressions.Match>()
		                         .Select(m => int.Parse(m.Value))
		                         .ToList();
		    
		    int maxNumber = numbers.Max() + 1;
        	
			return maxNumber;
        }
                
        /// <summary>
        /// This method gives name to keep after editting an element.
        /// </summary>
        [UserCodeMethod]
        public static string getEdittedName(string oldName)
        {
        	if (oldName == null)
        	{
        		return "Edited";
        	}
        	
        	else if (oldName.Contains("edited"))
        	{
        		if (oldName.Trim() == "edited")
        		{
        			return oldName + " 2";
        		}
        		
        		var newValue = oldName.Replace(" edited", "");
        	   	
        	   	return newValue;
        	}
        	
			else
			{
				return oldName + " edited";
			}        	
        }
                
        /// <summary>
        /// This method finds some specific element in a list, now you can get customised output for 
        /// whether you want that element found not.
        /// </summary>
        [UserCodeMethod]
        public static void findTextInList(Adapter element, string compareWith, bool wantMatch)
        {
        	IList<LiTag> listItems = element.FindDescendants<LiTag>();
        	bool found = false;   
        	
        	foreach (var i in listItems)
        	{
        		if (i.InnerText.Trim() == compareWith.Trim())
        		{
        			found = true;        			
        			break;
        		}
        	}
        	
        	if (found)
        	{
        		if(wantMatch)
        		{
        			Report.Success("Match Found!");
        		}
        		else
        		{
        			Report.Failure("Item exists in the list.");
        		}
        	}
        	else
        	{
        		if(wantMatch)
        		{
        			Report.Failure("No match Found!");
        		}
        		else
        		{
        			Report.Success("Item does not exist in the list.");
        		}
        	}
        	
        	return;
        }
        
        /// <summary>
        /// This method is to check if the data is correctly sorted, the way it is intended to be.
        /// </summary>
        [UserCodeMethod]
        public static void confirmSorting(Adapter element, string index, bool isDescending, bool isInteger)
        {
        	if (isInteger)
            {
        		IList<TrTag> tableRows = element.FindDescendants<TrTag>();

	            List<int> columnData = new List<int>();
	            foreach (var row in tableRows)
	            {            				        	
	                var cell = row.FindSingle<Unknown>("./td[" + index + "]/?");
	                columnData.Add(cell.GetAttributeValue<int>("innertext"));
	//                Report.Warn(cell.GetAttributeValue<string>("innertext").ToString());
	            }        		
            	
            	bool isSorted = isDescending
			        ? columnData.SequenceEqual(columnData.OrderByDescending(x => x))
			        : columnData.SequenceEqual(columnData.OrderBy(x => x));
            	
            	if (isSorted)
	            {
	                Report.Success("The column is correctly sorted.");
	            }
	            else
	            {
	                Report.Failure("The column is NOT correctly sorted.");
	            }
            }
            
            else
            {
            	IList<TrTag> tableRows = element.FindDescendants<TrTag>();

	            List<string> columnData = new List<string>();
	            foreach (var row in tableRows)
	            {            				        	
	                var cell = row.FindSingle<Unknown>("./td[" + index + "]/?");
	                columnData.Add(cell.GetAttributeValue<string>("innertext").Trim());
	//                Report.Warn(cell.GetAttributeValue<string>("innertext").ToString());
	            }
	            
	            List<string> sortedData = new List<string>(columnData);
	            sortedData.Sort(StringComparer.OrdinalIgnoreCase);
	
	            if (isDescending)
	            {
	            	sortedData.Reverse();
	            }
	
	            if (columnData.SequenceEqual(sortedData))
	            {
	                Report.Success("The column is correctly sorted.");
	            }
	            else
	            {
	                Report.Failure("The column is NOT correctly sorted.");
	            }
            }
            
        }                
        
        /// <summary>
        /// This method is for the case where a different option from dropdown is to be selected every time
        /// the code runs. So the alternate is 1st option and 2nd option for now.
        /// </summary>
        [UserCodeMethod]
        public static Int64 getDifferentOption(Adapter element)
        {
        	IList<InputTag> opts_input = element.FindDescendants<InputTag>();
        	string isChecked = null;        	               	
        	
        	if (opts_input.Count == 0)
        	{
        		IList<WebElement> opts_webElement = element.FindDescendants<WebElement>();
        		
        		if (opts_webElement[0].GetAttributeValue<string>("tagvalue") == "0")
        		{
        			return 1;
        		}
        		isChecked = opts_webElement[0].GetAttributeValue<string>("aria-selected"); 	
        		Report.Warn(opts_webElement[0].GetAttributeValue<string>("tagvalue"));        		
        	}
        	else if (opts_input.Count == 1)
        	{
        		return 1;
        	}
        	else if (opts_input.Count > 1)
        	{
        		isChecked = opts_input[0].GetAttributeValue<string>("Checked");        	
        	}  
        	
        	if (isChecked == "True" || isChecked == "true")
        	{
        		return 2;
        	}
        	else
        	{
        		return 1;
        	}
        }
        
        /// <summary>
        /// This method is to fetch the attribute "TagName" in RxPath for different pages. It is a bit hardcoding 
        /// done here, but that was the only way.
        /// </summary>
        [UserCodeMethod]
        public static string getTagNameForTab(string tabName)
        {
        	if (tabName.ToLower().Contains("budget"))
        	{
        		return "ng-multiselect-dropdown";
        	}
        	else if (tabName.ToLower().Contains("closeout") || tabName.ToLower().Contains("close_out"))
        	{
        		return "mat-select";
        	}
        	
        	return null;
        }
        
        /// <summary>
        /// This method is used in case when all options(selected and not selected) are shown to select 
        /// and the one must be selected which is not selected yet.
        /// </summary>
        [UserCodeMethod]
        public static int selectDifferentOption(Adapter element)
        {
        	IList<InputTag> opts_input = element.FindDescendants<InputTag>();        	
        	
        	if (opts_input.Count == 0)
        	{
        		IList<WebElement> opts_webElement = element.FindDescendants<WebElement>();
        		
        		foreach (var i in opts_webElement)
	        	{
	        		if (i.GetAttributeValue<string>("aria-disabled") == "false" && i.GetAttributeValue<string>("aria-selected") == "false")
	        		{	
	        			return (opts_webElement.IndexOf(i) + 1);
	        		}
	        	}
        	}

			foreach (var i in opts_input)
        	{
        		if (i.GetAttributeValue<string>("checked") == "false" || i.GetAttributeValue<string>("checked") == "False")
        		{
        			return (opts_input.IndexOf(i) + 1);
        		}
        	}        	
        	
        	return 0;
        }
        
        /// <summary>
        /// This method generates a random string with no constraints.
        /// </summary>
        [UserCodeMethod]
        public static void generateRandomString()
        {
        	var random = new Random();
        	var val = random.Next();
        	
        	Report.Warn(val.ToString());
        }
        
        /// <summary>
        /// This method is made for a specific scenario, where you can concatenate 6 strings together seperated by spaces.
        /// </summary>
        [UserCodeMethod]
        public static string concatStrings6(string s1, string s2, string s3, string s4, string s5, string s6)
        {        	
        	var l1 = string.IsNullOrEmpty(s1) ? new string[0] : s1.Trim().Split(' ');
        	var tempList = string.IsNullOrEmpty(s2) ? l1 : l1.Concat(s2.Trim().Split(' '));
        	tempList = string.IsNullOrEmpty(s3) ? tempList : tempList.Concat(s3.Trim().Split(' '));
        	tempList = string.IsNullOrEmpty(s4) ? tempList : tempList.Concat(s4.Trim().Split(' '));
        	tempList = string.IsNullOrEmpty(s5) ? tempList : tempList.Concat(s5.Trim().Split(' '));
			tempList = string.IsNullOrEmpty(s6) ? tempList : tempList.Concat(s6.Trim().Split(' '));
        	
			var finalList = tempList.Cast<string>().ToArray();			
			
			return string.Join(" ", finalList);
        }
        
        /// <summary>
        /// This method is made for specific scenario where you can concatenate 2 strings seperated by commma.
        /// </summary>
        [UserCodeMethod]
        public static string concatStrings2(string s1, string s2)
        {
        	var result = s1 + "," + s2;
        	return result;
        }                     
        
        /// <summary>
        /// This method is to get a random HEC CODE for some volour
        /// </summary>
        [UserCodeMethod]
        public static string generateRandomHEXCode()
        {
        	Random random = new Random();

	        // Generate random values for Red, Green, and Blue (0 to 255)
	        int red = random.Next(0, 256);
	        int green = random.Next(0, 256);
	        int blue = random.Next(0, 256);
	
	        // Convert the RGB values to a HEX color code
	        string hexColor = String.Format("#{0:X2}{1:X2}{2:X2}", red,green, blue);	       
	
	        return hexColor;
        }
        
        /// <summary>
        /// This method is used to get edited number. This method keeps increamenting the old number by 7 till the number gets becomes
        /// a multiple of 10, then it devides the number by 10 as decreament.
        /// </summary>
        [UserCodeMethod]
        public static int getEditedNumber(int oldNumber)
        {
        	if (oldNumber == null)
        	{
        		return 1;
        	}        
        	
        	else if (oldNumber % 10 == 0)
        	{
        		return oldNumber / 10;
        	}
        	
        	else
        	{
        		return oldNumber + 7;
        	}
        }
        
        /// <summary>
        /// This method checks if there is a second record fetched on searching for some item, if found, it compares the first and second
        /// item. They should NOT be equal.
        /// </summary>
        [UserCodeMethod]
        public static void compareSecondRecord_IfExist(string record1, string elementInfoItemRxPath)
        {
        	Element record2Info;       	
        	
        	if (Host.Local.TryFindSingle(elementInfoItemRxPath, 5000, out record2Info))
        	{
        		string record2 = record2Info.GetAttributeValueText("InnerText");
        		HelperMethodsCollection.compareStringsNotEqual(record1, record2);
        	}
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static string getCommaSeperatedString_FromRepo(string elementPath)
        {
        	var x = Host.Local.Find<InputTag>(elementPath);
        	List<string> strElements = new List<string>();
        	
        	foreach (var i in x)
        	{
        		strElements.Add(i.NextSibling.InnerText.ToString());        		
        	}
        	
        	strElements.Sort();
        	
        	string result = string.Join(",", strElements);
        	Report.Warn(result);
        	return result;
        }        
    }
}
