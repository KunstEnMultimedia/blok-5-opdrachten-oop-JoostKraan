using System;

class Microfoon
{
    public string Merk { get; set; }
    public bool IsUitverkocht { get; set; }
    public Microfoon(string merkIn, bool isUitverkochtIn)
    {
        this.IsUitverkocht = isUitverkochtIn;
        this.Merk = merkIn;
    }

    public Microfoon(string merkIn)
    {
        IsUitverkocht = false;
        this.Merk = merkIn;
    }

    public Microfoon(bool isUitverkocht)
    {
        Merk = "Onbekend";
        this.IsUitverkocht = true;
    }

    
}
