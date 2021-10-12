using LabNet2021.TP4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LabNet2021.TP4.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories>
    {
        public void Add(Categories item)
        {
            try
            {
                context.Categories.Add(item);
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
                var categoryToDelete = context.Categories.Find(id);
                context.Categories.Remove(categoryToDelete);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Categories> GetAll()
        {
            try
            {
                return context.Categories.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Categories item)
        {
            try
            {
                var categoryToUpdate = context.Categories.Find(item.CategoryID);
                categoryToUpdate.CategoryName = item.CategoryName;
                categoryToUpdate.Description = item.Description;
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
