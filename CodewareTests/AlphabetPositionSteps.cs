using System;
using CodeWare;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CodewareTests
{
    [Scope(Feature = "AlphabetPosition")]
    [Binding]
    public class AlphabetPositionSteps
    {
        [Given(@"輸入一段英文 (.*)")]
        public void Given輸入一段英文(string words)
        {
            ScenarioContext.Current.Set(words, "Input");
        }
        
        [When(@"開始轉換")]
        public void When開始轉換()
        {
            var words = ScenarioContext.Current.Get<string>("Input");
            var result = Kata.AlphabetPosition(words);
            ScenarioContext.Current.Set(result, "Result");
        }
        
        
        [Then(@"得到 (.*)")]
        public void Then得到(string expected)
        {
            var actual = ScenarioContext.Current.Get<string>("Result");
            Assert.AreEqual(expected, actual);
        }
    }
}
