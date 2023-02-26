using Library.Interface;
using Library.LogInCheck;
using System;
using System.Data;
using static Library.LogInCheck.CheckingLogIn;

internal class Program
{
    private static void Main(string[] args)
    {
        string username, password;

        Console.WriteLine("Insert your firstname together with your last name ");
        username = Console.ReadLine();
        Console.WriteLine("Insert your password");
        password = Console.ReadLine();


        var who = ManagementOfI.ICheckingLogInAction();

        Func<string, string, string> WhoIsUser = who.UserInfo;
        string info= WhoIsUser.Invoke(username,password);

        var newUser = ManagementOfI.IUserInterfaceManagement();
        newUser.role = info;

        AfterLogInTextChoise act = new AfterLogInTextChoise();
        act.Choice(newUser.role, username);
       
    }
}