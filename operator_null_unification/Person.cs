using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_null_unification
{
    class Person
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string SecondName { get; set; }

        public Contacts Contacts { get; set; }

        public string GetFullName()
        {
            return $"Name: {FirstName} | Middle Name: {MiddleName} | Last Name: {SecondName ?? "No data"}";
        }

        public string GetPhoneNumber()
        {
            return $"Phone Number: {Contacts?.PhoneNumber ?? "No Data"}";
        }
    }
}
