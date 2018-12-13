using System;
using SFA.DAS.Campaign.AutomationSuite.Project.Framework.Helpers;
using SFA.DAS.Campaign.AutomationSuite.Project.Tests.TestSupport;
using OpenQA.Selenium;

namespace SFA.DAS.Campaign.AutomationSuite.Project.Tests.Pages
{
    class DepartmentForEducationHomePage : BasePage
    {
        private static String PAGE_TITLE = "Department\r\nfor Education";

        public DepartmentForEducationHomePage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }
    }
}