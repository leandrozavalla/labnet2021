using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            int transporte;
            int pasajeros;
            List<TransportePublico> transportes = new List<TransportePublico> { };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Elija un medio de transporte: \n 1.Taxi \n 2.Omnibus");
                transporte = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cantidad de pasajeros:");
                pasajeros = Convert.ToInt32(Console.ReadLine());

                if (transporte == 1 && pasajeros <= 4)
                {
                    Taxi taxi = new Taxi(pasajeros) { Nombre = "Taxi" };
                    transportes.Add(taxi);
                    Console.WriteLine(taxi.Avanzar());
                }
                else if (transporte == 1)
                {
                    Console.WriteLine("La cantidad máxima de pasajeros para taxis es 4. Por favor vuelva a intentarlo...");
                }

                if (transporte == 2 && pasajeros >= 5 && pasajeros <= 40)
                {
                    Omnibus omnibus = new Omnibus(pasajeros) { Nombre = "Ómnibus" };
                    transportes.Add(omnibus);
                    Console.WriteLine(omnibus.Avanzar());
                }
                else if (transporte == 2)
                {
                    Console.WriteLine("La cantidad mínima de pasajeros para ómnibus es 5 y la máxima 40. Por favor vuelva a intentarlo...");
                }

                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadLine();
                Console.Clear();
            }

            foreach (var item in transportes)
            {
                Console.WriteLine($"{item.Nombre} {transportes.IndexOf(item) + 1}: {item.Pasajeros} pasajeros.");
            }

            Console.ReadLine();
        }
    }
}
