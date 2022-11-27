using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsConcepts
{
    internal class PrintArray<S>// int
    {
        S[] arr;
        public PrintArray(S[] ts)
        {
            this.arr = ts;
        }
        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"  ");
            }
        }
    }
}
