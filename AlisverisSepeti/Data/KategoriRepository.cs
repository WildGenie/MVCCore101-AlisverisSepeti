using AlisverisSepeti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisSepeti.Data
{
    public class KategoriRepository
    {
        AliverisSepetiContext context;

        public KategoriRepository(AliverisSepetiContext context)
        {
            this.context = context;
        }

        public List<Kategori> KategorileriGetir()
        {
            return context.Kategoriler.ToList();
        }

        public Kategori KategoriGetir(int id)
        {
            return context.Kategoriler.FirstOrDefault(kategori => kategori.Id == id);
        }
    }
}
