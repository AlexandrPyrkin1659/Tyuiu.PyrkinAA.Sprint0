using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyrkinAA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.PyrkinAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Александр";
            var res = DataServise.GetMessage(name);

            Assert.AreEqual("Привет, Александр", res);
        }
    }
}
