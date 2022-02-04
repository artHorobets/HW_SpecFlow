using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Xunit;
using OpenQA.Selenium.Support;
using System.Threading;

namespace HW_SpecFlow
{
    [Binding]

 //Background
    public class SearchCarsOnSiteStepDefinitions
    {
        [Given(@"user on the AUTO\.RIA homepage")]
        public void GivenUserOnTheAUTO_RIAHomepage()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl("https://auto.ria.com/uk/");
        }

        //Scenario: advanced search

        [When(@"user clicks on the button '([^']*)'")]
        public void WhenUserClicksOnTheButton(string p0)
        {
            Driver.driver.FindElement(By.XPath("//form[@id='mainSearchForm']/div[3]/a/span")).Click();
        }

        [Then(@"user reside at on the screen page with title '([^']*)'")]
        public void ThenUserResideAtOnTheScreenPageWithTitle(string p0)
        {
            IWebElement element = Driver.driver.FindElement(By.XPath("//h1[contains(.,'Розширений пошук вживаних авто')]"));
            string expected = element.Text;
            Assert.Equal("Розширений пошук вживаних авто", expected);
            Driver.driver.Quit();
        }

        ////Scenario: search passenger cars

        [When(@"user select ""([^""]*)"" on tab '([^']*)'")]
        public void WhenUserSelectOnTab(string автобуси, string транспорт)
        {
            IWebElement element = Driver.driver.FindElement(By.Name("category_id"));
            element.Click();
            element.SendKeys("Легкові");
            Thread.Sleep(2000);
            element.SendKeys(Keys.Enter);
        }

        [When(@"user clicks on element '([^']*)'")]
        public void WhenUserClicksOnElement(string пошук)
        {
            Driver.driver.FindElement(By.XPath("//button/span")).Click();
            Thread.Sleep(2000);
        }

        [Then(@"user sees on the screen page with message '([^']*)'")]
        public void ThenUserSeesOnTheScreenPageWithMessage(string p0)
        {
            IWebElement element = Driver.driver.FindElement(By.XPath("//h1[contains(.,'Продаж Легкових авто')]"));
            string expected = element.Text;
            Assert.Equal("Продаж Легкових авто", expected);
            Driver.driver.Quit();
        }

        ////Scenario: search only new cars in Kiev

        [When(@"user clicks on button_icon '([^']*)'")]
        public void WhenUserClicksOnButton_Icon(string p0)
        {
            Driver.driver.FindElement(By.XPath("//div[@id='header']/header/div[3]/div[2]/ul/li[2]/a")).Click();
        }

        [When(@"user select ""([^""]*)"" on select_tab '([^']*)'")]
        public void WhenUserSelectOnSelect_Tab(string p0, string від)
        {
            IWebElement element = Driver.driver.FindElement(By.Name("priceFrom"));
            element.Click();
            element.SendKeys("10000");
        }

        [When(@"user select ""([^""]*)"" on choose_tab '([^']*)'")]
        public void WhenUserSelectOnChoose_Tab(string p0, string до)
        {
            IWebElement element = Driver.driver.FindElement(By.Name("priceTo"));
            element.Click();
            element.SendKeys("30000");
            element.SendKeys(Keys.Enter);
        }

        [Then(@"user sees on the main_page text '([^']*)'")]
        public void ThenUserSeesOnTheMain_PageText(string p0)
        {
            IWebElement element = Driver.driver.FindElement(By.XPath("//strong[contains(.,'Нові авто в Україні')]"));
            string expected = element.Text;
            Assert.Equal("Нові авто в Україні", expected);
            Driver.driver.Quit();
        }

        //Scenario: search cars type like electric 

        [When(@"user cliks_on button_icon '([^']*)'")]
        public void WhenUserCliks_OnButton_Icon(string новини)
        {
            Driver.driver.FindElement(By.CssSelector(".nav-list_item:nth-child(3) > .elem-tab")).Click();
        }

        [When(@"user clicks on button_option '([^']*)'")]
        public void WhenUserClicksOnButton_Option(string акції)
        {
            Driver.driver.FindElement(By.CssSelector(".news-nav-btn:nth-child(6)")).Click();
        }

        [Then(@"user sees title on choosen page '([^']*)'")]
        public void ThenUserSeesTitleOnChoosenPage(string p0)
        {
            IWebElement element = Driver.driver.FindElement(By.CssSelector(".label-hot"));
            string expected = element.Text;
            Assert.Equal("На правах реклами", expected);
            Driver.driver.Quit();
        }
    }
}
