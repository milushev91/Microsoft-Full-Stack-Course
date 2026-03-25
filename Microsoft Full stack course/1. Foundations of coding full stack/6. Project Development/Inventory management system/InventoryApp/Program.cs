using System;
using System.Collections.Generic;


namespace InventoryManager
{
    public class InventoryManager
    {
        //---------Global variables------------
        public static bool programContinue = true;
        public static List<string> products = new List<string>();
        public static List<int> quantities = new List<int>();
        public static List<double> prices = new List<double>();

        //------------Main Methods--------
        
        //Add new product to inventory. Checks from invalid product name, quantity or price
        //and prints error message to the console
        public static void AddProduct()

        {
            string productName = GetProductName();
            int productIndex = GetProductIndex(productName);

            if (productIndex != -1)

            {
                DisplayErrorMessage("product name. Product already inside inventory");
                return;
            }
            int productQuantity = GetProductQuantity();

            if (productQuantity == -1)

            {
                DisplayErrorMessage("quantity");
                return;
            }

            double productPrice = GetProductPrice();

            if (productPrice == -1)

            {
                DisplayErrorMessage("price");
                return;
            }

            products.Add(productName);
            quantities.Add(productQuantity);
            prices.Add(productPrice);

            string action = $"Product {productName} with quantity of {productQuantity} and price of ${productPrice} was added to inventory";
            DisplayConfirmationMessage(action);

        }

        //Update product's stock level. Returns error message if invalid product name or quantity are given.
        public static void UpdateProductStockLevel()

        {
            string productName = GetProductName();
            int productIndex = GetProductIndex(productName);

            if (productIndex == -1)
            {
                DisplayErrorMessage("product name");
                return;
            }

            int quantity = GetProductQuantity();

            if (quantity == -1)

            {
                DisplayErrorMessage("quantity");
                return;
            }

            Console.WriteLine("Choose update option:");
            Console.WriteLine("1. Increase stock.");
            Console.WriteLine("2. Decrease stock.");
            string updateOption = Console.ReadLine();

            switch (updateOption)

            {
                case "1":
                    quantities[productIndex] += quantity;
                    string action = $"Stock level of {products[productIndex]} was increased by {quantity}. New stock level is {quantities[productIndex]}.";
                    DisplayConfirmationMessage(action);
                    break;
                case "2":
                    if (quantities[productIndex] < quantity)

                    {
                        Console.WriteLine($"Cannot decrease stock by {quantity} because current stock level is only {quantities[productIndex]}.");
                        return;
                    }
                    quantities[productIndex] -= quantity;
                    action = $"Stock level of {products[productIndex]} was decreased by {quantity}. New stock level is {quantities[productIndex]}.";
                    DisplayConfirmationMessage(action);
                    break;
                default:
                    DisplayErrorMessage("update option");
                    break;
            }

        }
        
        //Display all products in inventory with their quantity and price.
        public static void DisplayInventory()

        {
            for (int i = 0; i < products.Count; i++)

            {
                Console.WriteLine($"Product: {products[i]}, quantity: {quantities[i]}, price: {prices[i]}");
            }
        }

        //Remove product from inventory. Returns error message if invalid product name is given.
        public static void RemoveProduct()

        {
            string productName = GetProductName();
            int productIndex = GetProductIndex(productName);

            if (productIndex == -1)

            {
                DisplayErrorMessage("product name. Product not in inventory");
                return;
            }

            products.RemoveAt(productIndex);
            quantities.RemoveAt(productIndex);
            prices.RemoveAt(productIndex);

            DisplayConfirmationMessage($"Product: {productName} was removed");
        }

        //Exit program and print goodbye message to the console.
        public static void ExitProgram()

        {
            programContinue = false;
            Console.WriteLine("Program ends...Goodbye");
        }
        // helper methods

        //Display available actions to the user.
        public static void DisplayActions()

        {
            Console.WriteLine("Select action(1, 2, 3 or 4):");
            Console.WriteLine("1. Add product.");
            Console.WriteLine("2. Update product stock level.");
            Console.WriteLine("3. View invetory.");
            Console.WriteLine("4. Remove product.");
            Console.WriteLine("5. Exit system.");

        }

        //Display error message to the console. Takes error type as parameter to specify the error.
        public static void DisplayErrorMessage(string errorType)

        {
            Console.WriteLine($"Invalid {errorType}. Try again!");
        }

        //Display confirmation message to the console. Takes action as parameter to specify the message.    
        public static void DisplayConfirmationMessage(string action)

        {
            Console.WriteLine($"Success... {action}!");
        }

        //Prompts user for product name and returns it. Converts product name to lower case to avoid case sensitivity issues.
        public static string GetProductName()

        {
            Console.WriteLine("Enter product name:");
            string productName = Console.ReadLine().ToLower();

            return productName;
        }

        //Prompts admin to enter quantity and returns it. Returns -1 if quantity is less or equal to 0.

        public static int GetProductQuantity()

        {
            Console.WriteLine("Enter product quantity:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int quantity) && quantity > 0)

            {
                return quantity;
            }

            return -1;

        }

        //Prompts admin to enter price and returns it. Returns -1 if price is less or equal to 0.
        public static double GetProductPrice()

        {
            Console.WriteLine("Enter product price:");
            string input = Console.ReadLine();
            double price;

            if (double.TryParse(input, out price) && price > 0)

            {
                return price;
            }

            return -1;

        }

        //Returns index of the product in the products list. Takes product name as parameter. Returns -1 if product is not found.
        public static int GetProductIndex(string productName)

        {
            int index;

            for (int i = 0; i < products.Count; i++)

            {
                if (products[i] == productName)

                {
                    return i;
                }
            }

            return -1;
        }

        public static void Main(string[] args)
        {

            while (programContinue)

            {
                DisplayActions();
                string actionNumber = Console.ReadLine();

                switch (actionNumber)

                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        UpdateProductStockLevel();
                        break;
                    case "3":
                        DisplayInventory();
                        break;
                    case "4":
                        RemoveProduct();
                        break;
                    case "5":
                        ExitProgram();
                        break;
                    default:
                        DisplayErrorMessage("action number");
                        break;
                }

            }


        }
    }
}
