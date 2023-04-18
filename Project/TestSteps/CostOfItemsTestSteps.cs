using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LUMA.TestCases
{

    public class CostOfItemsTestSteps
    {
        private static object convet;
        #region Elements
        By SigninPage = By.XPath("//a[@href='#contentarea']");
        By userNameField = By.Id("email");
        By passwordField = By.Id("pass");
        By SigninButton = By.Id("send2");
       
        By firstItem = By.XPath("//span[@style='padding-bottom: 125%;' and img[@alt='Radiant Tee']]");
        By addtocort1 = By.XPath("//span[text()='Add to Cart']");
        By secondItem = By.XPath("//span[@style='padding-bottom: 125%;' and img[@alt='Breathe-Easy Tank']]");
        By thirdItem = By.XPath("//span[@style='padding-bottom: 125%;' and img[@alt='Argus All-Weather Tank']]");
        By fourthItem = By.XPath("//span[@style='padding-bottom: 125%;' and img[@alt='Hero Hoodie']]");
        By fifthItem = By.XPath("//span[@style='padding-bottom: 125%;' and img[@alt='Push It Messenger Bag']]");
        //By searchbar = By.Id("search");
        //By searchButton = By.XPath("//button[@type= 'submit' and @class='action search']");
        //By firstItem = By.XPath("//img[@class='product-image-photo' and @alt ='Caesar Warm-Up Pant']");
        //By price = By.Id("product-price-1556");
        //string sum = convet.ToString();


        By size = By.XPath("//div[@option-label='S']");
        By size2= By.Id("option-label-size-143-item-167");
        By size3 = By.XPath("//div[@option-label='S']");
        By size4 = By.Id("option-label-size-143-item-167");
        By color = By.Id("option-label-color-93-item-56");
        By color2 = By.Id("option-label-color-93-item-57");
        By color3 = By.Id("option-label-color-93-item-52");
        By color4 = By.Id("option-label-color-93-item-52");
        By addtocart = By.Id("product-addtocart-button");  
        By showCart = By.XPath("//a[@class='action showcart']");
        By viewCart = By.XPath("//a[@class='action viewcart' and span[text()='View and Edit Cart']]");

        #endregion
        //labels
        #region Test Steps  
        public void CostOfItemsTestStep(IWebDriver driver, string userName, string password)
        {
            //driver.FindElement(By.LinkText("Sign In")).Click();
            ////driver.FindElement(SigninButton).Click();
            //driver.FindElement(userNameField).SendKeys(userName);
            //driver.FindElement(passwordField).SendKeys(password);
            //driver.FindElement(SigninButton).Click();
            Thread.Sleep(5000);
            
            driver.FindElement(firstItem).Click();
           driver.Manage().Window.FullScreen();
            Thread.Sleep(2000);
            driver.FindElement(size).Click();
            Thread.Sleep(1000);
            driver.FindElement(color).Click();
            Thread.Sleep(3000);
            driver.FindElement(addtocort1).Click();
            Thread.Sleep(3000);
            // Navigate back to the first page
            driver.Navigate().Back();
            // Wait for the page to load
            Thread.Sleep(3000);


            driver.FindElement(secondItem).Click();
            Thread.Sleep(1000);
            driver.FindElement(size2).Click();
            Thread.Sleep(1000);
            driver.FindElement(color2).Click();
            Thread.Sleep(3000);
            driver.FindElement(addtocort1).Click();
            Thread.Sleep(5000);


            // Navigate back to the first page
            driver.Navigate().Back();
            // Wait for the page to load
            Thread.Sleep(3000);
            driver.FindElement(thirdItem).Click();
            Thread.Sleep(1000);
            driver.FindElement(size3).Click();
            Thread.Sleep(1000);
            driver.FindElement(color3).Click();
            Thread.Sleep(3000);
            driver.FindElement(addtocort1).Click();
            Thread.Sleep(2000);
            // Navigate back to the first page
            driver.Navigate().Back();
            // Wait for the page to load
            Thread.Sleep(3000);


            //driver.FindElement(fourthItem).Click();
            //driver.FindElement(size4).Click();
            //Thread.Sleep(1000);
            //driver.FindElement(color4).Click();
            //Thread.Sleep(3000);
            //driver.FindElement(addtocort1).Click();
            //Thread.Sleep(5000);


            // Navigate back to the first page
           // driver.Navigate().Back();
            // Wait for the page to load
            Thread.Sleep(3000);
            driver.FindElement(fifthItem).Click();            
            driver.FindElement(addtocart).Click();
            Thread.Sleep(5000);
           driver.FindElement(showCart).Click();
            driver.FindElement(viewCart).Click();
         

        }
        #endregion
    }
}

