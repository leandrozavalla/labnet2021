using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP2
{
    public static class EjercicioException
    {
        // Ejercicio 1
        public static string Division(this int dividendo)
        {
            try
            {
                int resultado = dividendo / 0;
                return $"El resultado es {resultado}.";
            }
            catch (DivideByZeroException ex)
            {
                return $"{ex.Message}";
            }
            finally
            {
                Console.WriteLine("La operación ha finalizado.");
            }
        }

        // Ejercicio 2
        public static string Division(this int dividendo, int? divisor)
        {
            try
            {
                int resultado = dividendo / divisor.Value;
                return $"El resultado es {resultado}.";
            }
            catch (DivideByZeroException ex)
            {
                return $"¡Solo Chuck Norris y los Jedi dividen por cero! \n {ex.Message}";
            }
            catch (InvalidOperationException ex)
            {
                return $"Ha ingresado un dato inválido como una letra o un valor nulo.";
            }
            catch (Exception ex)
            {
                return $"Ha ocurrido el siguiente error: \n {ex.Message}";
            }
        }
    }
}
