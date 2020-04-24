using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTest.support
{
    class Web
    {
        public static IWebDriver criarChrome()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://demo.automationtesting.in/Register.html";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver;
        }
    }
}
