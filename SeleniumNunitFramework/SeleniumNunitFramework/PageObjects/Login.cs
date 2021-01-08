﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitFramework.PageObjects
{
    public class Login
    {

        IWebDriver driver;
        public Login(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How=How.Id,Using = "input-email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Id, Using = "input-password")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/div/div[2]/div/form/input")]
        public IWebElement loginbutton { get; set; }


        public MyAccount NavigateToMyAccount()
        {
            email.SendKeys("sibtainsyed94@gmail.com");
            password.SendKeys("12345678");
            loginbutton.Click();
            return new MyAccount(driver);

        }



    }
}
