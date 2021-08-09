using System;
using System.Collections.Generic;

namespace trenRezervasyonSistemi.Models
{
    public class tren
    {
        public string ad { get; set; }
        public virtual ICollection<vagon> vagonlar { get; set; }
    }
}
