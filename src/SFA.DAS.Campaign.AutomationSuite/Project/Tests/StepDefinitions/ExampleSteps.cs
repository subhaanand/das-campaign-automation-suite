using System;
using SFA.DAS.Campaign.AutomationSuite.Project.Framework.Helpers;
using SFA.DAS.Campaign.AutomationSuite.Project.Tests.Pages;
using SFA.DAS.Campaign.AutomationSuite.Project.Tests.TestSupport;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SFA.DAS.Campaign.AutomationSuite.Project.Tests.StepDefinitions
{
    [Binding]
    public class ExampleSteps : BaseTest
    {
        [Given(@"I navigate to GOV.UK home page")]
        public void NavigateToGovUkHomePage()
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl();
        }

        [When(@"I search for (.*)")]
        public void SearchForText(String searchText)
        {
            WelcomeToGovUkPage welcomeToGovUkPage = new WelcomeToGovUkPage(webDriver);
            welcomeToGovUkPage.EnterSearchTextAndSubmit(searchText);
        }

        [When(@"I click on DFE link")]
        public void ClickOnDfeLink()
        {
            SearchResultsPage searchResultsPage = new SearchResultsPage(webDriver);
            searchResultsPage.ClickDfeLink();
        }

        [Then(@"I should be on DFE home page")]
        public void ShouldBeOnDfeHomePage()
        {
            PageInteractionHelper.VerifyPageHeading(By.TagName("h1"), "Department\r\nfor Education");
        }
    }
}