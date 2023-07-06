using AkademiPlusEntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusDataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NODIFQV\\SQLEXPRESS;initial catalog=AkademiPlusUnitOfWorkDb;integrated security=true");
            
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Process>Processes { get; set; }
    }
}
