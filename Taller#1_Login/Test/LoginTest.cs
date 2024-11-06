using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Taller_1_Login.PageObject;

namespace Taller_1_Login.Test
{
    //[TestFixture("emendez", "SuperSecretPassword!")] variable global para pasar los par�metros para todos los test
    public class Tests
    {
        public IWebDriver driver; //se necesita selenium para interacturar con el navegador o con la apicaci�n.
        public LoginPage loginPage;


        [SetUp]
        public void IniciarNavegador()
        {

            //tiene todos los componentes de selenium
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();      //buena pr�ctica pruebas e2e navegador maximizado
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login"); //metotodos lleban par�ntesis
            loginPage = new LoginPage(driver);
        }
        
        [TearDown]
        public void CerrarNavegador()
        {
            // una buena pr�ctica es cerrrar el navegador y posterior cerrar el driver
            driver.Close();
            driver.Quit();

        }
        [Category ("Regresi�n)")]
        [Order(1)]// Propiedad para ordenar las pruebas
        [TestCase ("tomsmith", "SuperSecretPassword!")] // Definici�n de par�metross
        [TestCase("emendez", "SuperSecretPassword!")]
        [TestCase("emendez", "pass!")]
        [Test]
        public void IngresoCorrecto(String user, String pass)
        {

            loginPage.IngresarCredenciales(user,pass);
        }

        

    }
}