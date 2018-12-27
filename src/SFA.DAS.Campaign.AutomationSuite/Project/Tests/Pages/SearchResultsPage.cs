using System;
using SFA.DAS.Campaign.AutomationSuite.Project.Framework.Helpers;
using SFA.DAS.Campaign.AutomationSuite.Project.Tests.TestSupport;
using OpenQA.Selenium;

namespace SFA.DAS.Campaign.AutomationSuite.Project.Tests.Pages
{
    public class SearchResultsPage : BasePage
    {
        private static String PAGE_TITLE = "Search results for";

        public SearchResultsPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        private By dfeLink = By.LinkText("Department for Education");

        internal DepartmentForEducationHomePage ClickDfeLink()
        {
            FormCompletionHelper.ClickElement(dfeLink);
            return new DepartmentForEducationHomePage(webDriver);
        }
    }
}