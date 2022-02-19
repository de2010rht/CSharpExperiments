using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace ChromeDriverTest
{
    [TestClass]
    public class ChromeLaunchTest
    {
        [TestMethod]
        public void TestBrowser()
        {
            var chromeDriverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            IWebDriver webDriver = new ChromeDriver(chromeDriverPath);
            webDriver.Navigate().GoToUrl("https://www.irfca.org");
            webDriver.Quit();
        }
    }
}
