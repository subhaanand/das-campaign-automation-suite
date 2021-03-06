﻿using System;
using SFA.DAS.Campaign.AutomationSuite.Project.Framework.Helpers;
using SFA.DAS.Campaign.AutomationSuite.Project.Tests.TestSupport;
using OpenQA.Selenium;

namespace SFA.DAS.Campaign.AutomationSuite.Project.Tests.Pages
{
    public class WelcomeToGovUkPage : BasePage
    {
        private static String PAGE_TITLE = "Welcome to GOV.UK";

        public WelcomeToGovUkPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        private By searchField = By.Name("q");
        private By searchButton = By.CssSelector(".search-submit");

        internal SearchResultsPage EnterSearchTextAndSubmit(String searchText)
        {
            FormCompletionHelper.EnterText(searchField, searchText);
            FormCompletionHelper.ClickElement(searchButton);
            return new SearchResultsPage(webDriver);
        }
    }
}