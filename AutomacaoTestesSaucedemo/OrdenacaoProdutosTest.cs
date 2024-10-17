using OpenQA.Selenium;
using System;

namespace AutomacaoTestesSaucedemo
{
    public class OrdenacaoProdutosTest : Begin
    {
        [Test]
        public void OrdenandoProdutosPorMenorValor()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            Thread.Sleep(1000);

            String textoAtualLogin = driver.FindElement(By.ClassName("app_logo")).Text;
            String textoEsperadoLogin = "Swag Labs";

            Thread.Sleep(1000);

            driver.FindElement(By.ClassName("product_sort_container")).Click();

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id=\"header_container\"]/div[2]/div/span/select/option[3]")).Click();

            Thread.Sleep(1000);

            String textoAtual = driver.FindElement(By.ClassName("inventory_item_name")).Text;
            String textoEsperado = "Sauce Labs Onesie";

            Assert.AreEqual(textoEsperado, textoAtual, "O texto atual não corresponde com o texto esperado!");

            Thread.Sleep(1000);
        }

        [Test]
        public void OrdenandoProdutosPorMaiorValor()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            Thread.Sleep(1000);

            String textoAtualLogin = driver.FindElement(By.ClassName("app_logo")).Text;
            String textoEsperadoLogin = "Swag Labs";

            Thread.Sleep(1000);

            driver.FindElement(By.ClassName("product_sort_container")).Click();

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id=\"header_container\"]/div[2]/div/span/select/option[4]")).Click();

            Thread.Sleep(1000);

            String textoAtual = driver.FindElement(By.ClassName("inventory_item_name")).Text;
            String textoEsperado = "Sauce Labs Fleece Jacket";

            Assert.AreEqual(textoEsperado, textoAtual, "O texto atual não corresponde com o texto esperado!");

            Thread.Sleep(1000);
        }

        [Test]
        public void OrdenandoProdutosPorNomeAZ()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            Thread.Sleep(1000);

            String textoAtualLogin = driver.FindElement(By.ClassName("app_logo")).Text;
            String textoEsperadoLogin = "Swag Labs";

            Thread.Sleep(1000);

            driver.FindElement(By.ClassName("product_sort_container")).Click();

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id=\"header_container\"]/div[2]/div/span/select/option[1]")).Click();

            Thread.Sleep(1000);

            String textoAtual = driver.FindElement(By.ClassName("inventory_item_name")).Text;
            String textoEsperado = "Sauce Labs Backpack";

            Assert.AreEqual(textoEsperado, textoAtual, "O texto atual não corresponde com o texto esperado!");

            Thread.Sleep(1000);
        }

        [Test]
        public void OrdenandoProdutosPorNomeZA()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            Thread.Sleep(1000);

            String textoAtualLogin = driver.FindElement(By.ClassName("app_logo")).Text;
            String textoEsperadoLogin = "Swag Labs";

            Thread.Sleep(1000);

            driver.FindElement(By.ClassName("product_sort_container")).Click();

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id=\"header_container\"]/div[2]/div/span/select/option[2]")).Click();

            Thread.Sleep(1000);

            String textoAtual = driver.FindElement(By.ClassName("inventory_item_name")).Text;
            String textoEsperado = "Test.allTheThings() T-Shirt (Red)";

            Assert.AreEqual(textoEsperado, textoAtual, "O texto atual não corresponde com o texto esperado!");

            Thread.Sleep(1000);
        }
    }
}