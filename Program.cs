using Interface19._4._2022.Models;
using System;

namespace Interface19._4._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Nicat");
            user.PasswordChecker("Nicat");
            user.FullName = "Said Zaidov";
            user.Email = "Said.zaidov.3169@mail.ru";
            user.ShowInof();
            Console.WriteLine(user.FullName);
            Console.WriteLine(user.Email);

        }
    }
}
