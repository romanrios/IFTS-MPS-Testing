namespace SeleniumLoginTest;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


public class Tests
{

    private IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://example.com/login");
        driver.Manage().Window.Maximize();
    }

    [Test]
    public void TestLogin()
    {
        driver.Navigate().GoToUrl("file:///H:/Mi unidad/IFTS_2025/MPS_testing/IFTS-MPS-Testing/SeleniumLogin/SeleniumLoginTest/login.html");

        IWebElement usernameField = driver.FindElement(By.Id("username"));
        IWebElement passwordField = driver.FindElement(By.Id("password"));
        IWebElement loginButton = driver.FindElement(By.Id("loginButton"));

        usernameField.SendKeys("admin");
        passwordField.SendKeys("1234");
        loginButton.Click();

        System.Threading.Thread.Sleep(2000);

        Assert.That(driver.Url, Is.EqualTo("file:///H:/Mi%20unidad/IFTS_2025/MPS_testing/IFTS-MPS-Testing/SeleniumLogin/SeleniumLoginTest/success.html"));

        Assert.That(driver.PageSource.Contains("Formulario completado exitosamente"), Is.True);
    }

    [TearDown]
    public void TearDown()
    {
        if (driver != null)
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
