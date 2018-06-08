using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Codewars;

namespace CodewarsTests
{
    [Binding]
    [Scope(Feature = "PrinterError")]
    public class PrinterErrorSteps
    {
        [Given(@"我的印表機列印出 (.*)")]
        public void Given我的印表機列印出(string printer)
        {
            ScenarioContext.Current.Set(printer, "Printer");
        }
        
        [When(@"進行分析")]
        public void When進行分析()
        {
            var printer = ScenarioContext.Current.Get<string>("Printer");
            string actual = Printer.PrinterError(printer);
            ScenarioContext.Current.Set(actual, "Actual");
        }
        
        [Then(@"結果為 (.*)")]
        public void Then結果為(string expected)
        {
            var actual = ScenarioContext.Current.Get<string>("Actual");
            Assert.AreEqual(expected, actual);
        }
    }
}
