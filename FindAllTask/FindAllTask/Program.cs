using Exceptions.Models;
using System;
using System.Collections.Generic;

namespace FindAllTask

{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> datas = new List<int>()
            //{
            //    1,2,3,4,5
            //};

            //MyList<int> nums = new MyList<int>();
            //nums.Add(1);
            //nums.Add(1);
            //nums.Add(1);
            //nums.Add(1);
            //nums.Add(1);
            //nums.Add(1);
            //nums.Add(1);
            //nums.Add(1);
            //nums.Add(1);            
            //nums.Add(1);
            //nums.Add(1);
            //nums.AddRange(datas);
            //nums.GetAll();

            MyList<string> names = new MyList<string>();
            names.Add("Eshgin");
            names.Add("Sadiq");
            names.Add("Seid");
            names.Add("Seid");

            var result = names.Find(m => m == "Seid");
            Console.WriteLine(result);

            var result1 =names.FindAll(m => m == "Seid");
            Console.WriteLine(result1);
        }
    }
   
}
