using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public static class Singleton
    {
        private static readonly int Counter = 0;
        static Singleton()
        {
            Console.WriteLine(Counter++);
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
            dynamic[] array = new dynamic[3];

            array[0] = 1;
            array[1] = "string";

            Student student = new Student();
            student.Id = 99;
            student.Name = "Pranav";

            array[2] = student;

        }

        public static (int , int) Divide(int num1,int num2)
        {
            return (num1, num2);
        }
    }


    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class NewClass
    {

    }
}
