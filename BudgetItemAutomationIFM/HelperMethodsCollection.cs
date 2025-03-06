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
using System.Globalization;
using System.Net;
using System.Diagnostics;

using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using OfficeOpenXml;

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
        /// This method simply fetched the value of "environment" global parameter, and creates a link of that env. for further use.
        /// </summary>
        [UserCodeMethod]
        public static string getURL_IFM()
        {
//        	Report.Warn(globalParameters.browserName);
        	var env = globalParameters.environment;
        	var url = env + ".ifm360.com";
        	
        	return url;
        }        
        
        /// <summary>
        /// The method checks for the count of items in the list, and provides a string (Name) with the index 
        /// of item to be inserted.
        /// The name is follows pattern : {AC}(Automatically Created){ Ranorex }[today's date (DDMM)][Instance Number], except for the case 
        /// where email is to be generated dynamically.
        /// </summary>
        [UserCodeMethod]
        public static string getNewCreateItem(int nextCount, string itemType)
        {
        	string newItem = null;
        	
        	if(itemType.ToLower() == "email")
        	{
        		newItem = "testEmail" + nextCount.ToString() + ".IFM@yopmail.com";
        	}
        	else
        	{
        		newItem = "AC Ranorex " + System.DateTime.Now.Day.ToString() + System.DateTime.Now.Month.ToString() + nextCount.ToString();
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
        /// This method is created to confirm if the passed strings are not equal. This method trims and lower cases the strings before comparison.
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
        		IList<WebElement> opts_webElement = element.FindChildren<WebElement>();
        		
        		if (opts_webElement[0].GetAttributeValue<string>("tagvalue") == "0")
        		{
        			Report.Warn("-1?");
        			return -1;
        		}
        		else if (opts_webElement.Count == 1)
        		{
        			return 1;
        		}
        		
        		isChecked = opts_webElement[0].GetAttributeValue<string>("aria-selected"); 	
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
        /// and the one must be selected which is not selected yet, or the first instance if there is no more than one option.
        /// </summary>
        [UserCodeMethod]
        public static int selectDifferentOption(Adapter element)
        {
        	IList<InputTag> opts_input = element.FindChildren<InputTag>();        	
        	
        	if (opts_input.Count <= 1)
        	{
        		IList<WebElement> opts_webElement = element.FindChildren<WebElement>();        
        		
        		if (opts_input.Count == 1 || opts_webElement.Count == 1)
        		{
        			return 1;
        		}
        		
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
        /// This method is made for a specific scenario, where you can concatenate UP TO 6 strings together seperated by spaces.
        /// </summary>
        [UserCodeMethod]
        public static string concatStrings_spaces(string s1, string s2, string s3, string s4, string s5, string s6)
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
        public static string concatStrings_comma(string s1, string s2)
        {
        	var result = s1 + "," + s2;
        	return result;
        }

		/// <summary>
        /// This method is made for specific scenario where you can concatenate 4 strings unseperated by any character.
        /// </summary>
        [UserCodeMethod]
        public static string concatStrings(string s1, string s2, string s3, string s4)
        {
        	var tempResult = string.IsNullOrEmpty(s2) ? s1 : s1+s2;
        	tempResult = string.IsNullOrEmpty(s3) ? tempResult : tempResult+s3;
        	tempResult = string.IsNullOrEmpty(s4) ? tempResult: tempResult+s4;
        	
        	return tempResult;
        }         
        
        /// <summary>
        /// This method is to get a random HEC CODE for some colour
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
        	if ((string.IsNullOrEmpty(oldNumber.ToString())) || oldNumber == 0)
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
        /// This method checks if any record with given fieldValue exists or not, checking if there is any record visible or not.
        /// </summary>
        [UserCodeMethod]
        public static void checkFirstRecord_IfExists(string fieldValue, string elementInfoItemRxPath)
        {
        	Element recordInfo;
        	
        	if (Host.Local.TryFindSingle(elementInfoItemRxPath, 5000, out recordInfo))
        	{
        		string recordValue = recordInfo.GetAttributeValueText("InnerText");
        		HelperMethodsCollection.compareStringsNotEqual(fieldValue, recordValue);
        	}
        	else
        	{
        		Report.Info("No record to verify.");
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
        	else
        	{
        		Report.Info("No second record found to check");
        	}
        }
        
        /// <summary>
        /// This method is used to get option values in dropdown as a string seperated by comma.
        /// Mostly used in scenario where selected options are needed to process later.
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
        
        /// <summary>
        /// This method is used to assign some value (your preference, needed to enter in corresponding recording), to some recording variable.
        /// Needed to create a method since assigning value to any variable on runtime without coding is not possible.
        /// </summary>
        [UserCodeMethod]
        public static string assignVariable(string variableValue)
        {
        	return variableValue;
        }
        
        
        /// <summary>
        /// This method simply converts any given string to it's corresponding integer. Returns an error and integer '0' in case of failure.
        /// </summary>
        [UserCodeMethod]
        public static int stringToInteger(string stringInput)
        {        	
        	int integerOutput;
        	if (int.TryParse(stringInput, out integerOutput))
        	{
        		return integerOutput;
        	}
        	else
        	{
        		Report.Failure("Invalid string passed to convert to Integer!!");
        		return 0;
        	}
        }
        
        
        /// <summary>
        /// This method checks if it has been "timePeriod" seconds since "startTime" to now.
        /// </summary>
        [UserCodeMethod]
        public static bool checkForDuration_Timespan(System.DateTime startTime, int timePeriod)
        {
        	System.DateTime timeNow = System.DateTime.Now;
        	
			TimeSpan duration = timeNow - startTime;
			
			return (duration.Seconds < timePeriod);
        }
        
        /// <summary>
        /// This method is specifically to wait till spinner disappears from the screen. Sometimes the spinner appears frequently within duration
        /// of 1 second or less, this method considers those durations and still waits if the spinner would appear again.
        /// </summary>
        [UserCodeMethod]
        public static void waitForLoading()
        {
        	var element = repo.ApplicationUnderTest.FaFaSpinFaSpinnerInfo;
//			var element = repo.IFM360ProjectInfo.FaFaSpinFaSpinnerInfo;
        	bool flag = true;
        	int checkStartTime = System.DateTime.Now.Minute;        	
        	
        	do
        	{
        		element.WaitForNotExists(120000);
        		
				System.DateTime startTime = System.DateTime.Now;
        		
        		while (checkForDuration_Timespan(startTime, 3))
        		{
        			if (element.Exists(0))
        			{
        				flag = true;
        				break;
        			}

        			flag = false;
//        			Delay.Milliseconds(200);
        		}
        		
        		if ((System.DateTime.Now.Minute - checkStartTime) >= 2)
        		{
        			Ranorex.Validate.Fail("Some error occurred while processing, please make suer there is no unwanted element on screen.");        			
        		}
        	}
        	while (flag);
        }  
        
        /// <summary>
        /// This method converts any given number(Interger) to phone number format. The condition is that the given integer should have 10 digits.
        /// </summary>
        [UserCodeMethod]
        public static string convertNumberToPhoneNumber(string number)
        {       	
        	if (number.Length != 10)
        	{
        		Report.Error("Seems like the 'Phone Number' field is populated with invalid data, please verify and re-run the test.");
        		return "--ERROR--";
        	}
        	
        	return ("(" + number.Substring(0, 3) + ") " + number.Substring(3, 3) + "-" + number.Substring(6, 4));
        }
        
        /// <summary>
        /// This method compares the given date to today.
        /// </summary>
        [UserCodeMethod]
        public static string compareDateWithCurrentDate(string displayedDate)
        {        	
        	System.DateTime formattedDate = new System.DateTime();
        	if (System.DateTime.TryParse(displayedDate, System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out formattedDate))
        	{
        		if (formattedDate.ToShortDateString() == System.DateTime.Now.ToShortDateString())
        		{
        			Report.Success("Dates matched!");
        		}
        		else
        		{
        			Report.Warn("The displayed date : " + formattedDate.ToShortDateString().ToString());
        			Report.Warn("Today's date : " + System.DateTime.Now.ToShortDateString().ToString());
        			Report.Error("These dates did not match, please confirm the created item.");
        		}
        	}
        	return "";
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static string compareTimeWithCurrentTime(string comparingTime, string bufferTime)
        {        	
        	System.DateTime formattedTime = new System.DateTime();
        	System.DateTime currentTime = System.DateTime.Now;
        	        	        
        	if (System.DateTime.TryParse(comparingTime, out formattedTime))
        	{				        	
        		TimeSpan bufferTime_TS = string.IsNullOrEmpty(bufferTime) ? TimeSpan.FromMinutes(0) : TimeSpan.FromMinutes(double.Parse(bufferTime));
        		TimeSpan difference = currentTime > formattedTime ? currentTime - formattedTime : formattedTime - currentTime;        		
        		Report.Warn(bufferTime_TS.ToString());
        		if (difference.Hours <= bufferTime_TS.Hours && difference.Minutes <= bufferTime_TS.Minutes)
        		{
        			Report.Success("The difference between the timestamps is : " + difference.ToString("hh") + " hour(s) " + difference.ToString("mm") + " minute(s), " +
        			               "which falls under buffer time duration of : " + bufferTime_TS.ToString("hh") + " hour(s) " + bufferTime_TS.ToString("mm") + " minute(s)");
        		}
        		else
        		{        			       			
        			Report.Warn("The provided timestamp : " + formattedTime.ToString("HH:mm"));
        			Report.Warn("Current Time : " + currentTime.ToString("HH:mm"));
        			Ranorex.Validate.Fail("The difference between the timestamps is : " + difference.ToString("hh") + " hour(s) " + difference.ToString("mm") + " minutes");
        		}
        	}
        	
        	return "";
        }
        
        /// <summary>
        /// This method generates a random Password, that would satisfy common creterias. 
        /// The method calls an API from third-party site to get such password.
        /// </summary>
        [UserCodeMethod]
        public static string generateRandomPassword()
        {
        	string url = "https://www.passwordrandom.com/query?command=password&count=1&length=8";
            
            using (var wb = new WebClient())
            {
                var response = wb.DownloadString(url);
                Report.Success("Your new password is : " + response);
                
                return response;
            }
        }
        
        /// <summary>
        /// This method finds a file that is downloaded after the method is called (5 seconds buffer time) and validates it's content for the data passed from the recording to confirm the file content.
        /// It can check for PDFs, Excels, and CSVs (XLS format).
        /// </summary>
        [UserCodeMethod]
        public static void confirmFileDownloaded(string extension, 
                                                 string expectedContent1 = "", 
                                                 string expectedContent2 = "", 
                                                 string expectedContent3 = "", 
                                                 string expectedContent4 = "")
        {       
        	var currentDateTime = System.DateTime.Now.Subtract((System.TimeSpan.FromSeconds(5)));
        	
        	string downloadPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
        	string filePath = null;

        	while (string.IsNullOrEmpty(filePath))
        	{
        		filePath = Directory.GetFiles(downloadPath, "*." + extension.ToLower())
					        		.OrderByDescending(f => File.GetLastWriteTime(f))
					        		.Where(f => File.GetLastWriteTime(f) > currentDateTime)
        							.FirstOrDefault();
        		
        		if ((System.DateTime.Now - currentDateTime) > System.TimeSpan.FromMinutes(3))
        		{
        			Ranorex.Validate.Fail("Either file is not downloaded in the defined time limit, or the file is not downloaded at all. Please check the download status.");
        			break;
        		}
        	}
        	
			if (!string.IsNullOrEmpty(filePath))
			{
				if (extension.ToLower() == "pdf")
        		{
					string fileContent = string.Empty;
	        		
	        		using (var pdfReader = new PdfReader(filePath))
	        		{
	        			fileContent = PdfTextExtractor.GetTextFromPage(pdfReader, 1);
	        		}	        		
					
	        		if (fileContent.Contains(expectedContent1.Trim()) &&
	        		    fileContent.Contains(expectedContent2.Trim()) && 
	        		    fileContent.Contains(expectedContent3.Trim()) && 
	        		    fileContent.Contains(expectedContent4.Trim()))
	        		{
	        			Report.Success("Correct file downloaded");
	        		}
	        		else
	        		{	        			
	        			Report.Error("Seems to be wrong file");
	        			Report.Warn("Here is the file Content to validate : ");
	        			Report.Warn(fileContent);
	        			Report.Warn("And here are the expected terms that were searched in the file : ");
	        			Report.Warn("Expected terms : " + expectedContent1 + ", " + expectedContent2 + ", " + expectedContent3 + ", " + expectedContent4);
	        			
	        			Ranorex.Validate.Fail("Please confirm the file and the content.");
	        		}        		
        		}
        	
	        	else if (extension.ToLower() == "xlsx")
	        	{
	        		FileInfo fileInfo = new FileInfo(filePath);
	        		
	        		using (ExcelPackage package = new ExcelPackage(fileInfo))
	        		{
	        			var workSheet = package.Workbook.Worksheets[0];
	        			string fileContentSample = "";        			
	        			
	        			for (var i=1; i<=(Math.Min(2, (workSheet.Dimension.End.Row))); i++)
	        			{
	        				for (var j=1; j<=workSheet.Dimension.End.Column; j++)
	        				{
	        					fileContentSample += (workSheet.Cells[i, j].Text + " ");
	        				}
	        			}	
	        			        			        		
	        			if (fileContentSample.Contains(expectedContent1.Trim()) && 
	        		    fileContentSample.Contains(expectedContent2.Trim()) && 
	        		    fileContentSample.Contains(expectedContent3.Trim()) && 
	        		    fileContentSample.Contains(expectedContent4.Trim()))
		        		{
		        			Report.Success("Correct file downloaded");
		        		}
		        		else
		        		{
		        			Report.Error("Seems to be wrong file");
		        			Report.Warn("Here is the file Content to validate : ");
		        			Report.Warn(fileContentSample);
		        			Report.Warn("And here are the expected terms that were searched in the file : ");
		        			Report.Warn("Expected terms : " + expectedContent1 + ", " + expectedContent2 + ", " + expectedContent3 + ", " + expectedContent4);
		        		}
	        		}
	        	}
	        	
	        	else if (extension.ToLower() == "csv")
	        	{
	        		var fileContent = File.ReadAllText(filePath);
	        		
	        		if (fileContent.Contains(expectedContent1.Trim()) && 
	        		    fileContent.Contains(expectedContent2.Trim()) && 
	        		    fileContent.Contains(expectedContent3.Trim()) && 
	        		    fileContent.Contains(expectedContent4.Trim()))
	        		{
	        			Report.Warn("Correct file downloaded");
	        		}
	        		else
	        		{
	        			Report.Error("Seems to be wrong file");
	        			Report.Warn("Here is the file Content to validate : ");
	        			Report.Warn(fileContent);
	        			Report.Warn("And here are the expected terms that were searched in the file : ");
	        			Report.Warn("Expected terms : " + expectedContent1 + ", " + expectedContent2 + ", " + expectedContent3 + ", " + expectedContent4);
	        		}
	        	}
			}
        	else
        	{
        		Ranorex.Validate.Fail("Seems like file is not downloaded yet.");
        		Report.Warn("Execution started at : " + currentDateTime.ToString());        		
        	}        	
        }
        
        /// <summary>
        /// This method closes all the PDF files opened in browser as a tab.
        /// That's it.
        /// </summary>
        [UserCodeMethod]
        public static void closeFileTab_IfOpen()
        {
        	string _browserName = globalParameters.browserName;
        	var tabs = Host.Local.Find<Ranorex.WebDocument>("/dom[@browsername='" + _browserName + "']");
        	
        	foreach (var tab in tabs)
        	{        		
        		if (tab.PageUrl.Contains(".pdf"))
        		{
        			tab.Close();
        		}
        	}
        }
        
    }
    
}
