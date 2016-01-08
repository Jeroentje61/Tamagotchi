using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi_WCF
{
    public class Tamagotchi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Naam { get; set; }
        public int Hunger { get; set; }
        public int Sleep { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }
        public DateTime AccesGranted { get; set; }
        public DateTime LastAcces { get; set; }
        public bool Alive { get ; set; }
        public bool Crazy { get; set; }
        public bool Munchies { get; set; }
        public bool TopAtleet { get; set; }
    }
}