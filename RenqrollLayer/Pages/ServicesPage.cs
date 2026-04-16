using OpenQA.Selenium;

namespace ReqnrollLayer.Pages
{
    internal class ServicesPage : BasePage
    {
        private readonly string servicesPageTitle = "Services | EPAM";

        public ServicesPage(IWebDriver driver) : base(driver) { }

        public void LoadServicePage()
        {
            base.WaitUntilTitleContains(this.servicesPageTitle);
        }
    }
}
