using System.Collections.Generic;
using System.Threading.Tasks;
using Сonsole_organizer_of_the_learning_process;

Group group = new Group();
Console.WriteLine("1 - Вывести информацию о группе");
Console.WriteLine("2 - Добавить студента");
Console.WriteLine("3 - Удалить студента");
Console.WriteLine("4 - Добавить занятие");
Console.WriteLine("5 - Удалить занятие");
Console.WriteLine("6 - Добавить задание");
Console.WriteLine("7 - Удалить задание");
Console.WriteLine("0 - Выход");


int option;
do
{
    Console.WriteLine("Введите запрос : ");
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            group.PrintLessonsInfo();
            break;
        case 2:
            Console.WriteLine("Напишите полное имя студента :");
            string fullName = Console.ReadLine();
            Console.WriteLine("Напишите номер телефона студента :");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Напишите почту студента :");
            string email = Console.ReadLine();
            IStudent student = new Student(fullName, number, email);
            group.AddStudent(student);
            break;
        case 3:
            Console.WriteLine("Напишите имя студента:");
             string studenToDeleteName = Console.ReadLine();
             group.RemoveStudent(studenToDeleteName);
             break;
        case 4:
            Console.WriteLine("Напишите дату занятия");
            string data = Console.ReadLine();
            Console.WriteLine("Напишите список тем занятия по одной через enter или 'stop', чтобы перейти дальше:");
            string topic = Console.ReadLine();
            List <string> topics = new List<string>();

             while (topic!= "stop")
             {
                topics.Add(topic);
                Console.WriteLine("Напишите список тем занятия по одной через enter или 'stop', чтобы перейти дальше:");
                topic =Console.ReadLine();

             }
            Console.WriteLine("Напишите комментарий от преподавателя:");
            string comment = Console.ReadLine();
            Console.WriteLine("Напишите тип занятия :");
            Console.WriteLine("1 - Лекция");
            Console.WriteLine("2 - Консультация");
            Console.WriteLine("3 - Другое");
            int type = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1:
                    Console.WriteLine(LessonType.Lecture);
                    break;
                case 2:
                    Console.WriteLine(LessonType.Consultation); 
                    break;
                case 3:
                    Console.WriteLine(LessonType.Other);
                    break;
            }
            ILesson lesson = new Lessons(data, topics, comment,LessonType.Lecture);
            group.AddLesson(lesson);
        break;
        //case 5:
        //    group.RemoveLesson();
        //    break;
        //case 6:
        //    group.AddTask();
        //    break;
        //case 7:
        //    group.RemoveTask();
        //    break;
         case 0:
            Console.WriteLine("Выход из программы");
            break;
        default:
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
            break;
    }
} while (option != 0);





