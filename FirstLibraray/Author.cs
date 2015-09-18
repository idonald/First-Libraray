﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLibraray
{
    //  TODO: Change class to Person (will need to update references).
    //  TODO: Add a new Account to represent a library account for a person (will neeed ID and Person as required in the constructor).
    public class Author
    {
       public int ID;
       public string Name;

       /// <summary>
       /// Author
       /// </summary>
       /// <param name="id">The ID value</param>
       /// <param name="name">The name of the author.</param>
        public Author(int id, string name = "")
        {
            ID = id;
            Name = name;
        }
    }
}
