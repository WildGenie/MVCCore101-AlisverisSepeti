using AlisverisSepeti.Models;
using System.Collections.Generic;
using System.Linq;

namespace AlisverisSepeti.Data
{
    public class UrunRepository
    {
        List<Urun> urunler;
        public UrunRepository()
        {
            urunler = new List<Urun>
            {
                new Urun{ Id = 1, KategoriId = 1, Isim="Profetorol"},
                new Urun{ Id = 2, KategoriId = 1, Isim="Kazandibi"},
                new Urun{ Id = 3, KategoriId = 1, Isim="Keşkül"},
                new Urun{ Id = 4, KategoriId = 2, Isim="Elma"},
                new Urun{ Id = 5, KategoriId = 2, Isim="Armut"},
                new Urun{ Id = 6, KategoriId = 2, Isim="Muz"},
                new Urun{ Id = 7, KategoriId = 3, Isim="Marul"},
                new Urun{ Id = 8, KategoriId = 3, Isim="Limon"},
                new Urun{ Id = 9, KategoriId = 3, Isim="Salatalık"},
            };
        }

        public List<Urun> UrunleriGetir()
        {
            return urunler;
        }

        public List<Urun> UrunleriKategoriyeGoreGetir(int kategoriId)
        {
            return urunler.Where(urun => urun.KategoriId == kategoriId).ToList();
        }
    }
}
