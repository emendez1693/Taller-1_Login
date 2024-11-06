using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Taller_1_Login.PageObject;

namespace Taller_1_Login.Test
{
    //[TestFixture("emendez", "SuperSecretPassword!")] variable global para pasar los parámetros para todos los test
    public class Tests
    {
        public IWebDriver driver; //se necesita selenium para interacturar con el navegador o con la apicación.
        public LoginPage loginPage;


        [SetUp]
        public void IniciarNavegador()
        {

            //tiene todos los componentes de selenium
            driver = new ChromeDriver();
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
        [Category ("Regresión)")]
        [Order(1)]// Propiedad para ordenar las pruebas
        [TestCase ("tomsmith", "SuperSecretPassword!")] // Definición de parámetross
        [TestCase("emendez", "SuperSecretPassword!")]
        [TestCase("emendez", "pass!")]
        [Test]
        public void IngresoCorrecto(String user, String pass)
        {

            loginPage.IngresarCredenciales(user,pass);
        }

        

    }
}