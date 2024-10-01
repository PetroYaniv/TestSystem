using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWep
{

    class MainPageObject
    {
        private IWebDriver _webDriver;
       
        private readonly By _InputUserName = By.XPath("//input[@id='user-name']");
        private readonly By _InputUserPassword = By.XPath("//input[@id='password']");
        private readonly By _LoginButton = By.XPath("//input[@id='login-button']");
        private readonly By _ErrorButtonMessage = By.XPath("//h3[@data-test='error']");
       
        public string errorText;
        public MainPageObject()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Navigate().GoToUrl("https://www.saucedemo.com/");


        }

        public void InputLoginStringAndReturn(string UserLogin,string UserPassword)
        {

            _webDriver.FindElement(_InputUserName).SendKeys(UserLogin);
            Thread.Sleep(300);
            _webDriver.FindElement(_InputUserPassword).SendKeys(UserPassword);
            Thread.Sleep(300);
            this.PressLogin();
           // this.ErrorText();

        }


        public void PressLogin()
        {
            _webDriver.FindElement(_LoginButton).Click();
           // this.ErrorText();
        }

        public void ErrorText()
        {
           
            

            errorText = _webDriver.FindElement(_ErrorButtonMessage).Text; 
        }

    }
}
