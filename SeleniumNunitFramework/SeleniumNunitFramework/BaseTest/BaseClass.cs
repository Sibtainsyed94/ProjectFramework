using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace SeleniumNunitFramework.BaseTest
{
    public class BaseClass
    {

        public IWebDriver driver;

        [OneTimeSetUp]

        public void open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //var URL = ConfigurationManager.AppSettings["URL"];

            driver.Url = "https://demo.opencart.com/index.php?route=account/login";


        }


        [OneTimeTearDown]
     public void close()
     {
            //driver.Quit();

     }

    }
}
