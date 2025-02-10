using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    internal static class Helper<T>
    {
        public static void Swap( ref T x , ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        
        //public static void Swap( ref decimal x , ref decimal y)
        //{
        //    decimal temp = x;
        //    x = y;
        //    y = temp;
        //}
        
        //public static void Swap( ref Point x , ref Point y)
        //{
        //    Point temp = x;
        //    x = y;
        //    y = temp;
        //}

    }
}
