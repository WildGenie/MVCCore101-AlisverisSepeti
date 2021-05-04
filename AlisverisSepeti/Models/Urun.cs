using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisSepeti.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
    }
}
