﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonsole_organizer_of_the_learning_process
{
    public class Student:IStudent
    {
        public string FullName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public Student (string fullName, int phoneNumber, string email)
        {
            string FullName = fullName;
            int PhoneNumber = phoneNumber;
            string Email = email;
        }
    }
}
