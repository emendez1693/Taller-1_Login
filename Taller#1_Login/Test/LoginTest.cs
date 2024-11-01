using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Taller_1_Login.PageObject;

namespace Taller_1_Login.Test
{
    public class Tests
    {
        public IWebDriver driver = new ChromeDriver(); //se necesita selenium para interacturar con el navegador o con la apicación.
        public LoginPage loginPage;


        [SetUp]
        public void IniciarNavegador()
        {

            //tiene todos los componentes de selenium
            driver.Manage().Window.Maximize();      //buena práctica pruebas e2e navegador maximizado
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login"); //metotodos lleban paréntesis
            loginPage = new LoginPage(driver);
        }


        
        
        [TearDown]
        public void CerrarNavegador()
        {
            // una buena práctica es cerrrar el navegador y posterior cerrar el driver
            driver.Close();
            driver.Quit();

        }
        [Test]
        public void IngresoCorrecto()
        {

            loginPage.IngresarCredenciales();
        }
        [Test]
        public void IngresoIncorrecto()
        {
            loginPage.IngresarCredenciales();

            //driver.FindElement(By.Id("username")).SendKeys("emendez");
            //Thread.Sleep(500);
            //driver.FindElement(By.Id("password")).SendKeys("SuperSecretPassword!");
            //Thread.Sleep(500);
            //driver.FindElement(By.CssSelector("#login button")).Click();
            //Thread.Sleep(500);


        }
    }
}