using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV_01
{
    public class FixedSizeList<T>
    {
        public T[] List { get; set; }
        public int Size { get; set; }

        public FixedSizeList(int capacity)
        {
            
            List = new T[capacity];
        }

       public void  Add (T item)
        {
            if (Size < List.Length)
            {
                List[Size] = item;
                Size++;
                Console.WriteLine("Item added successfully");
            }
            else
            {
                Console.WriteLine("List is full");
            }
        }

        public T Get(int index)
        {
            if (index < Size)
            {
                return List[index];
            }
            else
            {
                Console.WriteLine("Index out of range");
                return default(T);
            }
        }



    }
}
