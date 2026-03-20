using System;


namespace TaskManager
{
	public class Program
	
	{
	  //-----------Global variables---------
	  //Controls program's main loop
		public static bool programContinue = true;
		
			//Tasks variables
		public static string task1 = "";
		public static string task2 = "";
		public static string task3 = "";
			
		//Tasks status variables
		public static	bool task1Completed = false;
		public static bool task2Completed = false;
		public static bool task3Completed = false;
		
		//----------Methods-----------------
		//Stops program main loop
	  public static void ExitMainLoop()
	  
	  {
	    programContinue = false;
	  }
	  
	  //Print Activities on the console
	  public static void DisplayActivities()
	  
	  {
	    Console.WriteLine("Pick activity from the following list(1, 2, 3 or 4):");
	    Console.WriteLine("1. Add task");
	    Console.WriteLine("2. Mark task as completed");
	    Console.WriteLine("3. Display tasks and their status");
	    Console.WriteLine("4. Exit program");
	  }
	  
	  //Prompt user for new task 
	  public static string GetNewTask()
	  
	  {
	    Console.WriteLine("Enter task: ");
	    string newTask = Console.ReadLine();
	    
	    return newTask;
	  }
	  

	  //Add new Tasks
	  public static void AddNewTask(string newTask)
	  
	  {
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
	    
	    else {
	      Console.WriteLine("No more new tasks can be added!");
	    }
	  }
	  
	  
		public static void Main(string[] args)
		{
			//------------VARIABLES-------------
			

      
      //-----------Program Main Loop--------
			while (programContinue)
			
			{
			  DisplayActivities();
			  //Select activity
			  string choicenActivity = Console.ReadLine();
			  
			  switch (choicenActivity)
			  
			  {
			    case "1":
            string newTask = GetNewTask();
			      AddNewTask(newTask);
			      
			      break;
			    case "2":
			      break;
			    case "3":
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
