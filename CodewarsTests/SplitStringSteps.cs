using System;
using ExpectedObjects;
using TechTalk.SpecFlow;
using Codewars;

namespace CodewarsTests
{
    [Binding]
    public class SplitStringSteps
    {
        [Given(@"輸入字元 (.*)")]
        public void Given輸入字元(string words)
        {
            ScenarioContext.Current.Set(words);
        }
        
        [When(@"進行字元切割")]
        public void When進行字元切割()
        {
            var words = ScenarioContext.Current.Get<string>();
            string[] actual = SplitString.Solution(words);
            ScenarioContext.Current.Set(actual);
        }
        
        [Then(@"我會得到 (.*)")]
        public void Then我會得到(string[] exceped)
        {
            var actual = ScenarioContext.Current.Get<string[]>();
            exceped.ToExpectedObject().ShouldMatch(actual);
        }

        [StepArgumentTransformation]
        public string[] TransformToListOfString(string commaSeparatedList)
        {
            return commaSeparatedList.Split(',');
        }
    }
}
