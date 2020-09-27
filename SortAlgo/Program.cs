using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SortAlgo
{
    public static class Program
    {

        static void Main(string[] args)
        {
            while(true)
            {
                PublicConstructor test = new PublicConstructor();
                Console.WriteLine(test.baseline);
                Thread.Sleep(1000);
            }
           // var selectedInt = ReturnSelectedInt();

            //foreach (var item in selectedInt)
            //{
            //    Console.WriteLine(item);
            //}
        }

        public static IEnumerable<int> ReturnSelectedInt()
        {
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);

            foreach (var item in list)
            {
                if (item > 5) yield return item;
            }
        }
    }

    /// <summary>
    /// Public Constructor
    /// </summary>
    public class PublicConstructor
    {
        // Static variable that must be initialized at run time.
        public readonly string baseline;
        public PublicConstructor()
        {
            baseline = DateTime.Now.ToLongTimeString();
        }
        //public static string CheckParentClass()
        //{

        //    return baseline.ToString();
        //}
    }

    /// <summary>
    /// Private Constructor
    /// </summary>
    public class PrivateConstructor
    {
        // Static variable that must be initialized at run time.
        public readonly string baseline;
        private PrivateConstructor()
        {
            baseline = DateTime.Now.ToLongTimeString();
        }
        //public static string CheckParentClass()
        //{

        //    return baseline.ToString();
        //}
    }

    /// <summary>
    /// Static Constructor
    /// </summary>
    public static class StaticConstructor
    {
        // Static variable that must be initialized at run time.
        public static readonly string baseline;
        static StaticConstructor()
        {
            baseline = DateTime.Now.ToLongTimeString();
        }
        //public static string CheckParentClass()
        //{

        //    return baseline.ToString();
        //}
    }
}
