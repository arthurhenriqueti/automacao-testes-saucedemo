using AutomacaoTestesSaucedemo.Core;
using AutomacaoTestesSaucedemo.Pages;
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
            LoginPage login = new LoginPage(driver);
            login.LoginComDadosValidos();
        }

        [Test]
        public void LoginComUsuarioIncorreto()
        {
            LoginPage login = new LoginPage(driver);
            login.LoginComUsuarioInvalido();
        }

        [Test]
        public void LoginComSenhaIncorreta()
        {
            LoginPage login = new LoginPage(driver);
            login.LoginComSenhaInvalida();
        }
    }
}