using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ConsoleApp3
{
    internal class BrowserFactory
    {
        IWebDriver webDriver;
        public void Init_Browser(String browserName)
        {
            switch (browserName.ToLower())
            {
                case "chrome":
                    webDriver = new ChromeDriver();
                    webDriver.Manage().Window.Maximize();
                    break;
            }
        }
        public string Title
        {
            get { return webDriver.Title; }
        }
        public void OpenUrl(string url)
        {
            webDriver.Url = url;
        }
        public IWebDriver getDriver
        {
            get { return webDriver; }
        }
        public void Close()
        {
            webDriver.Quit();
        }
    }
}
