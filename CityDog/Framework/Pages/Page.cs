using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public abstract class Page
    {
        private const string url = @"https://citydog.by/";
        private WebDriverWait _wait;


        public IWebDriver Driver
        {
            get
            {
                return SeleniumDriver.Driver;
            }
        }


        public MainPage OpenMainPage()
        {
            Driver.Navigate().GoToUrl(url);

            return new MainPage();
        }


        public IWebElement WaitUntilElementIsVisible(By by)
        {
            _wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            return _wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}
