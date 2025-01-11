using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop_3
{
    internal class PrintedBook : Book
    {
        public int PageCount { get; set; }
        public PrintedBook(string author, string title, string isbn , int pagecount):base( author,  title,  isbn)
            {
            PageCount = pagecount;
            }
        public override string ToString()
        {
            return $"Auther : {Author}\ntitle: {Title}\nIsbn : {ISBN}\npageCount : {PageCount}";
        }
    }
}
