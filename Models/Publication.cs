using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biblioteca_Sena.Models;

// public class Publication
public class Publication
{
    // properties
    public string Title { get; set; }
    
    public DateTime PublicationDate { get; set; }

    // methods
    public Publication(string title, DateTime publicationDate)
    {
        Title = title;
        PublicationDate = publicationDate;
    }
}
