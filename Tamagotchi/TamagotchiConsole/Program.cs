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

            Console.WriteLine("Welkom!");
            Console.WriteLine("Wil je een nieuwe Tamagotchi aanmaken of een bestaande Tamagotchi kiezen? (nieuw||bestaand)");
            if (Console.ReadLine() == "nieuw")
            {
                Console.WriteLine("Typ de naam van je nieuwe Tamagotchi in. (of typ nee om te annuleren)");
                string antwoord = Console.ReadLine();
                service.CreateTamagotchi(antwoord);
            }
            else
            {
                Console.WriteLine("Kies een van de volgende Tamagotchis door zijn/haar naam in te typen...");
                if (service.GetTamagotchis() != null)
                {
                    foreach (string item in service.GetTamagotchis())
                    {
                        Console.Write(item + ", ");
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
            Console.WriteLine(service.ChooseTamagotchi(naam));
           
            

            Console.WriteLine("Typ een command in:");
            Console.WriteLine("eat, hug, play, sleep, workout");

            while (true)
            {
                string command = Console.ReadLine();
                Console.WriteLine(service.PerformAction(command));
            }
            
        }
    }
}
