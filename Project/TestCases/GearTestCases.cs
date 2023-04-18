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
using System.Threading;
using LUMA.TestSteps;

namespace LUMA.TestCases
{ 
    [TestClass]
    public class GearTestCases
    {

        [TestMethod]
        public void TC003_CheckWishListFunctionality()
        {
            //BaseClass.GetDriver("edge");
            //Thread.Sleep(3000);
            //BaseClass.GetURL("https://magento.softwaretestingboard.com");
            Thread.Sleep(3000);
          //BaseClass.MaximizeWindow();
            Thread.Sleep(3000);
            GearTestSteps gear = new GearTestSteps();


            gear.GearTestStep(BaseClass.driver, "ejazsamra03@gmail.com", "Samra123");
          //  string currUrl = BaseClass.driver.Url;
          //  Assert.AreEqual("https://adactinhotelapp.com/SearchHotel.php", currUrl);
          //  BaseClass.CloseDriver();
        }

       


    }
}
