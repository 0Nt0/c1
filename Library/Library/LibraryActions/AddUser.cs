using Library.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.LibraryActions
{
    internal class AddUser: IAddUser, IAddAdmin
    {
        public void AddAPerson(string smth)
        {
            Console.WriteLine("Enter the new users first name and lastname together and then the password");
            string name = Console.ReadLine();
            string pas = Console.ReadLine();
            string[] lines = File.ReadAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\"+smth+".txt");
            int have=Exhists(name,pas, smth);
            if (have>0)
            {
                Console.WriteLine("User already exhists");
            }
            else
            {
                List<string> updatedUsers = new List<string>();
                ; foreach (string line in lines)
                {
                    updatedUsers.Add(line);
                }
                updatedUsers.Add(name+" "+pas);
                File.WriteAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\"+smth+".txt", updatedUsers);
                Console.WriteLine("Added "+smth+": " + name);
            }
     
        }
        public int Exhists(string name, string pas, string smth)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\"+smth+".txt");
            int have = 0;
            foreach(string line in lines)
            {
                if(name+" "+pas==line)
                {
                    have++;
                }
            }
            return have;
        }
    }
}
