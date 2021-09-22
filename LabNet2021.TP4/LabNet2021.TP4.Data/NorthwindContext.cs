using LabNet2021.TP4.Entities;
using System.Data.Entity;

namespace LabNet2021.TP4.Data
{
    public partial class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("name=NorthwindConnection") { }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Shippers> Shippers { get; set; }
    }
}
