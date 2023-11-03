using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonsole_organizer_of_the_learning_process
{
    public class Group
    {
        List<IStudent> students { get; set; }
        List<ILesson> lessons { get; set; }
        List<ITask> tasks { get; set; }
        //public Group(List<ITask> tasks)
       // {
          //  this.students = new List<IStudent>();
           // this.lessons = new List<ILesson>();
            //this.tasks = new List<ITask>();
       // }
        public void AddStudent(IStudent student)
        {
            students.Add(student);
        }
        public void RemoveStudent(IStudent student)
        {
            students.Remove(student);
        }
        public void AddLesson(ILesson lesson)
        {
            lessons.Add(lesson);
        }
        public void RemoveLesson(ILesson lesson)
        {
            lessons.Remove(lesson);
        }
        public void AddTask(ITask task)
        {
            tasks.Add(task);
        }
        public void RemoveTask(ITask task)
        {
            tasks.Remove(task);
        }
        // вывод информации 
        public void PrintLessonsInfo()
        {
            Console.WriteLine("Студенты в группе:");
            foreach (IStudent student in students)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("Занятия в группе:");
            foreach (ILesson lesson in lessons)
            {
                Console.WriteLine(lesson.ToString());
            }

            Console.WriteLine("Задания в группе:");
            foreach (ITask task in tasks)
            {
                Console.WriteLine(task.ToString());
            }
        }

    }

}   
