using System;
using CodeWare;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewareTests
{
    [TestClass]
    public class KateTests
    {
        [TestMethod]
        public void SimpleTest()
        {
            Assert.AreEqual("1a", Kata.StringLetterCount("a"));
        }

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual("",Kata.StringLetterCount(""));
            
        }

        [TestMethod]
        public void SecondWordTest()
        {
            Assert.AreEqual("2a", Kata.StringLetterCount("aa"));
        }

        [TestMethod]
        public void RealTest1()
        {
            Assert.AreEqual("1a1b1c1d3e1f1g2h1i1j1k1l1m1n4o1p1q2r1s2t2u1v1w1x1y1z", Kata.StringLetterCount("The quick brown fox jumps over the lazy dog."));
        }

        [TestMethod]
        public void RealTest2()
        {
            Assert.AreEqual("2a1d5e1g1h4i1j2m3n3o3s6t1u2w2y", Kata.StringLetterCount("The time you enjoy wasting is not wasted time."));
        }

        [TestMethod]
        public void RealTest3()
        {
            Assert.AreEqual("", Kata.StringLetterCount("./4592#{}()"));
        }
    }
}
