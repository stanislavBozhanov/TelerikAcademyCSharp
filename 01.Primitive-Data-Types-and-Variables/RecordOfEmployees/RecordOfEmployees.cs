//A marketing firm wants to keep record of its employees. 
//Each record would have the following characteristics – first name, family name, age, 
//gender (m or f), ID number, unique employee number (27560000 to 27569999). 
//Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.

using System;

class RecordOfEmployees
{
    static void Main()
    {
        string firstName, familyName;
        byte age;
        char gender;
        int idNumber;
        short uniqueEmpNumber;

        firstName = "Stanislav";
        familyName = "Bozhanov";
        age = 22;
        gender = 'm';
        idNumber = 123456789;
        uniqueEmpNumber = 1234;

        Console.Write("Personal Information about {0} {1}:\n\nFirst Name: {0}\nFamily Name: {1}\n", firstName, familyName);
        Console.Write("Age: {0}\nGender: {1}\nID Number: {2}\nUnique Employee Number: {3}\n", age, gender, idNumber, 27560000 + uniqueEmpNumber);
    }
}