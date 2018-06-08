using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Codewars;

namespace CodewarsTests
{
    [Binding]
    [Scope(Feature = "IsTriangle")]
    public class IsTriangleSteps
    {
        [Given(@"我有三個邊長 (.*), (.*), (.*)")]
        public void Given我有三個邊長(int length1, int length2, int length3)
        {
            ScenarioContext.Current.Set(new int[] {length1, length2, length3});
        }
        
        [When(@"判斷是否可以組成三角形")]
        public void When判斷是否可以組成三角形()
        {
            int[] lengths = ScenarioContext.Current.Get<int[]>();
            bool actual = Triangle.IsTriangle(lengths[0], lengths[1], lengths[2]);
            ScenarioContext.Current.Set(actual);
        }
        
        [Then(@"結果為 (.*)")]
        public void Then結果為(bool expected)
        {
            var actual = ScenarioContext.Current.Get<bool>();
            Assert.AreEqual(expected, actual);
        }
    }
}
