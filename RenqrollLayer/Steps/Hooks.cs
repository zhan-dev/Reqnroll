using Reqnroll;
using ReqnrollLayer.Enum;
using ReqnrollLayer.WebDriver;

namespace ReqnrollLayer.Steps
{
    [Binding]
    internal class Hooks
    {
        private readonly DriverContext context;

        public Hooks(DriverContext context)
        {
            this.context = context;
        }

        [BeforeScenario]
        public void Setup()
        {
            var factory = new ChromeDriverFactory();
            this.context.Driver = factory.CreateDriver(WebBrowserMode.UXUI);
        }

        [AfterScenario]
        public void TearDown()
        {
            this.context.Driver?.Quit();
            this.context.Driver = null;
        }
    }
}
