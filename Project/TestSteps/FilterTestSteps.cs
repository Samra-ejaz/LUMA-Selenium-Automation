using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LUMA.TestCases
{

    public class FilterTestSteps: BaseClass
    {
        #region Elements
        By WhatISNEw = By.XPath("//a[@id='ui-id-3']");
        By jeacket = By.XPath("//a[@href='https://magento.softwaretestingboard.com/women/tops-women/jackets-women.html' and text()='Jackets']");
        By Size = By.XPath("//div[text()='Size']");
        By XL = By.XPath("//div[@class='swatch-option text ' and text()='XL']");
        By price = By.XPath("//div[text()='Price']");
        By PriceFilter = By.XPath("//a[@href='https://magento.softwaretestingboard.com/women/tops-women/jackets-women.html?price=60-70&size=170']");
        By Color = By.XPath("//div[text()='Color']");
        By Black = By.XPath("//div[ @class='swatch-option color 'and@option-id='49']");

        By AssertSize = By.XPath("//*[@id='option-label-size-143-item-170']");
        By AssertPrice = By.XPath("//*[@id='product-price-1364']/span");
        By AssertColor = By.XPath("body.page-with-filter.page-products.categorypath-women-tops-women-jackets-women.category-jackets-women.catalog-category-view.page-layout-2columns-left:nth-child(2) div.page-wrapper:nth-child(4) main.page-main div.columns:nth-child(4) div.sidebar.sidebar-main:nth-child(2) div.block.filter div.block-content.filter-content div.filter-options div.filter-options-item.allow.active:nth-child(2) div.filter-options-content div.swatch-attribute.swatch-layered.color:nth-child(1) div.swatch-attribute-options.clearfix a.swatch-option-link-layered:nth-child(1) > div.swatch-option.color");



        #endregion

        //labels
        #region Test Steps  
        public void FilterTestStep(IWebDriver driver)
        {
            Thread.Sleep(3000);
            driver.FindElement(WhatISNEw).Click();
            Thread.Sleep(2000);
            driver.FindElement(jeacket).Click();
            driver.FindElement(Size).Click();
            Thread.Sleep(2000);
            driver.FindElement(XL).Click();
            Thread.Sleep(2000);
            driver.FindElement(price).Click();
            Thread.Sleep(2000);
            driver.FindElement(PriceFilter).Click();
            Thread.Sleep(2000);
            driver.FindElement(Color).Click();
            Thread.Sleep(2000);
            driver.FindElement(Black).Click();
            Thread.Sleep(5000);



            //Assert.AreEqual("XL", GetElementText(AssertSize));
            //Assert.AreEqual("$69.00", GetElementText(AssertPrice));
            //Assert.AreEqual("Black", GetElementText(AssertColor));

        }
        #endregion
    }
}

