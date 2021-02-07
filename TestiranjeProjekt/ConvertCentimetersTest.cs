using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace TestiranjeProjekt
{
    
    [TestFixture]
    public class ConvertCentimetersTest
    {
        private IWebDriver driver;
        public string enterValue = "1000";
        public string valueInKilometers, valueInMeters, valueInCentimeters, 
            valueInMilimeters, valueInMicrometers, valueInNanometer, 
            valueInMiles, valueInYards,  valueInFoots, valueInInchs, 
            valueInLightYears;
        ConvertCentimeters converter = new ConvertCentimeters();

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void CentimeterToMeterTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.calculator.net/conversion-calculator.html");
            new SelectElement(driver.FindElement(By.Id("calFrom"))).SelectByText("Centimeter");
            driver.FindElement(By.XPath("//option[@value='3']")).Click();
            driver.FindElement(By.XPath("(//option[@value='1'])[2]")).Click();
            driver.FindElement(By.Name("fromVal")).Click();
            driver.FindElement(By.Name("fromVal")).Clear();
            driver.FindElement(By.Name("fromVal")).SendKeys(enterValue);
            valueInMeters = driver.FindElement(By.Name("toVal")).GetAttribute("value");
            double expected = converter.CentimeterToMeter(Convert.ToInt32(enterValue));
            double actual = Double.Parse(valueInMeters, System.Globalization.CultureInfo.InvariantCulture);
            Assert.AreEqual(Math.Round(expected, 5), Math.Round(actual, 5));
        }
        [Test]
        public void CentimeterToKilometerTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.calculator.net/conversion-calculator.html");
            new SelectElement(driver.FindElement(By.Id("calFrom"))).SelectByText("Centimeter");
            driver.FindElement(By.XPath("//option[@value='3']")).Click();
            driver.FindElement(By.Name("fromVal")).Click();
            driver.FindElement(By.Name("fromVal")).Clear();
            driver.FindElement(By.Name("fromVal")).SendKeys(enterValue);
            driver.FindElement(By.XPath("(//option[@value='2'])[2]")).Click();
            valueInKilometers = driver.FindElement(By.Name("toVal")).GetAttribute("value");
            double expected = converter.CentimeterToKilometer(Convert.ToInt32(enterValue));
            double actual = Double.Parse(valueInKilometers, System.Globalization.CultureInfo.InvariantCulture);
            Assert.AreEqual(Math.Round(expected, 5), Math.Round(actual, 5));
        }
        [Test]
        public void CentimeterToMilimeterTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.calculator.net/conversion-calculator.html");
            new SelectElement(driver.FindElement(By.Id("calFrom"))).SelectByText("Centimeter");
            driver.FindElement(By.XPath("//option[@value='3']")).Click();
            driver.FindElement(By.Name("fromVal")).Click();
            driver.FindElement(By.Name("fromVal")).Clear();
            driver.FindElement(By.Name("fromVal")).SendKeys(enterValue);
            driver.FindElement(By.XPath("(//option[@value='4'])[2]")).Click();
            valueInMilimeters = driver.FindElement(By.Name("toVal")).GetAttribute("value");
            double expected = converter.CentimeterToMilimeter(Convert.ToInt32(enterValue));
            double actual = Double.Parse(valueInMilimeters, System.Globalization.CultureInfo.InvariantCulture);
            Assert.AreEqual(Math.Round(expected, 5), Math.Round(actual, 5));
        }
        [Test]
        public void CentimeterToMicrometerTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.calculator.net/conversion-calculator.html");
            new SelectElement(driver.FindElement(By.Id("calFrom"))).SelectByText("Centimeter");
            driver.FindElement(By.XPath("//option[@value='3']")).Click();
            driver.FindElement(By.Name("fromVal")).Click();
            driver.FindElement(By.Name("fromVal")).Clear();
            driver.FindElement(By.Name("fromVal")).SendKeys(enterValue);
            driver.FindElement(By.XPath("(//option[@value='5'])[2]")).Click();
            valueInMicrometers = driver.FindElement(By.Name("toVal")).GetAttribute("value");
            double expected = converter.CentimeterToMicrometer(Convert.ToInt32(enterValue));
            double actual = Double.Parse(valueInMicrometers, System.Globalization.CultureInfo.InvariantCulture);
            Assert.AreEqual(Math.Round(expected, 5), Math.Round(actual, 5));
        }
        [Test]
        public void CentimeterToNanometerTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.calculator.net/conversion-calculator.html");
            new SelectElement(driver.FindElement(By.Id("calFrom"))).SelectByText("Centimeter");
            driver.FindElement(By.XPath("//option[@value='3']")).Click();
            driver.FindElement(By.Name("fromVal")).Click();
            driver.FindElement(By.Name("fromVal")).Clear();
            driver.FindElement(By.Name("fromVal")).SendKeys(enterValue);
            driver.FindElement(By.XPath("(//option[@value='6'])[2]")).Click();
            valueInNanometer = driver.FindElement(By.Name("toVal")).GetAttribute("value");
            double expected = converter.CentimeterToNanometer(Convert.ToInt32(enterValue));
            double actual = Double.Parse(valueInNanometer, System.Globalization.CultureInfo.InvariantCulture);
            Assert.AreEqual(Math.Round(expected, 5), Math.Round(actual, 5));
        }
        [Test]
        public void CentimeterToMileTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.calculator.net/conversion-calculator.html");
            new SelectElement(driver.FindElement(By.Id("calFrom"))).SelectByText("Centimeter");
            driver.FindElement(By.XPath("//option[@value='3']")).Click();
            driver.FindElement(By.Name("fromVal")).Click();
            driver.FindElement(By.Name("fromVal")).Clear();
            driver.FindElement(By.Name("fromVal")).SendKeys(enterValue);
            driver.FindElement(By.XPath("(//option[@value='7'])[2]")).Click();
            valueInMiles = driver.FindElement(By.Name("toVal")).GetAttribute("value");
            double expected = converter.CentimeterToMile(Convert.ToInt32(enterValue));
            double actual = Double.Parse(valueInMiles, System.Globalization.CultureInfo.InvariantCulture);
            Assert.AreEqual(Math.Round(expected, 5), Math.Round(actual, 5));
        }
        [Test]
        public void CentimeterToFootTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.calculator.net/conversion-calculator.html");
            new SelectElement(driver.FindElement(By.Id("calFrom"))).SelectByText("Centimeter");
            driver.FindElement(By.XPath("//option[@value='3']")).Click();
            driver.FindElement(By.Name("fromVal")).Click();
            driver.FindElement(By.Name("fromVal")).Clear();
            driver.FindElement(By.Name("fromVal")).SendKeys(enterValue);
            driver.FindElement(By.XPath("(//option[@value='9'])[2]")).Click();
            valueInFoots = driver.FindElement(By.Name("toVal")).GetAttribute("value");
            double expected = converter.CentimeterToFoot(Convert.ToInt32(enterValue));
            double actual = Double.Parse(valueInFoots, System.Globalization.CultureInfo.InvariantCulture);
            Assert.AreEqual(Math.Round(expected, 5), Math.Round(actual, 5));
        }
        [Test]
        public void CentimeterToYardTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.calculator.net/conversion-calculator.html");
            new SelectElement(driver.FindElement(By.Id("calFrom"))).SelectByText("Centimeter");
            driver.FindElement(By.XPath("//option[@value='3']")).Click();
            driver.FindElement(By.XPath("(//option[@value='8'])[2]")).Click();
            driver.FindElement(By.Name("fromVal")).Click();
            driver.FindElement(By.Name("fromVal")).Clear();
            driver.FindElement(By.Name("fromVal")).SendKeys(enterValue);
            valueInYards = driver.FindElement(By.Name("toVal")).GetAttribute("value");
            double expected = converter.CentimeterToYard(Convert.ToInt32(enterValue));
            double actual = Double.Parse(valueInYards, System.Globalization.CultureInfo.InvariantCulture);
            Assert.AreEqual(Math.Round(expected, 5), Math.Round(actual, 5));
        }
        [Test]
        public void CentimeterToInchTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.calculator.net/conversion-calculator.html");
            new SelectElement(driver.FindElement(By.Id("calFrom"))).SelectByText("Centimeter");
            driver.FindElement(By.XPath("//option[@value='3']")).Click();
            driver.FindElement(By.Name("fromVal")).Click();
            driver.FindElement(By.Name("fromVal")).Clear();
            driver.FindElement(By.Name("fromVal")).SendKeys(enterValue);
            driver.FindElement(By.XPath("(//option[@value='10'])[2]")).Click();
            valueInInchs = driver.FindElement(By.Name("toVal")).GetAttribute("value");
            double expected = converter.CentimeterToInch(Convert.ToInt32(enterValue));
            double actual = Double.Parse(valueInInchs, System.Globalization.CultureInfo.InvariantCulture);
            Assert.AreEqual(Math.Round(expected, 5), Math.Round(actual, 5));
        }
        [Test]
        public void CentimeterToLightYearTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.calculator.net/conversion-calculator.html");
            new SelectElement(driver.FindElement(By.Id("calFrom"))).SelectByText("Centimeter");
            driver.FindElement(By.XPath("//option[@value='3']")).Click();
            driver.FindElement(By.Name("fromVal")).Click();
            driver.FindElement(By.Name("fromVal")).Clear();
            driver.FindElement(By.Name("fromVal")).SendKeys(enterValue);
            driver.FindElement(By.XPath("(//option[@value='11'])[2]")).Click();
            valueInLightYears = driver.FindElement(By.Name("toVal")).GetAttribute("value");
            double expected = converter.CentimeterToLightYear(Convert.ToInt32(enterValue));
            double actual = Double.Parse(valueInLightYears, System.Globalization.CultureInfo.InvariantCulture);
            Assert.AreEqual(Math.Round(expected, 5), Math.Round(actual, 5));
        }
    }
}
