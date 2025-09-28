using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyrkinAA.Sprint0.Task3.V0.Lib;
namespace Tyuiu.PyrkinAA.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckValid()
        {
            Assert.AreEqual(10, DataServise.Sum(5, 5));
        }
    }
}
