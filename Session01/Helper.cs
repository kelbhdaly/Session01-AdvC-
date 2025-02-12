using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    internal static class Helper<T> where T : IEquatable<T>, IComparable<T>
    {

        public static void BubbleSort(T[] array)
        {
            if (array is null) return;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    //if (array[j] > array[j+1])
                    if (array[i].CompareTo(array[j + 1]) > 0)
                        Swap(ref array[j], ref array[j + 1]);
                }
            }
        }


        public static void BubbleSort(T[] array, IComparer<T> comparer)
        {
            if (array is null) return;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    //if (array[j] > array[j+1])
                    //  if (array[i].CompareTo(array[j+1]) >0) 

                    if (comparer.Compare(array[i], array[j]) > 0)
                        Swap(ref array[j], ref array[j + 1]);
                }
            }
        }


        public static int LinerSearch(T[] arr, T value)
        {
            if (arr?.Length > 0 && value is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {

                    if (value.Equals(arr[i]))
                        return i;

                    //Operator '==' cannot be applied to operands of type 'T' and 'T'
                    //if (arr[i] == value)
                    //if((value?.Equals(arr[i])) ?? false)
                }
            }
            return -1;

        }

        public static int LinerSearch(T[] arr, T value, IEqualityComparer<T> equalityComparer)
        {
            if (arr?.Length > 0 && value is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (equalityComparer.Equals(arr[i], value))
                        return i;
                }
            }
            return -1;

        }






        public static void Swap(ref T x, ref T y)
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
