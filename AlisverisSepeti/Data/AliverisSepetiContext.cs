using AlisverisSepeti.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisSepeti.Data
{
    public class AliverisSepetiContext : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=AlisverisSepeti;Integrated Security=True");
        }
    }
}
