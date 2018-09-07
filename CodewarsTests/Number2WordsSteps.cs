using System;
using Codewars;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CodewarsTests
{
    [Binding]
    [Scope(Feature = "Number2Words")]
    public class Number2WordsSteps
    {
        [Given(@"輸入 (.*) 一組數字")]
        public void Given輸入一組數字(int number)
        {
            ScenarioContext.Current.Set(number);
        }
        
        [When(@"按下轉換")]
        public void When按下轉換()
        {
            int number = ScenarioContext.Current.Get<int>();
            ScenarioContext.Current.Set(NumberTranslation.Number2Words(number));
        }
        
        [Then(@"得到 (.*) \.")]
        public void Then得到_(string expected)
        {
            string actual = ScenarioContext.Current.Get<string>();
            Assert.AreEqual(expected, actual);
        }
    }
}
