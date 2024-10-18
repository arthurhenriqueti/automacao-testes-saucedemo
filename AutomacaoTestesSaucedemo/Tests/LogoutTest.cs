using AutomacaoTestesSaucedemo.Core;
using AutomacaoTestesSaucedemo.Pages;
using OpenQA.Selenium;
using System;

namespace AutomacaoTestesSaucedemo.Tests
{
    public class LogoutTest : Begin
    {
        [Test]
        public void LogoutComSucesso()
        {
            LogoutPage logout = new LogoutPage(driver);
            logout.FazerLogin();
            logout.AbrirMenu();
            logout.ClicarEmLogout();
        }
    }
}