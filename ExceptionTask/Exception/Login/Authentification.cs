using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTask.Login
{
    public class Authentification : Exception
    {
        public static string Mail = "esqinceferli@mail.ru";
        public static string Password = "esqin12345";
        public Authentification(string message) : base(message)
        {

        }
        public static void Login(string mail, string password)
        {
            try
            {
                if (mail != Mail || password != Password)
                {
                    throw new Authentification("Mail ve ya Password sehvdir");
                }
                Console.WriteLine("Giris olundu");
            }
            catch (Exception message)
            {

                Console.WriteLine(message.Message); ;
            }
        }

    }
}
