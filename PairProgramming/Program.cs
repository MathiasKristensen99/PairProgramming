using System;

namespace PairProgramming
{
    static class Program
    {
        public 
        
        static void Main(string[] args)
        {
            int[] a = {1, 5, 6, 9, 15};
            int[] b = {3, 7, 8, 11, 18,};

            int[] array = a.Concat(b);
            int temp = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static T[] Concat<T>(this T[] first, params T[] second)
        {
            if (first == null)
            {
                return second;
            }

            if (second == null)
            {
                return first;
            }

            T[] result = new T[first.Length + second.Length];
            first.CopyTo(result, 0);
            second.CopyTo(result, first.Length);

            return result;
        }
    }
}