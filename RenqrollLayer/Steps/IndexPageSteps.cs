//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using NUnit.Framework;
//using Reqnroll;
//using ReqnrollLayer.Pages;

//namespace ReqnrollLayer.Steps
//{
//    [Binding]
//    internal class IndexPageSteps
//    {
//        private readonly IWebDriver driver;
//        private readonly IndexPage indexPage;

//        public IndexPageSteps()
//        {
//            driver = new ChromeDriver();
//            indexPage = new IndexPage(driver);
//        }

//        [Given(@"I navigate to the EPAM website")]
//        public void GivenINavigateToEPAMWebsite()
//        {
//            indexPage.Open();
//        }

//        [When(@"I click on the Search icon element")]
//        public void WhenIClickOnTheSearchIconElement()
//        {
//            indexPage.ClickSearchIcon();
//        }

//        [When(@"I enter the text '(.*)' into the search input")]
//        public void WhenIEnterTheTextIntoTheSearchInput(string searchText)
//        {
//            indexPage.EnterSearchText(searchText);
//        }

//        [When(@"I click on the Find button")]
//        public void WhenIClickOnTheFindButton()
//        {
//            indexPage.ClickFindButton();
//        }

//        [Then(@"The list of search results is displayed on the page")]
//        public void ThenTheListOfSearchResultsIsDisplayedOnThePage()
//        {
//            bool isDisplayed = indexPage.AreSearchResultsDisplayed();
//            Assert.IsTrue(isDisplayed);
//        }

//        [AfterScenario]
//        public void AfterScenario()
//        {
//            driver.Quit();
//        }
//    }
//}