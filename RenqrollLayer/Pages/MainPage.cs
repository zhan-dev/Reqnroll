using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace ReqnrollLayer.Pages
{
    public class MainPage : BasePage
    {
        private readonly string mainPageTitle = "EPAM | Software Engineering & Product Development Services";
        private readonly By topNavigationList = By.ClassName("top-navigation__row");
        private readonly By servicesLinkBy = By.LinkText("Services");
        private readonly By searchButtonBy = By.ClassName("header__icon");
        private readonly By searchInputBy = By.Id("new_form_search");
        private readonly By headerSearchPanelBy = By.ClassName("header-search__panel");
        private readonly By findButtonBy = By.CssSelector(".search-results__action-section > button");
        private readonly By searchResultsBlockBy = By.ClassName("search-results__items");
        public string Url { get; } = "https://www.epam.com/";

        public MainPage(IWebDriver driver) : base(driver) { }

        public void LoadMainPage()
        {
            base.NavigateTo(this.Url);
            base.WaitUntilTitleContains(this.mainPageTitle);
            base.AcceptAllCookie();
        }

        public void GoToServices()
        {
            base.FindChildByParent(this.topNavigationList, this.servicesLinkBy).Click();
        }

        public void ClickSearchIcon()
        {
            this.Driver.FindElement(this.searchButtonBy).Click();
        }

        public void InputDataIntoSearchInput(string searchText)
        {
            var waitInput = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(10));
            var activeInput = waitInput.Until(drv =>
            {
                var searchPanel = this.Driver.FindElement(this.headerSearchPanelBy);
                var element = searchPanel.FindElement(this.searchInputBy);

                return element.Displayed && element.Enabled ? element : null;
            });

            new Actions(this.Driver)
                .Click(activeInput)
                .Pause(TimeSpan.FromSeconds(1))
                .SendKeys(searchText)
                .Pause(TimeSpan.FromSeconds(1))
                .Perform();
        }

        public void ClickFindButton()
        {
            base.FindChildByParent(this.headerSearchPanelBy, this.findButtonBy).Click();
        }

        public bool AreSearchResultsDisplayed()
        {
            var searchResultsList = this.Driver.FindElement(searchResultsBlockBy);
            return searchResultsList.Displayed;
        }
    }
}
