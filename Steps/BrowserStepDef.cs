using OpenQA.Selenium;
using SpecFlowProject2Selenium.Drivers;
using System;
using TechTalk.SpecFlow;

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
            //ScenarioContext.Current.Pending();
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            driver.Url = "https://lambdatest.github.io/sample-todo-app/";
        }

        [Given(@"I select the first item")]
        public void GivenISelectTheFirstItem()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I select the second item")]
        public void GivenISelectTheSecondItem()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I entr the new value in the textbox")]
        public void GivenIEntrTheNewValueInTheTextbox()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click the Submit button")]
        public void WhenIClickTheSubmitButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I verify whether the item is added to the list")]
        public void ThenIVerifyWhetherTheItemIsAddedToTheList()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
