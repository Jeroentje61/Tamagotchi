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

            Console.WriteLine("Welkom bij je Tamagotchi!");

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
