using AlisverisSepeti.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisSepeti.Controllers
{
    public class KategoriController : Controller
    {
        public IActionResult Index()
        {
            var kategoriRepository = new KategoriRepository();
            var kategoriler = kategoriRepository.KategorileriGetir();
            return View(kategoriler);
        }
    }
}
