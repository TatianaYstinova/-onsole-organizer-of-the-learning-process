using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonsole_organizer_of_the_learning_process
{
    public interface ILesson
    {// занятия

        public string Date { get; set; }
        public List<string> topics { get; set; }
        public string Comment { get; set; }
        public enum LessonType //перечисление типов занятий
        {
            Lecture,
            Consultation,
            Other
        }


    }
}
