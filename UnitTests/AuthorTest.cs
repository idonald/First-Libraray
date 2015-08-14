using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstLibraray;

namespace UnitTests
{
    [TestClass]
    public class AuthorTest
    {
        [TestMethod]
        public void CreateAuthor()
        {
            var blarg = new Author(1);
            Assert.IsInstanceOfType(blarg, typeof(Author));
            Assert.AreEqual(blarg.ID, 1);
        }

        [TestMethod]
        public void CreateAuthorWithName()
        {
            var blarg = new Author(1, "Dave");
            Assert.IsInstanceOfType(blarg, typeof(Author));
            Assert.AreEqual(blarg.Name, "Dave");
        }
    }
}
