using Framework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.WhereToGoPageTests
{
    [TestFixture, Category("WhereToGo")]
    public class WhereToGoTests
    {
        private WhereToGoPage _whereToGoPage;


        [SetUp]
        public void SetUpMethods()
        {
            var mainPage = new MainPage().OpenMainPage();
            _whereToGoPage = (WhereToGoPage)mainPage.OpenSection(Sections.WhereToGo);
        }


        [Test]
        public void EventsExistOnPage()
        {
            Assert.Greater(_whereToGoPage.CountOfAllEvents, 0, "There are no events in 'Where To Go' page");
        }


        [Test]
        public void TodayEventsExist()
        {
            _whereToGoPage.SelectEventType(Events.Today);

            Assert.Greater(_whereToGoPage.CountOfAllEvents, 0, "There are no events for today in 'Where To Go' page");
        }


        [Test]
        public void TomorrowEventsExist()
        {
            _whereToGoPage.SelectEventType(Events.Tomorrow);

            Assert.Greater(_whereToGoPage.CountOfAllEvents, 0, "There are no events for tomorrow in 'Where To Go' page");
        }
    }
}
