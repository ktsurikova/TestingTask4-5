using Framework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class SeleniumDriver
    {
        private static IWebDriver _instance;


        public static IWebDriver Driver
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ChromeDriver();
                }

                return _instance;
            }
        }
    }
}
