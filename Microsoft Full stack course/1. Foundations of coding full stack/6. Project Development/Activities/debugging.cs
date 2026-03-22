using System;
using System.Collections.Generic;

class TaskManager
{
    static List<string> tasks = new List<string>();
    static List<bool> taskStatus = new List<bool>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Task Manager");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Mark Task as Completed");
            Console.WriteLine("3. View Tasks");
            Console.WriteLine("4. Exit");
Console.WriteLine("What would you like to do? (choose 1-4)");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    CompleteTask();
                    break;
                case "3":
                    ViewTasks();
                    break;
                case "4":
					Console.WriteLine("Exiting TaskManager... Goobye");
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.WriteLine("Enter task description:");
        string task = Console.ReadLine();
        tasks.Add(task);
        taskStatus.Add(false);  // Marking as not completed by default
        Console.WriteLine("Task added successfully.");
    }

    static void CompleteTask()
    {
		int tasksCount = tasks.Count;
		
		if (tasksCount == 0)
		{
			Console.WriteLine("No tasks available. Add tasks to complete them");
			return;
		}
        Console.WriteLine("Enter task number to mark as completed:");
		
		// Validate user input
		string input = Console.ReadLine();
		
		int taskNumber;
		while (!int.TryParse(input, out taskNumber))
		{
    		Console.WriteLine("Invalid task number! Enter valid task number:");
    		input = Console.ReadLine();
		}
		
		// Fixing Invalid number condition
        if (taskNumber <= 0 || taskNumber > tasks.Count)
        {
            Console.WriteLine("Invalid task number.");
            return;
        }
		
		//Fixing added task status
        taskStatus[taskNumber - 1] = true;
        Console.WriteLine($"Task '{tasks[taskNumber - 1]}' marked as completed.");
    }

    static void ViewTasks()
    {
		int tasksCount = tasks.Count;
		
		if (tasksCount == 0)
		{
			Console.WriteLine("No tasks available. Add tasks to view them");
		}
		
		else 
		{

			Console.WriteLine("Tasks:");
			//Fixing Loop end
			for (int i = 0; i < tasks.Count; i++)
			{
				string status = taskStatus[i] ? "Completed" : "Pending";
				Console.WriteLine($"{i + 1}. {tasks[i]} - {status}");
			}
		}
    }
}
