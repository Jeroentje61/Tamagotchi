using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TamagotchiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TamagotchiService.ITamagotchiService service = new TamagotchiService.TamagotchiServiceClient();
            TamagotchiService.Tamagotchi tmg;

            Console.WriteLine("Welkom!");
            Console.WriteLine("Wil je een nieuwe Tamagotchi aanmaken of een bestaande Tamagotchi kiezen? (nieuw||bestaand)");
            if (Console.ReadLine() == "nieuw")
            {
                Console.WriteLine("Typ de naam van je nieuwe Tamagotchi in. (of typ nee om te annuleren)");
                string antwoord = Console.ReadLine();
                tmg = service.CreateTamagotchi(antwoord);
                if (tmg != null) { Console.WriteLine("Je Tamagotchi " + tmg.Naam + " is aangemaakt!"); }
                else { Console.WriteLine("Er is geen Tamagotchi aangemaakt"); }
            }
            else
            {
                Console.WriteLine("Kies een van de volgende Tamagotchis door zijn/haar naam in te typen...");
                if (service.GetLivingTamagotchis() != null)
                {
                    foreach (TamagotchiService.Tamagotchi item in service.GetLivingTamagotchis())
                    {
                        Console.Write(item.Naam + ", ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Je hebt nog geen Tamagotchis, wil je er een aanmaken? Zo ja, typ zijn naam in, zoniet, typ nee.");
                    string antwoord = Console.ReadLine();
                    service.CreateTamagotchi(antwoord);
                }
            }
            string naam = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            tmg = service.ChooseTamagotchi(naam);
            naam = tmg.Naam;
            
            if (naam != null) { Console.WriteLine("Je speelt nu met " + naam);}
            else { Console.WriteLine("Deze Tamagotchi is niet gevonden...");}
           
            

            Console.WriteLine("Typ een command in:");
            Console.WriteLine("eat, hug, play, sleep, workout");

            while (true)
            {
                string command = Console.ReadLine();
                Console.WriteLine(service.PerformAction(command, tmg));
            }
            
        }
    }
}
