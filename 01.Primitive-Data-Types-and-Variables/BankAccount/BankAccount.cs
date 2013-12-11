//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//bank name, IBAN, BIC code and 3 credit card numbers associated with the account. 
//Declare the variables needed to keep the information for a single bank account
//using the appropriate data types and descriptive names.

using System;

class BankAccount
{
    static void Main(string[] args)
    {
        string holderFirstName = "Stanisalv";
        string holderSecondName = "Biserov";
        string holderThirdName = "Bozhanov";
        decimal availableMoney = 20349.3m;
        string bankName = "FIB";
        string IBAN = "BUIN454UN54535353";
        long CC1 = 1234123412341234;
        long CC2 = 2345234523452345;
        long CC3 = 3456345634563456;
        Console.Write("Name: {0} {1} {2}\n", holderFirstName, holderSecondName, holderThirdName);
        Console.Write("Money available: {0}\n", availableMoney);
        Console.Write("Bank: {0}\nIBAN: {1}\n", bankName, IBAN);
        Console.Write("CC1: {0}\nCC2: {1}\nCC3: {2}\n", CC1, CC2, CC3);
    }
}

