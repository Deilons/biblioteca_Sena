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
        foreach (Book book in Books)
        {
            if (book.Genre == Genre)
            {
                book.ShowBook();
            }
        }
    }

    public void ShowBooksByTitle()
    {
        foreach (Book book in Books)
        {
            if (book.Title == Title)
            {
                book.ShowBook();
            }
        }
    }

    public void ShowBooksByPublicationDate()
    {
        foreach (Book book in Books)
        {
            if (book.PublicationDate.Year == PublicationDate.Year)
            {
                book.ShowBook();
            }
        }
    }
}
