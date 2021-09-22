using LabNet2021.TP4.Data;

namespace LabNet2021.TP4.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext context;

        public BaseLogic()
        {
            context = new NorthwindContext();
        }
    }
}
