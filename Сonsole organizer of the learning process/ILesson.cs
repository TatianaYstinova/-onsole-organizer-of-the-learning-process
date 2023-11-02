﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonsole_organizer_of_the_learning_process
{
    public interface ILesson
    {// занятия

        public string Date();
        public List<string> topics();
        public string Comment();
        public enum LessonType //перечисление типов занятий
        {
            Lecture,
            Consultation,
            Other
        }


    }
}
