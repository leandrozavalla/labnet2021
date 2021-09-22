using LabNet2021.TP4.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LabNet2021.TP4.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories>
    {
        public void Add(Categories item)
        {
            context.Categories.Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var categoryToDelete = context.Categories.Find(id);
            context.Categories.Remove(categoryToDelete);
            context.SaveChanges();
        }

        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public void Update(Categories item)
        {
            var categoryToUpdate = context.Categories.Find(item.CategoryID);
            categoryToUpdate.CategoryName = item.CategoryName;
            categoryToUpdate.Description = item.Description;
            context.SaveChanges();
        }
    }
}
