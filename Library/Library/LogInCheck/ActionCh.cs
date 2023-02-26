using Library.Interface;
using Library.LibraryActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.LogInCheck
{
    internal class ActionCh: IActionChoice
    {
        public void ActionChoise(int n, string username)
        {
            switch (n)
            {
                case 1:
                    var book=ManagementOfI.IGetObjectBook();
                    book.SeeAllBooks(username);
                    break;
                case 2:

                    var retBook = ManagementOfI.IReturnObjectBook();
                    retBook.SeeAllUserBooks(username);
                    break;
                case 3:
                    var addBook = ManagementOfI.AddObjectBook();
                    addBook.AddNewBook();
                    break;
                case 4:
                    var delete = ManagementOfI.IDeleteObjectBook();
                    delete.DeleteABook();
                    break;
                case 5:
                    var user = ManagementOfI.AddObjectUser();
                    user.AddAPerson("User");
                    break;
                case 6:
                    var admin = ManagementOfI.AddObjectUser();
                    admin.AddAPerson("Admin");
                    break;
                default: break;
            }
        }
    }
}
