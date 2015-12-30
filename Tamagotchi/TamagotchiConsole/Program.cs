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
            int[] stats = service.GetStatusses();
            foreach (var item in service.GetStatusses())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
