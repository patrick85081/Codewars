using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codewars;
using NUnit.Framework;

namespace CodewarsTests
{
    [TestFixture]
    public class StringParseTests
    {
        public static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(new object[] { "10", 2 }).Returns(2);
                yield return new TestCaseData(new object[] { "10", 3 }).Returns(3);
                yield return new TestCaseData(new object[] { "12", 4 }).Returns(6);
                yield return new TestCaseData(new object[] { "1234567890", 10 }).Returns(1234567890);
                yield return new TestCaseData(new object[] { "FF", 16 }).Returns(255);
                yield return new TestCaseData(new object[] { "FF", 18 }).Returns(285);
                yield return new TestCaseData(new object[] { "ff", 18 }).Returns(285);
                yield return new TestCaseData(new object[] { "FFFFFFFF", 16 }).Returns(-1);
                yield return new TestCaseData(new object[] { "FFFFFFFE", 16 }).Returns(-2);
                //yield return new TestCaseData(new object[] { "80000000", 16 }).Returns(0);
            }
        }

        [Test]
        [ TestCaseSource("testCases")]
        public int ParseTest(string value, int fromBase) =>
            value.Parse(fromBase);

        [Test]
        public void OverflowExceptionTest()
        {
            Assert.That(() => "FFFFFFFFFF".Parse(16), Throws.TypeOf<OverflowException>());
        }

        [Test]
        public void FormatExceptionTest()
        {
            Assert.That(() => "FFFFFFFF".Parse(15), Throws.TypeOf<FormatException>());
        }

        [Test]
        public void ArgumentExceptionTest_Empty()
        {
            Assert.That(() => "".Parse(15), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void ArgumentExceptionTest_Null()
        {
            string str = null;
            Assert.That(() => str.Parse(15), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void ArgumentExceptionTest_fromBase_Less_2()
        {
            Assert.That(() => "0".Parse(1), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void ArgumentExceptionTest_fromBase_Greater_36()
        {
            Assert.That(() => "0".Parse(37), Throws.TypeOf<ArgumentException>());
        }

    }
}
