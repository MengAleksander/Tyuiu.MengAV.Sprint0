using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MengAV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MengAV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Саша";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Саша", res);
        }
    }
}
