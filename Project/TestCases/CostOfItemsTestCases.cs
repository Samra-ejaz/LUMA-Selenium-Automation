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

namespace LUMA.TestSteps

{
    [TestClass]
    public class CostOfItemsTestCases
    {
        [TestMethod]
        public void TC005_CostofItems()
        {
        //    BaseClass.GetDriver("edge");
        //    BaseClass.GetURL("https://magento.softwaretestingboard.com/");
         // BaseClass.MaximizeWindow();
            CostOfItemsTestSteps login = new CostOfItemsTestSteps();

            login.CostOfItemsTestStep(BaseClass.driver, "ejazsamra03@gmail.com", "Samra123");
            string currUrl = BaseClass.driver.Url;
            
            //BaseClass.CloseDriver();
        }



    }
}

