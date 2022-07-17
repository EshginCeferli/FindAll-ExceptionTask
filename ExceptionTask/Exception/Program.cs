using ExceptionTask.Login;
using System;
using System.Collections.Generic;

namespace ExceptionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Hometask
            Authentification.Login("esqinceferli@mail.ru", "esqin12345");

            #endregion


            //List<string> names = new List<string>() { "Messi,Suarez,Neymar,Xavi" };
            //string searchtext = "Xavi";
            //CheckNames(names, searchtext);
            //try
            //{
            //    int a = 5;
            //    int b = 0;
            //    var result = a / b;
            //    int[] arr = new int[3];
            //    arr[5] = 5;
            //}
            //catch (NullReferenceException message)
            //{

            //    Console.WriteLine(message.Message);
            //}
            //catch (DivideByZeroException message1)
            //{
            //    Console.WriteLine(message1.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Evvelki sehifye qayit");
            //}
        }

        //public static void DivideNums(int num1, int num2)
        //{
        //    try
        //    {
        //        if (num2 == 2)
        //        {
        //            throw new DivideExceptions("Cant be equal to 2");
        //        }
        //        Console.WriteLine(num1/num2);
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message); ;
        //    }
        //}


        public static void CheckNames(List<string> names, string name)
        {
            try
            {
                if (!names.Contains(name))
                {
                    throw new DivideExceptions("Not found name");
                }
                Console.WriteLine("Tapildi");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
        }
    }
}
