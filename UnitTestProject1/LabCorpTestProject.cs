using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

using UnitTestProject1.POM;

namespace UnitTestProject1
{

    [TestClass]
    public class LabCorpTestProject
    {


        /// <summary>
        /// Test Method Navigates to Lab Corp, searches specific job function, then confirms Job Title, Location, and ID using Chrome
        /// </summary>
        [TestMethod]
        public void ValidateJobTitleLocationID()

        {
            // Creates an Instance of web driver and navigates to Labcorp website
            IWebDriver webDriver = new ChromeDriver(@"C:\chromedriver_win32");
            webDriver.Navigate().GoToUrl("https://www.labcorp.com/");

            // Sets implicit wait so that the webdriver waits a duration of time to seek elements on a page
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

            LocatorClass Locator = new LocatorClass(webDriver);


            //Given user navigates to jobs, browses for Software Development Manager
            Locator.Classes.Click();
            Locator.SearchButton.SendKeys("Software Development Manager");
            Locator.SearchClick.Click();

            //When user selects Software Manager
            Locator.SoftwareManager.Click();


            //Then user will see job characteristics such as id, location, and title 
            Assert.AreEqual("Software Development Manager", Locator.JobTitle);
            Assert.AreEqual("Location\r\nSan Antonio, Texas, United States of America", Locator.JobLocation);
            Assert.AreEqual("Job Id : 2231421", Locator.JobId);
            Assert.AreEqual("Category\r\nInformation Technology", Locator.JobCategory);
            Assert.AreEqual("Job Type\r\nFull-Time", Locator.JobType);
            Assert.AreEqual("Labcorp Employee? Apply Here", Locator.AlreadyEmployee);

            //Information is displayed in console after text is stored in strings
            Console.Write(Locator.JobTitle);
            Console.Write(Locator.JobLocation);
            Console.Write(Locator.JobId);  
            Console.Write(Locator.JobCategory);
            Console.Write(Locator.JobType);
            Console.Write(Locator.AlreadyEmployee);      

            //User selects apply now
            Locator.ApplyNow.Click();



            webDriver.Close();
        
            

            
        }
    }
}
