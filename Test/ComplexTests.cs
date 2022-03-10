using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Task2022.Pages;
using Task2022.Utilities;

namespace Task2022
{
    [TestFixture]
    class ComplexTests : CommonDriver
    {
  
   [SetUp]
        public void LoginFunction()
        {
            driver = new ChromeDriver();
            // Login Page object initialization and definition
            LoginPage loginPage = new LoginPage();
            loginPage.LoginSteps(driver);

            // Home Page object initialization and definition
            HomePage homePage = new HomePage();
            homePage.GoToShareSkillPage(driver);

        }
        [Test, Order (1)]
        public void Create_ShareSkill()
        {
            // ShareSkill Page object initialization and definition
            ShareSkillPage shareSkillPageobj = new ShareSkillPage();
            shareSkillPageobj.CreateShareSkill(driver);
        }

        [Test, Order (2)]
        public void View_ShareSkill()
        {
            ManageListing manageListingobj = new ManageListing();
            manageListingobj.ViewShareSkill(driver);
        }


        [Test, Order (3)]
        public void Edit_ShareSkill()
        {
            // Edit ShareSkill
            ManageListing manageListingobj = new ManageListing();
            manageListingobj.EditShareSkill(driver);

        }
        [Test, Order (4)]
        public void Delete_ShareSkill()
        {
            //Delete ShareSkill
            ManageListing manageListingobj = new ManageListing();
            manageListingobj.DeleteShareSkill(driver);

        }
        [TearDown]
        public void CloseTestRun()
        {
         driver.Quit();
        }
    }
}
