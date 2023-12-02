using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint6.Task0.V29.Lib;

namespace Tyuiu.ShananinaVV.Sprint6.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()

        {
            DataService ds = new DataService();
            double res = ds.Calculate(2);
            double wait = 0.438;
            Assert.AreEqual(wait, res);
        }
    }
}
