using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Classes
{
    class Hotel
    {
        public string Nom { get; set;}
        public string Adresse { get; set;}
        public List<Chambre> LesChambres { get; set; }
    }
}
