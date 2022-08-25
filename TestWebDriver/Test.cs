using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebDriver
{
    internal class Test
    {
        IWebDriver driver;

        public object SeleniumExtras { get; private set; }

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void test()
        {
            driver.Url = "http://www.google.co.in";
            Console.WriteLine("a");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            
            IWebElement img = driver.FindElement(By.TagName("img"));
            Assert.IsNotNull(img);
            Assert.IsNotNull(img.GetAttribute("src"));


        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
