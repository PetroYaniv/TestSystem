using FluentAssertions;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium.DevTools.V127.Network;


namespace TestWep.StepDefinitions
{

   
    [Binding]
    public class CalculatorStepDefinitions
    {
        private MainPageObject _mainPage;
        private IWebDriver _driver;
        public string actualStr;

        [Given("UserLogin is (.*)")]
        public string UserLoginIs()
        {

            return "locked_out_user";
        }

        [Given("UserPassword is (.*)")]
        public string UserPasswordIs()
        {

            return "secret_sauce";
        }

        [Then("I open website")]
        public void OpenSite()
        {
            _mainPage = new MainPageObject();


        }

        [When("The two Inputs are input")]
        public void WhenTheTwoInputAreinput()
        {

            
            _mainPage.InputLoginStringAndReturn(UserLoginIs(), UserPasswordIs());


        }

        [When("The button was pressed")]
        public void WhenTheButtonPressed()
        {
           
           
           
        }

        [Then("the result should be (.*)")]
        public string Actual()
        {

            _mainPage.ErrorText();
            return _mainPage.errorText;

            
        }

        public CalculatorStepDefinitions()
        {

           

        }

    }
}
