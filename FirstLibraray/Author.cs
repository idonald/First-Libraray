using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLibraray
{
    public class Author
    {
       public int ID;
       public string Name;

        public Author(int id, string name = "")
        {
            ID = id;
            Name = name;
        }
    }
}
