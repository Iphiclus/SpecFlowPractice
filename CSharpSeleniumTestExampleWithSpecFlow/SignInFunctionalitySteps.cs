using CSharpSeleniumTestExampleWithSpecFlow.Actions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace CSharpSeleniumTestExampleWithSpecFlow
{
    [Binding]
    public class SignInFunctionalitySteps
    {
        private IWebDriver driver;
        private Enter enter;
        private Click click;

        [BeforeScenario("Signin")]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            enter = new Enter(driver);
            click = new Click(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Given(@"I am at the My Account page")]
        public void GivenIAmAtTheMyAccountPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=my-account");
            Assert.AreEqual("Login - My Store", driver.Title);
        }
        
        [When(@"I fill the account email textbox with my email")]
        public void WhenIFillTheAccountEmailTextboxWithMyEmail()
        {
            enter.Into(Pages.SignIn.EMAIL_TEXTFIELD).Text("xklein@trashmail.com");
           
        }
        
        [When(@"I fill the password textbox with my password")]
        public void WhenIFillThePasswordTextboxWithMyPassword()
        {
            enter.Into(Pages.SignIn.PASSWORD_TEXTFIELD).Text("password");
            
        }
        
        [When(@"I click the Sign In button")]
        public void WhenIClickTheSignInButton()
        {
            click.On(Pages.SignIn.SIGNIN_BUTTON);
        }
        
        [Then(@"I should be at the My account page")]
        public void ThenIShouldBeAtTheMyAccountPage()
        {
            //Assert.AreEqual("My account - My Store", driver.Title);
        }
    }
}
