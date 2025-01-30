using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV_01
{
    public class Bubble<T> where T : IComparable
    {
        public static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public static void BubbleSort(T[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        //Q3
        public static void ReverseArray(T[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == -1)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }

        }

        //Q4
        public static void EvenNumber(T[] Arr)
        {
            if (Arr == null || Arr.Length == 0)
            {
                return;
            }
            for (int i = 0; i < Arr.Length; i++)
            {
                int number = Convert.ToInt32(Arr[i]);
               
                if (number % 2 == 0)
                {
                    Console.Write(Arr[i] + " ");
                }
            }




        }
    }
}
        
        