using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.LogInCheck
{
    internal class SeeBooks
    {
        public void SeeAllBooks(string txt)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\"+txt+".txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }


    }
}
