using NUnit.Framework;
using Reqnroll;
using ReqnrollLayer.Pages;

namespace ReqnrollLayer.Steps
{
    [Binding]
    internal class CommonSteps
    {
        private readonly DriverContext context;
        private readonly MainPage mainPage;

        public CommonSteps(DriverContext context)
        {
            this.context = context;
            this.mainPage = new MainPage(this.context.Driver!);
        }

        [Given(@"I navigate to the EPAM website")]
        public void GivenINavigateToTheEPAMWebsite()
        {
            this.mainPage.LoadMainPage();
        }

        [Then(@"The page title is '(.*)'")]
        public void ThenThePageTitleContains(string expectedTitle)
        {
            Assert.IsTrue(this.context.Driver!.Title.Contains(expectedTitle));
        }
    }
}