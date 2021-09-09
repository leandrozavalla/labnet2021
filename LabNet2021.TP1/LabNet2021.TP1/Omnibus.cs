using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP1
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int pasajeros) : base(pasajeros)
        {

        }

        public override string Avanzar()
        {
            return $"Ómnibus avanzando con {Pasajeros} pasajeros.";
        }

        public override string Detenerse()
        {
            return "Ómnibus detenido.";
        }
    }
}
