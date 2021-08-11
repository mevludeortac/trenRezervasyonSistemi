using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using trenRezervasyonSistemi.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace trenRezervasyonSistemi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class trenController : Controller

    {

        [HttpGet]
        public string Get()
        {
            return "test";
        }
        // POST 
        [HttpPost]
        public IActionResult Post([FromBody] RezervasyonRequest request)
        {
            var kisiSayisi = request.RezervasyonYapilacakKisiSayisi;
            var farkliVagonlaraYerlestir = request.KisilerFarkliVagonlaraYerlestirilebilir;
            var vagonlar = request.Tren.Vagonlar;

            vagonlar = vagonlar.Where(vagon => vagon.DoluKoltukAdet < (vagon.Kapasite * 0.7) ).ToArray();
            //5.maddenin koşulları
            List<YerlesimAyrinti> yerlesimAyrinti = new List<YerlesimAyrinti>();
            foreach (var vagon in vagonlar)
            {
                yerlesimAyrinti.Add(new YerlesimAyrinti {
                    VagonAdi= vagon.Ad,
                    KisiSayisi = kisiSayisi
                });
            }
            
            var response = new RezervasyonResponse
            {
                rezervasyonYapılabilir = true,
                yerlesimAyrinti = yerlesimAyrinti.ToArray()
            };

            return Ok(response);
        }
    }


}

