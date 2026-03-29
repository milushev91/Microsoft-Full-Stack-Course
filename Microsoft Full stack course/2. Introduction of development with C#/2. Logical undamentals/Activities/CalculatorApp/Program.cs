public class Calculator
{
    static readonly int number1 = 5;
    static readonly int number2 = 10;

    public static int Add()

    {
        return number1 + number2;
    }

    static void Main()

    {
        int result = Add();
        Console.WriteLine("Result is: " + result + ".");
    }
}
