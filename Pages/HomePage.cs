using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2022.Pages
{
   class HomePage
    {
        public void GoToShareSkillPage(IWebDriver driver)
        {
            // Click on Share Skill button 
            Thread.Sleep(3000);
            IWebElement shareSkillButton = driver.FindElement(By.XPath("//a[@class='ui basic green button']"));
            shareSkillButton.Click();
        }
    }
}
