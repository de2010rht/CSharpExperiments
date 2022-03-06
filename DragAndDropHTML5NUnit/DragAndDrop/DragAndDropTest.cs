using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace DragAndDrop
{
    [TestFixture]
    public class DragAndDropTest
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [Test]
        public void DragAndDropTestMethod()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");
            IWebElement source = wait.Until(d => d.FindElement(By.Id("column-a")));

            var jsFile = File.ReadAllText(@"D:\My Works\workspaceVS\DragAndDropHTML5NUnit\drag_and_drop_helper.js");
            IJavaScriptExecutor jsExecutor = driver as IJavaScriptExecutor;
            jsExecutor.ExecuteScript(jsFile + "$('#column-a').simulateDragDrop({dropTarget: '#column-b'});");

            Assert.AreEqual("A", driver.FindElement(By.XPath("//*[@id='column-b']/header")).Text);
        }

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
