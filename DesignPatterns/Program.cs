using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.PrintMessage("Message From Employee");
            Singleton.PrintMessage("Message From Employer");
            Singleton.PrintMessage("Message From Staff");
        }
    }
}
