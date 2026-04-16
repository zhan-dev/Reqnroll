using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace ReqnrollLayer.Pages
{
    internal class ServicesPage : BasePage
    {
        private readonly string servicesPageTitle = "Services | EPAM";
        private readonly By servicesLinkBy = By.LinkText("Services");
        private readonly By responsibleAILinkBy = 
            By.XPath("//*[contains(@class, 'top-navigation__row')]//a[normalize-space(text()) = 'Responsible AI']");
        private readonly By generativeAILinkBy = 
            By.XPath("//*[contains(@class, 'top-navigation__row')]//a[normalize-space(text()) = 'Generative AI']");
        private readonly By ourRelatedExpertiseHeader = 
            By.XPath("//span[contains(text(), 'Our Related Expertise')]");
        private readonly By ourRelatedExpertiseButtons = By.CssSelector(".buttons-list > li");

        public ServicesPage(IWebDriver driver) : base(driver) { }

        public void LoadServicePage()
        {
            base.WaitUntilTitleContains(this.servicesPageTitle);
        }

        public void HoverToServiceLink()
        {
            var element = this.Driver.FindElement(this.servicesLinkBy);
            new Actions(this.Driver)
                .MoveToElement(element)
                .Perform();
        }

        public void ClickResponsibleAILink()
        {
            var button = this.Driver.FindElement(this.responsibleAILinkBy);

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(10));
            wait.Until(drv =>
            {
                var btn = drv.FindElement(this.responsibleAILinkBy);
                return (btn.Displayed && btn.Enabled) ? btn : null;
            });

            new Actions(this.Driver)
                .Click(button)
                .Perform();
        }

        public void ClickGenerativeAILink()
        {
            var button = this.Driver.FindElement(this.generativeAILinkBy);

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(10));
            wait.Until(drv =>
            {
                var btn = drv.FindElement(this.generativeAILinkBy);
                return (btn.Displayed && btn.Enabled) ? btn : null;
            });

            new Actions(this.Driver)
                .Click(button)
                .Perform();
        }

        public bool OurRelatedExpertiseIsDisplayed()
        {
            var header = this.Driver.FindElement(this.ourRelatedExpertiseHeader);
            var buttons = this.Driver.FindElements(this.ourRelatedExpertiseButtons);

            return header.Displayed && buttons.Count > 0;
        }
    }
}
