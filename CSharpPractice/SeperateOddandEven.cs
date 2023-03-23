using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    internal class SeperateOddandEven
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int oddCount = 0;
            int evenCount = 0;
            int evePos = 0;
            int oddPos = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            int[] oddArr = new int[oddCount];
            int[] evenArr = new int[evenCount];
           
            for(int i = 0;i<arr.Length;i++)
            {
                
                if (arr[i] % 2 == 0)
                {
                    evenArr[evePos++] = arr[i];
                    
                }
                else
                {
                    oddArr[oddPos++] = arr[i];
                   
                }

            }
            Console.WriteLine("Odd Array");
            for(int i = 0; i < oddArr.Length; i++)
            {
                Console.Write(oddArr[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Even Array");
            for (int i = 0; i < evenArr.Length; i++)
            {
                Console.Write(evenArr[i] + " ");
            }
            
        }
    }
}
