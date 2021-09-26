using LabNet2021.TP5.Entities;
using LabNet2021.TP5.Logic;
using System;

namespace LabNet2021.TP5.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseLogic baseLogic = new BaseLogic();
            int opcion;
            bool salir = false;

            while (!salir)
            {
                try
                {
                    Console.WriteLine("Elija una opción:\n\n" +
                    "1. Ejercicio 1\n" +
                    "2. Ejercicio 2\n" +
                    "3. Ejercicio 3\n" +
                    "4. Ejercicio 4\n" +
                    "5. Ejercicio 5\n" +
                    "6. Ejercicio 6\n" +
                    "7. Ejercicio 7\n" +
                    "8. Ejercicio 8\n" +
                    "9. Ejercicio 9\n" +
                    "10. Ejercicio 10\n" +
                    "12. Ejercicio 12\n" +
                    "13. Salir");

                    opcion = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    switch (opcion)
                    {
                        case 1:
                            // Ejercicio 1
                            Console.WriteLine(baseLogic.DevuelveCliente());
                            break;
                        case 2:
                            // Ejercicio 2
                            foreach (Products product in baseLogic.ProductosSinStockMS())
                            {
                                Console.WriteLine($"Producto: {product.ProductName} - Stock: {product.UnitsInStock}");
                            }
                            break;
                        case 3:
                            // Ejercicio 3
                            foreach (Products product in baseLogic.ProductosConStockPrecioMayorTresQS())
                            {
                                Console.WriteLine($"Producto: {product.ProductName} - Stock: {product.UnitsInStock} - Precio: ${Convert.ToDouble(product.UnitPrice)}");
                            }
                            break;
                        case 4:
                            // Ejercicio 4
                            foreach (Customers customer in baseLogic.ClientesRegionWAMS("WA"))
                            {
                                Console.WriteLine($"Nombre: {customer.ContactName} - Región: {customer.Region}");
                            }
                            break;
                        case 5:
                            // Ejercicio 5
                            Products item = baseLogic.PrimerProductoONulo(789);
                            Console.WriteLine($"Producto: {item.ProductName}");
                            break;
                        case 6:
                            // Ejercicio 6
                            foreach (var customers in baseLogic.ClientesNombresMayusculas())
                            {
                                Console.WriteLine($"{customers}");
                            }

                            Console.WriteLine();

                            foreach (var customers in baseLogic.ClientesNombresMinusculas())
                            {
                                Console.WriteLine($"{customers}");
                            }
                            break;
                        case 7:
                            // Ejercicio 7
                            DateTime date = new DateTime(1997, 01, 01);

                            foreach (CustomersOrdersDTO customers in baseLogic.JoinClientesOrdenes("WA", date))
                            {
                                Console.WriteLine($"Nombre: {customers.ContactName} - Región: {customers.Region} - Fecha de órden: {customers.OrderDate}");
                            }
                            break;
                        case 8:
                            // Ejercicio 8
                            foreach (Customers customers in baseLogic.TresPrimerosCientesWA("WA"))
                            {
                                Console.WriteLine($"Nombre: {customers.ContactName} - Región: {customers.Region}");
                            }
                            break;
                        case 9:
                            // Ejercicio 9
                            foreach (Products product in baseLogic.ProductosOrdenadosPorNombre())
                            {
                                Console.WriteLine($"Producto: {product.ProductName}");
                            }
                            break;
                        case 10:
                            // Ejercicio 10
                            foreach (Products product in baseLogic.ProductosOrdenadosPorStock())
                            {
                                Console.WriteLine($"Stock: {product.UnitsInStock} - Producto: {product.ProductName}");
                            }
                            break;
                        case 12:
                            // Ejercicio 12
                            Console.WriteLine($"Producto: { baseLogic.PrimerProducto().ProductName}");
                            break;
                        case 13:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Ha ingresado una opción incorrecta. Por favor vuelva a intentarlo...");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nHa ocurrido el siguiente error:\n{ex.Message}\nPor favor vuelva a intentarlo...");
                }
                finally
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            return;
        }
    }
}
