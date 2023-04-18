using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using LUMA.TestCases;
using System;

using System.Threading;

namespace LUMA.TestSteps

{
    [TestClass]
    public class LoginTestCases 
    {
        [TestMethod]
        public void TC001_LoginWithValidUsernameAndValidPassword()
        {

            LoginTestSteps login = new LoginTestSteps();

            login.LoginTestStep(BaseClass.driver, "ejazsamra03@gmail.com", "Samra123");
         // string currUrl = BaseClass.driver.Url;


            //string ExpectedWelcomeMessage = "Welcome, Samra Ejaz!";
            //Thread.Sleep(2000);
            //string ActualWelcomeMessage = GetElementText(By.XPath("//span[contains(text(),'Welcome, Samra Ejaz!')]"));

            //Assert.AreEqual(ExpectedWelcomeMessage, ActualWelcomeMessage);
            //CloseDriver();
            //BaseClass.CloseDriver();
        }

       
    }
}

