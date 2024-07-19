//star of the system menu

using biblioteca_Sena.Models;



class Program
{
    static void Main(string[] args)
    {
        // Initialize the library by adding some books
        var library = new Library("Library Title", new DateOnly(2022, 1, 1), "Author Name", 123456, "Genre", 29.99, "Description");
        library.AddBook(new Book("The Great Gatsby", new DateOnly(1925, 4, 10), "F. Scott Fitzgerald", 972, "Fiction", 1925, "hola"));
        library.AddBook(new Book("The Great Gatsby", new DateOnly(1925, 4, 10), "F. Scott Fitzgerald", 972, "Fiction", 1925, "hola"));

        library.AddBook(new Book("To Kill a Mockingbird", new DateOnly(1960, 7, 11), "Harper Lee", 520, "Fiction", 1960, "hello"));
        library.AddBook(new Book("The Catcher in the Rye", new DateOnly(1951, 7, 16), "J. D. Salinger", 310, "Fiction", 1951, "hola"));

        bool isRunning = true;

        while (isRunning)
        {
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

                    Console.WriteLine("Enter the title of the book: ");
                    string title = Console.ReadLine();
                    //check if book already exists or title is empty
                    if (library.Books.Any(book => book.Title == title))
                    {
                        Console.WriteLine("Book already exists.");
                        break;
                    }else if (string.IsNullOrEmpty(title))
                    {
                        Console.WriteLine("Title cannot be empty.");
                        break;
                    }

                    Console.WriteLine("Enter the publication date of the book: ");
                    DateOnly publicationDate = DateOnly.Parse(Console.ReadLine());
                    //check if publication date is in the future or empty
                    if (publicationDate > DateOnly.FromDateTime(DateTime.Now))
                    {
                        Console.WriteLine("Publication date cannot be in the future.");
                        break;
                    }else if (string.IsNullOrEmpty(title))
                    {
                        Console.WriteLine("Publication date cannot be empty.");
                        break;
                    }

                    Console.WriteLine("Enter the author of the book: ");
                    string author = Console.ReadLine();
                    //check if author is empty
                    if (string.IsNullOrEmpty(author))
                    {
                        Console.WriteLine("Author cannot be empty.");
                        break;
                    }

                    Console.WriteLine("Enter the ISBN of the book: ");
                    int isbn = int.Parse(Console.ReadLine());
                    //check if ISBN is negative or empty
                    if (string.IsNullOrEmpty(isbn.ToString()))
                    {
                        Console.WriteLine("ISBN cannot be empty.");
                        break;
                    }else if (isbn < 0)
                    {
                        Console.WriteLine("ISBN cannot be negative.");
                        break;
                    }
                    Console.WriteLine("Enter the genre of the book: ");
                    string genre = Console.ReadLine();
                    //check if genre is empty 
                    if (string.IsNullOrEmpty(genre))
                    {
                        Console.WriteLine("Genre cannot be empty.");
                        break;
                    }
                    Console.WriteLine("Enter the price of the book: ");
                    double price = double.Parse(Console.ReadLine());
                    //check if price is negative or empty
                    if (string.IsNullOrEmpty(price.ToString()))
                    {
                        Console.WriteLine("Price cannot be empty.");
                        break;
                    }else if (price < 0)
                    {
                        Console.WriteLine("Price cannot be negative.");
                        break;
                    }

                    Console.WriteLine("Enter the description of the book: ");
                    string description = Console.ReadLine();
                    //check if description is empty
                    if (string.IsNullOrEmpty(description))
                    {
                        Console.WriteLine("Description cannot be empty.");
                        break;
                    }
                    //add the book
                    library.AddBook(new Book(title, publicationDate, author, isbn, genre, price, description));
                    Console.WriteLine("Book added successfully.");
                    break;

                //remove book
                case 2:
                    Console.Clear();
                    Console.WriteLine("Enter the title of the book to remove: ");
                    string titleToRemove = Console.ReadLine();
                    //check if book exists
                    if (library.Books.Any(book => book.Title == titleToRemove))
                    {
                        library.RemoveBook(library.Books.Find(book => book.Title == titleToRemove));
                        Console.WriteLine("Book removed successfully.");
                    }else
                    {
                        Console.WriteLine("Book not found.");
                    }
                    break;

                //show books by author
                case 3:
                    Console.Clear();
                    library.ShowBooksByAuthor();
                    break;

                case 8:
                    Console.Clear();
                    foreach (Book book in library.Books)
                    {
                        book.ShowBook();
                    }
                    break;
            }
        }
    }
}