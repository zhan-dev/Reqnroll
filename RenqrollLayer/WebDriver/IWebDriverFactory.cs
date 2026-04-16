using OpenQA.Selenium;
using ReqnrollLayer.Enum;

namespace ReqnrollLayer.WebDriver
{
    public interface IWebDriverFactory
    {
        public IWebDriver CreateDriver(WebBrowserMode mode);
    }
}