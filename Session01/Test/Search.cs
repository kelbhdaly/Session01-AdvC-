using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01.Test
{
    internal static class Search<T> where T :IEquatable<T>
    {
        public static int Search02(T[] arr02 , T valueSearch , IEqualityComparer<T> equalityComparer)
        {
            if (arr02.Length >0 && valueSearch is not null)
            {
                for (int i = 0; i < arr02.Length; i++)
                {
                    if (valueSearch.Equals(arr02[i])) 
                        return i;

                }

            }
            return -1;
        }

    }
}
