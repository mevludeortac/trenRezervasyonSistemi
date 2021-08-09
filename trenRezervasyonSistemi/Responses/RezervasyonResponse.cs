using System.Collections.Generic;
using trenRezervasyonSistemi.Models;
public class RezervasyonResponse{
    public bool rezervasyonYapılabilir {get; set;}
    public YerlesimAyrinti[] yerlesimAyrinti {get;set;}
}

public class YerlesimAyrinti {
    public string VagonAdi {get;set;}
    public int KisiSayisi {get;set;}
}