using Library.LibraryActions;
using Library.LogInCheck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interface
{
    internal class ManagementOfI
    {
        public static IAddAdmin AddObjectAdmin()
        {
            return new AddUser();
        }
        public static IAddBook AddObjectBook()
        {
            return new AddBook();
        }
        public static IAddUser AddObjectUser()
        {
            return new AddUser();
        }
        public static IDeleteBook IDeleteObjectBook()
        {
            return new DeleteBook();
        }
        public static IGetBook IGetObjectBook()
        {
            return new GetBook();
        }
        public static IReturnBook IReturnObjectBook()
        {
            return new ReturnBook();
        }
        public static userInterface IUserInterfaceManagement()
        {
            return new User();
        }
       public static ICheckLogIn ICheckingLogInAction()
        {
            return new CheckingLogIn();
        }
        public static IActionChoice IChooseWhatToDo()
        {
            return new ActionCh();
        }
    }
}
