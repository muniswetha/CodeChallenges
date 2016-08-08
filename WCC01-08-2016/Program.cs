using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCC01_08_2016
{
    public class Program
    {
        static void Main(string[] args)
        {
            UInt16[] array = { 11, 20, 8, 31 };
            var element = FindEle(array);
            if(element == null)
                Console.WriteLine("No Element found with equal weights on both sides.");
            else
                Console.WriteLine("Element is {0}", element);
        }

        public static UInt16? FindEle(UInt16[] array)
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
                return null;
            }
            Console.WriteLine("Elements in array are not meeting criteria.");
            return null;
        }

        public static bool ValidateArray(UInt16[] array)
        {
            if (array == null) throw new ArgumentNullException("array");
            var loopLength = array.Length%2 == 0 ? array.Length/2 : array.Length/2 + 1;
            for (var i = 0; i < loopLength; i++)
            {
                var rightIndex = array.Length - i - 1;
                if (array[i] <= 20000 && array[i] > 0 && array[i] <= 20000 && array[rightIndex] > 0 &&
                    array[rightIndex] <= 20000)
                    continue;
                return false;
            }
            return true;
        }
    }
}
