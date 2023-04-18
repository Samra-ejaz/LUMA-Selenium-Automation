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
using System.Runtime.InteropServices.WindowsRuntime;

namespace LUMA
{
    public class BaseClass
    {

        public static IWebDriver driver;

        public static void GetDriver(string browser)
        {

            if (browser == "chrome")
            {
                driver = new ChromeDriver();
            }
            else if (browser == "firefox")
            {
                driver = new FirefoxDriver();
            }
            else if (browser == "edge")
            {
                driver = new EdgeDriver();
            }
        }
        #region actualresults()
        public string getText(By name)
        {
            string text = driver.FindElement(name).Text;
            return text;

        }
        #endregion


        #region GetElementText
        public string GetElementText(By by)
        {
            string text;
            try
            {
                text = driver.FindElement(by).Text;
            }
            catch
            {
                try
                {
                    text = driver.FindElement(by).GetAttribute("value");
                }
                catch
                {
                    text = driver.FindElement(by).GetAttribute("innerHTML");
                }
            }
            return text;
        }
        #endregion

        public static void GetURL(string url)
        {
            driver.Url = url;
        }
        public static void MaximizeWindow()
        {
            driver.Manage().Window.Maximize();
        }

        public static void CloseDriver()
        {
            driver.Close();
        }
        public void ClickNow(By btheXpath)
        {
            driver.FindElement(btheXpath).Click();
        }
    }
}
