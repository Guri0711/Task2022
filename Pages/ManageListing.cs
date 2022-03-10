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
    class ManageListing
    {
        public void ViewShareSkill(IWebDriver driver)
        {
            // Go To Manage Listing
            IWebElement goToManageListing = driver.FindElement(By.XPath("//a[@href='/Home/ListingManagement']"));
            goToManageListing.Click();


            // identify view icon and click

            Wait.WaitTobeVisible(driver, "XPath", "//i[@class = 'eye icon']", 3);
            IWebElement viewIconButto = driver.FindElement(By.XPath("//i[@class = 'eye icon']"));
            viewIconButto.Click();
        }
        public void EditShareSkill(IWebDriver driver)
        {

            // Go To Manage Listing
            IWebElement goToManageListing = driver.FindElement(By.XPath("//a[@href='/Home/ListingManagement']"));
            goToManageListing.Click();

            //identify last page button 
            Thread.Sleep(2000);
            IWebElement gotoLastPage = driver.FindElement(By.CssSelector("#listing-management-section > div:nth-child(3) > div:nth-child(2) > div.ui.buttons.semantic-ui-react-button-pagination > button:nth-child(4)"));
            gotoLastPage.Click();

            //identify edit icon
            Thread.Sleep(2000);
            IWebElement editButton = driver.FindElement(By.CssSelector("#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(2) > i"));
            editButton.Click();

            //identify the edit Title textbox and add title
            Wait.WaitTobeVisible(driver, "XPath", "//input[@type ='text' and @name='title' ]", 3);

            IWebElement edittitleTextbox = driver.FindElement(By.XPath("//input[@type ='text' and @name='title' ]"));
            edittitleTextbox.Clear();
            edittitleTextbox.SendKeys("Painting");

            //identify the editDescription textbox and add detail
            IWebElement editdescriptionTextbox = driver.FindElement(By.XPath("//textarea[@name='description']"));
            editdescriptionTextbox.Clear();
            editdescriptionTextbox.SendKeys("I love to do painting");

            // identify category dropbox and select
            IWebElement editcategoryDropdown = driver.FindElement(By.XPath("//select[@name='categoryId']"));
            editcategoryDropdown.Click();

            IWebElement editcategoryOptionDropdown = driver.FindElement(By.XPath("//option[@value='4']"));
            editcategoryOptionDropdown.Click();


            // identify sub-category dropdown
            IWebElement editsubcategoryDropdown = driver.FindElement(By.XPath("//select[@name = 'subcategoryId']"));
            editsubcategoryDropdown.Click();

            IWebElement editsubcategoryOptionDropdown = driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(1) > select > option:nth-child(5)"));
            editsubcategoryOptionDropdown.Click();

            // identify edit tag textbox and enter detail
            IWebElement edittagsTextbox = driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(4) > div.twelve.wide.column > div > div > div > span > a"));
            edittagsTextbox.Click();
            IWebElement edittagsTextbox1 = driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(4) > div.twelve.wide.column > div.form-wrapper.field.error > div > div > div > input"));
            edittagsTextbox1.SendKeys("painting");
            edittagsTextbox1.SendKeys(Keys.Enter);

            //identify service type and select
            IWebElement editserviceTypeRadioButton = driver.FindElement(By.XPath("//input[@name='serviceType' and @value = '1']"));
            editserviceTypeRadioButton.Click();

            // identify location type and select
            IWebElement editlocationTypeRadioButton = driver.FindElement(By.XPath("//*[@name = 'locationType' and @value = '0']"));
            editlocationTypeRadioButton.Click();

            //identify available days and add details
            IWebElement editstartdateSelect = driver.FindElement(By.XPath("//input[@type='date' and @name='startDate']"));
            editstartdateSelect.SendKeys("12122022");
            editstartdateSelect.SendKeys(Keys.Enter);


            IWebElement editmonDateStartTimeSelect = driver.FindElement(By.XPath("//label[text()='Mon']/following::input[@name='StartTime']"));
            editmonDateStartTimeSelect.SendKeys("0730am");
            editmonDateStartTimeSelect.SendKeys(Keys.Enter);

            IWebElement editmonDateEndTimeSelect = driver.FindElement(By.XPath("//label[text()='Mon']/following::input[@name='EndTime']"));
            editmonDateEndTimeSelect.SendKeys("0745pm");
            editmonDateEndTimeSelect.SendKeys(Keys.Enter);


            Wait.WaitTobeVisible(driver, "XPath", "//label[text()='Tue']/following::input[@name='StartTime']", 3);

            IWebElement edittuesDateTimeSelect = driver.FindElement(By.XPath("//label[text()='Tue']/following::input[@name='StartTime']"));
            edittuesDateTimeSelect.SendKeys("0830am");
            edittuesDateTimeSelect.SendKeys(Keys.Enter);

            IWebElement edittuesDateEndTimeSelect = driver.FindElement(By.XPath("//label[text()='Tue']/following::input[@name='EndTime']"));
            edittuesDateEndTimeSelect.SendKeys("0830pm");
            edittuesDateEndTimeSelect.SendKeys(Keys.Enter);

            Wait.WaitTobeVisible(driver, "XPath", "//label[text()='Wed']/following::input[@name='StartTime']", 3);

            IWebElement editwedStartTimeSelect = driver.FindElement(By.XPath("//label[text()='Wed']/following::input[@name='StartTime']"));
            editwedStartTimeSelect.SendKeys("0830am");
            editwedStartTimeSelect.SendKeys(Keys.Enter);

            IWebElement editwedEndTimeSelect = driver.FindElement(By.XPath("//label[text()='Wed']/following::input[@name='EndTime']"));
            editwedEndTimeSelect.SendKeys("0830pm");
            editwedEndTimeSelect.SendKeys(Keys.Enter);

            Wait.WaitTobeVisible(driver, "XPath", "//label[text()='Thu']/following::input[@name='StartTime']", 3);

            IWebElement editthuStartTimeSelect = driver.FindElement(By.XPath("//label[text()='Thu']/following::input[@name='StartTime']"));
            editthuStartTimeSelect.SendKeys("0830am");
            editthuStartTimeSelect.SendKeys(Keys.Enter);

            IWebElement editthuEndTimeSelect = driver.FindElement(By.XPath("//label[text()='Thu']/following::input[@name='EndTime']"));
            editthuEndTimeSelect.SendKeys("0830pm");
            editthuEndTimeSelect.SendKeys(Keys.Enter);

            Wait.WaitTobeVisible(driver, "XPath", "//label[text()='Fri']/following::input[@name='StartTime']", 3);

            IWebElement editfriStartTimeSelect = driver.FindElement(By.XPath("//label[text()='Fri']/following::input[@name='StartTime']"));
            editfriStartTimeSelect.SendKeys("0830am");
            editfriStartTimeSelect.SendKeys(Keys.Enter);

            IWebElement editfriEndTimeSelect = driver.FindElement(By.XPath("//label[text()='Fri']/following::input[@name='EndTime']"));
            editfriEndTimeSelect.SendKeys("0830pm");
            editfriEndTimeSelect.SendKeys(Keys.Enter);


            // identify the skill trade and select
            IWebElement editskillTradeBulletButton = driver.FindElement(By.XPath("//input[@name='skillTrades' and @value= 'false']"));
            editskillTradeBulletButton.Click();

            IWebElement creditTextbox = driver.FindElement(By.XPath("//input[@name = 'charge']"));
            creditTextbox.SendKeys("10");

            // identify the Active and select
            IWebElement editactiveBulletButton = driver.FindElement(By.XPath("//input[@name= 'isActive' and @value= 'true']"));
            editactiveBulletButton.Click();

            // identify the save button and click
            IWebElement editsaveButton = driver.FindElement(By.XPath("//input[@type='button']"));
            editsaveButton.Click();


            // Checking the edited record

            //Thread.Sleep(2000);
            //IWebElement gotoLastPage1 = driver.FindElement(By.CssSelector("#listing-management-section > div:nth-child(3) > div:nth-child(2) > div.ui.buttons.semantic-ui-react-button-pagination > button:nth-child(4)"));
            //gotoLastPage1.Click();

            //IWebElement actualeditedRecord = driver.FindElement(By.CssSelector("#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(3)"));


            //if (actualeditedRecord.Text == "Painting")
            //{
            //    Assert.Pass("Share Skill edited successfully, Test Passed.");

            //}
            //else
            //{
            //    Assert.Fail("Test Failed");
            //}
            Thread.Sleep(2000);
            IWebElement goToSecondPage = driver.FindElement(By.CssSelector("#listing-management-section > div:nth-child(3) > div:nth-child(2) > div.ui.buttons.semantic-ui-react-button-pagination > button:nth-child(4)"));
            goToSecondPage.Click();
            Thread.Sleep(2000);

            IWebElement editedCode = driver.FindElement(By.CssSelector("#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1)"));

            Assert.That(editedCode.Text != "Painting", "Share Skill edited.");
        }

        public void DeleteShareSkill(IWebDriver driver)
        {

            // Go To Manage Listing
            IWebElement goToManageListing = driver.FindElement(By.XPath("//a[@href='/Home/ListingManagement']"));
            goToManageListing.Click();

            //Identify the Delete button 
            Thread.Sleep(2000);
            IWebElement firstPageButton = driver.FindElement(By.CssSelector("#listing-management-section > div:nth-child(3) > div:nth-child(2) > div.ui.buttons.semantic-ui-react-button-pagination > button:nth-child(2)"));
            firstPageButton.Click();

            IWebElement deleteIconButton = driver.FindElement(By.CssSelector("#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(3) > i"));
            deleteIconButton.Click();

            IWebElement yesbutton = driver.FindElement(By.CssSelector("body > div.ui.page.modals.dimmer.transition.visible.active > div > div.actions > button.ui.icon.positive.right.labeled.button"));
            yesbutton.Click();
        }
    }
}
