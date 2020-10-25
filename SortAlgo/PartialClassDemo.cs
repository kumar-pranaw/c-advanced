using System;
using System.Collections.Generic;
using System.Text;

namespace SortAlgo
{
    public static partial class PartialClass
    {
        public static string EmpFirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public static string EmpLastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public static string MyName()
        {
            return _firstName + " " + _lastName;
        }
    }
}
