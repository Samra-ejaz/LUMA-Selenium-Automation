using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using LUMA.TestCases;
using Project.TestSteps;

namespace LUMA.TestSteps

{
    [TestClass]
    public class AddToCartTestCases
    {
        [TestMethod]
        public void TC006_ADDtoCortFuntionality()
        {
            //BaseClass.GetDriver("edge");
            //BaseClass.GetURL("https://magento.softwaretestingboard.com/");
           //aseClass.MaximizeWindow();
            AddToCartTestSteps login = new AddToCartTestSteps();

            login.AddToCartTestStep(BaseClass.driver, "ejazsamra03@gmail.com", "Samra123");
            string currUrl = BaseClass.driver.Url;
            //Assert.AreEqual("https://adactinhotelapp.com/SearchHotel.php", currUrl);
            BaseClass.CloseDriver();
        }

        //[TestMethod]
        //public void TC002_LoginWithValidUsernameAndInvaildPassword()
        // {
        //    BaseClass.GetDriver("chrome");
        //        BaseClass.GetURL("https://magento.softwaretestingboard.com/");
        //        LoginTestSteps login = new LoginTestSteps();
        //        login.LoginTestStep(BaseClass.driver, "ejazsamra03@gmail.com", "@123456");

        //    //Assert.AreEqual("https://adactinhotelapp.com/", driver.Url);
        //    BaseClass.CloseDriver();
        //    }

        //    //[TestMethod]
        //public void TC002_LoginWithInvalidUsernameAndValidPassword()
        //{
        //BaseClass.GetDriver("edge");
        //    BaseClass.GetURL("https://magento.softwaretestingboard.com/");
        //    LoginTestSteps login = new LoginTestSteps();
        //    login.LoginTestStep(BaseClass.driver, "warda", "Samra123");

        //    //Assert.AreEqual("https://adactinhotelapp.com/", driver.Url);
        //    BaseClass.CloseDriver();
        //}


    }
}

