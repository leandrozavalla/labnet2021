using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNet2021.TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 100;

            // Ejercicio 1
            Console.WriteLine(numero.Division());

            // Ejercicio 2
            Console.WriteLine(numero.Division(10));
            Console.WriteLine(numero.Division(0));
            Console.WriteLine(numero.Division(null));

            // Ejercicio 3
            try
            {
                Logic.LanzarExcepcion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            // Ejercicio 4
            try
            {
                CustomException.LanzarCustomException();
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            Console.ReadLine();
        }
    }
}
