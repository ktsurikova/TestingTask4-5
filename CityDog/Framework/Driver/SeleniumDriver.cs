using Framework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Logging;

namespace Framework
{
    public class SeleniumDriver
    {
        private static IWebDriver _instance;
        private static readonly ILogger logger = new NLogger();

        public static IWebDriver Driver
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ChromeDriver();

                    var firingDriver = new EventFiringWebDriver(_instance);

                    firingDriver.ElementClicked += (sender, args) =>
                    {
                        logger.Debug(DateTime.Now, "element clicked");
                    };

                    firingDriver.ElementClicking += (sender, args) =>
                    {
                        logger.Debug(DateTime.Now, "element clicking");
                    };

                    firingDriver.FindElementCompleted += (sender, args) =>
                    {
                        logger.Debug(DateTime.Now, "element found");
                    };

                    firingDriver.ExceptionThrown += (sender, args) =>
                    {
                        Exception e = args.ThrownException;
                        logger.Error(DateTime.Now, e?.Message, e?.StackTrace);
                    };

                    _instance = firingDriver;
                }

                return _instance;
            }
        }
    }
}
