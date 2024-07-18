using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biblioteca_Sena.Models;

public class Book : Publication
{
    // properties

    public string Author { get; set; }

    public int ISBN { get; set; }

    public string Genre { get; set; }

    public double Price { get; set; }

    public string Description { get; set; }

    // methods

    public Book(string title, DateTime publicationDate, string author, int isbn, string genre, double price, string description) : base(title, publicationDate)
    {   
        title = Title;
        publicationDate = PublicationDate;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Price = price;
        Description = description;
    }

    public void ShowDescription()
    {
        Console.WriteLine(Description);
    }

    public bool IsRecent()
    {
        if (DateTime.Now.Year - PublicationDate.Year > 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
