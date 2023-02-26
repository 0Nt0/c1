using Library.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.LogInCheck
{
    internal class CheckingLogIn:ICheckLogIn
    {

        public string UserInfo(string username, string password)
        {
            int s = 0;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\User.txt");
            string[] lines2 = System.IO.File.ReadAllLines(@"C:\Users\ziliu\Desktop\3M\3M2P\C#\Library\Admin.txt");

            foreach (string line in lines)
            {
                if (line == username + " " + password)
                {
                    s++;
                }
            }
            if (s != 0)
            {
                return "User";
            }
            else
            {
                foreach (string line2 in lines2)
                {
                    if (line2 == username + " " + password)
                    {
                        s++;
                    }
                }
                if (s != 0)
                {
                    return "Admin";
                }
                else return "Person does not exhist";

            };

        }

    }
}
