using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] orderStatuses = {"Pending", "Shipped", "Delivered", "Cancelled"};
        
        for (int i = 0; i < orderStatuses.Length; i++) {
            
            string status = orderStatuses[i];
            
            switch (status) {
                case "Pending":
                    Console.WriteLine("Order is pending.");
                    break;
                case "Shipped":
                    Console.WriteLine("Order has been shipped.");
                    break;
                case "Delivered":
                    Console.WriteLine("Order has beed delivered.");
                    break;
                case "Cancelled":
                    Console.WriteLine("Order has been cancelled.");
                    break;
                default:
                    Console.WriteLine("Unknown status.");
                    break;
            }
        }
    }   
}
