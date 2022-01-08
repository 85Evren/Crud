using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder

         optionBuilder)
        {
            //DESKTOP - S0CBLLS\SQLEXPRESS
            optionBuilder.UseSqlServer(@"server=.\SQLEXPRESS;Database=User;uid=sa;pwd=123");

        }
        public DbSet<User> User { get; set; }
       



    }
}
