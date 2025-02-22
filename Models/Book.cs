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

    public Book(string title, DateOnly publicationDate, string author, int isbn, string genre, double price, string description) : base(title, publicationDate)
    {   
        title = Title;
        publicationDate = PublicationDate;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Price = price;
        Description = description;
    }

    public void ShowBook()
    {
        Console.WriteLine($@"
        Title: {Title} 
        Year: {PublicationDate} 
        Author: {Author} 
        ISBN: {ISBN} 
        Genre: {Genre} 
        Price: {Price} 
        Description: {Description}"
        );
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

    public void ShowDescription()
    {   
        Console.WriteLine("Title: ");
        Console.WriteLine(Title);
        Console.WriteLine("Description: ");
        Console.WriteLine(Description);
    }
}
