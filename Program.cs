


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SauceDemoTests
{
  class Program
  {
    static void Main(String[] args)
    {
      IWebDriver driver = new ChromeDriver();
      WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromDays(60));
      try
      {
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        // driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
        // driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
        // driver.FindElement(By.Id("login-button")).Click();

        // driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();

        // driver.FindElement(By.Id("Checkout")).Click();

        // driver.FindElement(By.Id("first-name")).SendKeys("John");
        // driver.FindElement(By.Id("last-name")).SendKeys("Doe");
        // driver.FindElement(By.Id("postal-code")).SendKeys("12345");
        // driver.FindElement(By.Id("continue")).Click();

        // driver.FindElement(By.Id("Finish")).Click();

        wait.Until(d => d.FindElement(By.Id("user_name"))).SendKeys("standard_user");
        wait.Until(d => d.FindElement(By.Id("password"))).SendKeys("standard_user");
        wait.Until(d => d.FindElement(By.Id("login-button"))).Click();

        wait.Until(d => d.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"))).Click();

        wait.Until(d => d.FindElement(By.ClassName("Shopping_cart_link"))).Click();

        wait.Until(d => d.FindElement(By.Id("checkout"))).Click();

        wait.Until(d => d.FindElement(By.Id("first_name"))).SendKeys("John");
        wait.Until(d => d.FindElement(By.Id("last_name"))).SendKeys("Doe");
        wait.Until(d => d.FindElement(By.Id("postal_code"))).SendKeys("12345");
        wait.Until(d => d.FindElement(By.Id("continue"))).Click();

        wait.Until(d => d.FindElement(By.Id("finish"))).Click();



        String confirmationMessage  = driver.FindElement(By.ClassName("complete-header")).Text;
        if(confirmationMessage == "THANK YOU FOR YOUR ORDER")
        {
          Console.WriteLine("Test passed: Purchase confirmed.");
        }
        else
        {
          Console.WriteLine("Test Failed: Purchase not confirmed.");
        }
      }
      catch(Exception e)
      {
        Console.WriteLine($"Test Failed: {e.Message}");
      }
      finally
      {
        driver.Quit();

      }
    
    }
  }
}