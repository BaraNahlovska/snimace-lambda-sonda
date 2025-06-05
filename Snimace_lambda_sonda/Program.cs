using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Zadej typ motoru: malý (do 1.3l), střední (1.4 - 1.9l), velký (nad 2.0l)");
        string typMotoru = Console.ReadLine();

        if (typMotoru == "malý" || typMotoru == "maly")
        {
            Console.WriteLine("Hodnoty nastaveny pro motor do objemu 1.3l)");
        }
        else if (typMotoru == "střední" || typMotoru == "stredni")
        {
            Console.WriteLine("Hodnoty nastaveny pro motory o objemu 1.4 - 1.9l");
        }
        else if (typMotoru == "velký" || typMotoru == "velky")
        {
            Console.WriteLine("Hodnota nastaveny pro motory o objemu nad 2.0l");
        }
        else
        {
            Console.WriteLine("Neplatný vstup");
        }
    }
}