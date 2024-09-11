using System;
using System.Collections.Generic;

namespace TodoListManager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> todoList = new List<string>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nTodo List Manager");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. List Tasks");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddTask(todoList);
                        break;
                    case "2":
                        ListTasks(todoList);
                        break;
                    case "3":
                        RemoveTask(todoList);
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddTask(List<string> todoList)
        {
            Console.Write("Enter the task description: ");
            string task = Console.ReadLine();
            todoList.Add(task);
            Console.WriteLine("Task added.");
        }

        static void ListTasks(List<string> todoList)
        {
            if (todoList.Count == 0)
            {
                Console.WriteLine("No tasks to display.");
                return;
            }

            Console.WriteLine("Tasks:");
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todoList[i]}");
            }
        }

        static void RemoveTask(List<string> todoList)
        {
            ListTasks(todoList);

            if (todoList.Count == 0)
            {
                return;
            }

            Console.Write("Enter the number of the task to remove: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= todoList.Count)
            {
                todoList.RemoveAt(index - 1);
                Console.WriteLine("Task removed.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }
}

