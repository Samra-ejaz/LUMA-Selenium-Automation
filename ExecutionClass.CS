using LUMA;
using LUMA.TestSteps;
using LUMA.TestCases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
namespace FinalSqaProject
{
    [TestClass]
    public class ExecutionClass
    {
        [AssemblyInitialize]
        public static void AssemblyStart(TestContext context)
        {
            LoginTestSteps login_Test = new LoginTestSteps();
            BataBase.SetDriver("edge");
            login_Test.TC001_LoginWithValidData();
        }
        [AssemblyCleanup]
        public static void AssemblyEnd()
        {
        }
        [TestMethod]
        public void RunAll()
        {
            //Register_TestCases reg = new Register_TestCases();
            //reg.TC002_AlreadyRegisterEmail();
            //reg.TC002_1_AlreadyRegisterPhone();
            //FilterRecord_testSteps fil = new FilterRecord_testSteps();
            //fil.TC003_FilterData();
            //SearchTestStpes sts = new SearchTestStpes();
            //sts.TC004_SearchRecord();
            //AddtoCartTestSteps add = new AddtoCartTestSteps();
            //add.TC005_VerifyItemsAdd();
            //DeleteCartTestSteps del = new DeleteCartTestSteps();
            //del.TC006_VerifyAndDeleteCart();
        }
    }
}






