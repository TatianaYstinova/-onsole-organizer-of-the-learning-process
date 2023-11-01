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
        public Group(  List<ITask> tasks)
        {
            this.students = new List<IStudent>();
            this.lessons = new List<ILesson>();
            this.tasks = new List<ITask>();
        }
        public void AddStudent(IStudent student)
        {
            students.Add(student);
        }
        public void AddLesson(ILesson lesson)
        {
            lessons.Add(lesson);
        }
        public void AddTask(ITask task)
        {
            tasks.Add(task);
        }
        // вывод информации о занятиях
        public void PrintLessonsInfo()
        {
            Console.WriteLine("Занятия:");
            foreach (ILesson lesson in lessons)
            {
                Console.WriteLine(lesson.Date,lesson.);
            }
        }

        // вывод информации о заданиях
        public void PrintTasksInfo()
        {
            Console.WriteLine("Задания:");
            foreach (var task in tasks)
            {
                Console.WriteLine($"Название: {task.Name}, Занятие: {task.LessonName}");
            }
        }
    }
}
