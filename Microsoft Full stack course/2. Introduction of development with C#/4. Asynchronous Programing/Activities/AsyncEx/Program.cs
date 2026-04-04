public class Program

{
    public static async Task PerformLongOperationAsync()
    {
        try
        {
            Console.WriteLine("Operation started...");
            await Task.Delay(3000);
            Console.WriteLine("Operation completed.");

            throw new Exception("Simulated error");
        }

        catch  (Exception ex)
        {
            Console.WriteLine("Error is: " + ex.Message);
        }



    }

    public static async Task Main()

    {
        await PerformLongOperationAsync();
        Console.WriteLine("Main method ended.");

    }
}
