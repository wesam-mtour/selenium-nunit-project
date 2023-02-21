using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace ConsoleApp3
{
    class NUnit_Demo_1
    {
        BrowserFactory brow = new BrowserFactory();
        String test_url = "https://integration.vulcan.highcon.link/queue";
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            brow.Init_Browser("Chrome");
        }

        [Test]
        public void test_Browserops()
        {
            brow.OpenUrl(test_url);
            driver = brow.getDriver;
            System.Threading.Thread.Sleep(4000);
            IWebElement element = driver.FindElement(By.CssSelector("p#headerTitle"));
            Console.WriteLine(element.Text);
            // Test verification from the header title which should be equal to Job Queue
            Assert.AreEqual(element.Text, "Job Queue");
        }

        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }
}
