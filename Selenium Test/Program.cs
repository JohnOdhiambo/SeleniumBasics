using System;
using OpenQA.Selenium;
using OpenQA.Selenium.chrome;

namespace Selenium_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Instance/Reference of EdgeDriver browser
            IWebDriver driver = new EdgeDriver();

            //Navigate to the given url page
            driver.Navigate().GoToUrl("https://www.google.com/");
            //Webdriver finds element by name
            IWebElement ele = driver.FindElement(By.Name("q"));
            ele.Click();
            Thread.Sleep(3000);

            IWebElement ele1 = driver.FindElement(By.Name("btnK"));
            ele1.Click();
            Thread.Sleep(4000);

            driver.Close();
            Console.Write("Test Case ended");
            //Console.WriteLine("Hello World!");
        }
    }

    //Write Selenium Test using NUnit
    //Using NUnit.Framework - inbuilt Test attribute used to mark methods as callable
    //SetUp attribuute is used to identify a method that is to be called immediately, each test runs
    //TearDown attribute is used to identify a method to be called immediately after each test is executed. This method is called even if an execption occurs
    IWebDriver driver = new ChromeDriver();
    public void Initialize()
    {
        driver.Navigate().GoToUrl("https://www.facebook.com/");

        driver.Manage().Window.Maximize();
        Thread.Sleep(2000);
    }
    public void ExecuteTest()
    {
        IWebElement ele = driver.FindElement(By.Id("email"));

        ele.SendKeys("jay@gmail.com");
        Thread.Sleep(2000);
        Console.Write("username value is entered");

        IWebElement ele1 = driver.FindElement(By.Name("pass"));
        ele1.SendKeys("#######");
        Console.Write("password is entered");

        IWebElement ele2 = driver.FindElement(By.Id("loginid"));
        ele2.Click();
        Thread.Sleep(3000);
        Console.Write("login button is clicked");
    }
    public void EndTest()
    {
        driver.Close();
    }

    //Select class is used for selecting&deselcting option in a dropdown
    WebElement testDropDown = driver.findElement(By.id("testingDropDown"));
    Select dropdown = new Select(testDropDown);

}
