using Framework.Pages.Constants;
using Framework.Pages.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Logging;

namespace Framework.Pages
{
    public class WhereToGoPage : Page, IWhereToGo
    {
        private readonly ILogger _logger = new NLogger();

        [FindsBy(How = How.XPath, Using = PageLocators.AllEventsXpath)]
        public IList<IWebElement> AllEvents;

        public WhereToGoPage()
        {
            PageFactory.InitElements(Driver, this);
        }


        public int CountOfAllEvents
        {
            get
            {
                return AllEvents.Count;
            }
        }

        public WhereToGoPage SelectEventType(Events eventName)
        {
            _logger.Debug(DateTime.Now, $"href {eventName} clicked");
            GetHref(eventName).Click();

            return new WhereToGoPage();
        }


        #region Private Methods

        private IWebElement GetHref(Events eventName)
        {
            string eventText;

            switch (eventName)
            {
                case Events.Today:
                    eventText = "Сегодня";
                    break;

                case Events.Tomorrow:
                    eventText = "Завтра";
                    break;

                default:
                    _logger.Error(DateTime.Now, $"not supported {eventName}");
                    throw new NotSupportedException();
            }

            string xpath = $@"//ul[contains(@class, 'afishaMain-categories')]/li/a[text()='{eventText}']";

            return Driver.FindElement(By.XPath(xpath));
        }

        #endregion
    }


    public enum Events
    {
        AllActual,
        DoggyChoice,
        Today,
        Tomorrow,
        Weekend,
        Past
    }
}
