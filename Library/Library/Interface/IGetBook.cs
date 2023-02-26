using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interface
{
    internal interface IGetBook
    {
        public void SeeAllBooks(string username);
        public void ChooseBook(string[] lines, string username);
        public void AddBookToUserList(string book, string username);
    }
}
