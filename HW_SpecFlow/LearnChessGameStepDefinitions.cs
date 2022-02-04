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
    public class LearnChessGameStepDefinitions
    {
       //Background:

        [Given(@"user on the chess\.com homepage")]
        public void GivenUserOnTheChess_ComHomepage()
        {
            Chrome.chrome = new ChromeDriver();
            Chrome.chrome.Navigate().GoToUrl("https://www.chess.com/");
            Chrome.chrome.Manage().Window.FullScreen();
        }

        //Scenario: deside chess puzzle rush

        [When(@"user clicks on button '([^']*)'")]
        public void WhenUserClicksOnButton(string puzzle)
        {
            Chrome.chrome.FindElement(By.XPath("//div[@id='sb']/div[2]/a[3]/span")).Click();
            Chrome.chrome.Manage().Window.FullScreen();
        }

        [When(@"user clicks on element_a '([^']*)'")]
        public void WhenUserClicksOnElement_A(string p0)
        {
            Chrome.chrome.FindElement(By.XPath("//div[@id='board-layout-sidebar']/div/div/div[2]/div/button[2]/div/div")).Click();
        }

        [Then(@"user watch messageon the screen page '([^']*)'")]
        public void ThenUserWatchMessageonTheScreenPage(string p0)
        {
            IWebElement element = Chrome.chrome.FindElement(By.XPath("//div[@id='board-layout-sidebar']/div/div/div/div/h1"));
            string expected = element.Text;
            Assert.Equal("Puzzle Rush", expected);
            Chrome.chrome.Quit();
        }

        //Scenario: search news about chess players

        [When(@"user input '([^']*)' in search field")]
        public void WhenUserInputInSearchField(string news)
        {
            Chrome.chrome.Manage().Window.FullScreen();
            IWebElement element = Chrome.chrome.FindElement(By.XPath("//div[@id='sb']/div[2]/div[8]/div/div/div/input"));
            element.Click();
            element.SendKeys("News");
            element.SendKeys(Keys.Enter);
        }

        [When(@"user click on tab '([^']*)'")]
        public void WhenUserClickOnTab(string p0)
        {
            Chrome.chrome.Manage().Window.FullScreen();
            Chrome.chrome.FindElement(By.XPath("//div[@id='vue-instance']/div[2]/div/div/ul/li/a/div/h3")).Click();
        }

        [When(@"user select tab '([^']*)'")]
        public void WhenUserSelectTab(string p0)
        {
            Chrome.chrome.Manage().Window.FullScreen();
            Chrome.chrome.FindElement(By.XPath("//a[contains(text(),'Chess Players')]")).Click();
        }

        [Then(@"user sees menu with text '([^']*)'")]
        public void ThenUserSeesMenuWithText(string p0)
        {
            IWebElement element = Chrome.chrome.FindElement(By.XPath("//span[contains(.,'Chess Players')]"));
            string expected = element.Text;
            Assert.Equal("Chess Players", expected);
            Chrome.chrome.Quit();
        }

        //Scenario: play chess with computer

        [When(@"user cliks on button_p '([^']*)'")]
        public void WhenUserCliksOnButton_P(string play)
        {
            Chrome.chrome.Manage().Window.FullScreen();
            Chrome.chrome.FindElement(By.XPath("//div[@id='sb']/div[2]/a[2]/span")).Click();
        }

        [When(@"user select menu tab '([^']*)'")]
        public void WhenUserSelectMenuTab(string computer)
        {
            Chrome.chrome.Manage().Window.FullScreen();
            Chrome.chrome.FindElement(By.XPath("//div[@id='board-layout-sidebar']/div/div[2]/div/a[2]/div[2]/div")).Click();
        }

        [When(@"user click on tab_c '([^']*)'")]
        public void WhenUserClickOnTab_C(string choose)
        {
            Chrome.chrome.FindElement(By.XPath("//div[4]/div/div[2]/button")).Click();
        }

        [When(@"user click on tab_p '([^']*)'")]
        public void WhenUserClickOnTab_P(string play)
        {
            Chrome.chrome.FindElement(By.XPath("//div[4]/div/div[2]/button")).Click();
        }

        [Then(@"user sees bot message '([^']*)'")]
        public void ThenUserSeesBotMessage(string p0)
        {
            IWebElement element = Chrome.chrome.FindElement(By.XPath("//span[contains(.,'Jimmy')]"));
            string expected = element.Text;
            Assert.Equal("Jimmy", expected);
            Chrome.chrome.Quit();
        }

        //Scenario: learn tactics lessons

        [When(@"user cliks on button_c '([^']*)'")]
        public void WhenUserCliksOnButton_C(string connect)
        {
            Chrome.chrome.FindElement(By.XPath("//div[@id='sb']/div[2]/a[6]/span")).Click();
            Chrome.chrome.Manage().Window.FullScreen();
        }

        [When(@"user cliks on munu_d '([^']*)'")]
        public void WhenUserCliksOnMunu_D(string p0)
        {
            Chrome.chrome.FindElement(By.XPath("//div[@id='view-forums-index']/div/div/a/div/span")).Click();
        }

        [Then(@"user sees header title text '([^']*)'")]
        public void ThenUserSeesHeaderTitleText(string p0)
        {
            IWebElement element = Chrome.chrome.FindElement(By.XPath("//span[contains(.,'General Chess Discussion')]"));
            string expected = element.Text;
            Assert.Equal("General Chess Discussion", expected);
            Chrome.chrome.Quit();
        }

    }
}
