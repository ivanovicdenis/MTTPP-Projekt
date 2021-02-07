using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace TestiranjeProjekt
{
    [TestFixture]
    public class AgeCalculatorTest
    {
        private IWebDriver driver;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void FindAgeCalculatorTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.calculator.net/");
            driver.FindElement(By.Id("calcSearchTerm")).Click();
            driver.FindElement(By.Id("calcSearchTerm")).Clear();
            driver.FindElement(By.Id("calcSearchTerm")).SendKeys("Age Calculator");
            driver.FindElement(By.Id("bluebtn")).Click();
            driver.FindElement(By.LinkText("Age Calculator")).Click();
        }
        [Test]
        public void AgeCalculatorFunctionTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.calculator.net/");
            driver.FindElement(By.LinkText("Age Calculator")).Click();
            driver.FindElement(By.Id("today_Month_ID")).Click();
            new SelectElement(driver.FindElement(By.Id("today_Month_ID"))).SelectByText("Aug");
            driver.FindElement(By.XPath("//option[@value='7']")).Click();
            driver.FindElement(By.Id("today_Day_ID")).Click();
            new SelectElement(driver.FindElement(By.Id("today_Day_ID"))).SelectByText("28");
            driver.FindElement(By.XPath("//select[@id='today_Day_ID']/option[28]")).Click();
            driver.FindElement(By.Id("today_Year_ID")).Click();
            driver.FindElement(By.Id("today_Year_ID")).Clear();
            driver.FindElement(By.Id("today_Year_ID")).SendKeys("1998");
            driver.FindElement(By.XPath("//input[@value='Calculate']")).Click();
        }
    }
}
