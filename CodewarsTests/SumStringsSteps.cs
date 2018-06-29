using Codewars;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CodewarsTests
{
    [Binding]
    [Scope(Feature = "SumStrings")]
    public class SumStringsSteps
    {
        [Given(@"第一個數字 (.*)")]
        public void Given第一個數字(string number1)
        {
            ScenarioContext.Current.Set<string>(number1, "Number1");
        }
        
        [Given(@"第二個數字 (.*)")]
        public void Given第二個數字(string number2)
        {
            ScenarioContext.Current.Set<string>(number2,"Number2");
        }
        
        [When(@"進行相加")]
        public void When進行相加()
        {
            ScenarioContext.Current.Set<string>(
                Kata.SumStrings(
                    ScenarioContext.Current.Get<string>("Number1"),
                    ScenarioContext.Current.Get<string>("Number2")), 
                "actual");
        }
        
        [Then(@"結果應為 (.*)")]
        public void Then結果應為(string expected)
        {
            var actual = ScenarioContext.Current.Get<string>("actual");
            Assert.AreEqual(expected, actual);
        }
    }
}
