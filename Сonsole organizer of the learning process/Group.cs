using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonsole_organizer_of_the_learning_process
{
    public class Group
    {
        List<Student> students { get; set; }
        List<ALessons> lessons { get; set; }
        List<ATasks> tasks { get; set; }
        public Group()
        {
            List<Student> students = new List<Student>();
            List<ALessons> lessons = new List<ALessons>();
            List<ATasks> tasks = new List<ATasks>();
        }
        public void InfoAboutGroup()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Информация о группе : {student.FullName} , {student.PhoneNumber} , {student.Email}");
            }
            
        }
    }
}
