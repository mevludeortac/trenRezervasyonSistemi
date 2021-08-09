using System;
namespace trenRezervasyonSistemi.Models
{
    public class vagon
    {
       
        public string ad { get; set; }
        public double kapasite { get; set; }
        public Int64 doluKoltukAdedi { get; set; }
        public int trenId { get; set; }
        public virtual tren Tren { get; set; }

    }
}
