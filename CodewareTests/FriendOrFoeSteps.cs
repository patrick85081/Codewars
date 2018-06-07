using System;
using System.Collections;
using CodeWare;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using ExpectedObjects;
using System.Linq;

namespace CodewareTests
{
    [Scope(Feature = "FriendOrFoe")]
    [Binding]
    public class FriendOrFoeSteps
    {
        [Given(@"輸入好友名單 '(.*)'")]
        public void Given輸入好友名單(string[] frends)
        {
            ScenarioContext.Current.Set(frends, "Fiends");
        }
        
        [When(@"進行篩選")]
        public void When進行篩選()
        {
            var friends = ScenarioContext.Current.Get<string[]>("Fiends");
            ScenarioContext.Current.Set(Kata.FriendOrFoe(friends), "Actual");
        }
        
        [Then(@"得到 '(.*)'")]
        public void Then得到(string[] expected)
        {
            var actual = ScenarioContext.Current.Get<IEnumerable<string>>("Actual");
            expected.ToExpectedObject().ShouldMatch(actual);
        }

        [StepArgumentTransformation]
        public string[] TransformToListOfString(string commaSeparatedList)
        {
            return commaSeparatedList.Split(',');
        }
    }
}
