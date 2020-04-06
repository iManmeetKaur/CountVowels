using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountVowels;

namespace NUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test1()
        {
            Assert.AreEqual(5, Program.countVowels("Aeolia"));
        }

        [TestMethod]
        public void test2()
        {
            Assert.AreNotEqual(4, Program.countVowels("Aeolia"));
        }

        [TestMethod]
        public void test3()
        {
            Assert.AreEqual(0, Program.countVowels("RHYTHM"));
        }

        [TestMethod]
        public void test4()
        {
            Assert.AreNotEqual(1, Program.countVowels("SyzYgy"));
        }

        [TestMethod]
        public void test5()
        {
            Assert.AreNotEqual(3, Program.countVowels("Hello"));
        }
    }
}
