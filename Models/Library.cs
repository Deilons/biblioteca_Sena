using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace biblioteca_Sena.Models;

public class Library : Book
{
    // attributes
    public List<Book>? Books { get; set; }

    // methods

    public Library(string title, DateTime publicationDate, string author, int isbn, string genre, double price, string description) 
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
        Books?.Add(book);
    }

    public void RemoveBook(Book book)
    {
        Books?.Remove(book);
    }

    public void ShowBooksByAuthor()
    {
        foreach (Book book in Books?.ToList() ?? new List<Book>())
        {
            if (book.Author == Author)
            {
                book.ShowDescription();
            }
        }
    }

    public void ShowBooksByGenre()
    {
        foreach (Book book in Books?.ToList() ?? new List<Book>())
        {
            if (book.Genre == Genre)
            {
                book.ShowDescription();
            }
        }
    }

    public void ShowBooksByTitle()
    {
        foreach (Book book in Books?.ToList() ?? new List<Book>())
        {
            if (book.Title == Title)
            {
                book.ShowDescription();
            }
        }
    }

    public void ShowBooksByPublicationDate()
    {
        foreach (Book book in Books?.ToList() ?? new List<Book>())
        {
            if (book.PublicationDate.Year == PublicationDate.Year)
            {
                book.ShowDescription();
            }
        }
    }
}
