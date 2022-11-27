using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsConcepts
{

    /// <summary>
    /// non-generic which causes method duplication
    /// </summary>
    internal class CompareToDemo
    {
        //  2,    3,    4
        public static int MaxIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            if ((firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0))
            {
                return firstValue;
            }
            if ((secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0))
            {
                return secondValue;
            }
            if ((thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0))
            {
                return thirdValue;
            }
            return firstValue;
        }
        public static float MaxFloatNumber(float firstValue, float secondValue, float thirdValue)
        {
            if ((firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0))
            {
                return firstValue;
            }
            if ((secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0))
            {
                return secondValue;
            }
            if ((thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0))
            {
                return thirdValue;
            }
            return firstValue;
        }
        public static string MaxString(string firstValue, string secondValue, string thirdValue)
        {
            if ((firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0))
            {
                return firstValue;
            }
            if ((secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0))
            {
                return secondValue;
            }
            if ((thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0))
            {
                return thirdValue;
            }
            return firstValue;
        }
        public static void Main()
        {
            // specific method for specific datatype
            Console.WriteLine(CompareToDemo.MaxString("aaa", "bbb", "ccc"));

            Console.WriteLine(MaxFloatNumber(1.1f, 2.2f, 3.3f));

            Console.WriteLine(MaxIntegerNumber(5, 3, 4));
        }
    }
}
