﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CodewarsTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("FizzBuzz")]
    public partial class FizzBuzzFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FizzBuzz.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FizzBuzz", "\tIn order to 報數遊戲，三個倍數報Fizz，五的倍數報Buzz，十五的倍數報FizzBuzz\r\n\tAs a teacher\r\n\tI want to 讓" +
                    "我輸入一個數字，計算出需要報數用的字串", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void 報數測試當我輸入(string input, string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("報數測試，當我輸入", exampleTags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given(string.Format("當我輸入 {0}", input), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.When("產生報數字串", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then(string.Format("得到 {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("報數測試，當我輸入: 1")]
        public virtual void 報數測試當我輸入_1()
        {
#line 6
this.報數測試當我輸入("1", "1", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("報數測試，當我輸入: 2")]
        public virtual void 報數測試當我輸入_2()
        {
#line 6
this.報數測試當我輸入("2", "2", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("報數測試，當我輸入: 3")]
        public virtual void 報數測試當我輸入_3()
        {
#line 6
this.報數測試當我輸入("3", "Fizz", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("報數測試，當我輸入: 4")]
        public virtual void 報數測試當我輸入_4()
        {
#line 6
this.報數測試當我輸入("4", "4", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("報數測試，當我輸入: 5")]
        public virtual void 報數測試當我輸入_5()
        {
#line 6
this.報數測試當我輸入("5", "Buzz", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("報數測試，當我輸入: 6")]
        public virtual void 報數測試當我輸入_6()
        {
#line 6
this.報數測試當我輸入("6", "Fizz", ((string[])(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("報數測試，當我輸入: 15")]
        public virtual void 報數測試當我輸入_15()
        {
#line 6
this.報數測試當我輸入("15", "FizzBuzz", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion