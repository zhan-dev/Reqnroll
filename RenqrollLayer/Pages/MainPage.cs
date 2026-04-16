using OpenQA.Selenium;

namespace ReqnrollLayer.Pages
{
    public class MainPage : BasePage
    {
        private readonly string mainPageTitle = "EPAM | Software Engineering & Product Development Services";
        private readonly By topNavigationList = By.ClassName("top-navigation__row");
        private readonly By servicesLinkBy = By.LinkText("Services");
        public string Url { get;  } = "https://www.epam.com/";

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
    }
}
