using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Сonsole_organizer_of_the_learning_process;

Group group = new Group();
Console.WriteLine("1 - Вывести информацию о группе");
Console.WriteLine("2 - Добавить студента");
Console.WriteLine("3 - Удалить студента");
Console.WriteLine("4 - Добавить занятие");
Console.WriteLine("5 - Удалить занятие");
Console.WriteLine("6 - Добавить задание");
Console.WriteLine("7 - Удалить задание");
Console.WriteLine("8 - Добавить подзадание");
Console.WriteLine("9 - Удалить подзадание");
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
        case 5:
            Console.WriteLine("Напишите дату  удаляемого занятия ");
            string lessonToDeleteDate = Console.ReadLine();
            group.RemoveLesson(lessonToDeleteDate);
            
            break;
        case 6:
            Console.WriteLine("Напишите тип задания:");
            Console.WriteLine("1 - Обычное задание");
            Console.WriteLine("2 - Тестирование");
            Console.WriteLine("3 - Проект");
            int task= int.Parse(Console.ReadLine());

            switch (task)
            {
                case 1:
                    Console.WriteLine("Напишите название:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Напишите формулировку:");
                    string formulation = Console.ReadLine();
                    Console.WriteLine("Напишите ссылки на доп материалы по одной через enter или 'stop', чтобы перейти дальше:");
                    string linksToAddMaterial = Console.ReadLine();
                    List<string> linksToAddMaterials = new List<string>();

                    while (linksToAddMaterial != "stop")
                    {
                        linksToAddMaterials.Add(linksToAddMaterial);
                        Console.WriteLine("Напишите список тем занятия по одной через enter или 'stop', чтобы перейти дальше:");
                        linksToAddMaterial = Console.ReadLine();

                    }

                    Console.WriteLine("Напишите срок сдачи");
                    string deadLine = Console.ReadLine();
                    group.AddTask(new RegularAssignment(name , deadLine , formulation ,linksToAddMaterials));
                   
                    break;
                case 2:
                    Console.WriteLine("Напишите название теста:");
                    string nameTest= Console.ReadLine();
                    Console.WriteLine("Напишите ссылки на тестирование в стороннем ресурсе по одной через enter или 'stop', чтобы перейти дальше:");
                    string testing = Console.ReadLine();
                    List<string> LinkTestInAThirdPartyResource = new List<string>();

                    while(testing != "stop")
                    {
                        LinkTestInAThirdPartyResource.Add(testing);
                        Console.WriteLine("Напишите ссылки на тестирование в стороннем ресурсе по одной через enter или 'stop', чтобы перейти дальше:");
                        testing = Console.ReadLine();
                    }
                    Console.WriteLine("Напишите срок сдачи");
                    string dateOfDelivery = Console.ReadLine();
                    group.AddTask(new TestAssignment(nameTest, dateOfDelivery, LinkTestInAThirdPartyResource));
                
                    break;
                case 3:
                    Console.WriteLine("Напишите название:");
                    string nameProject = Console.ReadLine();
                    Console.WriteLine("Напишите кратное описание:");
                    string description = Console.ReadLine();
                    Console.WriteLine("Напишите набор подзадач по одной через enter или 'stop', чтобы перейти дальше:");
                    string addSubtask = Console.ReadLine();

                    List<string> Subtasks = new List<string>();

                    while ( addSubtask != "stop")
                    {
                        Subtasks.Add(addSubtask);
                        Console.WriteLine("Напишите набор подзадач по одной через enter или 'stop', чтобы перейти дальше:");
                        addSubtask = Console.ReadLine();
                    }

                    Console.WriteLine("Напишите ссылки на доп материалы по одной через enter или 'stop', чтобы перейти дальше:");
                    string addMaterials = Console.ReadLine();

                    List<string> LinksToAddMaterials = new List<string>();

                    while (addMaterials != "stop")
                    {
                        LinksToAddMaterials.Add(addMaterials);
                        Console.WriteLine("Напишите ссылки на доп материалы по одной через enter или 'stop', чтобы перейти дальше:");
                        addMaterials= Console.ReadLine();
                    }

                    Console.WriteLine("Напишите срок сдачи:");
                    string deadlineDelivery = Console.ReadLine();
                    group.AddTask(new ProjectAssignment(nameProject, description , Subtasks, LinksToAddMaterials , deadlineDelivery));
                  
                    break;
                default:
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
                    
                    break;
            }

            break;
        case 7:
            Console.WriteLine("Напишите название удаляемого занятия");
            string taskToDeleteName = Console.ReadLine();
            group.RemoveTask(taskToDeleteName);

           break;
        case 8:
            List<String> subtasks = new List<string>();
            while (true)
            {
                Console.WriteLine("Введите подзадачу (или 'exit' для выхода): ");
                string sub = Console.ReadLine();

                if(sub.ToLower() == "exit")
                {
                    break;
                }
                subtasks.Add(sub);
                Console.WriteLine("Подзадача добавлена.");
            }
            Console.WriteLine("Список подзадач:");
            foreach(string sub in subtasks)
            {
                Console.WriteLine(sub);
            }
            group.

            break;
        //case 9:
        //    Console.WriteLine("Напишите подзадачу для удаления");
        //    string








        case 0:

            Console.WriteLine("Выход из программы");

            break;
        default:
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");

            break;
    }
} while (option != 0);





