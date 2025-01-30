using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            // int[] arr = { 78, 55, 45, 98, 13 };
            //Bubble<int>.BubbleSort(arr);
            // foreach(int i in arr)
            // {
            //     Console.Write(i + " ");
            // }

            #endregion

            #region Q2

            //Range<int> range= new Range<int>(1, 10);
            //Console.WriteLine(range.IsInRange(5));

            //Range<double> range1 = new Range<double>(8, 4);
            //Console.WriteLine(range1.IsInRange(6.5));

            //double length = Range<double>.Length(4.5,9.4);
            //Console.WriteLine(length);

            #endregion

            #region Q3

            //int[] arr = { 15,8,4,22,90 };
            //Bubble<int>.ReverseArray(arr);
            //foreach (int i in arr)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion



            #region Q4

            //int[] arr = { 15, 8, 4, 22, 90 };
            //Bubble<int>.EvenNumber(arr);

            #endregion

            #region Q5

            //FixedSizeList<int> list = new FixedSizeList<int>(4);
            //list.Add(5);
            //list.Add(8);
            //list.Add(9);
            //list.Add(10);
            ////list.Add(11);

            //Console.WriteLine(list.Get(2));
            #endregion

            #region Q6
            NonRepeatedCharacter NonRepeatedCharacter = new NonRepeatedCharacter();

            int x =NonRepeatedCharacter.GetNonRepeatedCharacter("mohammed");

            Console.WriteLine(x);
            #endregion

        }
    }
}
