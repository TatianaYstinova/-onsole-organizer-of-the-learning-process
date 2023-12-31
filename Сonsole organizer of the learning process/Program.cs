﻿using System.Collections.Generic;
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
Console.WriteLine("10 - Отметить какие задания студентом были приняты");
Console.WriteLine("11 - Получить список статусов конкретного задания у всех студентов группы");
Console.WriteLine("12- Получить список статусов конкретного студента по всем заданиям группы");
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
            LessonType typeOne = LessonType.Lecture;

            switch (type)
            {
                case 1:
                    typeOne = LessonType.Lecture;
                    break;
                case 2:
                    typeOne = LessonType.Consultation;
                    break;
                case 3:
                    typeOne = LessonType.Other;
                    break;
            }

            ILesson lesson = new Lessons(data, topics, comment, typeOne);
            
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

                    ITask taskToAdd = new TestAssignment(nameTest, dateOfDelivery, LinkTestInAThirdPartyResource);
                    group.AddTask(taskToAdd);
                
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
            while (true)
            {
               Console.WriteLine("Введите подзадачу (или 'exit' для выхода): ");
               string subtaskAdd = Console.ReadLine();
               Console.WriteLine("Введите имя  задания для которого собираемся добавлять позадачу: ");
               string taskNameAdd = Console.ReadLine();

                if (subtaskAdd.ToLower() == "exit")
                {
                    break;
                }
                
                Console.WriteLine("Подзадача добавлена.");
            group.AddSubtask(taskNameAdd, subtaskAdd);
            }
            break;
        case 9:
           
            
               Console.WriteLine("Напишите подзадачу для удаления");
               string subtaskRemove = Console.ReadLine() ;
               Console.WriteLine("Напишите имя задания для которого собираетесь удалить подзадачу: ");
               string taskNameRemove = Console.ReadLine();

              Console.WriteLine("Подзадача удалена");
               group.RemoveSubtask(taskNameRemove, subtaskRemove);
            
            break;
        case 10:
            Console.WriteLine("Напишите имя студента:");
            string studentName = Console.ReadLine();
            Console.WriteLine("Напишите задание:");
            string taskName = Console.ReadLine();
            Console.WriteLine("Напишите статус задания:");
            string status = Console.ReadLine();
            group.AssignATask(studentName, taskName, status);

            break;
        case 11:
            Console.WriteLine("напишите название задания: ");

            string t = Console.ReadLine();// название задания

            Dictionary<string,string> statusesByStudent = group.GetTaskStatus(t);

            foreach( IStudent studentOne in group.students)
            {
                Console.WriteLine($"{studentOne.FullName}  {statusesByStudent[studentOne.FullName]}");
            }

            break;
            case 12:
            Console.WriteLine("Напишите имя студента:");
            string nameStudent = Console.ReadLine();

            Dictionary<string, string> statusesByTasks = group.GetStudentStatus(nameStudent);

            foreach( ITask taskOne in group.tasks)
            {
                Console.WriteLine($"{taskOne.Name}  {statusesByTasks[taskOne.Name]}");  
            }
            break;
        case 0:

            Console.WriteLine("Выход из программы");

            break;
        default:
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");

            break;
    }
} while (option != 0);

