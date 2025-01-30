using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV_01
{
    public class Range<T> where T : IComparable<T>
    {
       public T Max { get; set; }
       public T Min { get; set; }

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
                return ;
            Min = min;
            Max = max;
            
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public static T Length(T min,T max)
        {
            dynamic Max = max;
            dynamic Min = min;
            dynamic length = Max - Min;
            return length;

        }
    }
}
