using AlisverisSepeti.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisSepeti.Controllers
{
    public class UrunController : Controller
    {
        AliverisSepetiContext context;
        public UrunController()
        {
            context = new AliverisSepetiContext();
        }

        public IActionResult Index(int? kategoriId)
        {
            var urunRepository = new UrunRepository(context);
            var kategoriRepository = new KategoriRepository(context);
            List<Models.Urun> model;

            if (kategoriId.HasValue)
            {
                var kategori = kategoriRepository.KategoriGetir(kategoriId.Value);

                ViewData["Filtre"] = kategori;
                model = urunRepository.UrunleriKategoriyeGoreGetir(kategoriId.Value);
            }
            else
            {
                model = urunRepository.UrunleriGetir();
            }

            return base.View(model);
        }

    }
}
