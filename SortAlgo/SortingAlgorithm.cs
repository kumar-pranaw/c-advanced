using System;
using System.Collections.Generic;

namespace SortAlgo
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string EmpSalary { get; set; }
    }
    public static class SortingAlgorithm
    {
        public static int[] DefaultSorting()
        {
            int[] unSortedArray = new[] { 1, 5, 32, 20, 10, 0, 5, 22 };

            int[] sortedArray = { };
            string[] unsortedStringArray = new[] { "A", "D", "J", "K" };
            // Console.WriteLine(unsortedStringArray);
            Array.Sort(unSortedArray);
            for (int i = 0; i < unSortedArray.Length; i++)
            {

            }

            return unSortedArray;
        }

        public static List<Employee> ListEmployees()
        {
            List<Employee> employees = new List<Employee>
           {
               new Employee()
               {
                   EmpName = "Loveleen Kaur",
                   EmpSalary = "30,000",
                   Id = 2
               },
               new Employee()
               {
                   EmpName = "Pranav Kumar",
                   EmpSalary = "40,000",
                   Id = 3
               },
               new Employee()
               {
                   EmpName = "John Bennett",
                   EmpSalary = "30,000",
                   Id = 1
               },
               new Employee()
               {
                   EmpName = "Marline Adams",
                   EmpSalary = "30,000",
                   Id = 4
               }
           };

            return employees;

        }

        private static void SortArray(int[] numbers)
        {
            QuickSort(numbers, 0, numbers.Length - 1);
        }

        private static void QuickSort(int[] numbers, int left, int right)
        {

        }
    }
}
