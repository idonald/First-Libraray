using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstLibraray;

namespace UnitTests
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void CreateBook()
        {
            var newBook = new Book("The Book");
            Assert.IsInstanceOfType(newBook, typeof (Book));
            Assert.AreEqual(newBook.Title, "The Book");
        }

        [TestMethod]
        public void CreateAuthorWithName()
        {
            var author = new Author(1, "Dave");
            var newBook = new Book("The Book");

            newBook.Author = author;

            Assert.AreEqual(newBook.Author, author);
        }

    }
}
