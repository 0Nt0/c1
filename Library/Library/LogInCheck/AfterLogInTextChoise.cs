using Library.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.LogInCheck
{
    public delegate void EventHandlers(string a, string username);
    internal class AfterLogInTextChoise
    {
        public event EventHandlers ch;

        public AfterLogInTextChoise()
        {
            ch += Choice;

        }
        public void Choice(string a, string username)
        {

            if (ch != null)
            {
                var action = ManagementOfI.IChooseWhatToDo();
                int n = -10;

                if (a == "User")
                {
                    while (n != 0)
                    {
                        Console.WriteLine("0- Log off \n 1- Get a book \n 2- Return a book ");
                        n = Convert.ToInt32(Console.ReadLine());
                        if (n <= 2)
                        {
                            action.ActionChoise(n, username);
                        }

                    }
                }
                else if (a == "Admin")
                {
                    while (n != 0)
                    {
                        Console.WriteLine("0- Log off \n 1- Get a book \n 2- Return a book \n 3- Add a new Book \n 4- Delete a book \n 5- Add a new user \n 6- Add a new Admin");
                        n = Convert.ToInt32(Console.ReadLine());
                        action.ActionChoise(n, username);
                    }
    ;
                }
            }
        }


    }
}
