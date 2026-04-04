public class Program

{
    public static string book1Title = "";
    public static string book2Title = "";
    public static string book3Title = "";
    public static string book4Title = "";
    public static string book5Title = "";

    public static string GetChoice()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Add a book");
        Console.WriteLine("2. Remove a book");
        Console.WriteLine("3. View all books");
        Console.WriteLine("4. Exit");

        return Console.ReadLine();
    }

    public static void AddBook()
    {
        Console.WriteLine("Enter the title of the book to add:");
        string title = Console.ReadLine();

        if (string.IsNullOrEmpty(book1Title))
        {
            book1Title = title;
        }
        else if (string.IsNullOrEmpty(book2Title))
        {
            book2Title = title;
        }
        else if (string.IsNullOrEmpty(book3Title))
        {
            book3Title = title;
        }
        else if (string.IsNullOrEmpty(book4Title))
        {
            book4Title = title;
        }
        else if (string.IsNullOrEmpty(book5Title))
        {
            book5Title = title;
        }
        else
        {
            Console.WriteLine("Library is full. Cannot add more books.");
        }
    }
    
    public static void RemoveBook()
    {
        Console.WriteLine("Enter the title of the book to remove:");
        string title = Console.ReadLine();

        if (book1Title == title)
        {
            book1Title = "";
        }
        else if (book2Title == title)
        {
            book2Title = "";
        }
        else if (book3Title == title)
        {
            book3Title = "";
        }
        else if (book4Title == title)
        {
            book4Title = "";
        }
        else if (book5Title == title)
        {
            book5Title = "";
        }
        else
        {
            Console.WriteLine("Book not found in the library.");
        }
    }
    
    public static void ViewBooks()
    {
        Console.WriteLine("Books in the library:");
        if (!string.IsNullOrEmpty(book1Title)) Console.WriteLine(book1Title);
        if (!string.IsNullOrEmpty(book2Title)) Console.WriteLine(book2Title);
        if (!string.IsNullOrEmpty(book3Title)) Console.WriteLine(book3Title);
        if (!string.IsNullOrEmpty(book4Title)) Console.WriteLine(book4Title);
        if (!string.IsNullOrEmpty(book5Title)) Console.WriteLine(book5Title);
    }
    public static void Main(string[] args)

    {
        string choice = GetChoice();

        while (choice != "4")
        {
            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    RemoveBook();
                    break;
                case "3":
                    ViewBooks();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            choice = GetChoice();
        }

    }

}
