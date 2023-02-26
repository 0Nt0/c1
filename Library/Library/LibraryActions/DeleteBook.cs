using Library.Interface;
using Library.LogInCheck;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.LibraryActions
{
    internal class DeleteBook: IDeleteBook
    {
        public void DeleteABook()
        {
            SeeBooks books = new SeeBooks();
            int have = 0;
            books.SeeAllBooks("Books");
            string name = Console.ReadLine();
            string[] lines = File.ReadAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\Books.txt");
            foreach(string line in lines)
            {
                if(line==name)
                {
                    have++;
                }
            }
            if(have==0)
            {
                Console.WriteLine("This book does not exhist in the library");
            }
            else
            {
                List<string> updatedBooks = new List<string>();
                ; foreach (string line in lines)
                {
                    if (line != name)
                    {
                        updatedBooks.Add(line);
                    }
                }
                File.WriteAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\Books.txt", updatedBooks);
            }

        }
    }
}
