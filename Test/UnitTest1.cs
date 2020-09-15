using NUnit.Framework;
using Opgave4;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
            // TODO
        }

        [Test]
        public void TestReverse()
        {
            Assert.AreEqual("a", Program.ReverseString("a"));
            Assert.AreEqual("ba", Program.ReverseString("ab"));
            Assert.AreEqual("", Program.ReverseString(""));
            Assert.AreEqual("!dlrow a tahW", Program.ReverseString("What a world!"));
        }

        [Test]
        public void TestIsPalindrome()
        {
            Assert.IsTrue(Program.IsPalindrome(""));
            Assert.IsTrue(Program.IsPalindrome("a"));
            Assert.IsTrue(Program.IsPalindrome("Anna"));
            Assert.IsFalse(Program.IsPalindrome("Hello"));
        }
    }
}