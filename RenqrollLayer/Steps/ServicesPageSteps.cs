using OpenQA.Selenium.BiDi.BrowsingContext;
using Reqnroll;
using Reqnroll.Assist;
using ReqnrollLayer.Pages;

namespace ReqnrollLayer.Steps
{
    [Binding]
    internal class ServicesPageSteps
    {
        private readonly DriverContext context;
        private readonly MainPage mainPage;
        private readonly ServicesPage servicesPage;

        public ServicesPageSteps(DriverContext context)
        {
            this.context = context;
            this.mainPage = new MainPage(this.context.Driver!);
            this.servicesPage = new ServicesPage(this.context.Driver!);
        }

        [When("I click on the Services navigation link")]
        public void WhenIClickOnTheServicesNavigationLink()
        {
            this.mainPage.GoToServices();
            this.servicesPage.LoadServicePage();
        }

        [When("I took away cursor from the Services navigation link")]
        public void WhenITookAwayCursorFromTheServicesNavigationLink()
        {

        }

        [When("I hover cursor on the Services navigation link")]
        public void IHoverCursorOnTheServicesBavigationLink()
        {

        }

        [When("I click to '(.*)' from Services dropdown menu")]
        public void IClickToCategoryFromServicesDropdownMenu(string category)
        {

        }

        [Then("The section 'Our Related Expertise' is displayed on the page")]
        public void TheSectionOurRelatedExpertiseIsDisplayedOnThePage()
        {

        }
    }
}