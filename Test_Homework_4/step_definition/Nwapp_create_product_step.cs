using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CucumberMessages;
using Test_Homework_6.business_object;
using Test_Homework_6.service.ui_service;

namespace Test_Homework_6.step_definition
{
    [Binding]
    class LoginSteps
    {
        private IWebDriver driver;
        private NewProduct cakePops = new NewProduct("Cake pops", "Confections", "Specialty Biscuits, Ltd.",
                              "15", "2 boxes x 7 pieces", "20", "0", "10");

        [Given(@"I am at the login page")]
                public void GivenIAmAtTheLoginPage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http:\\localhost:5000");
            driver.Manage().Window.Maximize();
        }

        [When(@"I type in fields username and password")]

        public void WhenITypeInFieldUsername()
        {
            new LoginPage(driver).InputUserData("user", "user");
        }

        [When(@"I click the login button")]
        public void WhenIClickLoginButton()
        {
            new LoginPage(driver).ResultLoginPage();
        }

        [When(@"I click the allproducts text")]
        public void WhenIClickTHEallProductsText()
        {
            new HomePage(driver).HomePageToAllProductsPage();
        }
        
        [When(@"I open createNew page")]
        public void WhenIOpenCreateNewPage()
        {
            new AllProductsPage(driver).createNewPage();
        }

        [When(@"I create the new product")]
        public void WhenICreateTheNewProduct()
        {
            new CreateNewPage(driver).CreateNewProduct(cakePops);
        }

        [Then(@"I have to make sure that the new product is on the allProducts page")]
        public void ThenIHaveToMakeSureThatTheNewProductIsOnTheAllProductsPage()
        {
            Assert.AreEqual("Cake pops", new AllProductsPage(driver).GetNameNewProduct("Cake pops"));
        }
    }
}
