using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Zadej typ motoru: malý (do 1.3l), střední (1.4 - 1.9l), velký (nad 2.0l)");
        string typMotoru = Console.ReadLine().ToLower();

        double minOtacky = 0, maxOtacky = 0;
        double minMAF = 0, maxMAF = 0;
        double minLambda = 0.98, maxLambda = 1.02;

        if (typMotoru == "malý" || typMotoru == "maly")
        {
            Console.WriteLine("Hodnoty nastaveny pro motor do objemu 1.3l)");
            minOtacky = 700;
            maxOtacky = 900;
            minMAF = 2.5;
            maxMAF = 4.5;
        }
        else if (typMotoru == "střední" || typMotoru == "stredni")
        {
            Console.WriteLine("Hodnoty nastaveny pro motory o objemu 1.4 - 1.9l");
            minOtacky = 750;
            maxOtacky = 950;
            minMAF = 3.5;
            maxMAF = 6.0;
        }
        else if (typMotoru == "velký" || typMotoru == "velky")
        {
            Console.WriteLine("Hodnota nastaveny pro motory o objemu nad 2.0l");
            minOtacky = 750;
            maxOtacky = 1000;
            minMAF = 5.0;
            maxMAF = 8.0;
        }
        else
        {
            Console.WriteLine("Neplatný vstup");
            return;
        }

        Console.WriteLine("Zadej otáčky motoru (např. 850):");
        int otacky = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Zadej hodnotu MAF v g/s (např. 3.5):");
        double maf = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Zadej hodnotu pro lambda sondu (např. 1.00)");
        double lambda = Convert.ToDouble(Console.ReadLine());

        if (otacky >= minOtacky && otacky <= maxOtacky)
        {
            Console.WriteLine("Otáčky jsou v normě.");
        }
        else
        {
            Console.WriteLine("Otáčky jsou mimo rozsah!");
        }

        if (maf >= minMAF && maf <= maxMAF)
        {
            Console.WriteLine("Hodnota MAF je v normě");
        }
        else
        {
            Console.WriteLine("Hodnota MAF je mimo rozsah!");
        }

        if (lambda >= minLambda && lambda <= maxLambda)
        {
            Console.WriteLine("Lambda sonda je v normě");
        }
        else
        {
            Console.WriteLine("Hondnota lambda sondy je mimo rozsah!");
        }
    }
}