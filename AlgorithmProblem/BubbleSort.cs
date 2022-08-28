using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    public class BubbleSort
    {
        public void BubbleSrt()
        {
            int[] arr = { 55,44,12,97,56,03,74 };

            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted List of the Integers:");
            foreach (int p in arr)
                Console.Write(p + " ");
            Console.Read();
            

        }
    }
}
