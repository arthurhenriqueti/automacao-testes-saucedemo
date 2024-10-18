using AutomacaoTestesSaucedemo.Core;
using OpenQA.Selenium;
using System;

namespace AutomacaoTestesSaucedemo.Tests
{
    public class CarrinhoTest : Begin
    {
        [Test]
        public void AdicionandoItem()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            Thread.Sleep(1000);

            string textoAtualLogin = driver.FindElement(By.ClassName("app_logo")).Text;
            string textoEsperadoLogin = "Swag Labs";

            Assert.AreEqual(textoEsperadoLogin, textoAtualLogin, "O texto atual não corresponde com o texto esperado!");

            driver.FindElement(By.Name("add-to-cart-sauce-labs-backpack")).Click();
            driver.FindElement(By.ClassName("shopping_cart_badge")).Click();

            Thread.Sleep(1000);

            string textoAtual = driver.FindElement(By.ClassName("inventory_item_name")).Text;
            string textoEsperado = "Sauce Labs Backpack";

            Thread.Sleep(1000);

            Assert.AreEqual(textoEsperado, textoAtual, "O texto atual não corresponde com o texto esperado!");
        }

        [Test]
        public void RemovendoItem()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            Thread.Sleep(1000);

            string textoAtualLogin = driver.FindElement(By.ClassName("app_logo")).Text;
            string textoEsperadoLogin = "Swag Labs";

            Assert.AreEqual(textoEsperadoLogin, textoAtualLogin, "O texto atual não corresponde com o texto esperado!");

            driver.FindElement(By.Name("add-to-cart-sauce-labs-backpack")).Click();
            driver.FindElement(By.ClassName("shopping_cart_badge")).Click();

            Thread.Sleep(1000);

            string textoAtualAdd = driver.FindElement(By.ClassName("inventory_item_name")).Text;
            string textoEsperadoAdd = "Sauce Labs Backpack";

            Assert.AreEqual(textoEsperadoAdd, textoAtualAdd, "O texto atual não corresponde com o texto esperado!");

            Thread.Sleep(1000);

            driver.FindElement(By.Id("remove-sauce-labs-backpack")).Click();

            string textoAtual = driver.FindElement(By.ClassName("cart_desc_label")).Text;
            string textoEsperado = "Description";

            Thread.Sleep(1000);

            Assert.AreEqual(textoEsperado, textoAtual, "O texto atual não corresponde com o texto esperado!");
        }

        [Test]
        public void FinalizarCompra()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            Thread.Sleep(1000);

            string textoAtualLogin = driver.FindElement(By.ClassName("app_logo")).Text;
            string textoEsperadoLogin = "Swag Labs";

            Assert.AreEqual(textoEsperadoLogin, textoAtualLogin, "O texto atual não corresponde com o texto esperado!");

            driver.FindElement(By.Name("add-to-cart-sauce-labs-backpack")).Click();
            driver.FindElement(By.ClassName("shopping_cart_badge")).Click();

            Thread.Sleep(1000);

            string textoAtualFinalizar = driver.FindElement(By.ClassName("inventory_item_name")).Text;
            string textoEsperadoFinalizar = "Sauce Labs Backpack";

            Thread.Sleep(1000);

            Assert.AreEqual(textoEsperadoFinalizar, textoAtualFinalizar, "O texto atual não corresponde com o texto esperado!");

            Thread.Sleep(1000);

            driver.FindElement(By.Id("checkout")).Click();

            Thread.Sleep(1000);

            driver.FindElement(By.Id("first-name")).SendKeys("Arthur");
            driver.FindElement(By.Id("last-name")).SendKeys("Paiva");
            driver.FindElement(By.Id("postal-code")).SendKeys("00000-000");

            Thread.Sleep(1000);

            driver.FindElement(By.Id("continue")).Click();

            Thread.Sleep(1000);

            driver.FindElement(By.Id("finish")).Click();

            Thread.Sleep(1000);

            string textoAtual = driver.FindElement(By.ClassName("complete-header")).Text;
            string textoEsperado = "Thank you for your order!";

            Thread.Sleep(1000);
        }
    }
}