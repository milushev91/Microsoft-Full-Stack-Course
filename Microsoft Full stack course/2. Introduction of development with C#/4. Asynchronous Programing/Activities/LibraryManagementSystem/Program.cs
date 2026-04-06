public class LibraryManager

{
    public static string book1Title = "";
    public static string book2Title = "";
    public static string book3Title = "";
    public static string book4Title = "";
    public static string book5Title = "";
    public static bool book1CheckedOut = false;
    public static bool book2CheckedOut = false;
    public static bool book3CheckedOut = false;
    public static bool book4CheckedOut = false;
    public static bool book5CheckedOut = false;
    public static int borrowedBooksCount = 0;

    public static void AddBook()

    {
        string title = GetBookTitle();
        if (BookAlreadyIn(title))

        {
            DisplayErrorMessage("book title. Book already in library");
            return;
        }

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
            DisplayErrorMessage("action. Library is full. Cannot add more books.");
            return;
        }
        DisplayConfirmationMessage($"Book {title} added to library");
    }

    public static void RemoveBook()

    {
        string title = GetBookTitle();

        if (book1Title == title)

        {
            book1Title = "";
            book1CheckedOut = false;
        }
        else if (book2Title == title)

        {
            book2Title = "";
            book2CheckedOut = false;
        }
        else if (book3Title == title)

        {
            book3Title = "";
            book3CheckedOut = false;
        }
        else if (book4Title == title)

        {
            book4Title = "";
            book4CheckedOut = false;
        }
        else if (book5Title == title)

        {
            book5Title = "";
            book5CheckedOut = false;
        }
        else

        {
            DisplayErrorMessage("action. Book not found in the library.");
            return;
        }

        DisplayConfirmationMessage($"Book {title} removed from library.");

    }

    public static void ViewBooks()

    {
        Console.WriteLine("Books in the library:");
        if (!string.IsNullOrEmpty(book1Title))

        {
            Console.WriteLine($"- {book1Title} {(book1CheckedOut ? "(Checked out)" : "")}");
        }
        if (!string.IsNullOrEmpty(book2Title))

        {
            Console.WriteLine($"- {book2Title} {(book2CheckedOut ? "(Checked out)" : "")}");
        }
        if (!string.IsNullOrEmpty(book3Title))

        {
            Console.WriteLine($"- {book3Title} {(book3CheckedOut ? "(Checked out)" : "")}");
        }
        if (!string.IsNullOrEmpty(book4Title))

        {
            Console.WriteLine($"- {book4Title} {(book4CheckedOut ? "(Checked out)" : "")}");
        }
        if (!string.IsNullOrEmpty(book5Title))

        {
            Console.WriteLine($"- {book5Title} {(book5CheckedOut ? "(Checked out)" : "")}");
        }
    }

    public static void SearchBook()

    {
        string title = GetBookTitle();
        if (BookAlreadyIn(title))

        {
            DisplayConfirmationMessage($"Book {title} is available in the library.");
        }
        else

        {
            DisplayErrorMessage("action. Book not found in the library.");
        }
    }

    public static void BorrowBook()

    {
        if (borrowedBooksCount >= 3)

        {
            DisplayErrorMessage("action. You have already borrowed the maximum number of books (3).");
            return;
        }

        string title = GetBookTitle();

        if (book1Title == title)

        {
            if (!book1CheckedOut)

            {
                book1CheckedOut = true;
                borrowedBooksCount++;
                DisplayConfirmationMessage($"You have borrowed {title}.");
            }
            else

            {
                DisplayErrorMessage("action. Book is already checked out.");
            }
        }
        else if (book2Title == title)

        {
            if (!book2CheckedOut)

            {
                book2CheckedOut = true;
                borrowedBooksCount++;
                DisplayConfirmationMessage($"You have borrowed {title}.");
            }
            else

            {
                DisplayErrorMessage("action. Book is already checked out.");
            }
        }
        else if (book3Title == title)

        {
            if (!book3CheckedOut)

            {
                book3CheckedOut = true;
                borrowedBooksCount++;
                DisplayConfirmationMessage($"You have borrowed {title}.");
            }
            else

            {
                DisplayErrorMessage("action. Book is already checked out.");
            }
        }
        else if (book4Title == title)

        {
            if (!book4CheckedOut)

            {
                book4CheckedOut = true;
                borrowedBooksCount++;
                DisplayConfirmationMessage($"You have borrowed {title}.");
            }
            else

            {
                DisplayErrorMessage("action. Book is already checked out.");
            }
        }
        else if (book5Title == title)

        {
            if (!book5CheckedOut)

            {
                book5CheckedOut = true;
                borrowedBooksCount++;
                DisplayConfirmationMessage($"You have borrowed {title}.");
            }
            else

            {
                DisplayErrorMessage("action. Book is already checked out.");
            }
        }
        else

        {
            DisplayErrorMessage("action. Book not found in the library.");
        }
    }

    public static void ReturnBook()

    {
        string title = GetBookTitle();

        if (book1Title == title)

        {
            if (book1CheckedOut)

            {
                book1CheckedOut = false;
                borrowedBooksCount--;
                DisplayConfirmationMessage($"You have returned {title}.");
            }
            else

            {
                DisplayErrorMessage("action. Book was not checked out.");
            }
        }
        else if (book2Title == title)

        {
            if (book2CheckedOut)

            {
                book2CheckedOut = false;
                borrowedBooksCount--;
                DisplayConfirmationMessage($"You have returned {title}.");
            }
            else

            {
                DisplayErrorMessage("action. Book was not checked out.");
            }
        }
        else if (book3Title == title)

        {
            if (book3CheckedOut)

            {
                book3CheckedOut = false;
                borrowedBooksCount--;
                DisplayConfirmationMessage($"You have returned {title}.");
            }
            else

            {
                DisplayErrorMessage("action. Book was not checked out.");
            }
        }
        else if (book4Title == title)

        {
            if (book4CheckedOut)

            {
                book4CheckedOut = false;
                borrowedBooksCount--;
                DisplayConfirmationMessage($"You have returned {title}.");
            }
            else

            {
                DisplayErrorMessage("action. Book was not checked out.");
            }
        }
        else if (book5Title == title)

        {
            if (book5CheckedOut)

            {
                book5CheckedOut = false;
                borrowedBooksCount--;
                DisplayConfirmationMessage($"You have returned {title}.");
            }
            else

            {
                DisplayErrorMessage("action. Book was not checked out.");
            }
        }
        else

        {
            DisplayErrorMessage("action. Book not found in the library.");
        }
    }


    public static string GetBookTitle()

    {
        Console.WriteLine("Enter book title:");
        return Console.ReadLine().ToLower();
    }

    public static bool BookAlreadyIn(string title)

    {
        if (book1Title == title || book2Title == title || book3Title == title || book4Title == title || book5Title == title)
        {
            return true;
        }
        return false;
    }

    public static void DisplayOptions()

    {
        Console.WriteLine("Welcome to the Library Management system.");
        Console.WriteLine("Choose which action you to perform(1 to 9):");
        Console.WriteLine("1. Add book.");
        Console.WriteLine("2. Remove book.");
        Console.WriteLine("3. View books.");
        Console.WriteLine("4. Search book");
        Console.WriteLine("5. Borrow book.");
        Console.WriteLine("6. Return book.");
        Console.WriteLine("7. Show borrowed books count");
        Console.WriteLine("8. Exit program.");

    }

    public static void DisplayConfirmationMessage(string text)

    {
        Console.WriteLine($"{text}. Action completed successfully.");
    }
    public static void DisplayErrorMessage(string text)

    {
        Console.WriteLine($"Invalid {text}! Try again.");
    }
    public static void Main()

    {
        DisplayOptions();
        string choice = Console.ReadLine();

        while (choice != "8")

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
                case "4":
                    SearchBook();
                    break;
                case "5":
                    BorrowBook();
                    break;
                case "6":
                    ReturnBook();
                    break;
                case "7":
                    Console.WriteLine($"You have borrowed {borrowedBooksCount} book(s).");
                    break;
                case "8":
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;
                default:
                    DisplayErrorMessage("action");
                    break;
            }

            DisplayOptions();
            choice = Console.ReadLine();
        }
    }
}