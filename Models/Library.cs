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
    public void AddBook(Book book)
    {
        if (book != null)
        {
            Books.Add(book);
        }
        else
        {
            Console.WriteLine("Book not added.");
        }
    }

    public void RemoveBook(Book book)
    {
        if (book != null)
        {
            Books.Remove(book);
        }
        else
        {
            Console.WriteLine("Book not removed.");
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
        foreach (Book book in Books)
        {
            if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                book.ShowBook();
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
