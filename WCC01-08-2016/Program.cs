using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCC01_08_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            UInt16[] array = { 11, 20, 8, 31 };
            FindEle(array);
        }

        public static UInt16 FindEle(UInt16[] array)
        {
            if(ValidateArray(array))
            {
                var leftIndex = 0;
                var rightIndex = array.Length - 1;
                
                var leftSum = 0;
                var rightSum = 0;
                
                while(leftIndex < rightIndex)
                {
                    if (leftSum <= rightSum)
                    {
                        leftSum += array[leftIndex];
                        leftIndex++;
                    }
                    else
                    {
                        rightSum += array[rightIndex];
                        rightIndex--;
                    }
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine("Element is {0}", array[leftIndex]);
                    return array[leftIndex];
                }
                Console.WriteLine("No Element found with equal weights on both sides.");
                return ushort.MinValue;
            }
            Console.WriteLine("Elements in array are not meeting criteria.");
            return ushort.MinValue;
        }

        public static bool ValidateArray(UInt16[] array)
        {
            if (array == null) throw new ArgumentNullException("array");
            return array.Max() <= 20000 && array.Min() > 0;
        }
    }
}
