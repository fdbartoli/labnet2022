using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01_poo
{
    public class Taxi : PublicTransport
    {
        public Taxi(int passangers, int id) : base(passangers, id)
        {
        }

        public override string NumberOfPassangers()
        {
            return string.Format("El número de pasajeros de este taxi es {0}", passangers);
        }
        public override string ToString()
        {
            return string.Format("Taxi Nº: {0}", id);
        }
    }
}
