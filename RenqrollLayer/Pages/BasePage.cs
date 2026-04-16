using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ReqnrollLayer.Pages
{
    public abstract class BasePage
    {
        private readonly By acceptAllCookieBy = By.Id("onetrust-accept-btn-handler");
        protected IWebDriver Driver { get; }

        protected BasePage(IWebDriver driver)
        {
            ArgumentNullException.ThrowIfNull(driver);
            this.Driver = driver;
        }

        protected string GetTitle()
        {
            return this.Driver.Title;
        }

        protected void NavigateTo(string url)
        {
            this.Driver.Navigate().GoToUrl(url);
        }

        protected string WaitUntilTitleContains(string pageTitle)
        {
            var wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(10));
            try
            {
                return wait.Until(drv =>
                {
                    return this.GetTitle().Contains(pageTitle) ? this.GetTitle() : null;
                });
            }
            catch (WebDriverTimeoutException)
            {
                throw;
            }
        }

        protected void AcceptAllCookie()
        {
            var wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            try
            {
                wait.Until(drv =>
                {
                    var element = drv.FindElement(this.acceptAllCookieBy);
                    return (element.Displayed && element.Enabled) ? element : null;
                }).Click();
            }
            catch (WebDriverTimeoutException)
            {
                throw;
            }

            wait.Until(drv => !drv.FindElement(this.acceptAllCookieBy).Displayed);
        }

        protected IWebElement FindChildByParent(By parentBy, By childBy)
        {
            var wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));

            try
            {
                return wait.Until(drv =>
                {
                    var parent = drv.FindElement(parentBy);
                    var element = parent.FindElement(childBy);
                    return element.Displayed ? element : null;
                });
            }
            catch (WebDriverTimeoutException)
            {
                throw;
            }
        }
    }
}
