﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DemoProject.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class AsAStockAppUserIWantToPurchaseAGivenAmountOfStockAtTheLatestValueSoThatICanIncreaseTheValueOfMyPortfolioFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "PurchaseStock.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "As a StockApp user I want to purchase a given amount of stock at the latest value" +
                    " so that I can increase the value of my portfolio", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "As a StockApp user I want to purchase a given amount of stock at the latest value" +
                            " so that I can increase the value of my portfolio")))
            {
                global::DemoProject.Features.AsAStockAppUserIWantToPurchaseAGivenAmountOfStockAtTheLatestValueSoThatICanIncreaseTheValueOfMyPortfolioFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void AsAStockAppUserIWantToPurchaseAGivenAmountOfStockAtTheLatestValueSoThatICanIncreaseTheValueOfMyPortfolio(string initialPortfolioValue, string amountOfStockToBuy, string stockCode, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Initial Portfolio Value", initialPortfolioValue);
            argumentsOfScenario.Add("AmountOfStockToBuy", amountOfStockToBuy);
            argumentsOfScenario.Add("StockCode", stockCode);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a StockApp user I want to purchase a given amount of stock at the latest value" +
                    " so that I can increase the value of my portfolio", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 testRunner.Given("That I am a StockApp user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.And(string.Format("My initial portfolio has a value of \'{0}\'", initialPortfolioValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 7
 testRunner.When(string.Format("I purchase \'{0}\' amount of \'{1}\' at the latest value", amountOfStockToBuy, stockCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
 testRunner.Then(string.Format("My portfolio has increased in value when compared with \'{0}\'", initialPortfolioValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("As a StockApp user I want to purchase a given amount of stock at the latest value" +
            " so that I can increase the value of my portfolio: 1500")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "As a StockApp user I want to purchase a given amount of stock at the latest value" +
            " so that I can increase the value of my portfolio")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "1500")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Initial Portfolio Value", "1500")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AmountOfStockToBuy", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:StockCode", "MSFT")]
        public virtual void AsAStockAppUserIWantToPurchaseAGivenAmountOfStockAtTheLatestValueSoThatICanIncreaseTheValueOfMyPortfolio_1500()
        {
#line 4
this.AsAStockAppUserIWantToPurchaseAGivenAmountOfStockAtTheLatestValueSoThatICanIncreaseTheValueOfMyPortfolio("1500", "10", "MSFT", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("As a StockApp user I want to purchase a given amount of stock at the latest value" +
            " so that I can increase the value of my portfolio: 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "As a StockApp user I want to purchase a given amount of stock at the latest value" +
            " so that I can increase the value of my portfolio")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Initial Portfolio Value", "0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AmountOfStockToBuy", "5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:StockCode", "SBUX")]
        public virtual void AsAStockAppUserIWantToPurchaseAGivenAmountOfStockAtTheLatestValueSoThatICanIncreaseTheValueOfMyPortfolio_0()
        {
#line 4
this.AsAStockAppUserIWantToPurchaseAGivenAmountOfStockAtTheLatestValueSoThatICanIncreaseTheValueOfMyPortfolio("0", "5", "SBUX", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("As a StockApp user I want to purchase a given amount of stock at the latest value" +
            " so that I can increase the value of my portfolio: 100")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "As a StockApp user I want to purchase a given amount of stock at the latest value" +
            " so that I can increase the value of my portfolio")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "100")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Initial Portfolio Value", "100")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AmountOfStockToBuy", "3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:StockCode", "AMZN")]
        public virtual void AsAStockAppUserIWantToPurchaseAGivenAmountOfStockAtTheLatestValueSoThatICanIncreaseTheValueOfMyPortfolio_100()
        {
#line 4
this.AsAStockAppUserIWantToPurchaseAGivenAmountOfStockAtTheLatestValueSoThatICanIncreaseTheValueOfMyPortfolio("100", "3", "AMZN", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("As a StockApp user I want to purchase a given amount of stock at the latest value" +
            " so that I can increase the value of my portfolio: 25000")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "As a StockApp user I want to purchase a given amount of stock at the latest value" +
            " so that I can increase the value of my portfolio")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "25000")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Initial Portfolio Value", "25000")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AmountOfStockToBuy", "8")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:StockCode", "BA")]
        public virtual void AsAStockAppUserIWantToPurchaseAGivenAmountOfStockAtTheLatestValueSoThatICanIncreaseTheValueOfMyPortfolio_25000()
        {
#line 4
this.AsAStockAppUserIWantToPurchaseAGivenAmountOfStockAtTheLatestValueSoThatICanIncreaseTheValueOfMyPortfolio("25000", "8", "BA", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion