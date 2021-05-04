using AlisverisSepeti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisSepeti.Data
{
    public class KategoriRepository
    {
        List<Kategori> kategoriler;

        public KategoriRepository()
        {
            kategoriler = new List<Kategori>
            {
                new Kategori {Id=1, Isim="Tatlılar"},
                new Kategori {Id=2, Isim="Meyveler"},
                new Kategori {Id=3, Isim="Sebzeler"}
            };
        }

        public List<Kategori> KategorileriGetir()
        {
            return kategoriler;
        }
    }
}
