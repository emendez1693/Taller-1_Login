using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_1_Login.PageObject
{
    public class LoginPage
    {
        public IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            this._driver = driver;   //Este driver asignele el driver que viene para eso se usa el this                         
        }
        // readonly el valor de los elementos no cambien el valor durante el Test
        private readonly By _txtUserName = By.Id("username");
        private readonly By _txtPassword = By.Id("password");
        private readonly By _btnLogin = By.CssSelector("#login button");

        //le vamos a decir a seleniu que los elementos declarados tenemos que interacturar con ellos
        public IWebElement username => _driver.FindElement(_txtUserName); //=> simplifica el código
        public IWebElement password => _driver.FindElement(_txtPassword);
        public IWebElement btnlogin => _driver.FindElement(_btnLogin);

        public void IngresarCredenciales() 
        {
            //Localizadores: identifiación los elementos del DOM 
            //selenium tiene un orden de prioridad, el ID es el primero ya que es único 
            username.SendKeys("tomsmith");
            password.SendKeys("SuperSecretPassword!");
            btnlogin.Click();   
        
        }

    }
}
