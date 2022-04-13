using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject2Selenium.Drivers
{
    public class SeleniumDriver
    {
        private IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;

        public SeleniumDriver (ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        public IWebDriver Setup(String browserName)
        {
            dynamic capability = GetBrowserOptions(browserName);


            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capability.ToCapabilities());

            // IWebDriver driver = new RemoteWebDriver(new Uri("http://www.example.com"), firefoxOptions);

            //driver = new ChromeDriver();

            _scenarioContext.Set(driver, "WebDriver");
            driver.Manage().Window.Maximize();
            

            return driver;

        }

        private dynamic GetBrowserOptions(string browserName)
        {
            if (browserName.ToLower() == "chrome")
                return new ChromeOptions();
            if (browserName.ToLower() == "firefox")
                return new FirefoxOptions();
            if (browserName.ToLower() == "MicrosoftEdge")
                return new EdgeOptions();
            if (browserName.ToLower() == "Safari")
                return new SafariOptions();

            //return chrome if no browsername is provided
            return new ChromeOptions();
        }


        public IWebDriver Setup()
        {
            //Hardcoded Firefoxoption
            var firefoxOptions = new FirefoxOptions();
            string uri = "http://localhost:4444/wd/hub";
            //driver = new RemoteWebDriver(new Uri(uri), firefoxOptions.ToCapabilities());
            driver = new FirefoxDriver();

            //Set the driver
            _scenarioContext.Set(driver, "WebDriver");
            driver.Manage().Window.Maximize();
            return driver;

        }

    }
}
