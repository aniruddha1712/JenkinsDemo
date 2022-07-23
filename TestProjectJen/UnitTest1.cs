using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace TestProjectJen
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected1 = "Hello World!!";
        private const string Expected2 = "Hello World!";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleAppJenkins.Program.Method1();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected1, result);
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleAppJenkins.Program.Method1();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected2, result);
            }
        }
    }
}
