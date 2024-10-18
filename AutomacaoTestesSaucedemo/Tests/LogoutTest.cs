using AutomacaoTestesSaucedemo.Core;
using OpenQA.Selenium;
using System;

namespace AutomacaoTestesSaucedemo.Tests
{
    public class LogoutTest : Begin
    {
        [Test]
        public void LogoutComSucesso()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            Thread.Sleep(1000);

            string textoAtualLogin = driver.FindElement(By.ClassName("app_logo")).Text;
            string textoEsperadoLogin = "Swag Labs";

            Assert.AreEqual(textoEsperadoLogin, textoAtualLogin, "O texto atual não corresponde com o texto esperado!");

            Thread.Sleep(1000);

            driver.FindElement(By.ClassName("bm-burger-button")).Click();

            Thread.Sleep(1000);

            driver.FindElement(By.Id("logout_sidebar_link")).Click();

            string textoAtual = driver.FindElement(By.ClassName("login_logo")).Text;
            string textoEsperado = "Swag Labs";

            Assert.AreEqual(textoEsperado, textoAtual, "O texto atual não corresponde com o texto esperado!");

            Thread.Sleep(1000);
        }
    }
}