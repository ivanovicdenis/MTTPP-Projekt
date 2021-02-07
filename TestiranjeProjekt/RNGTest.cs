using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestiranjeProjekt
{
    class RNGTest
    {
        private IWebDriver driver;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void RandomNumberGeneratorTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.calculator.net/");
            driver.FindElement(By.LinkText("Random Number Generator")).Click();
            driver.FindElement(By.Name("submit1")).Click();
            driver.FindElement(By.Name("submit1")).Click();
            driver.FindElement(By.Name("submit1")).Click();
            driver.FindElement(By.Name("submit1")).Click();
            driver.FindElement(By.Name("submit1")).Click();
        }
        
    }
}
