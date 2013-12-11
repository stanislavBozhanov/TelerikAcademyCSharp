using System;

class NullVar
{
    static void Main()
    {
        int? someInteger = null;
        double? someDouble = null;
        Console.WriteLine("This is some integer with Null value: {0}", someInteger);
        Console.WriteLine("This is some real number with Null value: {0}", someDouble);
        someInteger += null;
        someDouble += 2.72;
        Console.WriteLine("The value of the integer is: " + someInteger);
        Console.WriteLine("The value of the real number is: " + someDouble);
    }
}
