using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintName
{
    //Write a method that asks the user for his name and prints “Hello, <name>” 
    //(for example, “Hello, Peter!”). Write a program to test this method.

    class PrintName
    {
        static void PrintMyName(string name)
        {
            Console.WriteLine("Hello, {0}", name);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();

        }
    }
}
