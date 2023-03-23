using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    internal class duplicates
    {
        public static void Main(string[] args)  //change to main while executing
        {
            int[] arr = { 1, 3, 4, 3, 2, 5, 6 };
            int temp = 0;
            int duplicate = 0;

            //perforing sorting tofind duplicates
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            //counting duplicates
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    duplicate++;
                }
            }

            Console.WriteLine(duplicate);

        }
    }
}
