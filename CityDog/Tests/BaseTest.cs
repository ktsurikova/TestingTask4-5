using Framework;
using Framework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [SetUpFixture]
    public class BaseTest
    {
        [OneTimeTearDown]
        public void TearDownMethods()
        {
            SeleniumDriver.Driver.Close();
        }
    }
}
