using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LUMA.TestSteps
{

    public class GearTestSteps : BaseClass
    {
        #region Elements
        By SigninPage = By.XPath("//a[@href='#contentarea']");
        By userNameField = By.Id("email");
        By passwordField = By.Id("pass");
        By SigninButton = By.Id("send2");
        By Gear = By.XPath("//span[text()='Gear']");
        By fitness_Equipment =By.XPath("//span[contains(text(), 'Fitness Equipment')]");
        By firstitem = By.XPath("//a[@class='product-item-link' and @href='https://magento.softwaretestingboard.com/sprite-yoga-companion-kit.html']");
        By WishList = By.XPath("//a[@data-action='add-to-wishlist']");
        By Account = By.XPath("//li[@class='nav item' and a[text()='My Account']]");
        By MywishList = By.XPath("//a[text()='My Wish List']");
       
        By Verify = By.XPath("//a[text()=' Sprite Yoga Companion Kit ']");
        #endregion

        //labels
        #region Test Steps  
        public void GearTestStep(IWebDriver driver, string userName, string password)
        {
            ////driver.FindElement(WhatISNEw).Click();
            ////Thread.Sleep(2000);
            //driver.FindElement(By.LinkText("Sign In")).Click();
            ////driver.FindElement(SigninButton).Click();
            //driver.FindElement(userNameField).SendKeys(userName);
            //driver.FindElement(passwordField).SendKeys(password);
            //driver.FindElement(SigninButton).Click();

            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(Gear)).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(fitness_Equipment).Click();
            driver.FindElement(firstitem).Click();
            Thread.Sleep(2000);
            driver.FindElement(WishList).Click();   
            Thread.Sleep(2000);
            driver.FindElement(Account).Click();
            Thread.Sleep(2000);
            driver.FindElement(MywishList).Click();

           // Assert.AreEqual("Sprite Yoga Companion Kit ", GetElementText(Verify));

        }
        #endregion
    }
}

