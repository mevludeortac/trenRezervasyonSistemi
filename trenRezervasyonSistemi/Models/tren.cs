using System;
using System.Collections.Generic;

namespace trenRezervasyonSistemi.Models
{
    public class Tren
    {
        public string Ad { get; set; }
        public virtual ICollection<Vagon> Vagonlar { get; set; }
    }
}
