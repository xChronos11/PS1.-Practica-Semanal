using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PS1._Practica_Semanal.Models
{
    public class PS1DbContext : DbContext
    {
        public PS1DbContext() : base("MyConnection")
        {

        }
        public DbSet<Game> Games {get; set;}
    }
}