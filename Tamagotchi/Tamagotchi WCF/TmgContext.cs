using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Tamagotchi_WCF
{
    public class TmgContext : DbContext
    {

        public TmgContext()
            : base("name=TamagotchiNiels_db")
        {

        }

        public DbSet<Tamagotchi> Tamagotchis { get; set; }
    }
}