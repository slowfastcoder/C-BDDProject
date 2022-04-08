using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
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

        public IWebDriver Setup()
        {
            //Hardcoded Firefoxption
            var firefoxOptions = new FirefoxOptions();
            string uri = "http://localhost:4444/wd/hub";
            driver = new RemoteWebDriver(new Uri(uri), firefoxOptions.ToCapabilities());

            //Set the driver
            _scenarioContext.Set(driver, "WebDriver");
            driver.Manage().Window.Maximize();
            return driver;

        }

    }
}
