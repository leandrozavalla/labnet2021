using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP2
{
    public class CustomException : Exception
    {
        // Ejercicio 4
        public CustomException(string mensaje) : base(mensaje)
        {

        }

        public static void LanzarCustomException(string mensaje = "Excepción personalizada.")
        {
            throw new CustomException(mensaje);
        }
    }
}
