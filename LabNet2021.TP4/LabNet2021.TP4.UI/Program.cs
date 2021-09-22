using LabNet2021.TP4.Entities;
using LabNet2021.TP4.Logic;
using System;

namespace LabNet2021.TP4.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            ShippersLogic shippersLogic = new ShippersLogic();
            int opcion;
            bool salir = false;

            while (!salir)
            {
                try
                {
                    Console.WriteLine("Elija una opción:\n\n" +
                    "1. Consultar datos\n" +
                    "2. Agregar registro\n" +
                    "3. Actualizar registro\n" +
                    "4. Eliminar registro\n" +
                    "5. Salir");

                    opcion = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("¿Qué datos quiere consultar?:\n\n" +
                                "1. Categorías\n" +
                                "2. Transportes");

                            opcion = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();

                            switch (opcion)
                            {
                                case 1:
                                    Console.WriteLine("CATEGORÍAS\n");
                                    foreach (Categories category in categoriesLogic.GetAll())
                                    {
                                        Console.WriteLine($"Código: {category.CategoryID} - Nombre: {category.CategoryName} - Descripción: {category.Description}");
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("TRANSPORTES\n");
                                    foreach (Shippers shipper in shippersLogic.GetAll())
                                    {
                                        Console.WriteLine($"Código: {shipper.ShipperID} - Empresa: {shipper.CompanyName} - Teléfono: {shipper.Phone}");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Ha ingresado una opción incorrecta. Por favor vuelva a intentarlo...");
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("¿Dónde quiere agregar un registro?:\n\n" +
                                "1. Categorías\n" +
                                "2. Transportes");

                            opcion = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();

                            switch (opcion)
                            {
                                case 1:
                                    Console.WriteLine("AGREGAR CATEGORÍA\n");
                                    Console.Write("Nombre de la categoría: ");
                                    string categoriaNombre = Console.ReadLine();
                                    Console.Write("Descripción de la categoría: ");
                                    string categoriaDescripcion = Console.ReadLine();

                                    categoriesLogic.Add(new Categories
                                    {
                                        CategoryName = categoriaNombre,
                                        Description = categoriaDescripcion
                                    });

                                    Console.WriteLine("\n¡Operación exitosa!");
                                    break;
                                case 2:
                                    Console.WriteLine("AGREGAR TRANSPORTE\n");
                                    Console.Write("Nombre de la empresa: ");
                                    string transporteNombre = Console.ReadLine();
                                    Console.Write("Teléfono de la empresa: ");
                                    string transporteTelefono = Console.ReadLine();

                                    shippersLogic.Add(new Shippers
                                    {
                                        CompanyName = transporteNombre,
                                        Phone = transporteTelefono
                                    });

                                    Console.WriteLine("\n¡Operación exitosa!");
                                    break;
                                default:
                                    Console.WriteLine("Ha ingresado una opción incorrecta. Por favor vuelva a intentarlo...");
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("¿Dónde quiere actualizar un registro?:\n\n" +
                                "1. Categorías\n" +
                                "2. Transportes");

                            opcion = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();

                            switch (opcion)
                            {
                                case 1:
                                    Console.WriteLine("ACTUALIZAR CATEGORÍA\n");
                                    foreach (Categories category in categoriesLogic.GetAll())
                                    {
                                        Console.WriteLine($"Código: {category.CategoryID} - Nombre: {category.CategoryName} - Descripción: {category.Description}");
                                    }
                                    Console.WriteLine();
                                    Console.Write("Escriba el código de la categoría: ");
                                    int categoriaID = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Nombre de la categoría: ");
                                    string categoriaNombre = Console.ReadLine();
                                    Console.Write("Descripción de la categoría: ");
                                    string categoriaDescripcion = Console.ReadLine();

                                    categoriesLogic.Update(new Categories
                                    {
                                        CategoryID = categoriaID,
                                        CategoryName = categoriaNombre,
                                        Description = categoriaDescripcion
                                    });

                                    Console.WriteLine("\n¡Operación exitosa!");
                                    break;
                                case 2:
                                    Console.WriteLine("ACTUALIZAR TRANSPORTE\n");
                                    foreach (Shippers shipper in shippersLogic.GetAll())
                                    {
                                        Console.WriteLine($"Código: {shipper.ShipperID} - Empresa: {shipper.CompanyName} - Teléfono: {shipper.Phone}");
                                    }
                                    Console.WriteLine();
                                    Console.Write("Escriba el código de la empresa: ");
                                    int transporteID = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Nombre de la empresa: ");
                                    string transporteNombre = Console.ReadLine();
                                    Console.Write("Teléfono de la empresa: ");
                                    string transporteTelefono = Console.ReadLine();

                                    shippersLogic.Update(new Shippers
                                    {
                                        ShipperID = transporteID,
                                        CompanyName = transporteNombre,
                                        Phone = transporteTelefono
                                    });

                                    Console.WriteLine("\n¡Operación exitosa!");
                                    break;
                                default:
                                    Console.WriteLine("Ha ingresado una opción incorrecta. Por favor vuelva a intentarlo...");
                                    break;
                            }
                            break;
                        case 4:
                            Console.WriteLine("¿Dónde quiere eliminar un registro?:\n\n" +
                                "1. Categorías\n" +
                                "2. Transportes");

                            opcion = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();

                            switch (opcion)
                            {
                                case 1:
                                    Console.WriteLine("ELIMINAR CATEGORÍA\n");
                                    foreach (Categories category in categoriesLogic.GetAll())
                                    {
                                        Console.WriteLine($"Código: {category.CategoryID} - Nombre: {category.CategoryName} - Descripción: {category.Description}");
                                    }
                                    Console.WriteLine();
                                    Console.Write("Escriba el código de la categoría: ");
                                    int categoriaID = Convert.ToInt32(Console.ReadLine());

                                    categoriesLogic.Delete(categoriaID);

                                    Console.WriteLine("\n¡Operación exitosa!");
                                    break;
                                case 2:
                                    Console.WriteLine("ELIMINAR TRANSPORTE\n");
                                    foreach (Shippers shipper in shippersLogic.GetAll())
                                    {
                                        Console.WriteLine($"Código: {shipper.ShipperID} - Empresa: {shipper.CompanyName} - Teléfono: {shipper.Phone}");
                                    }
                                    Console.WriteLine();
                                    Console.Write("Escriba el código de la empresa: ");
                                    int transporteID = Convert.ToInt32(Console.ReadLine());

                                    shippersLogic.Delete(transporteID);

                                    Console.WriteLine("\n¡Operación exitosa!");
                                    break;
                                default:
                                    Console.WriteLine("Ha ingresado una opción incorrecta. Por favor vuelva a intentarlo...");
                                    break;
                            }
                            break;
                        case 5:
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
