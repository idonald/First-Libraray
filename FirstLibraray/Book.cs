using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLibraray
{
    public class Book
    {
        //  Todo: Add ISBN string vairable.
        //  TODO: Change the required field passed into the constructor to be the ISBN number.
        //  TODO: Make title not required by removing it from the constructor.
        public string Title;
        public Author Author;
        //  Constructor
        public Book(string title)
        {
            Title = title;
        }
    }
}
