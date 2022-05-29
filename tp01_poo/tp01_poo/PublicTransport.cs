using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01_poo
{
    public abstract class PublicTransport
    {
        public int passangers { get; set; }
        public int id { get; set; } 

        public PublicTransport(int passangers, int id)
        {
            this.passangers = passangers;            
            this.id = id;
        }
        public abstract string NumberOfPassangers();
        
        public virtual string Avanzar()
        {
            return "Avanza";
        }

        public virtual string Detenerse()
        {
            return "Se detiene";
        }

    }
}

