using System;

namespace TaskManager
{
    public class Program
    {
        // ----------- Global variables ---------
        // Controls program's main loop
        public static bool programContinue = true;

        // Tasks variables
        public static string task1 = "";
        public static string task2 = "";
        public static string task3 = "";

        // Tasks status variables
        public static bool task1Completed = false;
        public static bool task2Completed = false;
        public static bool task3Completed = false;

        // ---------- Methods -----------------

        // Stops program main loop
        public static void ExitMainLoop()
        {
            programContinue = false;
        }

        // Print Activities on the console
        public static void DisplayActivities()
        {
            Console.WriteLine("Pick activity from the following list (1, 2, 3 or 4):");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Mark task as completed");
            Console.WriteLine("3. Display tasks and their status");
            Console.WriteLine("4. Exit program");
        }

        // Prompt user for new task 
        public static string GetNewTask()
        {
            Console.WriteLine("Enter task: ");
            string newTask = Console.ReadLine();

            return newTask;
        }

        // Add new Tasks
        public static void AddNewTask()
        {
            string newTask = GetNewTask();

            if (task1 == "")
            {
                task1 = newTask;
            }
            else if (task2 == "")
            {
                task2 = newTask;
            }
            else if (task3 == "")
            {
                task3 = newTask;
            }
            else
            {
                Console.WriteLine("No more new tasks can be added!");
            }
        }
        
        //Print Valid option
        public static void PrintValidTasks(string validOptions)
        
        {
            Console.WriteLine("Set task as completed. Choose the corresponding number:");
            
            if (validOptions.Contains("1"))
            
            {
                Console.WriteLine("1." + task1);
            }
            
            if (validOptions.Contains("2"))
            
            {
                Console.WriteLine("2." + task2);
            }
            
            if (validOptions.Contains("3"))
            
            {
                Console.WriteLine("3." + task3);
            }
         
        }
        
        public static bool CheckTask(string task)
        
        {
            if (task != "")
            
            {
                return true;
            }
            
            return false;
        }
        
        //Return valid options
        public static string ReturnValidOptions()
        
        {
            string validOptions = "";
            if (CheckTask(task1))
            
            {
                validOptions += "1";
            } 
            
            if (CheckTask(task2))
            
            {
                validOptions += "2";
            }
            
            if (CheckTask(task3))
            
            {
                validOptions += "3";
            }
            
            return validOptions;
        }
        
        public static string ReturnValidChoice()
        
        {
            string validOptions = ReturnValidOptions();
            
            PrintValidTasks(validOptions);
            string userChoice = Console.ReadLine();
            
            while (!validOptions.Contains(userChoice))
            
            {
                Console.WriteLine("Invalid task. Choose valid task number!");
                PrintValidTasks(validOptions);
                userChoice = Console.ReadLine();
            }
            
            return userChoice;
        }
        
        public static void MarkTaskAsCompleted()
        
        {
            string userChoice = ReturnValidChoice();
            
            switch (userChoice)
            
            {
                case "1":
                    task1Completed = true;
                    Console.WriteLine($"{task1} is now completed");
                    break;
                case "2":
                    task2Completed = true;
                    Console.WriteLine($"{task2} is now completed");
                    break;
                case "3":
                    task3Completed = true;
                    Console.WriteLine($"{task3} is now completed");
                    break;
            }
            
        }

        public static void DisplayTaskAndStatus(string task, bool status)
        
        {
            if (CheckTask(task))
            
            {
                Console.WriteLine(task);
                
                if (status)
                {
                    Console.WriteLine("Completed");
                }
                
                else
                
                {
                    Console.WriteLine("Pending");
                }
                
            }
        }
        
        public static void DisplayAllTasksWithStatus()
        
        {
            DisplayTaskAndStatus(task1, task1Completed);
            DisplayTaskAndStatus(task2, task2Completed);
            DisplayTaskAndStatus(task3, task3Completed);
            
        }

        public static void Main(string[] args)
        {
            // ----------- Program Main Loop --------
            while (programContinue)
            {
                DisplayActivities();

                // Select activity
                string choicenActivity = Console.ReadLine();

                switch (choicenActivity)
                {
                    case "1":
                        AddNewTask();
                        break;

                    case "2":
                        MarkTaskAsCompleted();
                        break;

                    case "3":
                        DisplayAllTasksWithStatus();
                        break;

                    case "4":
                        Console.WriteLine("Goodbye. Program ends...");
                        ExitMainLoop();
                        break;

                    default:
                        Console.WriteLine("Invalid activity. Try again!");
                        break;
                }
            }
        }
    }
}
