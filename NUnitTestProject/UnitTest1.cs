using NUnit.Framework;
using CountVowels;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void test1()
        {
            Assert.AreEqual(5, Program.countVowels("Aeolia"));
        }

        [Test]
        public void test2()
        {
            Assert.AreNotEqual(4, Program.countVowels("Aeolia"));
        }

        [Test]
        public void test3()
        {
            Assert.AreEqual(0, Program.countVowels("RHYTHM"));
        }

        [Test]
        public void test4()
        {
            Assert.AreNotEqual(1, Program.countVowels("SyzYgy"));
        }

        [Test]
        public void test5()
        {
            Assert.AreNotEqual(3, Program.countVowels("Hello"));
        }
    }
}