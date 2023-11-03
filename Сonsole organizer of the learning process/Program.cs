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
            group.AddStudent();
            break;
        case 3:
            group.RemoveStudent(); 
            break;
        case 4:
            group.AddLesson();
            break;
        case 5:
            group.RemoveLesson();
            break;
        case 6:
            group.AddTask();
            break;
        case 7:
            group.RemoveTask();
            break;
         case 0:
            Console.WriteLine("Выход из программы");
            break;
        default:
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
            break;
    }
} while (option != 0);





