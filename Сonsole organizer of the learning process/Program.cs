using System.Collections.Generic;
using System.Threading.Tasks;
using Сonsole_organizer_of_the_learning_process;

Group group = new Group(); // создаем объект группы
//добавляем студентов в группу
group.AddStudent(new Student("Иванов Иван", 1234, "1234"));
group.AddStudent(new Student("Петров Петр", 56788 ,"677"));
group.AddLesson(new Lessons("Математика", LessonType.Other ));
group.AddLesson(new Lessons("Физика"));
// добавляем задания в группу
group.AddTask(new Task("Домашнее задание 1", "Математика"));
group.AddTask(new Task("Домашнее задание 2", "Физика"));


    Console.WriteLine("Введите запрос (students - студенты, lessons - занятия, tasks - задания):");
    string query = Console.ReadLine(); // считываем запрос от пользователя

    switch (query)
    {
        case "students":
            group.PrintStudentsInfo(); // выводим информацию о студентах
            break;
        case "lessons":
            group.PrintLessonsInfo(); // выводим информацию о занятиях
            break;
        case "tasks":
            group.PrintTasksInfo(); // выводим информацию о заданиях
            break;
        default:
            Console.WriteLine("Некорректный запрос!");
            break;
    }


