using F2FMassMessage.Pages;
using OpenQA.Selenium.Chrome;

var options = new ChromeOptions();
    // You can add options here if needed, e.g. options.AddArgument("--headless");
    using (var driver = new ChromeDriver(options))
    {
        var page = new PlanningMassMessagePage(driver);

        try
        {
            page.Navigate();
            page.LoginAndGoToAgency();
            page.SelectSecondTableRow();
            page.OpenSliders();
            page.ClickCreateMassButton();
            page.SelectSecondCard();
            page.ConfirmSelection();
            page.EnterMessage("Hallo alles goed? xxx");
            page.SubmitMessage();
            page.SelectExpandingButtonCard();
            page.SelectDate();
            page.SelectTime("17:30");
            page.FinalSubmit();

            Console.WriteLine("✅ Mass message planned successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
        finally
        {
            driver.Quit();
        }
    }