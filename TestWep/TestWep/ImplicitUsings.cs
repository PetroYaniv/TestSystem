global using FluentAssertions;
global using NUnit;
global using TechTalk.SpecFlow;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using TestWep.StepDefinitions;

namespace SeleniumNunit
{
    [TestFixture]
    public class ExampleTest
    {
       

        [Test]
        public void SampleTest()
        {
            // private IWebDriver _webDriver;

     

           
            var testweb = new CalculatorStepDefinitions();
            testweb.OpenSite();
            Thread.Sleep(300);
            testweb.UserLoginIs();
            Thread.Sleep(300);
            testweb.UserPasswordIs();
            Thread.Sleep(300);
                    
            testweb.WhenTheTwoInputAreinput();
            Thread.Sleep(300);
            testweb.WhenTheButtonPressed();
            Thread.Sleep(300);
            string actual = testweb.Actual();
            Thread.Sleep(300);
            string expected = "Epic sadface: Sorry, this user has been locked out.";
            Assert.AreEqual(expected, actual);
        }

       
    }
}
