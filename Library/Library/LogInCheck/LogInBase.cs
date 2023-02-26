using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.LogInCheck
{
    internal abstract class LogInBase
    {
        public void LogIn(string role, string UserRole)
        {
            int n = -10;

            if (role == UserRole && UserRole == "User")
            {
                while (n != 0)
                {
                    Console.WriteLine("0- Log off \n 1- Get a book \n 2- Return a book ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
            }
            else if (role == UserRole && UserRole == "Admin")
            {
                while (n != 0)
                {
                    Console.WriteLine("0- Log off \n 1- Get a book \n 2- Return a book \n 3- Add a new Book \n 4- Delete a book \n 5- Add a new user \n 6- Add a new Admin \n 7- Rent a book");
                    n = Convert.ToInt32(Console.ReadLine());
                }
;
            }
        }

       

    }
   
}
