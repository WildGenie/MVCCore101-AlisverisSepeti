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
        public IActionResult Index(int? kategoriId)
        {
            var urunRepository = new UrunRepository();
            List<Models.Urun> model;

            if (kategoriId.HasValue)
            {
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
