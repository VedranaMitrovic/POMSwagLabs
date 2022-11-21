using NUnit.Framework;
using SeleniumPOM.Driver;
using SeleniumPOM.Page;

namespace SeleniumPOM;

public class TestClass
{
    private LoginPage _loginPage;
    private HomePage _homePage;
    private ProductPage _productPage;

    [SetUp]

    public void BeforeScenario()
    {
        WebDriver.Initialize();
        _loginPage = new LoginPage();
        _homePage = new HomePage();
        _productPage = new ProductPage();

    }

    [TearDown]
    public void AfterScenario()
    {
        WebDriver.CleanUp();
    }


    [Test]

    public void TC01_AddBackpackToCart_BackpackShouldBeAdded()
    {

        Login("standard_user", "secret_sauce");
        _homePage.SauceLabsBackpack.Click();
        _productPage.AddToCart.Click();
        _productPage.BackToProducts.Click();



    }

 


    public void Login(string name, string pass)
    {
        _loginPage.LoginOnPage(name, pass);
    }
}