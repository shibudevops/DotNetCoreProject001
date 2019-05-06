using System;

namespace DotNetCoreProject001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var settings = new MyFirstClass("Sample Setting String");
            Console.WriteLine( settings.PrintSettings());

        }
    }
}
