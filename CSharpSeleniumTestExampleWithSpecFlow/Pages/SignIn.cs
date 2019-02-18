using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumTestExampleWithSpecFlow.Pages
{
    class SignIn
    {
        public static By EMAIL_TEXTFIELD        = By.XPath("//input[@name='email']");
        public static By PASSWORD_TEXTFIELD     = By.XPath("//input[@name='passwd']");
        public static By SIGNIN_BUTTON          = By.CssSelector("button#SubmitLogin.button.btn.btn-default.button-medium");
        public static By STEST_SITE_HEADER      = By.XPath("//*[@id='center_column']/h1");
        public static By ERROR_MESSAGE          = By.XPath("//*[@id='center_column']/div[1]");
        
    }
}
