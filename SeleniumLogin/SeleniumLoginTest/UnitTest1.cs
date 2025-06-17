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
        // driver.Navigate().GoToUrl("https://example.com/login");
        // driver.Manage().Window.Maximize();
    }

    [Test]
    public void LoginCorrecto()
    {
        try
        {
            driver.Navigate().GoToUrl("file:///H:/Mi unidad/IFTS_2025/MPS_testing/IFTS-MPS-Testing/SeleniumLogin/SeleniumLoginTest/login.html");

            IWebElement usernameField = driver.FindElement(By.Id("username"));
            IWebElement passwordField = driver.FindElement(By.Id("password"));
            IWebElement loginButton = driver.FindElement(By.Id("loginButton"));

            usernameField.SendKeys("admin");
            passwordField.SendKeys("1234");
            loginButton.Click();

            System.Threading.Thread.Sleep(2000);

            // Assert.That(driver.Url, Is.EqualTo("file:///H:/Mi%20unidad/IFTS_2025/MPS_testing/IFTS-MPS-Testing/SeleniumLogin/SeleniumLoginTest/success.html"));
            Assert.That(driver.Url.EndsWith("success.html"), "La URL esperada no coincide con la URL actual.");
            Assert.That(driver.PageSource.Contains("Formulario completado exitosamente"), Is.True);
        }
        catch (Exception e)
        {
            Assert.Fail($"Fallo Test LoginCorrecto: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Test LoginCorrecto ejecutado...");
        }   
    }



    [Test]
    public void LoginConUsuarioVacio()
    {
        try
        {
            driver.Navigate().GoToUrl("file:///H:/Mi unidad/IFTS_2025/MPS_testing/IFTS-MPS-Testing/SeleniumLogin/SeleniumLoginTest/login.html");

            IWebElement usernameField = driver.FindElement(By.Id("username"));
            IWebElement passwordField = driver.FindElement(By.Id("password"));
            IWebElement loginButton = driver.FindElement(By.Id("loginButton"));

            usernameField.SendKeys("");
            passwordField.SendKeys("1234");
            loginButton.Click();

            System.Threading.Thread.Sleep(2000);

            Assert.That(driver.Url.EndsWith("login.html"), "No se debería haber redirigido.");
        }
        catch (Exception e)
        {
            Assert.Fail($"Fallo Test LoginConUsuarioVacio: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Test LoginConUsuarioVacio ejecutado...");
        }   
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
