using System;
using Codewars;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CodewarsTests
{
    [Binding]
    [Scope(Feature = "FizzBuzz")]
    public class FizzBuzzSteps
    {
        [Given(@"當我輸入 (.*)")]
        public void Given當我輸入(int number)
        {
            ScenarioContext.Current.Set(number);
        }
        
        [When(@"產生報數字串")]
        public void When產生報數字串()
        {
            var input = ScenarioContext.Current.Get<int>();
            string result = new FizzBuzz().Create(input);
            ScenarioContext.Current.Set(result);
        }

        [Then(@"得到 (.*)")]
        public void Then得到(string expected)
        {
            var actual = ScenarioContext.Current.Get<string>();
            Assert.AreEqual(expected, actual);
        }
    }
}
