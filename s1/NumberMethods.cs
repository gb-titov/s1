using System;
using System.Collections.Generic;

namespace s1
{
    internal class NumberMethods
    {

        public static int GetMax(int a, int b)
        {
            if (a == b)
                throw new ArgumentException("Numbers are equal");
            if (a > b)
                return a;
            return b;
        }

        public static int GetMax(int a, int b, int c)
        {
            if (a == b && b == c)
                throw new ArgumentException("Numbers are equal");
            if (a > b && a > c)
                return a;
            if (b > c)
                return b;
            return c;
        }

        public static bool IsEven(int a)
        {
            return a % 2 == 0;
        }


        public static IEnumerable<int> GetAllEvenTillNumber(int num)
        {
            if (num < 2)
                throw new ArgumentOutOfRangeException($"Number {num} less than 2");

            List<int> list = new List<int>();

            int i = 2;

            while (i <= num)
            {
               
                list.Add(i);
                i = i + 2;
            }
            return list;
        }
    }
}
