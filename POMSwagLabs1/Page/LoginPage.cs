using OpenQA.Selenium;
using WebDriver = SeleniumPOM.Driver.WebDriver;

namespace SeleniumPOM.Page
{
    public class LoginPage
    {

        private IWebDriver driver = WebDriver.Instance;

        public IWebElement Username => driver.FindElement(By.Id("user-name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement Login => driver.FindElement(By.Id("login-button"));

        public void LoginOnPage(string name, string password)
        {
            Username.SendKeys(name);
            Password.SendKeys(password);
            Login.Submit();
        }
    }
}
