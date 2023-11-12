using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonsole_organizer_of_the_learning_process
{
    public class Student : IStudent
    {
        public string FullName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public Dictionary<string,string > acceptedTask { get; set; }
       
        public Student(string fullName, int phoneNumber, string email)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public override string ToString()
        {
            string ops= FullName + " " + PhoneNumber + " " + Email;

            return ops;
        }

    }

}
