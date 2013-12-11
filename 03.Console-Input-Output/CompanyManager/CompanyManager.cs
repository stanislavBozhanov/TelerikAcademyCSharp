//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and its manager and prints them on the console.

using System;

class CompanyManager
{
    static void Main()
    {
        Console.WriteLine("Enter company name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter company address: ");
        string address = Console.ReadLine();
        Console.WriteLine("Enter company gsm");
        int gsm = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter company fax number");
        int fax = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter company website: ");
        string website = Console.ReadLine();
        Console.WriteLine("Enter company manager: ");
        string manager = Console.ReadLine();
        Console.WriteLine("Enter manager firstname");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Enter manager lastname");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("Enter manager age");
        int age = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Enter manager phone number");
        int managerPhone = int.Parse(Console.ReadLine());
        Console.Write("Company: {0}\nAdress: {1}\nPhone number: {2}\nFax number: {3}\nWeb site: {4}\n", name, address, gsm, fax, website);
        Console.Write("Manager: {0}\nFirst name: {1}\nLast name: {2}\nAge: {3}\nPhone number: {4}\n", manager, managerFirstName, managerLastName,age, managerPhone);
    }
}
