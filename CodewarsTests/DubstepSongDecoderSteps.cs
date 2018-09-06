using System;
using Codewars;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CodewarsTests
{
    [Binding]
    [Scope(Feature = "DubstepSongDecoder")]
    public class DubstepSongDecoderSteps
    {
        [Given(@"我有一首混音音樂 (.*)")]
        public void Given我有一首混音音樂(string orgSong)
        {
            ScenarioContext.Current.Set(orgSong,"Song");
        }
        
        [When(@"音樂還原")]
        public void When音樂還原()
        {
            var song = ScenarioContext.Current.Get<string>("Song");
            ScenarioContext.Current.Set(new Dubstep().SongDecoder(song), "Actual");
        }
        
        [Then(@"得到原始音樂 (.*)")]
        public void Then得到原始音樂(string expected)
        {
            var actual = ScenarioContext.Current.Get<string>("Actual");

            Assert.AreEqual(expected, actual);
        }
    }
}
