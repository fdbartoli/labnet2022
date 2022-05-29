using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01_poo
{
    public class Bus : PublicTransport
    {
        public Bus(int passagers, int id) : base(passagers, id)
        {
        }

        public override string NumberOfPassangers()
        {
            return string.Format("El número de pasajeros de este Omnibus es {0}", passangers);
        }
        public override string ToString()
        {
            return string.Format("Bus Nº: {0}", id);
        }
    }
}

