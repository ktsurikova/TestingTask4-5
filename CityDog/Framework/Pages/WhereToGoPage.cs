using Framework.Pages.Constants;
using Framework.Pages.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class WhereToGoPage : Page, IWhereToGo
    {
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
                    throw new NotImplementedException();
            }

            string xpath = String.Format(@"//ul[contains(@class, 'afishaMain-categories')]/li/a[text()='{0}']", eventText);

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
