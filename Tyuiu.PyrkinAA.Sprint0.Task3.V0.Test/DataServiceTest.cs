using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyrkinAA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.PyrkinAA.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
