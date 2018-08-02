using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Classes
{
    class Chambre
    {
        public string Numéro { get; set; }
        public int NombreLits { get; set; }
        public double PrixNuitée { get; set; }

        public Hotel Hotel { get; set; }
        public List<Réservartion> LesClients { get; set; }
    }
}
