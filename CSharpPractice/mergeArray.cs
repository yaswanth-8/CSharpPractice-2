using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    internal class mergeArray
    {
        static int pos = 0;
        static void mergeArr(int[] sourceArr, int[] destArr)
        {
            for(int i=0;i<sourceArr.Length; i++)
            {
                destArr[pos++] = sourceArr[i];
            }
        }
        public static void Merge(string[] args)  //change main XXXXXXXXXXXXXXXXXXXXXXXXXXX
        {
            int[] arr1 = { 1, 8, 3 };
            int[] arr2 = { 4, 7, 6 };
            int temp;
            int totallen = arr1.Length + arr2.Length;
            int[] mergedArr = new int[totallen];
            mergeArr(arr1, mergedArr);
            mergeArr(arr2, mergedArr);
            for (int i = 0; i < totallen; i++)
            {
                for (int j = i; j < totallen; j++)
                {
                    if (mergedArr[j] < mergedArr[i])
                    {
                        temp = mergedArr[i];
                        mergedArr[i] = mergedArr[j];
                        mergedArr[j] = temp;
                    }
                }
            }
            for (int i=0;i<mergedArr.Length;i++)
            {
                Console.WriteLine(mergedArr[i]);
            }

        }
    }
}
