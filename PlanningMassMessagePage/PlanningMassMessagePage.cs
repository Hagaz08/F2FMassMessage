using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace F2FMassMessage.Pages
{
    public class PlanningMassMessagePage
    {
        private readonly IWebDriver driver;

        public PlanningMassMessagePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://f2f.com/");
        }

        public void LoginAndGoToAgency()
        {
            driver.FindElement(By.CssSelector(".navbar-item > .profile-image")).Click();
            driver.FindElement(By.LinkText("Ga naar agency")).Click();
        }

        public void SelectSecondTableRow()
        {
            driver.FindElement(By.CssSelector(@"tr:nth-child(2) .PquJEW_link .\_7lrYkG_text > .\_7lrYkG_text")).Click();
        }

        public void OpenSliders()
        {
            driver.FindElement(By.CssSelector(".Rb86QW_sliders:nth-child(2)")).Click();
        }

        public void ClickCreateMassButton()
        {
            var createButton = driver.FindElement(By.CssSelector(@".\_6fMQbG_createMassButton"));
            createButton.Click();

            new Actions(driver).MoveToElement(createButton).Perform();
            Thread.Sleep(500);
        }

        public void SelectSecondCard()
        {
            driver.FindElement(By.CssSelector(".v-h2ZW_card:nth-child(2) .v-h2ZW_check")).Click();
        }

        public void ConfirmSelection()
        {
            var confirmBtn = By.CssSelector( @".\_7lrYkG_primary > .\_7lrYkG_text > .\_7lrYkG_text");
            driver.FindElement(confirmBtn).Click();
            driver.FindElement(confirmBtn).Click();
        }

        public void EnterMessage(string message)
        {
            var messageBox = driver.FindElement(By.Name("message"));
            messageBox.Click();
            messageBox.SendKeys(message);
        }

        public void SubmitMessage()
        {
            driver.FindElement(By.CssSelector(@".\_7lrYkG_primary")).Click();
            driver.FindElement(By.CssSelector(@".\_8HzuwW_primary")).Click();
        }

        public void SelectExpandingButtonCard()
        {
            driver.FindElement(By.CssSelector(".ztm8ka_expandingButtonCard:nth-child(2) > .ztm8ka_headerContainer")).Click();
        }

        public void SelectDate()
        {
            driver.FindElement(By.Name("date")).Click();
            driver.FindElement(By.CssSelector(".rdp-row:nth-child(3) > .rdp-cell:nth-child(1) > .rdp-button_reset")).Click();
        }

        public void SelectTime(string time)
        {
            var timeBox = driver.FindElement(By.Name("time"));
            timeBox.Click();
            timeBox.SendKeys(time);
        }

        public void FinalSubmit()
        {
            driver.FindElement(By.CssSelector(@".\_7lrYkG_primary > .\_7lrYkG_text > .\_7lrYkG_text")).Click();
        }
    }
}
