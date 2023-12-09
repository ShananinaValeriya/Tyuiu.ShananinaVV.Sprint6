using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint6.Task6.V2.Lib;


namespace Tyuiu.ShananinaVV.Sprint6.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V2.txt";
            string wait = "da ijiH M upBSzre YGVyY";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
