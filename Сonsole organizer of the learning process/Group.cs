using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonsole_organizer_of_the_learning_process
{
    public class Group
    {
       public List<IStudent> students { get; set; }
       public List<ILesson> lessons { get; set; }
       public  List<ITask> tasks { get; set; }
       public Group() 
        {
            students = new List<IStudent>();
            lessons = new List<ILesson>();
            tasks = new List<ITask>();
        }
        
        public void AddStudent(IStudent student)
        {
            students.Add(student);
        }
        public void RemoveStudent(string studenToDeleteName)
        {
            for( int i = 0; i < students.Count; i++)
            {
                IStudent student = students[i];

                if (studenToDeleteName == student.FullName)
                {
                    students.Remove(student);
                }
                else
                {
                    Console.WriteLine($"Студент с именем '{studenToDeleteName}' не найден.");
                }
            }
        }
        public void AddLesson(ILesson lesson)
        {
            lessons.Add(lesson);
        }
        public void RemoveLesson( string lessonToDeleteDate)
        {
            for( int i = 0;i < lessons.Count;i++)
            {
                ILesson lesson = lessons[i];

                if (lessonToDeleteDate == lesson.Date)
                {
                    lessons.Remove(lesson);
                }
                else
                {
                    Console.WriteLine($"Студент с именем '{lessonToDeleteDate}' не найден.");
                }
            }
        }
        public void AddTask(ITask task)
        {
            tasks.Add(task);
        }
        public void RemoveTask(string taskToDeleteName)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                ITask task = tasks[i];

                if (taskToDeleteName == task.Name)
                {
                    tasks.Remove(task);
                }
                else
                {
                    Console.WriteLine($"Занятие  с указанной датой '{taskToDeleteName}' не найдено.");
                }
            }
        }
        public void AddSubtask(string taskName,string sub )
        {
           for( int i = 0; i< tasks.Count; i++)
            {
                ITask task = tasks[i];
                if(taskName == task.Name)
                {
                  task.Subtasks.Add(sub);
                }
            }
        }
        public void RemoveSubtask(string taskName,string sub)
        {
            for( int i =0; i< tasks.Count; i++)
            {
                ITask task = tasks[i];
                if( taskName == task.Name)
                {
                    task.Subtasks.Remove(sub);
                }
            }
        }
        public void AssignATask(string studentName,string task,string status)
        {
            for( int i = 0 ; i< students.Count ; i++) 
            {
                IStudent student = students[i];
                if(studentName == student.FullName)
                {
                    student.acceptedTask.Add(task,status);
                }
            }
        }
        public Dictionary<string, string> GetTaskStatus(string taskName) 
        {
            Dictionary<string, string> statusesByStudent = new Dictionary<string, string>();
            foreach( IStudent student in students) 
            {
                string status= student.acceptedTask[taskName];
                statusesByStudent.Add(student.FullName,status);
            }
            return statusesByStudent;
        }
        public Dictionary<string, string> GetStudentStatus(string studentName)
        {
            Dictionary<string, string> statusesByTasks = new Dictionary<string, string>();

            //находим студента с указанным именем
            foreach (IStudent student in students)
            {
                if (studentName == student.FullName)

                { foreach (ITask task in tasks)
                    {
                        statusesByTasks = student.acceptedTask;
                    }

                 }
                else
                {
                    Console.WriteLine($"Студента с именем {studentName} нет в группе");
                }
            }
            return statusesByTasks;
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
