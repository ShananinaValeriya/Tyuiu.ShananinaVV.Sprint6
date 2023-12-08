using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShananinaVV.Sprint6.Task4.V21.Lib
{
    public class DataService : ISprint6Task4V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] vallueArray;
            int len = (stopValue - startValue) + 1;
            vallueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((2 * x - 1) != 0)
                {
                    y = (((2 * Math.Cos(x) + 2) / (2 * x - 1)) + Math.Cos(x) - 5 * x + 3);
                    y = Math.Round(y, 2);
                    vallueArray[count] = y;
                    count++;
                }
                else
                {
                    y = 0;
                    vallueArray[count] = y;
                    count++;
                }
            }
            return vallueArray;
        }
    }
}
