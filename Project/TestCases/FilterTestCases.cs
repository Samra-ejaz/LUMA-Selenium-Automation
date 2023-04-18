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
    public class FilterTestCases 
    {
        [TestMethod]
        public void TC002_CheckAllFilters()
        {
            //BaseClass.GetDriver("edge");
            //BaseClass.GetURL("https://magento.softwaretestingboard.com/");
         // BaseClass.MaximizeWindow();
            FilterTestSteps login = new FilterTestSteps();

            login.FilterTestStep(BaseClass.driver);
            string currUrl = BaseClass.driver.Url;
            
         // BaseClass.CloseDriver();
        }
    }
}

