using System;
using Codewars;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CodewarsTests
{
    [Binding]
    [Scope(Feature = "NextLargeNumber")]
    public class NextLargeNumberSteps
    {
        [Given(@"當我輸入 (.*)")]
        public void Given當我輸入(long input)
        {
            ScenarioContext.Current.Set(input, "Input");
        }
        
        [When(@"重組後")]
        public void When重組後()
        {
            var input = ScenarioContext.Current.Get<long>("Input");
            var result = new NextLargerNumber().Next(input);
            ScenarioContext.Current.Set(result, "Actual");
        }
        
        [Then(@"應該為 (.*)")]
        public void Then應該為(long expected)
        {
            var actual = ScenarioContext.Current.Get<long>("Actual");

            Assert.AreEqual(expected, actual);
        }
    }
}
