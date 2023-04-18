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

    public class ReviewTestSteps : BaseClass
    {
        #region Elements
        //By SigninPage = By.XPath("//a[@href='#contentarea']");
        //By userNameField = By.Id("email");
        //By passwordField = By.Id("pass");
        //By SigninButton = By.Id("send2");
        By searchbar = By.Id("search");
        By searchButton = By.XPath("//button[@type= 'submit' and @class='action search']");
        By FirstItem = By.XPath("//img[@alt='Selene Yoga Hoodie']");
        By addReview = By.XPath("//a[@class ='action add']");
        By ratting = By.ClassName("rating-1");
        By name = By.Id("nickname_field");
        By summaryField = By.Id("summary_field");
        By reviewFiled = By.Id("review_field");
        By submitReview = By.XPath("//span[text() ='Submit Review']");      
        By goTOAccount = By.XPath("//button[@class='action switch' and @data-action='customer-menu-toggle']");
        By myAccount= By.LinkText("My Account");
        By myreviews = By.XPath("//li[@class='nav item']//a[text()='My Product Reviews']");
       // By VerifyNameReview = By.XPath("//*[@id=\"my-reviews-table\"]/tbody/tr[1]/td[4]");
       // By VerifyReview = By.XPath("//*[@id='my-reviews-table']/tbody/tr/td[4]");
        
        #endregion

        //labels
        #region Test Steps  
        public void ReviewTestStep(IWebDriver driver, string userName, string password)
        {
            //driver.FindElement(WhatISNEw).Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.LinkText("Sign In")).Click();
            ////driver.FindElement(SigninButton).Click();
            //driver.FindElement(userNameField).SendKeys(userName);
            //driver.FindElement(passwordField).SendKeys(password);
            //driver.FindElement(SigninButton).Click();

            //Actions actions = new Actions(driver);
            //actions.MoveToElement(driver.FindElement(Gear)).Build().Perform();

            Thread.Sleep(3000);
            driver.FindElement(searchbar).SendKeys("Selene Yoga Hoodie");
            driver.FindElement(searchButton).Click();
            Thread.Sleep(1000);
            driver.FindElement(FirstItem).Click();
            Thread.Sleep(1000);
            driver.FindElement(addReview).Click();
            Thread.Sleep(1000);
            

           
            driver.FindElement(ratting).Click();
            Thread.Sleep(3000);
            driver.FindElement(name).Clear();
            Thread.Sleep(3000);
            driver.FindElement(name).SendKeys("Samra Ejaz");
            driver.FindElement(summaryField).SendKeys("Good");
            Thread.Sleep(3000);
            driver.FindElement(reviewFiled).SendKeys("I like the stuff");
            Thread.Sleep(3000);
            driver.FindElement(submitReview).Click();
            driver.FindElement(goTOAccount).Click();
            driver.FindElement(myAccount).Click();

            
            driver.FindElement(myreviews).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@class = 'logo']")).Click();


         //   Assert.AreEqual("I like the stuff", GetElementText(VerifyNameReview));
            //Assert.AreEqual("aaaaaaaaaaaa", GetElementText(VerifyReview));
          

        }
        #endregion
    }
}

