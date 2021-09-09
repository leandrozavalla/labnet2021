using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP1
{
    public abstract class TransportePublico
    {
        public string Nombre { get; set; }
        public int Pasajeros { get; set; }

        public TransportePublico(int pasajeros)
        {
            Pasajeros = pasajeros;
        }

        public abstract string Avanzar();

        public abstract string Detenerse();
    }
}
