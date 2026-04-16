using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace ReqnrollLayer.Pages
{
    public class IndexPage
    {
        private static string Url { get; } = "https://www.epam.com";
        private readonly IWebDriver driver;

        public IndexPage(IWebDriver driver) => this.driver = driver ?? throw new ArgumentException(nameof(driver));

        public IndexPage Open()
        {
            driver.Url = Url;
            return this;
        }

        public void ClickSearchIcon()
        {
            var searchIcon = driver.FindElement(By.ClassName("dark-iconheader-search__search-icon"));
            searchIcon.Click();
        }

        public void EnterSearchText(string phrase)
        {
            var searchPanel = WaitForSearchPanel();
            var searchInput = searchPanel.FindElement(By.Name("q"));
            var clickAndSendKeysActions = new Actions(driver);

            clickAndSendKeysActions.Click(searchInput)
                .Pause(TimeSpan.FromSeconds(1))
                .SendKeys(phrase)
                .Perform();
        }

        public void ClickFindButton()
        {
            var searchPanel = WaitForSearchPanel();
            var findButton = searchPanel.FindElement(By.XPath(".//*[@class='search-results__input-holder']/following-sibling::button"));
            findButton.Click();
        }

        public bool AreSearchResultsDisplayed()
        {
            var searchResultsList = driver.FindElement(By.ClassName("search-results__items"));
            return searchResultsList.Displayed;
        }

        private IWebElement WaitForSearchPanel()
        {
            var searchPanelWait = new WebDriverWait(driver, TimeSpan.FromSeconds(2))
            {
                PollingInterval = TimeSpan.FromSeconds(0.25),
                Message = "Search panel has not been found"
            };
            return searchPanelWait.Until(driver => driver.FindElement(By.ClassName("header-search__panel")));
        }
    }
}