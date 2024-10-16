using System;

class Program
{
    static void Main()
    {
        long buyukSayi = 500000000000;

        int kucukDeger = (int)buyukSayi;

        Console.WriteLine("long değeri: " + buyukSayi);
        Console.WriteLine("int değeri: " + kucukDeger);
    }
}