using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop_3
{
    internal class EBook : Book
    {
        public double FileSize { get; set; }
     
        public EBook(string author , string title , string isbn , double filesize):base(author , title , isbn)
        {
            FileSize = filesize;
        }
        public override string ToString()
        {
            return $"Auther : {Author}\ntitle: {Title}\nIsbn : {ISBN}\nFileSize : {FileSize}";
        }
    }
}
