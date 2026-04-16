//using NUnit.Framework;
//using OpenQA.Selenium;
//using Reqnroll;
//using ReqnrollLayer.Enum;
//using ReqnrollLayer.Pages;
//using ReqnrollLayer.WebDriver;

//namespace ReqnrollLayer.Steps
//{
//    [Binding]
//    internal class MainPageSteps
//    {
//        private readonly IWebDriver driver;
//        private readonly MainPage mainPage;

//        public MainPageSteps()
//        {
//            ChromeDriverFactory driverFactory = new ChromeDriverFactory();
//            this.driver =  driverFactory.CreateDriver(WebBrowserMode.UXUI);
//            this.mainPage = new MainPage(this.driver);
//        }

//        [Given(@"I navigate to the EPAM website")]
//        public void GivenINavigateToEPAMWebsite()
//        {
//            //indexPage.Open();
//        }

//        [When(@"I click on the Search icon element")]
//        public void WhenIClickOnTheSearchIconElement()
//        {
//            //indexPage.ClickSearchIcon();
//        }

//        [When(@"I enter the text '(.*)' into the search input")]
//        public void WhenIEnterTheTextIntoTheSearchInput(string searchText)
//        {
//            //indexPage.EnterSearchText(searchText);
//        }

//        [When(@"I click on the Find button")]
//        public void WhenIClickOnTheFindButton()
//        {
//            //indexPage.ClickFindButton();
//        }

//        [Then(@"The list of search results is displayed on the page")]
//        public void ThenTheListOfSearchResultsIsDisplayedOnThePage()
//        {
//            //bool isDisplayed = indexPage.AreSearchResultsDisplayed();
//            //Assert.IsTrue(isDisplayed);
//        }

//        [AfterScenario]
//        public void AfterScenario()
//        {
//            this.driver.Quit();
//        }
//    }
//}
