
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestiranjeProjekt
{
    class OpeningAllConvertersTest
    {
        private IWebDriver driver;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
        }
        [Test]
            public void OpeningAllCalculatorsTest()
            {
                driver.Navigate().GoToUrl("https://www.calculator.net/");
                driver.FindElement(By.LinkText("Mortgage Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Loan Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Auto Loan Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Interest Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Payment Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Retirement Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Amortization Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Investment Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Inflation Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Finance Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Income Tax Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Compound Interest Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Compound Interest Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Salary Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Interest Rate Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Interest Rate Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Sales Tax Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("BMI Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Calorie Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Body Fat Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("BMR Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Ideal Weight Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Pace Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Pregnancy Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Pregnancy Conception Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Due Date Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Scientific Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Fraction Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Percentage Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Random Number Generator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Triangle Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Standard Deviation Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Age Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Date Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Time Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Hours Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("GPA Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Grade Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Concrete Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Subnet Calculator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Password Generator")).Click();
                driver.Navigate().Back();
                driver.FindElement(By.LinkText("Conversion Calculator")).Click();
            }
        }
    }
