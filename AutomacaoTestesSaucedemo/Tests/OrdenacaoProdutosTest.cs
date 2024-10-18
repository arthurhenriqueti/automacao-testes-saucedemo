using AutomacaoTestesSaucedemo.Core;
using AutomacaoTestesSaucedemo.Pages;
using OpenQA.Selenium;
using System;

namespace AutomacaoTestesSaucedemo.Tests
{
    public class OrdenacaoProdutosTest : Begin
    {
        [Test]
        public void OrdenandoProdutosPorMenorValor()
        {
            OrdenacaoProdutosPage ordenacao = new OrdenacaoProdutosPage(driver);
            ordenacao.FazerLogin();
            ordenacao.OrdenarPorMenorValor();
        }

        [Test]
        public void OrdenandoProdutosPorMaiorValor()
        {
            OrdenacaoProdutosPage ordenacao = new OrdenacaoProdutosPage(driver);
            ordenacao.FazerLogin();
            ordenacao.OrdenarPorMaiorValor();
        }

        [Test]
        public void OrdenandoProdutosPorNomeAZ()
        {
            OrdenacaoProdutosPage ordenacao = new OrdenacaoProdutosPage(driver);
            ordenacao.FazerLogin();
            ordenacao.OrdenarPorNomeAZ();
        }

        [Test]
        public void OrdenandoProdutosPorNomeZA()
        {
            OrdenacaoProdutosPage ordenacao = new OrdenacaoProdutosPage(driver);
            ordenacao.FazerLogin();
            ordenacao.OrdenarPorNomeZA();
        }
    }
}