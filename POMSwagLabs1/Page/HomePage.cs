using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriver = SeleniumPOM.Driver.WebDriver;

namespace SeleniumPOM.Page;


public class HomePage
{
    private IWebDriver driver = WebDriver.Instance;

    public IWebElement SauceLabsBackpack => driver.FindElement(By.Id("item_4_img_link"));
    

}
