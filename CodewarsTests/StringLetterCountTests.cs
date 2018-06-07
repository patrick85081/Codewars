using System;
using Codewars;
using NUnit.Framework;

namespace CodewarsTests
{
    [TestFixture]
    public class StringLetterCountTests
    {
        [Test]
        public void SimpleTest()
        {
            Assert.AreEqual("1a", Kata.StringLetterCount("a"));
        }

        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", Kata.StringLetterCount(""));
        }

        [Test]
        public void SecondWordTest()
        {
            Assert.AreEqual("2a", Kata.StringLetterCount("aa"));
        }

        [Test]
        public void RealTest1()
        {
            Assert.AreEqual("1a1b1c1d3e1f1g2h1i1j1k1l1m1n4o1p1q2r1s2t2u1v1w1x1y1z", Kata.StringLetterCount("The quick brown fox jumps over the lazy dog."));
        }

        [Test]
        public void RealTest2()
        {
            Assert.AreEqual("2a1d5e1g1h4i1j2m3n3o3s6t1u2w2y", Kata.StringLetterCount("The time you enjoy wasting is not wasted time."));
        }

        [Test]
        public void RealTest3()
        {
            Assert.AreEqual("", Kata.StringLetterCount("./4592#{}()"));
        }
    }
}