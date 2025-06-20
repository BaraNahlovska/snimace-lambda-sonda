using System;

class Program
{
    static void Main()
    {
        int otackyMin = 650;
        int otackyMax = 950; 

        Console.WriteLine("Zadej typ motoru: malý (do 1.3l), střední (1.4 - 1.9l), velký (nad 2.0l)");
        string typMotoru = Console.ReadLine().ToLower();

        double MAFmin = 0; 
        double MAFmax = 0;


        switch (typMotoru)
        {
            case "malý":
            case "maly":
                Console.WriteLine("Hodnoty nastaveny pro motor do objemu 1.3l)");
                MAFmin = 2.5;
                MAFmax = 4.5; 
                break;
            case "střední":
            case "stredni":
                Console.WriteLine("Hodnoty nastaveny pro motory o objemu 1.4 - 1.9l");
                MAFmin = 3.5;
                MAFmax = 6.0;
                break;
            case "velký":
            case "velky":
                Console.WriteLine("Hodnota nastaveny pro motory o objemu nad 2.0l");
                MAFmin = 5.0;
                MAFmax = 8.0;
                break;
            default:
                Console.WriteLine("Neplatný vstup. Zadej malý, stžední nebo velký"); 
                return;
        }

        int otacky = 0;
        double MAF = 0;
        double lambda = 0;


        while (true)
        {
            Console.WriteLine("Zadej otáčky motoru (např. 850):");
            string vstup = Console.ReadLine();

            if (int.TryParse(vstup, out otacky))
            {
                if (otacky >= 100 && otacky <= 10000) 
                    break;
                Console.WriteLine("Zadaná hodnota je mimo rozsah. Zadej hodnotu znovu.");
            } 
            else
            {
                Console.WriteLine("Neplatný vstup. Zadej hodnotu otáček znovu");
            }
        }

        while (true)
        {
            Console.WriteLine("Zadej hodnotu MAF (g/s, např. 3.5):");
            string vstup = Console.ReadLine();

            if (double.TryParse(vstup, out MAF))
            {
                if (MAF >= 0 && MAF <= 100)
                    break;
                Console.WriteLine("Zadaná hodnota MAF je mimo rozsah. Zadej hodnotu znovu.");
            }
            else
            {
                Console.WriteLine("Neplatný vstup. Zadej hodnotu MAF znovu");
            }
        }

        while (true)
        {
            Console.WriteLine("Zadej hodnotu pro lambda sondu - AFR (např. 1.00):");
            string vstup = Console.ReadLine();

            if (double.TryParse(vstup, out lambda))
            {
                if (lambda >= 0.5 && lambda <= 2)
                    break;
                Console.WriteLine("Zadaná hodnota je mimo rozsah. Zadej hodnotu znovu.");
            }
            else
            {
                Console.WriteLine("Nepllatný vstup. Zadej hodnotu pro lambda sondu znovu");
            }
        }

        string zpravaOtacky = (otacky < otackyMin) ? "Otáčky jsou příliš nízké." :
                              (otacky > otackyMax) ? "Otáčky jsou příliš vysoké." :
                              "Otáčky jsou v normě.";

        string zpravaMAF = (MAF < MAFmin) ? "Hodnota MAF je příliš nízká." :
                           (MAF > MAFmax) ? "Hodnota MAF je příliš vysoká." :
                           "Hodnota MAF je v normě.";

        string zpravaLambda = (lambda < 0.97) ? "Hodnota lambdy je příliš nízká." :
                              (lambda > 1.03) ? "Hodnota lambdy je příliš vysoká." :
                              "Hodnoty lambdy jsou v normě.";


        Console.WriteLine("\n--- VYHODNOCENÍ ---");
        Console.WriteLine(zpravaOtacky); 
        Console.WriteLine(zpravaMAF); 
        Console.WriteLine(zpravaLambda);

        if (MAF  < MAFmin && lambda > 1.03)
        {
           Console.WriteLine("Doporučení: kontrola těsnosti sání nebo MAF senzor");
        }
        else if (MAF < MAFmax && lambda < 0.97)
        {
            Console.WriteLine("Doporučení: kontrola regulace paliva nebo vadný MAF senzor.");
        }
        else if (otacky > otackyMax && lambda > 1.03)  
        {
            Console.WriteLine("Doporučení: kontrola podtlaku, možné přisávání falešného vzduchu.");
        }


        
    }
}