using EFCF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF.Context
{
    internal class EmployeeDataBase : DbContext
    {
        public DbSet<Dept> Depts { get; set; }

        public DbSet<Emp> Emps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source = DESKTOP-052IKRS\\SQLEXPRESS; " +
                "initial catalog = EmployeeDataBase; integrated security=SSPI; \nTrustServerCertificate=True;");
        }
    }
}
