using AlisverisSepeti.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AlisverisSepeti.Data
{
    public class UrunRepository
    {
        AliverisSepetiContext context;
        public UrunRepository(AliverisSepetiContext context)
        {
            this.context = context;
        }

        public List<Urun> UrunleriGetir()
        {
            return context.Urunler.Include(urun => urun.Kategori).ToList();
        }

        public List<Urun> UrunleriKategoriyeGoreGetir(int kategoriId)
        {
            return context.Urunler.Include(urun => urun.Kategori).Where(urun => urun.KategoriId == kategoriId).ToList();
        }
    }
}
