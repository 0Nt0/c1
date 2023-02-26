using Library.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Library.LogInCheck;

namespace Library.LibraryActions
{
    internal class GetBook:IGetBook
    {
        public void SeeAllBooks(string username)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\Books.txt");
            SeeBooks see =new SeeBooks();
            see.SeeAllBooks("Books");
            ChooseBook(lines, username);

        }
        public void ChooseBook(string[] lines, string username)
        {
            int have = 0;
            string book = Console.ReadLine();
            foreach(string line in lines)
            {
                if (book==line)
                {
                    have++;                }
            }
            if(have==0)
            {
                Console.WriteLine("This book does not exhist or is taken");
            }
            else
            {
                Console.WriteLine("You got: "+book+"!");
                AddBookToUserList(book, username);
            }
            
        }
        public void AddBookToUserList(string book, string username)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\Books.txt");
            List<string> updatedBooks = new List<string>();
;            foreach(string line in lines)
            {
                if(line!=book)
                {
                    updatedBooks.Add(line);
                }
            }
            File.WriteAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\Books.txt", updatedBooks);

            string[] lines2 = File.ReadAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\UserBooks.txt");
            List<string> updatedUserBooks = new List<string>();
             foreach (string line2 in lines2)
            {
                    updatedUserBooks.Add(line2); 
            }
            updatedUserBooks.Add(book + " " + username);
            File.WriteAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\UserBooks.txt", updatedUserBooks);

        }
    }
}
