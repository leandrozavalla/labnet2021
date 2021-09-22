using LabNet2021.TP4.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LabNet2021.TP4.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {
        public void Add(Shippers item)
        {
            context.Shippers.Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var shipperToDelete = context.Shippers.Find(id);
            context.Shippers.Remove(shipperToDelete);
            context.SaveChanges();
        }

        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public void Update(Shippers item)
        {
            var shipperToUpdate = context.Shippers.Find(item.ShipperID);
            shipperToUpdate.CompanyName = item.CompanyName;
            shipperToUpdate.Phone = item.Phone;
            context.SaveChanges();
        }
    }
}
