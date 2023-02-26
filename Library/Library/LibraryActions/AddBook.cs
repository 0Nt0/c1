using Library.Interface;
using Library.LogInCheck;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Library.LibraryActions
{
    internal class AddBook: IAddBook
    {
        public void AddNewBook()
        {
            SeeBooks see = new SeeBooks();
            int have = 0;
            see.SeeAllBooks("Books");
            string name=Console.ReadLine();
            string[] lines = File.ReadAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\Books.txt");
            foreach(string line in lines)
            {
                if (line == name)
                {
                    have++;
                }
            }
            if (have > 0)
            {
                Console.WriteLine("Book is already in the library");
            }
            else
            {
                List<string> updatedBooks = new List<string>();
                ; foreach (string line in lines)
                {
                        updatedBooks.Add(line);
                }
                updatedBooks.Add(name);
                File.WriteAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\Books.txt", updatedBooks);
                Console.WriteLine("Added book: "+name);
            }

        }
    }
}
