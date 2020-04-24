using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProvaTest.pages;
using ProvaTest.support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTest
{
    [TestFixture]
    class Program
    {

        private IWebDriver driver;

        static void Main(string[] args)
        {
        }

        public string numeroAleatorio()
        {
            Random random = new Random();
            String numeroAleatorio = random.Next(1000000000).ToString().PadRight(10, '0');
            return numeroAleatorio;
        }

        public string emailAleatorio()
        {
            Random random = new Random();
            String emailAleatorio = String.Format($"teste{random.Next(10000)}@teste.com");
            return emailAleatorio;
        }

        [Test]
        public void testCadastroCompleto()
        {
            new PaginaRegistro(driver).
                digitarPrimeiroNome("Cleber").
                digitarUltimoNome("Henrique").
                digitarEndereco("Rua 25, Zona Sul - São Paulo").
                digitarEmail(emailAleatorio()).
                digitarNumeroTelefone(numeroAleatorio()).
                escolherGenero().
                escolherHobbies().
                escolherIdioma().
                escolherSkills().
                escolherPais().
                preenchendoPaisSelecionado().
                escolherNascimento().
                digitarSenha("Aa@123").
                digitarConfirmacaoSenha("Aa@123").
                clicarSubmit();

            System.Threading.Thread.Sleep(4000);
            Assert.AreEqual(driver.Url, "http://demo.automationtesting.in/WebTable.html");
        }

        [Test]
        public void testCadastroApenasCamposObrigatorios()
        {
            new PaginaRegistro(driver).
                digitarPrimeiroNome("Matheus").
                digitarUltimoNome("Fidélis").
                digitarEndereco("Rua 11 de Agosto, Zona Oeste - Amapá").
                digitarEmail(emailAleatorio()).
                digitarNumeroTelefone(numeroAleatorio()).
                escolherGenero().
                escolherPais().
                clicarSubmit();

            System.Threading.Thread.Sleep(4000);
            Assert.AreEqual(driver.Url, "http://demo.automationtesting.in/WebTable.html");
        }

        [Test]
        public void testRefresh()
        {
            new PaginaRegistro(driver).
                clicarRefresh();
            Assert.AreEqual(driver.Url, "http://demo.automationtesting.in/Register.html");
        }

        [SetUp]
        public void SetUp()
        {
            driver = Web.criarChrome();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
