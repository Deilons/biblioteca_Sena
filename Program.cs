//star of the system menu

using biblioteca_Sena.Models;



class Program
{
    static void Main(string[] args)
    {
        // Initialize the library by adding some books
        var library = new Library("Library Title", new DateOnly(2022, 1, 1), "Author Name", 123456, "Genre", 29.99, "Description");

        
        library.Books.Add(new Book("The Great Gatsby", new DateOnly(1925, 4, 10), "F. Scott Fitzgerald", 972, "Fiction", 1925, "hola"));
        library.Books.Add(new Book("The Great Gatsby", new DateOnly(1925, 4, 10), "F. Scott Fitzgerald", 972, "Fiction", 1925, "hola"));
        library.Books.Add(new Book("a", new DateOnly(2000, 12, 12), "a",1, "a", 12, "a"));
        library.Books.Add(new Book("To Kill a Mockingbird", new DateOnly(1960, 7, 11), "Harper Lee", 520, "Fiction", 1960, "hello"));
        library.Books.Add(new Book("The Catcher in the Rye", new DateOnly(1951, 7, 16), "J. D. Salinger", 310, "Fiction", 1951, "hola"));

        bool isRunning = true;

        while (isRunning)
        {   
            Console.Clear();
            Console.WriteLine("Welcome to the library!");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Remove book");
            Console.WriteLine("3. Show books by author");
            Console.WriteLine("4. Show books by genre");
            Console.WriteLine("5. Show books by title");
            Console.WriteLine("6. Show books by publication date");
            Console.WriteLine("7. Show books description");
            Console.WriteLine("8. Show all books");
            Console.WriteLine("10. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            // check if choice is valid
            if (choice < 1 || choice > 10)
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }
            switch (choice)
            {   
                //add book
                case 1:
                    Console.Clear();

                    library.AddBook();                        
                    Console.WriteLine("Book added successfully.");
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    break;

                //remove book
                case 2:
                    Console.Clear();

                    Console.WriteLine("Enter the title of the book to remove: ");
                    string titleToRemove = Console.ReadLine();
                    // validate input
                    if (string.IsNullOrWhiteSpace(titleToRemove))
                    {
                        Console.WriteLine("Title cannot be empty. Please try again.");
                        Console.WriteLine("press enter to continue");
                        Console.ReadLine();
                        break;
                    }else
                    {
                        library.RemoveBook(titleToRemove);
                    }
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    break;

                //show books by author
                case 3:
                    Console.Clear();
                    library.ShowBooksByAuthor();
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    break;

                //show books by genre
                case 4:
                    Console.Clear();
                    library.ShowBooksByGenre();
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    break;

                //show books by title
                case 5:
                    Console.Clear();
                    library.ShowBooksByTitle();
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    break;

                //show books by publication date
                case 6:
                    Console.Clear();
                    library.ShowBooksByPublicationDate();
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    break;

                //show books description
                case 7:
                    Console.Clear();
                    foreach (Book book in library.Books)
                    {
                        book.ShowDescription();
                    }
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    break;

                //show all books
                case 8:
                    Console.Clear();
                    Console.WriteLine("All books:");
                    library.ShowAllBooks();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;

                //exit
                case 10:
                Console.WriteLine("Are you sure you want to exit? (y/n) ");
                string answer = Console.ReadLine();
                if (answer == "y")
                {   
                    Console.WriteLine("Thank you for using the library. Goodbye!");
                    isRunning = false;
                }
                break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}