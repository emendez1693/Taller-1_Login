using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Taller_1_Login
{
    public class Tests
    {
        

        [Test]
        public void IngresoCorrecto()
        {
            IWebDriver driver = new ChromeDriver(); //se necesita selenium para interacturar con el navegador o con la apicación.
                                                    //tiene todos los componentes de selenium
            driver.Manage().Window.Maximize();      //buena práctica pruebas e2e navegador maximizado
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login"); //metotodos lleban paréntesis

            //Localizadores: identifiación los elementos del DOM 
            //selenium tiene un orden de prioridad, el ID es el primero ya que es único 

            driver.FindElement(By.Id("username")).SendKeys("tomsmith");
            driver.FindElement(By.Id("password")).SendKeys("SuperSecretPassword!");
            driver.FindElement(By.CssSelector("#login button")).Click();



            // una buena práctica es cerrrar el navegador y posterior cerrar el driver
            driver.Close();
            driver.Quit();


        }
    }
}