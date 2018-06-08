using System;
using Codewars;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CodewarsTests
{
    [Binding]
    [Scope(Feature = "GetSum")]
    public class GetSumSteps
    {
        Sum sum = new Sum();

        [Given(@"開始數字： (.*), 結束數字 (.*)")]
        public void Given開始數字結束數字(int firstNumber, int secondNumber)
        {
            ScenarioContext.Current.Set(firstNumber, "First");
            ScenarioContext.Current.Set(secondNumber, "Second");
        }
        
        [When(@"開始計算")]
        public void When開始計算()
        {
            int first = ScenarioContext.Current.Get<int>("First");
            int second = ScenarioContext.Current.Get<int>("Second");
            ScenarioContext.Current.Set(sum.GetSum(first, second), "Actual");
        }
        
        [Then(@"結果為 (.*)")]
        public void Then結果為(int expected)
        {
            var actual = ScenarioContext.Current.Get<int>("Actual");
            Assert.AreEqual(expected, actual);
        }
    }
}
