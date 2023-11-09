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
        public void SetAssignmentStatus(int assignment, bool status)
        {
            assignmentStatus[assignment] = status;
        }

       // метод присваения статуса
        public string GetAssignmentStatus(int assignment)
        {
            bool status;
            if (assignmentStatus.TryGetValue(assignment, out status))
            {
                return status ? "Принято" : "Не принято";
            }
            else
            {
                return "Статус отсутствует";
            }
        }


    }

}
