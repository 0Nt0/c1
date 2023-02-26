using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interface
{
    internal interface IReturnBook
    {
        public void SeeAllUserBooks(string username);
        public void SelectBookToReturn(string[] lines, string username);


    }
}
