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
        public static By USERNAME_TEXTFIELD = By.XPath("//input[@name='UserName']");
        public static By PASSWORD_TEXTFIELD = By.XPath("//input[@name='Password']");
        public static By LOGIN_BUTTON = By.XPath("//input[@name='Login']");
    }
}
