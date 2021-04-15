namespace LINQ_Practice.Console
{
    using Lib;
    using Lib.Extensions;

    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;


    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to LINQ practice!");

            var itemMasters = await new List<ItemMaster>().LoadFromFile();
        }
    }
}