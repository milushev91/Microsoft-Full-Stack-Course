using System;
using System.Collections.Generic;

class TaskItem
{
    public string Description { get; set; }
    public bool IsComplete { get; set; }

    public TaskItem(string description)
    {
        Description = description;
        IsComplete = false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<TaskItem> tasks = new List<TaskItem>();
        bool exit = false;

        while (!exit)
        {
            DisplayMenu();
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                ProcessChoice(choice, tasks, ref exit);
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("1. View Tasks");
        Console.WriteLine("2. Add Task");
        Console.WriteLine("3. Mark Task Complete");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");
    }

    static void ProcessChoice(int choice, List<TaskItem> tasks, ref bool exit)
    {
        switch (choice)
        {
            case 1:
                ViewTasks(tasks);
                break;
            case 2:
                AddTask(tasks);
                break;
            case 3:
                MarkTaskComplete(tasks);
                break;
            case 4:
                exit = true;
                break;
            default:
                Console.WriteLine("Invalid option, please try again.");
                break;
        }
    }

    static void ViewTasks(List<TaskItem> tasks)
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = tasks[i].IsComplete ? "Complete" : "Pending";
                Console.WriteLine($"{i + 1}. {tasks[i].Description} - {status}");
            }
        }
    }

    static void AddTask(List<TaskItem> tasks)
    {
        Console.Write("Enter the task: ");
        string taskDescription = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(taskDescription))
        {
            Console.WriteLine("Task description cannot be empty.");
        }
        else
        {
            tasks.Add(new TaskItem(taskDescription));
            Console.WriteLine("Task added.");
        }
    }

    static void MarkTaskComplete(List<TaskItem> tasks)
    {
        Console.Write("Enter the task number to mark complete: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
        {
            if (tasks[taskNumber - 1].IsComplete)
            {
                Console.WriteLine("Task is already complete.");
            }
            else
            {
                tasks[taskNumber - 1].IsComplete = true;
                Console.WriteLine("Task marked as complete.");
            }
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
}