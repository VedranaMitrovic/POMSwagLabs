using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriver = SeleniumPOM.Driver.WebDriver;

namespace SeleniumPOM.Page;


     public class ProductPage
     {
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement AddToCart => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement BackToProducts => driver.FindElement(By.Id("back-to-products"));

      }
