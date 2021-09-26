using LabNet2021.TP5.Data;
using LabNet2021.TP5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LabNet2021.TP5.Logic
{
    public class BaseLogic
    {
        private readonly NorthwindContext context;

        public BaseLogic()
        {
            context = new NorthwindContext();
        }

        // Ejercicio 1
        public Customers DevuelveCliente()
        {
            return context.Customers.First();
        }

        // Ejercicio 2
        public List<Products> ProductosSinStockMS()
        {
            return context.Products.Where(p => p.UnitsInStock == 0).ToList();
        }

        public List<Products> ProductosSinStockQS()
        {
            var query = from products in context.Products
                        where products.UnitsInStock == 0
                        select products;

            List<Products> result = query.ToList();

            return result;
        }

        // Ejercicio 3
        public List<Products> ProductosConStockPrecioMayorTresMS()
        {
            return context.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3).ToList();
        }

        public List<Products> ProductosConStockPrecioMayorTresQS()
        {
            var query = from products in context.Products
                        where products.UnitsInStock > 0 && products.UnitPrice > 3
                        select products;

            List<Products> result = query.ToList();

            return result;
        }

        // Ejercicio 4
        public List<Customers> ClientesRegionWAMS(string region)
        {
            return context.Customers.Where(c => c.Region == region).ToList();
        }

        public List<Customers> ClientesRegionWAQS(string region)
        {
            var query = from customers in context.Customers
                        where customers.Region == region
                        select customers;

            List<Customers> result = query.ToList();

            return result;
        }

        // Ejercicio 5
        public Products PrimerProductoONulo(int id)
        {
            var result = context.Products.FirstOrDefault(p => p.ProductID == id);
            return result;
        }

        // Ejercicio 6
        public List<string> ClientesNombresMayusculas()
        {
            var query = from customers in context.Customers
                        select customers;

            List<string> customerUpper = new List<string>();

            foreach (Customers customer in query)
            {
                customerUpper.Add(customer.ContactName.ToUpper());
            }

            return customerUpper;
        }

        public List<string> ClientesNombresMinusculas()
        {
            var query = from customers in context.Customers
                        select customers;

            List<string> customerLower = new List<string>();

            foreach (Customers customer in query)
            {
                customerLower.Add(customer.ContactName.ToLower());
            }

            return customerLower;
        }

        // Ejercicio 7
        public List<CustomersOrdersDTO> JoinClientesOrdenes(string region, DateTime date)
        {
            var query = from customers in context.Customers
                        join orders in context.Orders
                        on customers.CustomerID equals orders.CustomerID
                        where customers.Region == region && orders.OrderDate > date
                        select new CustomersOrdersDTO
                        {
                            ContactName = customers.ContactName,
                            Region = customers.Region,
                            OrderDate = (DateTime)orders.OrderDate
                        };

            List<CustomersOrdersDTO> result = query.ToList();

            return result;
        }

        // Ejercicio 8
        public List<Customers> TresPrimerosCientesWA(string region)
        {
            return context.Customers.Where(c => c.Region == region).Take(3).ToList();
        }

        // Ejercicio 9
        public List<Products> ProductosOrdenadosPorNombre()
        {
            var query = from products in context.Products
                        orderby products.ProductName ascending
                        select products;

            List<Products> result = query.ToList();

            return result;
        }

        // Ejercicio 10
        public List<Products> ProductosOrdenadosPorStock()
        {
            return context.Products.OrderBy(p => p.UnitsInStock).ToList();
        }

        // Ejercicio 12
        public Products PrimerProducto()
        {
            return context.Products.ToList().First();
        }
    }
}
