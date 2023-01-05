using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bolgsitesi.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BIM-TEKNIK-SERV;database=personelYonetim;integrated security=true;");
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public DbSet<Login> logins { get; set; }
        public DbSet<Signup> signups { get; set; }

        

    }}
