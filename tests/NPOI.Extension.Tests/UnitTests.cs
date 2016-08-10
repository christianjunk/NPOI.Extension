using NUnit.Framework;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using NPOI.Extension.Tests.Case_1;

namespace NPOI.Extension.Tests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void TestMethod1()
        {
            var file = Path.Combine(TestContext.CurrentContext.TestDirectory, @"Case 1\Book - Testcase 1.xlsx");
            Assert.IsTrue(File.Exists(file));

            var loadFromExcel = Excel.Load<Model>(file);
            Debug.WriteLine(loadFromExcel.Count());
        }
    }
}
