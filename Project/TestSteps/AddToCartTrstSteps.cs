using LUMA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project.TestSteps
{

    public class AddToCartTestSteps: BaseClass
    {
        #region Elements
        By SigninPage = By.XPath("//a[@href='#contentarea']");
        By userNameField = By.Id("email");
        By passwordField = By.Id("pass");
        By SigninButton = By.Id("send2");
        By searchbar = By.Id("search");
        By searchButton = By.XPath("//button[@type= 'submit' and @class='action search']");
        By firstItem= By.XPath("//img[@class='product-image-photo' and @alt ='Caesar Warm-Up Pant']");
        By size = By.XPath("//div[@option-id='177' and @id='option-label-size-143-item-177']");
       By color = By.XPath("//div[@option-label='Black']");
        By quantity = By.XPath("//input[@id='qty']");
        By addToCart = By.Id("product-addtocart-button");
        By showCart = By.XPath("//a[@class='action showcart']");
       By item = By.XPath("//strong[@class='product-item-name']");
        #endregion

        //labels
        #region Test Steps  
        public void AddToCartTestStep(IWebDriver driver, string userName, string password)
        {
            //driver.FindElement(By.LinkText("Sign In")).Click();
            ////driver.FindElement(SigninButton).Click();
            //driver.FindElement(userNameField).SendKeys(userName);
            //driver.FindElement(passwordField).SendKeys(password);
            //driver.FindElement(SigninButton).Click();
            driver.FindElement(searchbar).SendKeys("pants");
            driver.FindElement(searchButton).Click();
            driver.FindElement(firstItem).Click();
            Thread.Sleep(2000);
            driver.FindElement(size).Click();
            Thread.Sleep(1000);
            driver.FindElement(color).Click();
            Thread.Sleep(1000);
            driver.FindElement(quantity).Clear();
            Thread.Sleep(1000);
            driver.FindElement(quantity).SendKeys("500");
            Thread.Sleep(1000);
            driver.FindElement(addToCart).Click();
            Thread.Sleep(4000);
            driver.FindElement(showCart).Click();
            Thread.Sleep(11000);
            Assert.AreEqual("Caesar Warm-Up Pant", GetElementText(item));

        }
        #endregion
    }
}

