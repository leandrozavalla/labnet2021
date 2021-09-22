using System.Collections.Generic;

namespace LabNet2021.TP4.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(int id);
    }
}
