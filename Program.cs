using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SeleniumConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = null;
            try
            {
                // Start Chrome
                driver = new ChromeDriver();
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                var vars = new Dictionary<string, object>();

                driver.Navigate().GoToUrl("https://f2f.com/");
                driver.Manage().Window.Size = new System.Drawing.Size(1693, 1080);

                driver.FindElement(By.CssSelector(".profile-image")).Click();
                driver.FindElement(By.LinkText("Ga naar agency")).Click();
                driver.FindElement(By.CssSelector("tr:nth-child(2) .\\_9MjrcG_displayName")).Click();

                {
                    var element = driver.FindElement(By.CssSelector(".\\_9MjrcG_large > .\\_9MjrcG_frame"));
                    new Actions(driver).MoveToElement(element).Perform();
                }
                {
                    var element = driver.FindElement(By.TagName("body"));
                    new Actions(driver).MoveToElement(element, 0, 0).Perform();
                }

                driver.FindElement(By.CssSelector(".\\_7lrYkG_small:nth-child(2) > .\\_7lrYkG_text > .\\_7lrYkG_text")).Click();
                driver.FindElement(By.CssSelector(".x9qUeG_linkItem:nth-child(1) > .x9qUeG_textContainer")).Click();

                {
                    var element = driver.FindElement(By.CssSelector("div:nth-child(5) > .OsMxUq_folder > .u9X6NG_unstyledLink > .OsMxUq_folderImage"));
                    new Actions(driver).MoveToElement(element).Perform();
                }
                {
                    var element = driver.FindElement(By.TagName("body"));
                    new Actions(driver).MoveToElement(element, 0, 0).Perform();
                }

                driver.FindElement(By.CssSelector("div:nth-child(1) > .OsMxUq_folder > .u9X6NG_unstyledLink > .OsMxUq_folderImage")).Click();
                driver.FindElement(By.CssSelector("div:nth-child(1) > .OsMxUq_folder > .u9X6NG_unstyledLink > .OsMxUq_folderImage")).Click();
                driver.FindElement(By.CssSelector(".ryxRiG_wrapper:nth-child(1) > .\\_73re8W_pickerBadgeContainer")).Click();
                driver.FindElement(By.CssSelector(".\\_8HzuwW_button:nth-child(2)")).Click();
                driver.FindElement(By.Id("Vector")).Click();
                driver.FindElement(By.CssSelector(".n3Mc_G_mentions__input")).Click();
                driver.FindElement(By.CssSelector(".n3Mc_G_mentions__input")).SendKeys("Hallo hoe gaat het\n#leuk #lief ");
                driver.FindElement(By.CssSelector(".\\_63d-OW_actionButton:nth-child(1) path:nth-child(1)")).Click();
                driver.FindElement(By.CssSelector(".\\_8HzuwW_button")).Click();
                driver.FindElement(By.CssSelector(".\\_7lrYkG_primary > .\\_7lrYkG_text > .\\_7lrYkG_text")).Click();
                driver.FindElement(By.CssSelector(".ztm8ka_expandingButtonCard:nth-child(3) .ztm8ka_header")).Click();
                driver.FindElement(By.Name("date")).Click();
                driver.FindElement(By.CssSelector(".rdp-row:nth-child(5) > .rdp-cell:nth-child(2) > .rdp-button_reset")).Click();
                driver.FindElement(By.Name("time")).Click();
                driver.FindElement(By.Name("time")).SendKeys("16:35");
                driver.FindElement(By.CssSelector(".\\_8aiCSq_slider")).Click();
                driver.FindElement(By.Name("tillDate")).Click();
                driver.FindElement(By.CssSelector(".rdp-row:nth-child(5) > .rdp-cell:nth-child(3) > .rdp-button_reset")).Click();
                driver.FindElement(By.Name("tillTime")).Click();
                driver.FindElement(By.Name("tillTime")).SendKeys("16:35");
                driver.FindElement(By.CssSelector(".\\_7lrYkG_primary > .\\_7lrYkG_text > .\\_7lrYkG_text")).Click();

                {
                    var element = driver.FindElement(By.CssSelector(".U0wPHW_iconWrapper path:nth-child(2)"));
                    new Actions(driver).MoveToElement(element).Perform();
                }
                {
                    var element = driver.FindElement(By.TagName("body"));
                    new Actions(driver).MoveToElement(element, 0, 0).Perform();
                }
                {
                    var element = driver.FindElement(By.CssSelector(".U0wPHW_iconWrapper > svg"));
                    new Actions(driver).MoveToElement(element).Perform();
                }

                driver.FindElement(By.CssSelector(".U0wPHW_iconWrapper > svg")).Click();
                driver.FindElement(By.CssSelector("tr:nth-child(3) .\\_9MjrcG_displayName")).Click();
                driver.FindElement(By.CssSelector(".\\_7lrYkG_small:nth-child(2) > .\\_7lrYkG_text > .\\_7lrYkG_text")).Click();
                driver.FindElement(By.CssSelector(".x9qUeG_linkItem:nth-child(1) .x9qUeG_explainText")).Click();

                {
                    var element = driver.FindElement(By.CssSelector("div:nth-child(5) > .OsMxUq_folder > .u9X6NG_unstyledLink > .OsMxUq_folderImage"));
                    new Actions(driver).MoveToElement(element).Perform();
                }
                {
                    var element = driver.FindElement(By.TagName("body"));
                    new Actions(driver).MoveToElement(element, 0, 0).Perform();
                }

                driver.FindElement(By.CssSelector("div:nth-child(1) > .OsMxUq_folder > .u9X6NG_unstyledLink > .OsMxUq_folderImage")).Click();
                driver.FindElement(By.CssSelector("div:nth-child(1) > .OsMxUq_folder > .u9X6NG_unstyledLink > .OsMxUq_folderImage")).Click();
                driver.FindElement(By.CssSelector(".ryxRiG_wrapper:nth-child(1) > .\\_73re8W_pickerBadgeContainer")).Click();
                driver.FindElement(By.CssSelector(".\\_8HzuwW_button:nth-child(2)")).Click();
                driver.FindElement(By.CssSelector(".\\_63d-OW_actionButton:nth-child(1) svg")).Click();
                driver.FindElement(By.CssSelector(".n3Mc_G_mentions__input")).Click();
                driver.FindElement(By.CssSelector(".n3Mc_G_mentions__input")).SendKeys("Hello alles goed\n#lief ");
                driver.FindElement(By.CssSelector(".\\_63d-OW_actionButton:nth-child(1) path:nth-child(1)")).Click();
                driver.FindElement(By.CssSelector(".\\_8HzuwW_button")).Click();
                driver.FindElement(By.CssSelector(".\\_7lrYkG_primary > .\\_7lrYkG_text > .\\_7lrYkG_text")).Click();
                driver.FindElement(By.CssSelector(".ztm8ka_expandingButtonCard:nth-child(3) .ztm8ka_header")).Click();
                driver.FindElement(By.Name("date")).Click();
                driver.FindElement(By.CssSelector(".rdp-row:nth-child(5) > .rdp-cell:nth-child(2) > .rdp-button_reset")).Click();
                driver.FindElement(By.Name("time")).Click();
                driver.FindElement(By.Name("time")).SendKeys("14:35");
                driver.FindElement(By.CssSelector(".\\_8aiCSq_slider")).Click();
                driver.FindElement(By.Name("tillDate")).Click();
                driver.FindElement(By.CssSelector(".rdp-row:nth-child(5) > .rdp-cell:nth-child(3) > .rdp-button_reset")).Click();
                driver.FindElement(By.Name("tillTime")).Click();
                driver.FindElement(By.Name("tillTime")).SendKeys("14:35");
                driver.FindElement(By.CssSelector(".\\_7lrYkG_primary")).Click();

                {
                    var element = driver.FindElement(By.CssSelector(".U0wPHW_iconWrapper path:nth-child(1)"));
                    new Actions(driver).MoveToElement(element).Perform();
                }
                {
                    var element = driver.FindElement(By.TagName("body"));
                    new Actions(driver).MoveToElement(element, 0, 0).Perform();
                }
                driver.FindElement(By.CssSelector(".U0wPHW_iconWrapper path:nth-child(1)")).Click();

                Console.WriteLine("Automation completed successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                driver?.Quit();
            }
        }
    }
}
