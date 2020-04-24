using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTest.pages
{
    class PaginaRegistro : BasePage
    {
        public object Assert { get; internal set; }

        public PaginaRegistro(IWebDriver driver) : base(driver)
        {
        }

        public PaginaRegistro digitarPrimeiroNome (String primeiroNome)
        {
            driver.FindElement(By.XPath("//input[@type='text'][@placeholder='First Name']")).SendKeys(primeiroNome);
            return this;
        }

        public PaginaRegistro digitarUltimoNome(String ultimoNome)
        {
            driver.FindElement(By.XPath("//input[@type='text'][@placeholder='Last Name']")).SendKeys(ultimoNome);
            return this;
        }
        public PaginaRegistro digitarEndereco(String endereco)
        {
            driver.FindElement(By.XPath("//*[@ng-model='Adress']")).SendKeys(endereco);
            return this;
        }
        public PaginaRegistro digitarEmail(String email)
        {
            driver.FindElement(By.XPath("//*[@type='email']")).SendKeys(email);
            return this;
        }
        public PaginaRegistro digitarNumeroTelefone(String numeroTelefone)
        {
            driver.FindElement(By.XPath("//*[@type='tel']")).SendKeys(numeroTelefone);
            return this;
        }
        public PaginaRegistro escolherGenero()
        {
            driver.FindElement(By.XPath("//*[@value='Male']")).Click();
            return this;
        }
        public PaginaRegistro escolherHobbies()
        {
            driver.FindElement(By.XPath("//input[@type='checkbox'][@id='checkbox1']")).Click();
            driver.FindElement(By.XPath("//input[@type='checkbox'][@id='checkbox2']")).Click();
            driver.FindElement(By.XPath("//input[@type='checkbox'][@id='checkbox3']")).Click();
            return this;
        }
        public PaginaRegistro escolherIdioma()
        {
            driver.FindElement(By.XPath("//div[@id='msdd']")).Click();
            driver.FindElement(By.XPath("//a[text()='Portuguese']")).Click();
            driver.FindElement(By.XPath("/html[1]/body[1]/section[1]/div[1]/div[1]")).Click();
            return this;
        }
        public PaginaRegistro escolherSkills()
        {
            driver.FindElement(By.XPath("//select[@id='Skills']")).Click();
            driver.FindElement(By.XPath("//*[@value='Java']")).Click();
            driver.FindElement(By.XPath("/html[1]/body[1]/section[1]/div[1]/div[1]")).Click();
            return this;
        }
        public PaginaRegistro escolherPais()
        {
            IWebElement paises = driver.FindElement(By.XPath("//select[@id='countries']"));
            SelectElement paisDropbox = new SelectElement(paises);
            paisDropbox.SelectByValue("India");
            return this;
        }
        public PaginaRegistro preenchendoPaisSelecionado()
        {
            driver.FindElement(By.XPath("//*[@role='combobox']")).Click();
            driver.FindElement(By.XPath("//*[@type='search']")).SendKeys("India" + Keys.Enter);
            return this;
        }
        public PaginaRegistro escolherNascimento()
        {
            IWebElement ano = driver.FindElement(By.XPath("//*[@id='yearbox']"));
            SelectElement anoDropbox = new SelectElement(ano);
            anoDropbox.SelectByValue("1996");
            IWebElement mes = driver.FindElement(By.XPath("//*[@ng-model='monthbox']"));
            SelectElement mesDropbox = new SelectElement(mes);
            mesDropbox.SelectByValue("February");
            IWebElement dia = driver.FindElement(By.XPath("//*[@ng-model='daybox']"));
            SelectElement diaDropbox = new SelectElement(dia);
            diaDropbox.SelectByValue("22");
            return this;
        }
        public PaginaRegistro digitarSenha(String senha)
        {
            driver.FindElement(By.XPath("//*[@ng-model='Password']")).Click();
            driver.FindElement(By.XPath("//*[@ng-model='Password']")).SendKeys(senha);
            return this;
        }
        public PaginaRegistro digitarConfirmacaoSenha(String confirmacaoSenha)
        {
            driver.FindElement(By.XPath("//*[@ng-model='CPassword']")).Click();
            driver.FindElement(By.XPath("//*[@ng-model='CPassword']")).SendKeys(confirmacaoSenha);
            return this;
        }
        public PaginaRegistro clicarSubmit()
        {
            driver.FindElement(By.XPath("//button[contains(text(),'Submit')]")).Click();
            return this;
        }  

        public PaginaRegistro clicarRefresh()
        {
            driver.FindElement(By.XPath("//button[text()='Refresh']")).Click();
            System.Threading.Thread.Sleep(4000);

            return this; ;
        }
    }
}
