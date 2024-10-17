using OpenQA.Selenium;
using System;

namespace AutomacaoTestesSaucedemo
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

            String textoAtualLogin = driver.FindElement(By.ClassName("app_logo")).Text;
            String textoEsperadoLogin = "Swag Labs";

            Assert.AreEqual(textoEsperadoLogin, textoAtualLogin, "O texto atual não corresponde com o texto esperado!");

            Thread.Sleep(1000);

            driver.FindElement(By.ClassName("bm-burger-button")).Click();

            Thread.Sleep(1000);

            driver.FindElement(By.Id("logout_sidebar_link")).Click();

            String textoAtual = driver.FindElement(By.ClassName("login_logo")).Text;
            String textoEsperado = "Swag Labs";

            Thread.Sleep(1000);
        }
    }
}