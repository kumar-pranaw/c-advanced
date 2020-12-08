using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    class InterviewPrograms
    {
        public void StupidPrograms()
        {
            var email = "prnvkmr954@gmail.com";

            var fullName = "Pranav Kumar Verma";
            string vowels = "aeiou";

            var phoneNumber = "9878346215";
            string[] stringNumber = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            List<string> evenList = new List<string>();
            List<string> oddList = new List<string>();

            // FYI This is not any inbuild function this is LINQ expression removing the number from mail fastest then any regex and any inbuild function
            var mailWithoutNumber = new String(email.Where(c => c != '-' && (c < '0' || c > '9')).ToArray());
            Console.WriteLine(mailWithoutNumber);

            // Remove vowels from name
            fullName = new string(fullName.Where(c => !vowels.Contains(c)).ToArray());
            Console.WriteLine(fullName);

            //Even Number First And Odd Numbers at last
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (Convert.ToInt32(phoneNumber[i]) % 2 == 0)
                {
                    evenList.Add(phoneNumber[i].ToString());
                }
                else
                {
                    oddList.Add(phoneNumber[i].ToString());
                }
            }

            var evenOutput = String.Join("", evenList);

            var oddOutput = String.Join("", oddList);

            // Separating even Numbers to first and odd to last
            Console.WriteLine(evenOutput + oddOutput);

            foreach (var item in stringNumber)
            {
                if (Convert.ToInt32(item) > 5)
                {
                    Console.WriteLine(item);
                }
            }

            var descendingNumber = stringNumber.Select(x => x).OrderByDescending(x => x);
        } 
    }
}
