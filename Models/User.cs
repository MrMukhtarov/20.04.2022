using System;
using System.Collections.Generic;
using System.Text;
using Interface19._4._2022.Interface;

namespace Interface19._4._2022.Models
{
    class User : iAccount
    {
        public string FullName;
        public string Email;


        public string password { get; set; }

        public User(string password)
        {
            PasswordChecker(password);
        }
        public bool PasswordChecker(string password)
        {
            bool checked1 = false;
            bool checked2 = false;
            bool checked3 = false;
            if (password.Length >= 8)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i]))
                    {
                        checked1 = true;
                    }
                    else if (char.IsDigit(password[i]))
                    {
                        checked2 = true;

                    }
                    else if (char.IsLower(password[i]))
                    {
                        checked3 = true;
                    }
                }
                if (checked1 && checked2 && checked3)
                {
                    return true;
                }
                while (true)
                {
                    
                }
            }
            else
            {
                Console.WriteLine("Sifre 8 reqemden az olmamalidir");
            }

            return false;
        }
        public void ShowInof()
        {
            Console.WriteLine($"Tam Adad: {FullName}");
            Console.WriteLine($"Email: {Email}");

        }

        void iAccount.PasswordChecker(string password)
        {
            throw new NotImplementedException();
        }
    }
}

      
    

