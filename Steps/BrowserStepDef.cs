using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject2Selenium.Drivers;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject2Selenium.Features
{
    [Binding]
    public class BrowserStepDef
    {
        IWebDriver driver;

        private readonly ScenarioContext _scenarioContext;

        public BrowserStepDef(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"I navigate to LambdaTest App on the following environment")]
        public void GivenINavigateToLambdaTestAppOnTheFollowingEnvironment(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            //driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup((string)data.Browser);

            driver.Url = "https://lambdatest.github.io/sample-todo-app/";
        }

        [Given(@"I select the first item")]
        public void GivenISelectTheFirstItem()
        {
            driver.FindElement(By.Name("li1")).Click();
        }

        [Given(@"I select the second item")]
        public void GivenISelectTheSecondItem()
        {
            driver.FindElement(By.Name("li2")).Click();

        }

        [Given(@"I entr the new value in the textbox")]
        public void GivenIEntrTheNewValueInTheTextbox()
        {
            driver.FindElement(By.Id("sampletodotext")).SendKeys("sampletodotext");
        }

        [When(@"I click the Submit button")]
        public void WhenIClickTheSubmitButton()
        {
            driver.FindElement(By.Id("addbutton")).Click();
        }

        [Then(@"I verify whether the item is added to the list")]
        public void ThenIVerifyWhetherTheItemIsAddedToTheList()
        {
            Assert.That(driver.FindElement(By.XPath("/html/body/div/div/div/ul/li[6]/span")).Text, Is.EqualTo("sampletodotext"));
        }
    }
}
