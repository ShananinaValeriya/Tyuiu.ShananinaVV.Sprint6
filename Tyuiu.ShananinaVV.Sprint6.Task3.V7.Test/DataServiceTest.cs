using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint6.Task3.V7.Lib;

namespace Tyuiu.ShananinaVV.Sprint6.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] matrix = { { 31,  25,  -18,  12,   9 },
                              {  6,  34,   -2,   2,  -18},
                              { -5,   4,   27,   4,  -1 },
                              {  4,  15,   34,  -6,  -10},
                              {  0,   8,    5,  14,  -17} };

            int[,] res = ds.Calculate(matrix);
            int[,] wait = { { 31,  25,  -18,  -6,   9 },
                            {  6,  34,   -2,   2,  -18},
                            { -5,   4,   27,   4,  -1 },
                            {  4,  15,   34,  12,  -10},
                            {  0,   8,    5,  14,  -17} };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
