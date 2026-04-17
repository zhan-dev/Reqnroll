using NUnit.Framework;
using Reqnroll;
using ReqnrollLayer.Pages;

namespace ReqnrollLayer.Steps
{
    [Binding]
    internal class MainPageSteps
    {
        private readonly DriverContext context;
        private readonly MainPage mainPage;

        public MainPageSteps(DriverContext context)
        {
            this.context = context;
            this.mainPage = new MainPage(this.context.Driver!);
        }

        [When(@"I click on the Search icon element")]
        public void WhenIClickOnTheSearchIconElement()
        {
            this.mainPage.ClickSearchIcon();
        }

        [When(@"I enter the text '(.*)' into the search input")]
        public void WhenIEnterTheTextIntoTheSearchInput(string searchText)
        {
            this.mainPage.InputDataIntoSearchInput(searchText);
        }

        [When(@"I click on the Find button")]
        public void WhenIClickOnTheFindButton()
        {
            this.mainPage.ClickFindButton();
        }

        [Then(@"The list of search results is displayed on the page")]
        public void ThenTheListOfSearchResultsIsDisplayedOnThePage()
        {
            bool isDisplayed = this.mainPage.AreSearchResultsDisplayed();
            Assert.IsTrue(isDisplayed);
        }
    }
}
