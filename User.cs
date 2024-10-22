using ConsoleApp3.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class User:IAccount
    {
        public User(string fullname, string email, string password)
        { 
            Fullname = fullname;
            Email = email;
            Password = password;

            ++_id;
            Id= _id;


        }

        public int Id { get; set; }
        private int _id;

        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        

        public bool PasswordChecker(string password)
        {
            if(password.Length < 8)
            {
                return false;
            }

            bool hasUppercase=false;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'A' && password[i]<='Z') 
                {
                    hasUppercase = true;
                    break;

                }
                
            }
            if (!hasUppercase) 
            { 
                return false;
            }

            bool haslowercase = false;
            for (int i = 0;i < password.Length; i++)
            {
                if (password[i] >='a' && password[i]<='z')
                {
                    haslowercase = true;
                    break;
                }
            }
            if (!haslowercase)
            {
                return false;
            }

            bool hasnumber = false;
            for(int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    hasnumber = true;
                    break;
                }
            }
            if(!hasnumber) 
            {
                return false;
            }

            return true;

            

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id}, Fullname:{Fullname}, Email:{Email}");
        }
    }
}
