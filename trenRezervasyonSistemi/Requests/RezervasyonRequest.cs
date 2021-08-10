using System.Collections.Generic;
using trenRezervasyonSistemi.Models;

public class RezervasyonRequest {
    public Tren Tren {get;set;}
    public int RezervasyonYapilacakKisiSayisi {get;set;}
    public bool KisilerFarkliVagonlaraYerlestirilebilir {get;set;}
}