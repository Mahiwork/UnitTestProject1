using OpenQA.Selenium;
using System;

namespace UnitTestProject1.POM
{
    public class LocatorClass
    {

        //Constructor for class
        public LocatorClass(IWebDriver webDriver)
        {
            Driver = webDriver;
        }



        private IWebDriver Driver { get; }

        //Web Elements 
        public IWebElement Classes => Driver.FindElement(By.ClassName("no-ext"));
        
        public IWebElement SearchButton => Driver.FindElement(By.ClassName("ph-a11y-search-box"));

        public IWebElement SearchClick => Driver.FindElement(By.Id("ph-search-backdrop"));

        public IWebElement SoftwareManager => Driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/div/div[2]/section[3]/div/div/div/div[2]/div[2]/ul/li[1]/div[1]/span/a/div/span"));

        public IWebElement ApplyNow => Driver.FindElement(By.ClassName("primary-button"));

        //String variables for assertions 
        public string JobTitle => Driver.FindElement(By.ClassName("job-title")).Text;
        
        public String JobId => Driver.FindElement(By.ClassName("jobId")).Text;
        public string JobLocation => Driver.FindElement(By.ClassName("job-location")).Text;

        public string JobCategory=> Driver.FindElement(By.ClassName("job-category")).Text;

        public string JobType => Driver.FindElement(By.ClassName("type")).Text;
        public string AlreadyEmployee => Driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div[2]/section/div/div/div/div[2]/a/ppc-content")).Text;








    }

}
