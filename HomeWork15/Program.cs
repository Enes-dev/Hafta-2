using System;

class Program
{
    static void Main()
    {
        string booleanString = "True";

        bool booleanValue = bool.Parse(booleanString);

        Console.WriteLine("String değeri: " + booleanString);
        Console.WriteLine("Bool değeri: " + booleanValue);
    }

}    