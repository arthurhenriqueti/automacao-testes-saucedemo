using AutomacaoTestesSaucedemo.Core;
using AutomacaoTestesSaucedemo.Pages;
using OpenQA.Selenium;
using System;

namespace AutomacaoTestesSaucedemo.Tests
{
    public class CarrinhoTest : Begin
    {
        [Test]
        public void AdicionandoItem()
        {
            CarrinhoPage carrinho = new CarrinhoPage(driver);
            carrinho.FazerLogin();
            carrinho.AdicionarItem();
        }

        [Test]
        public void RemovendoItem()
        {
            CarrinhoPage carrinho = new CarrinhoPage(driver);
            carrinho.FazerLogin();
            carrinho.AdicionarItem();
            carrinho.RemoverItem();
        }

        [Test]
        public void FinalizarCompra()
        {
            CarrinhoPage carrinho = new CarrinhoPage(driver);
            carrinho.FazerLogin();
            carrinho.AdicionarItem();
            carrinho.FinalizarCompra();
        }
    }
}