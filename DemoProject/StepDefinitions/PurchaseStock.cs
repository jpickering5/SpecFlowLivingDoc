using System;
using TechTalk.SpecFlow;
using StockApp;

namespace DemoProject.StepDefinitions
{
    [Binding]
    public class PurchaseStock

    {
        public StockAppClass stockApp = new StockAppClass();

        [Given(@"That I am a StockApp user")]
        public void GivenThatIAmAStockAppUser()
        {
            stockApp.User = "DemoUser";
        }

        [Given(@"My initial portfolio has a value of '([^']*)'")]
        public void GivenMyInitialPortfolioHasAValueOf(string portfolioValue)
        {
            stockApp.SetPortfolioValue(int.Parse(portfolioValue));
        }

        [When(@"I purchase '([^']*)' amount of '([^']*)' at the latest value")]
        public void WhenIPurchaseAmountOfAtTheLatestValue(string amount, string stockCode)
        {
            stockApp.PurchaseStock(amount, stockCode);
        }

        [Then(@"My portfolio has increased in value when compared with '([^']*)'")]
        public void ThenMyPortfolioHasIncreasedInValueWhenComparedWith(string portfolioValue)
        {
            int initialPortfolioValue = Int32.Parse(portfolioValue);
            int newPortfolioValue = stockApp.PortfolioValue;

            newPortfolioValue.Should().BeGreaterThan(initialPortfolioValue);
        }

    }
}
