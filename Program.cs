using ClosedXML.Excel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using SeleniumExtras.WaitHelpers;

class Program
{
    static IWebDriver driver;
    static IJavaScriptExecutor js;

    static void Main(string[] args)
    {
        try
        {
            // Load Excel file
            string excelPath = @"C:\Users\Decagon\Documents\f2f Data.xlsx"; // Change to your actual Excel file path
            var rows = ReadExcelData(excelPath);

            // Start Chrome
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;

            // Open site
            driver.Navigate().GoToUrl("https://f2f.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1693, 1080);

            foreach (var row in rows)
            {
                string creatorName = row.CreatorName;
                string message = row.Message;
                string startDate = row.StartDate;
                string startTime = row.StartTime.ToString();
                string endDate = row.EndDate;
                string endTime = row.EndTime.ToString();

                // Actions sequence
                Click(By.CssSelector(".profile-image"));
                Click(By.LinkText("Ga naar agency"));

                // Click creator name dynamically from Excel
                Click(By.CssSelector($"{creatorName}"));

                // Select folder
                Click(By.CssSelector("div:nth-child(1) > .OsMxUq_folder > .u9X6NG_unstyledLink > .OsMxUq_folderImage"));

                // Click picker badge
                Click(By.CssSelector(".ryxRiG_wrapper:nth-child(1) > .\\_73re8W_pickerBadgeContainer"));
                Click(By.CssSelector(".\\_8HzuwW_button:nth-child(2)"));

                // Enter message
                Click(By.CssSelector(".n3Mc_G_mentions__input"));
                Type(By.CssSelector(".n3Mc_G_mentions__input"), message);

                // Send message
                Click(By.CssSelector(".\\_63d-OW_actionButton:nth-child(1) path:nth-child(1)"));

                // Next
                Click(By.CssSelector(".\\_8HzuwW_button"));

                // Start date & time
                Click(By.Name("date"));
                SelectDate(startDate);
                Click(By.Name("time"));
                Type(By.Name("time"), startTime);

                // Slider click
                Click(By.CssSelector(".\\_8aiCSq_slider"));

                // End date & time
                Click(By.Name("tillDate"));
                SelectDate(endDate);
                Click(By.Name("tillTime"));
                Type(By.Name("tillTime"), endTime);

                // Save
                Click(By.CssSelector(".\\_7lrYkG_primary"));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            driver?.Quit();
        }
    }

    static void Click(By by)
    {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        var element = wait.Until(ExpectedConditions.ElementToBeClickable(by));
        element.Click();
    }

    static void Type(By by, string text)
    {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        var element = wait.Until(ExpectedConditions.ElementIsVisible(by));
        element.Clear();
        element.SendKeys(text);
    }

    static void SelectDate(string day)
    {
        // Click the day button inside date picker
        driver.FindElement(By.XPath($"//button[text()='{day}']")).Click();
        Thread.Sleep(2000);
    }

    static List<(string CreatorName, string Message, string StartDate, string StartTime, string EndDate, string EndTime)> ReadExcelData(string path)
    {
        var list = new List<(string, string, string, string, string, string)>();
        using (var workbook = new XLWorkbook(path))
        {
            var ws = workbook.Worksheet(1);
            var rows = ws.RangeUsed().RowsUsed().Skip(1); // skip header

            foreach (var row in rows)
            {
                list.Add((
                    row.Cell(1).GetString(), // Creator Name
                    row.Cell(2).GetString(), // Message
                    row.Cell(3).GetString(), // Start Date
                    row.Cell(4).GetString(), // Start Time
                    row.Cell(5).GetString(), // End Date
                    row.Cell(6).GetString()  // End Time
                ));
            }
        }
        return list;
    }
}
