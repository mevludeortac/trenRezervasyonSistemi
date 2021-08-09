using System;
namespace trenRezervasyonSistemi.Models
{
    public class tren
    {
        public string ad { get; set; }
        public vagon vagonlar { get; set; }
        public int rezervasyonYapilacakKisiSayisi { get; set; }
        public bool kisilerFarkliVagonlaraYerlestirilebilir { get; set; }
    }
}
