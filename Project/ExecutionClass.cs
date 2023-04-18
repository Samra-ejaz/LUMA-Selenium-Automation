using LUMA;
using LUMA.TestSteps;
using LUMA.TestCases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
namespace LUMA
{
    [TestClass]
    public class ExecutionClass
    {
        [AssemblyInitialize]
        public static void AssemblyStart(TestContext context)
        {
            LoginTestCases login_Test = new LoginTestCases();
           
            BaseClass.GetDriver("edge");
            BaseClass.GetURL("https://magento.softwaretestingboard.com/");
            BaseClass.MaximizeWindow();
            login_Test.TC001_LoginWithValidUsernameAndValidPassword();


        }
        [AssemblyCleanup]
        public static void AssemblyEnd()
        {
        }
        [TestMethod]
        public void RunAll()
        {
            FilterTestCases fil = new FilterTestCases();
            fil.TC002_CheckAllFilters();
            GearTestCases ger = new GearTestCases();
            ger.TC003_CheckWishListFunctionality();
            ReviewTestCases rev = new ReviewTestCases();
            rev.TC004_CheckReviewFunctionality();
            CostOfItemsTestCases cost = new CostOfItemsTestCases();
            cost.TC005_CostofItems();
            AddToCartTestCases cart = new AddToCartTestCases();
            cart.TC006_ADDtoCortFuntionality();
            
        }
    }
}
