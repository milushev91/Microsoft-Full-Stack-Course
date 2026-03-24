using System.Collections.Generic;


class InvetoryManager

{
    public static bool programContinue = true;
    public static List<string> products = [];
    public static List<int> quantities = [];
    public static List<double> prices = [];

    public static void DisplayMainMenu()

    {
        Console.WriteLine("Choose option(1, 2, 3 or 4): ");
        Console.WriteLine("1. Add new product.");
        Console.WriteLine("2. Update product stock.");
        Console.WriteLine("3. View Inventory.");
        Console.WriteLine("4. Remove product.");
        Console.WriteLine("5. Exit inventory manager.");
        
    }
    static void Main(string[] args)

    {
        while (programContinue)

        {
            DisplayMainMenu();
            string choice = Console.ReadLine();

            switch (choice)

            {
                
            }
        }
    }
}
