using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Test_Homework_6
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        private IWebElement loginField => driver.FindElement(By.Id("Name"));
        private IWebElement passwordField => driver.FindElement(By.Id("Password"));

        //Метод вводит логин и пароль на странице Login.
        public LoginPage InputUserData (string userName, string userPassword)
        {
            new Actions(driver).Click(loginField).SendKeys(userName).Build().Perform();
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
            new Actions(driver).Click(passwordField).SendKeys(userPassword).Build().Perform();
            return new LoginPage(driver);
        }
        private IWebElement loginButton => driver.FindElement(By.CssSelector(".btn"));
        // Метод нажимает кнопку "Отправить" на странице Логин.
        public HomePage ResultLoginPage()
        {
            new Actions(driver).Click(loginButton).Build().Perform();
            return new HomePage(driver);
        }
        private IWebElement nameLoginPage => driver.FindElement(By.XPath("/html/body/div[1]/h2"));
        public string GetNameLoginPage()  //Метод  возвращает название страницы Login.
        {
            return nameLoginPage.Text;
        }

    }
}
