using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTest.pages
{
    class BasePage
    {
        protected IWebDriver driver;

        public BasePage (IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
