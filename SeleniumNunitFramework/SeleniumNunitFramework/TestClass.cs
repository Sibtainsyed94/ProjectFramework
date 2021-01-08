// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumNunitFramework.BaseTest;

namespace SeleniumNunitFramework
{
    [TestFixture]
    public class TestClass : BaseClass
    {


        [Test,Order(1),Category("LoginTest")]
        public void TestMethod()

        {
         driver.FindElement(By.Id("txtusername")).SendKeys("30442293");

        }
    }

}


