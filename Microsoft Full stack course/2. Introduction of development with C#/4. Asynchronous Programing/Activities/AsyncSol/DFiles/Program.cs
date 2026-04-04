public class Program

{
    public async Task<string> DownloadFileAsync(string fileName)

    {
        Console.WriteLine($"Download of {fileName} started.");
        await Task.Delay(3000);
        Console.WriteLine($"Download of {fileName} completed.");
        return $"{fileName} content";
    } 

    public async Task DownloadFilesAsync()

    {
        var downloadTask1 = DownloadFileAsync("File1");
        var downloadTask2 = DownloadFileAsync("File2");

        await Task.WhenAll(downloadTask1, downloadTask2);
        Console.WriteLine("All downloads completed.");
    }

    public static async Task Main(string[] args)

    {
        Program program = new();
        await program.DownloadFilesAsync();
        Console.WriteLine("Main method ended");
    }
}