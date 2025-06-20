using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Zadej typ motoru: malý (do 1.3l), střední (1.4 - 1.9l), velký (nad 2.0l)");
        string typMotoru = Console.ReadLine().ToLower();

        double minMAF = 0; 
        double maxMAF = 0;


        switch (typMotoru)
        {
            case "malý":
            case "maly":
                Console.WriteLine("Hodnoty nastaveny pro motor do objemu 1.3l)");
                minMAF = 2.5;
                maxMAF = 4.5; 
                break;
            case "střední":
            case "stredni":
                Console.WriteLine("Hodnoty nastaveny pro motory o objemu 1.4 - 1.9l");
                minMAF = 3.5;
                maxMAF = 6.0;
                break;
            case "velký":
            case "velky":
                Console.WriteLine("Hodnota nastaveny pro motory o objemu nad 2.0l");
                minMAF = 5.0;
                maxMAF = 8.0;
                break;
            default:
                Console.WriteLine("Neplatný vstup. Zadej malý, stžední nebo velký"); 
                return;
        }
        

        Console.WriteLine("Zadej otáčky motoru (např. 850):");
        int otacky = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Zadej hodnotu MAF v g/s (např. 3.5):");
        double maf = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Zadej hodnotu pro lambda sondu (např. 1.00)");
        double lambda = Convert.ToDouble(Console.ReadLine());

        bool otackyOk = otacky >= 650 && otacky <= 950;
        bool lambdaOk = lambda >= 0.98 && lambda <= 1.02;
        bool mafOk = maf >= minMAF && maf <= maxMAF;

        Console.WriteLine("\n--- VYHODNOCENÍ ---"); 


        if (otackyOk && lambdaOk && mafOk)
        {
            Console.WriteLine("Všechny hodnoty jsou v normě.");
        }
        else
        {
 
            if (!otackyOk)
                Console.WriteLine("Otáčky jsou mimo rozsah volnoběhu!"); 
            if (!lambdaOk) 
                { Console.WriteLine("Hodnota lambda sondy vykazuje odchylku"); 
            if (!mafOk && otackyOk && lambdaOk)
            {
                    if (maf > maxMAF)
                        Console.WriteLine("Hodnota MAF je vysoká!");
                    else if (maf < minMAF)
                        Console.WriteLine("Hodnota MAF je nízká!");
            }

            if (!otackyOk && !lambdaOk && !mafOk)  
                Console.WriteLine("Všechny hodnoty mimo rozsah");


            }


        }
    }
}