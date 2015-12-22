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
            ServiceReference1.ITamagotchiService service = new ServiceReference1.TamagotchiServiceClient();

            Console.WriteLine("Welkom bij je Tamagotchi!");
        }
    }
}
