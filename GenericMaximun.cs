//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace GenericsConcepts
//{
//    /// <summary>
//    /// with generics we don't have to duplicate the methods again and again
//    /// </summary>
//    /// <typeparam name="T"></typeparam>
//    internal class GenericMaximum<T> where T : IComparable// Person
//    {
//        public T MaximumValue(T firstValue, T secondValue, T thirdValue)
//        {
//            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
//            {
//                return firstValue;
//            }
//            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 )
//            {
//                return secondValue;
//            }
//            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 )
//            {
//                return thirdValue;
//            }
//            return firstValue;
//        }
//    }
//    public class Person : IComparable
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int CompareTo(object obj)
//        {
//            if (obj is Person person)
//            {
//                return Id.CompareTo(person.Id);
//            }
//            throw new Exception("Invalid comparison");
//        }
//    }
//}
