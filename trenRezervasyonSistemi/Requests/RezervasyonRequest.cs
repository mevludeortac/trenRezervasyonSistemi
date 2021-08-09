using System.Collections.Generic;
using trenRezervasyonSistemi.Models;

public class RezervasyonRequest {
    public string ad {get;set;}
    // public ICollection<vagon> vagonlar {get;set;}
    
    public int trenId {get;set;}
        public int rezervasyonYapilacakKisiSayisi {get;set;}
    public bool kisilerFarkliVagonlaraYerlestirilebilir {get;set;}
    public bool rezervasyonYapılabilir {get;set;}
}