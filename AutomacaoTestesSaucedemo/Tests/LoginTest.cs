using AutomacaoTestesSaucedemo.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomacaoTestesSaucedemo.Tests
{
    public class LoginTest : Begin
    {
        [Test]
        public void LoginComSucesso()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            Thread.Sleep(1000);

            string textoAtual = driver.FindElement(By.ClassName("app_logo")).Text;
            string textoEsperado = "Swag Labs";

            Assert.AreEqual(textoEsperado, textoAtual, "O texto atual não corresponde com o texto esperado!");
        }

        [Test]
        public void LoginComUsuarioIncorreto()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user123");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            Thread.Sleep(1000);

            string textoAtual = driver.FindElement(By.TagName("h3")).Text;
            string textoEsperado = "Epic sadface: Username and password do not match any user in this service";

            Assert.AreEqual(textoEsperado, textoAtual, "O texto atual não corresponde com o texto esperado!");
        }

        [Test]
        public void LoginComSenhaIncorreta()
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