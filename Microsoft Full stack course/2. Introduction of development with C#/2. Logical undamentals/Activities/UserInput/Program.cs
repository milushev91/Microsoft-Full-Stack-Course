public class UserInput

{
    public static void GreetUser()

    {
        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");
    }

    public static void Main()
    {
        GreetUser();
    }
}
