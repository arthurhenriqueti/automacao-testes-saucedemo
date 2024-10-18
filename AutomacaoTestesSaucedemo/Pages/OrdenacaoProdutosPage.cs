using OpenQA.Selenium;
using System;

namespace AutomacaoTestesSaucedemo.Pages
{
    public class OrdenacaoProdutosPage
    {
        public IWebDriver driver;

        public OrdenacaoProdutosPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void FazerLogin()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            Thread.Sleep(1000);

            string textoAtualLogin = driver.FindElement(By.ClassName("app_logo")).Text;
            string textoEsperadoLogin = "Swag Labs";

            Thread.Sleep(1000);
        }

        public void OrdenarPorMenorValor()
        {
            driver.FindElement(By.ClassName("product_sort_container")).Click();

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id=\"header_container\"]/div[2]/div/span/select/option[3]")).Click();

            Thread.Sleep(1000);

            string textoAtual = driver.FindElement(By.ClassName("inventory_item_name")).Text;
            string textoEsperado = "Sauce Labs Onesie";

            Assert.AreEqual(textoEsperado, textoAtual, "O texto atual não corresponde com o texto esperado!");

            Thread.Sleep(1000);
        }

        public void OrdenarPorMaiorValor()
        {
            driver.FindElement(By.ClassName("product_sort_container")).Click();

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id=\"header_container\"]/div[2]/div/span/select/option[4]")).Click();

            Thread.Sleep(1000);

            string textoAtual = driver.FindElement(By.ClassName("inventory_item_name")).Text;
            string textoEsperado = "Sauce Labs Fleece Jacket";

            Assert.AreEqual(textoEsperado, textoAtual, "O texto atual não corresponde com o texto esperado!");

            Thread.Sleep(1000);
        }

        public void OrdenarPorNomeAZ()
        {
            driver.FindElement(By.XPath("//*[@id=\"header_container\"]/div[2]/div/span/select/option[1]")).Click();

            Thread.Sleep(1000);

            string textoAtual = driver.FindElement(By.ClassName("inventory_item_name")).Text;
            string textoEsperado = "Sauce Labs Backpack";

            Assert.AreEqual(textoEsperado, textoAtual, "O texto atual não corresponde com o texto esperado!");

            Thread.Sleep(1000);
        }

        public void OrdenarPorNomeZA()
        {
            driver.FindElement(By.ClassName("product_sort_container")).Click();

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id=\"header_container\"]/div[2]/div/span/select/option[2]")).Click();

            Thread.Sleep(1000);

            string textoAtual = driver.FindElement(By.ClassName("inventory_item_name")).Text;
            string textoEsperado = "Test.allTheThings() T-Shirt (Red)";

            Assert.AreEqual(textoEsperado, textoAtual, "O texto atual não corresponde com o texto esperado!");

            Thread.Sleep(1000);
        }
    }
}