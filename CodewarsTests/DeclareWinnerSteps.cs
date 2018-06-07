using System;
using Codewars;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CodewarsTests
{
    [Binding]
    public class DeclareWinnerSteps
    {
        [Given(@"第一名戰士 (.*), 生命 (.*), 攻擊 (.*)")]
        public void Given第一名戰士生命攻擊(string name, int health, int attack)
        {
            ScenarioContext.Current.Set(new Fighter(name,health,attack),"First");
        }
        
        [Given(@"第二名戰士 (.*), 生命 (.*), 攻擊 (.*)")]
        public void Given第二名戰士生命攻擊(string name, int health, int attack)
        {
            ScenarioContext.Current.Set(new Fighter(name, health, attack), "Second");
        }
        
        [When(@"由 (.*) 先攻")]
        public void When由先攻(string name)
        {
            ScenarioContext.Current.Set(name);
        }
        
        [Then(@"戰鬥結果 (.*) 獲勝")]
        public void Then戰鬥結果獲勝(string name)
        {
            var f1 = ScenarioContext.Current.Get<Fighter>("First");
            var f2 = ScenarioContext.Current.Get<Fighter>("Second");
            var winner = ScenarioContext.Current.Get<string>();
            Assert.AreEqual(name, Kata.DeclareWinner(f1, f2, winner));
        }
    }
}
