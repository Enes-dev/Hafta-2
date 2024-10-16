using System;

class Program
{
    static void Main()
    {
        float sayiFloat = 1.23f;

        double sayiDouble = (double)sayiFloat;

        Console.WriteLine("Float değeri: " + sayiFloat);
        Console.WriteLine("Double değeri: " + sayiDouble);

        if (sayiFloat == sayiDouble)
        {
            Console.WriteLine("Float ve Double değerleri eşittir.");
        }
        else
        {
            Console.WriteLine("Float ve Double değerleri eşit değildir.");
        }
    }
}