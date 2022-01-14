using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp.Models
{
        public class CrudAppDbContext : DbContext
        {

            protected override void OnConfiguring(DbContextOptionsBuilder

             optionBuilder)
            {
                //DESKTOP - S0CBLLS\SQLEXPRESS
                optionBuilder.UseSqlServer(@"server=.\SQLEXPRESS;Database=CrudApp1;uid=sa;pwd=123");

            }
        public DbSet<User> Kullanici { get; set; }

        public DbSet<Categories> Kategori { get; set; }

        public DbSet<Shippers> Nakliyeci { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<User>().Property(c => c.Name).HasColumnName("UserName").HasMaxLength(20);
            modelBuilder.Entity<Shippers>().Property(c => c.Name).HasColumnName("ShipperName");//c.name name kolonunda değişiklik yapılacaktır.


        }

        internal void Remove()
        {
            throw new NotImplementedException();
        }
    }

    }
