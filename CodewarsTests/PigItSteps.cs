using System;
using Codewars;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CodewarsTests
{
    [Binding]
    [Scope(Feature = "PigIt")]
    public class PigItSteps
    {
        [Given(@"輸入 (.*)")]
        public void Given輸入AtrickPay(string input)
        {
            ScenarioContext.Current.Set(input, "Input");
        }
        
        [When(@"進行轉換")]
        public void When進行轉換()
        {
            var input = ScenarioContext.Current.Get<string>("Input");
            ScenarioContext.Current.Set(Kata.PigIt(input), "Actual");
        }
        
        [Then(@"應該為 (.*)")]
        public void Then應該為Patrick(string expected)
        {
            var actual = ScenarioContext.Current.Get<string>("Actual");
            Assert.AreEqual(expected, actual);
        }
    }
}
