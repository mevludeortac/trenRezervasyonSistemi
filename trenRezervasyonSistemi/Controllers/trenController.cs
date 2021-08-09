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
        public string  Get()
        {
            return "test";
        }
        // POST 
        [HttpPost]
        public IActionResult Post([FromBody] RezervasyonRequest request)
        {
            if (request.rezervasyonYapılabilir == true){
                 var response = new RezervasyonResponse
           {
               rezervasyonYapılabilir = true,
               yerlesimAyrinti = new YerlesimAyrinti[] {
                    new YerlesimAyrinti {
                   VagonAdi= "vagon1",
                   KisiSayisi = 5
                                        }
                                                    }                    
                     };
                                 return Ok(response);
            }
            else
                {
                var yerlesimAyrinti = new YerlesimAyrinti[0];
                }
            } 
        }   
    }

