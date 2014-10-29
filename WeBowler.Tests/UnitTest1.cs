using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace WeBowler.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void init()
        {
            Console.WriteLine("Initialize");
        }
        [TestCleanup]
        public void cleanup()
        {
            Console.WriteLine("cleanup");
        }
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("test1");
            Assert.AreEqual(Int32.Parse("2"), 1 + 1);
        }

        [Ignore]
        [TestMethod]
        public void Test_Failure()
        {
            Console.WriteLine("test2");
            Assert.AreEqual(Int32.Parse("2"), 1);
        }
    }
}
