using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MengAV.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArray(int[] numOne, int[] numTwo)
        {
            int[] resultArray = new int[5];

            for (var i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = numOne[i] + numTwo[i];
            }

            return resultArray;
        }
    }
}
