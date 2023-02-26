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
    internal class ReturnBook: IReturnBook
    {
        public void SeeAllUserBooks(string username)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\UserBooks.txt");
            
            SeeBooks see = new SeeBooks();
            see.SeeAllBooks("UserBooks");

            SelectBookToReturn(lines, username);
        }
        public void SelectBookToReturn(string[] lines, string username)
        {
            int have = 0;
            string book = Console.ReadLine();
            foreach (string line in lines)
            {
                if (book+" "+username == line)
                {
                    have++;
                }
            }
            if(have==0)
            {
                Console.WriteLine("You do not have this book!");
            }
            else
            {
                Console.WriteLine("You have returned the book: "+book);
                ReturnSelectedBook(username, lines,book);
            }
        }

        public void ReturnSelectedBook(string username, string[] lines, string book)
        {
            List<string> updatedUserBooks = new List<string>();
            foreach (string line in lines)
            {
                if (line != book+" "+username)
                {
                    updatedUserBooks.Add(line);
                }
            }
            File.WriteAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\UserBooks.txt", updatedUserBooks);

            string[] lines2 = File.ReadAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\Books.txt");
            List<string> updatedBooks = new List<string>();
            foreach (string line2 in lines2)
            {
                updatedBooks.Add(line2);
            }
            updatedBooks.Add(book);
            File.WriteAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\Books.txt", updatedBooks);
        }

    }
}
