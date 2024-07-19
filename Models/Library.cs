using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace biblioteca_Sena.Models;

public class Library : Book
{
    // attributes
    public List<Book> Books { get; set; }

    // methods

    public Library(string title, DateOnly publicationDate, string author, int isbn, string genre, double price, string description)
    : base(title, publicationDate, author, isbn, genre, price, description)
    {
        Title = title;
        PublicationDate = publicationDate;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Price = price;
        Description = description;

        Books = new List<Book>();
    }
    public void AddBook()
    {
        string title;
        DateOnly publicationDate;
        string author;
        int isbn;
        string genre;
        double price;
        string description;

        Console.WriteLine("Enter the title of the book: ");
        while (true)
        {
            title = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Title cannot be empty. Please try again.");
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("Enter the publication date of the book (YYYY-MM-DD): ");
        while (true)
        {
            if (DateOnly.TryParse(Console.ReadLine(), out publicationDate))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid publication date format. Please enter date in YYYY-MM-DD format. Please try again.");
            }
        }

        Console.WriteLine("Enter the author of the book: ");
        while (true)
        {
            author = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(author))
            {
                Console.WriteLine("Author cannot be empty. Please try again.");
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("Enter the ISBN of the book: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out isbn))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid ISBN. Please enter a valid integer. Please try again.");
            }
        }

        Console.WriteLine("Enter the genre of the book: ");
        while (true)
        {
            genre = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(genre))
            {
                Console.WriteLine("Genre cannot be empty. Please try again.");
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("Enter the price of the book: ");
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out price))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid price. Please enter a valid number. Please try again.");
            }
        }

        Console.WriteLine("Enter the description of the book: ");
        while (true)
        {
            description = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(description))
            {
                Console.WriteLine("Description cannot be empty. Please try again.");
            }
            else
            {
                break;
            }
        }

        Books.Add(new Book(title, publicationDate, author, isbn, genre, price, description));
    }

    public void RemoveBook(string titleToRemove)
    {
        Book bookToRemove = Books.FirstOrDefault(book => book.Title == titleToRemove);
        if (bookToRemove != null)
        {
            Books.Remove(bookToRemove);
            Console.WriteLine("Book removed successfully.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    public void ShowBooksByAuthor()
    {
        Console.WriteLine("Enter the author name: ");
        string author = Console.ReadLine();
        bool found = false;
        foreach (Book book in Books)
        {
            if (book.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                book.ShowBook();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"No books found for the specified author: {author}");
        }
    }

    public void ShowBooksByGenre()
    {
        bool found = false;
        Console.WriteLine("Enter the genre: ");
        string genre = Console.ReadLine();
        foreach (Book book in Books)
        {
            if (book.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase))
            {
                book.ShowBook();
                found = true;

            }
            else if (!found)
            {
                Console.WriteLine($"No books found for the specified genre: {genre}");
                Console.WriteLine("want to try again? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    ShowBooksByGenre();
                }
                else
                {
                    break;
                }
            }
        }
    }

    public void ShowBooksByTitle()
    {
        Console.WriteLine("Enter the title: ");
        string title = Console.ReadLine();
        bool found = false;
        // search for books by title
        foreach (Book book in Books)
        {
            if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                book.ShowBook();
                found = true;
            }
        }
        // display message if no books found
        if (!found)
        {
            Console.WriteLine($"No books found for the specified title: {title}");
            Console.WriteLine("want to try again? (y/n)");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                ShowBooksByTitle();
            }
        }
    }



    public void ShowBooksByPublicationDate()
    {
        Console.WriteLine("Enter the publication date: ");
        DateOnly publicationDate = DateOnly.Parse(Console.ReadLine());
        bool found = false;
        // search for books by publication date
        foreach (Book book in Books)
        {
            if (book.PublicationDate.Equals(publicationDate))
            {
                book.ShowBook();
                found = true;
            }
        }
        // display message if no books found
        if (!found)
        {
            Console.WriteLine($"No books found for the specified publication date: {publicationDate}");
            Console.WriteLine("want to try again? (y/n)");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                ShowBooksByPublicationDate();
            }
        }
    }

    public void ShowAllBooks()
    {
        foreach (Book book in Books)
        {
            book.ShowBook();
        }
    }
}
