using OpenQA.Selenium;
using System;

namespace AutomacaoTestesSaucedemo.Pages
{
    public class LoginPage
    {
        public IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void LoginComDadosValidos()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            Thread.Sleep(1000);

            string textoAtual = driver.FindElement(By.ClassName("app_logo")).Text;
            string textoEsperado = "Swag Labs";

            Assert.AreEqual(textoEsperado, textoAtual, "O texto atual não corresponde com o texto esperado!");
        }

        public void LoginComUsuarioInvalido()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user123");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            Thread.Sleep(1000);

            string textoAtual = driver.FindElement(By.TagName("h3")).Text;
            string textoEsperado = "Epic sadface: Username and password do not match any user in this service";

            Assert.AreEqual(textoEsperado, textoAtual, "O texto atual não corresponde com o texto esperado!");
        }

        public void LoginComSenhaInvalida()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce123");
            driver.FindElement(By.Id("login-button")).Click();

            Thread.Sleep(1000);

            string textoAtual = driver.FindElement(By.TagName("h3")).Text;
            string textoEsperado = "Epic sadface: Username and password do not match any user in this service";

            Assert.AreEqual(textoEsperado, textoAtual, "O texto atual não corresponde com o texto esperado!");
        }
    }
}