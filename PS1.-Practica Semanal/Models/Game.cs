using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PS1._Practica_Semanal.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public string Platform { get; set; }
        public string Classification { get; set; }
        public string imagen { get; set; }
    }
    
}