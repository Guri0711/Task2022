using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2022.Utilities;

namespace Task2022.Pages
{
    class ShareSkillPage
    {
        public void CreateShareSkill(IWebDriver driver)
        {
            //identify the Title textbox and add title
            IWebElement titleTextbox = driver.FindElement(By.XPath("//input[@name= 'title']"));
            titleTextbox.SendKeys("Cooking");

            //identify the Description textbox and add detail
            IWebElement descriptionTextbox = driver.FindElement(By.XPath("//textarea[@name ='description']"));
            descriptionTextbox.SendKeys("I love cooking and baking");

            // identify category dropbox and select
            IWebElement categoryDropdown = driver.FindElement(By.XPath("//select[@name='categoryId']"));
            categoryDropdown.Click();

            IWebElement categoryOptionDropdown = driver.FindElement(By.XPath("//option[@value='8']"));
            categoryOptionDropdown.Click();


            // identify sub-category dropdown
            IWebElement subcategoryDropdown = driver.FindElement(By.XPath("//select[@name = 'subcategoryId']"));
            subcategoryDropdown.Click();

            IWebElement subcategoryOptionDropdown = driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(1) > select > option:nth-child(2)"));
            subcategoryOptionDropdown.Click();

            // identify tag textbox and enter detail
            IWebElement tagsTextbox = driver.FindElement(By.XPath("//input[@class ='ReactTags__tagInputField']"));
            tagsTextbox.SendKeys("Baking");
            tagsTextbox.SendKeys(Keys.Enter);

            //identify service type and select
            IWebElement serviceTypeRadioButton = driver.FindElement(By.XPath("//input[@name='serviceType']"));
            serviceTypeRadioButton.Click();

            // identify location type and select
            IWebElement locationTypeRadioButton = driver.FindElement(By.XPath("//*[@name = 'locationType' and @value = '1']"));
            locationTypeRadioButton.Click();

            //identify available days and add details
            IWebElement startdateSelect = driver.FindElement(By.XPath("//input[@type='date' and @name='startDate']"));
            startdateSelect.SendKeys("31122022");
            startdateSelect.SendKeys(Keys.Enter);


            IWebElement monDateStartTimeSelect = driver.FindElement(By.XPath("//label[text()='Mon']/following::input[@name='StartTime']"));
            monDateStartTimeSelect.SendKeys("0830am");
            monDateStartTimeSelect.SendKeys(Keys.Enter);

            IWebElement monDateEndTimeSelect = driver.FindElement(By.XPath("//label[text()='Mon']/following::input[@name='EndTime']"));
            monDateEndTimeSelect.SendKeys("0845pm");
            monDateEndTimeSelect.SendKeys(Keys.Enter);


            Wait.WaitTobeVisible(driver, "XPath", "//label[text()='Tue']/following::input[@name='StartTime']", 3);

            IWebElement tuesDateTimeSelect = driver.FindElement(By.XPath("//label[text()='Tue']/following::input[@name='StartTime']"));
            tuesDateTimeSelect.SendKeys("0930am");
            tuesDateTimeSelect.SendKeys(Keys.Enter);

            IWebElement tuesDateEndTimeSelect = driver.FindElement(By.XPath("//label[text()='Tue']/following::input[@name='EndTime']"));
            tuesDateEndTimeSelect.SendKeys("0930pm");
            tuesDateEndTimeSelect.SendKeys(Keys.Enter);

            Wait.WaitTobeVisible(driver, "XPath", "//label[text()='Wed']/following::input[@name='StartTime']", 3);

            IWebElement wedStartTimeSelect = driver.FindElement(By.XPath("//label[text()='Wed']/following::input[@name='StartTime']"));
            wedStartTimeSelect.SendKeys("0930am");
            wedStartTimeSelect.SendKeys(Keys.Enter);

            IWebElement wedEndTimeSelect = driver.FindElement(By.XPath("//label[text()='Wed']/following::input[@name='EndTime']"));
            wedEndTimeSelect.SendKeys("0930pm");
            wedEndTimeSelect.SendKeys(Keys.Enter);

            Wait.WaitTobeVisible(driver, "XPath", "//label[text()='Thu']/following::input[@name='StartTime']", 3);

            IWebElement thuStartTimeSelect = driver.FindElement(By.XPath("//label[text()='Thu']/following::input[@name='StartTime']"));
            thuStartTimeSelect.SendKeys("0930am");
            thuStartTimeSelect.SendKeys(Keys.Enter);

            IWebElement thuEndTimeSelect = driver.FindElement(By.XPath("//label[text()='Thu']/following::input[@name='EndTime']"));
            thuEndTimeSelect.SendKeys("0930pm");
            thuEndTimeSelect.SendKeys(Keys.Enter);

            Wait.WaitTobeVisible(driver, "XPath", "//label[text()='Fri']/following::input[@name='StartTime']", 3);

            IWebElement friStartTimeSelect = driver.FindElement(By.XPath("//label[text()='Fri']/following::input[@name='StartTime']"));
            friStartTimeSelect.SendKeys("0930am");
            friStartTimeSelect.SendKeys(Keys.Enter);

            IWebElement friEndTimeSelect = driver.FindElement(By.XPath("//label[text()='Fri']/following::input[@name='EndTime']"));
            friEndTimeSelect.SendKeys("0930pm");
            friEndTimeSelect.SendKeys(Keys.Enter);


            // identify the skill trade and select
            IWebElement skillTradeBulletButton = driver.FindElement(By.XPath("//input[@name= 'skillTrades']"));
            skillTradeBulletButton.Click();

            //identify skill exchange and add details
            IWebElement skillExchangeTextbox = driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(8) > div:nth-child(4) > div > div > div > div > div > input"));
            skillExchangeTextbox.SendKeys("Baking");
            skillExchangeTextbox.SendKeys(Keys.Enter);

            // identify the Active and select
            IWebElement activeBulletButton = driver.FindElement(By.XPath("//input[@name= 'isActive' and @value= 'false']"));
            activeBulletButton.Click();

            // identify the save button and click
            IWebElement saveButton = driver.FindElement(By.XPath("//input[@type='button']"));
            saveButton.Click();

            // Checking the created record
            Thread.Sleep(2000);
            IWebElement actualRecord = driver.FindElement(By.CssSelector("#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(3)"));


            if (actualRecord.Text == "Cooking")
            {
                Assert.Pass("Share Skill created successfully, Test Passed.");

            }
            else
            {
                Assert.Fail("Test Failed");
            }

        }

        
    }
}
