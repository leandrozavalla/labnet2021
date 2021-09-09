using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP1
{
    public class Taxi : TransportePublico
    {
        public Taxi(int pasajeros) : base(pasajeros)
        {

        }

        public override string Avanzar()
        {
            return $"Taxi avanzando con {Pasajeros} pasajeros.";
        }

        public override string Detenerse()
        {
            return "Taxi detenido.";
        }
    }
}
