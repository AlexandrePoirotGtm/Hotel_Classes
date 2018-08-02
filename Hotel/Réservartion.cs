using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Classes
{
    class Réservartion
    {
        public DateTime DateDebut { get; set; }
        public int NombreNuitée { get; set; }

        public Chambre Chambres { get; set; }
        public Client Clients { get; set; }
    }
}
