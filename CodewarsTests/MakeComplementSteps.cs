using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Codewars;

namespace CodewarsTests
{
    [Binding]
    [Scope(Feature = "MakeComplement")]
    public class MakeComplementSteps
    {
        [Given(@"我有一個DNA字串 (.*)")]
        public void Given我有一個DNA字串(string dna)
        {
            ScenarioContext.Current.Set(dna,"DNA");
        }
        
        [When(@"取得互補面")]
        public void When取得互補面()
        {
            var dna = ScenarioContext.Current.Get<string>("DNA");
            var actual = DnaStrand.MakeComplement(dna);
            ScenarioContext.Current.Set(actual,"Actual");
        }
        
        [Then(@"我應該得到 (.*)")]
        public void Then我應該得到(string expected)
        {
            var actual = ScenarioContext.Current.Get<string>("Actual");
            Assert.AreEqual(expected, actual);
        }
    }
}
