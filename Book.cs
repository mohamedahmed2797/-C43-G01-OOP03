using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop_3
{
    internal class Book
    {
        public string? Title { get; set; }
        public string? Author {  get; set; }
        public string ISBN { get; set; }

        public Book(string author , string title ,string isbn)
        {
            Author = author;
            Title = title;
            ISBN = isbn;
        }
    }
}
