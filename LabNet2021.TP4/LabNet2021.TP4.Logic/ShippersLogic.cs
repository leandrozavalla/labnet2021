using LabNet2021.TP4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LabNet2021.TP4.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {
        public void Add(Shippers item)
        {
            try
            {
                context.Shippers.Add(item);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var shipperToDelete = context.Shippers.Find(id);
                context.Shippers.Remove(shipperToDelete);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Shippers> GetAll()
        {
            try
            {
                return context.Shippers.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Shippers item)
        {
            try
            {
                var shipperToUpdate = context.Shippers.Find(item.ShipperID);
                shipperToUpdate.CompanyName = item.CompanyName;
                shipperToUpdate.Phone = item.Phone;
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
