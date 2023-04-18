using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUMA.TestCases
{

    public class LoginTestSteps : BaseClass
    {
        #region Elements
        By SigninPage = By.XPath("//a[@href='#contentarea']");
        By userNameField = By.Id("email");
        By passwordField = By.Id("pass");
        By SigninButton = By.Id("send2");
        //By validate = By.XPath("//span[text()='Welcome, Samra Ejaz!']");

        #endregion

        //labels
        #region Test Steps  
        public void LoginTestStep(IWebDriver driver, string userName, string password)
        {
           //string actual = "Welcome, Samra Ejaz!";
           driver.FindElement(By.LinkText("Sign In")).Click();
           // driver.FindElement(SigninButton).Click();
            driver.FindElement(userNameField).SendKeys(userName);
            driver.FindElement(passwordField).SendKeys(password);
            driver.FindElement(SigninButton).Click();
          
            //Assert.AreEqual(actual,t);
        }
        #endregion
    }
}

