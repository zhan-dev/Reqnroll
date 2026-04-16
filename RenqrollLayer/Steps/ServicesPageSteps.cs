using NUnit.Framework;
using Reqnroll;
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

        [When("I hover cursor on the Services navigation link")]
        public void IHoverCursorOnTheServicesNavigationLink()
        {
            this.servicesPage.HoverToServiceLink();
        }

        [When("I click to '(.*)' from Services dropdown menu")]
        public void IClickToCategoryFromServicesDropdownMenu(string category)
        {
            switch (category)
            {
                case "Responsible AI":
                this.servicesPage.ClickResponsibleAILink();
                    break;

                case "Generative AI":
                this.servicesPage.ClickGenerativeAILink();
                    break;

                default:
                    throw new ArgumentException($"Unknown: {category}");
            }
        }

        [Then("The section 'Our Related Expertise' is displayed on the page")]
        public void TheSectionOurRelatedExpertiseIsDisplayedOnThePage()
        {
            bool isDisplayed = this.servicesPage.OurRelatedExpertiseIsDisplayed();
            Assert.IsTrue(isDisplayed);
        }
    }
}