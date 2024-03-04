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
        if (isUitverkocht)
        {
            Console.WriteLine("is uitverkocht");
        }
        else if (!isUitverkocht)
        {
            Console.WriteLine("Is niet uitverkocht");
        }
        Merk = "Onbekend";
        this.IsUitverkocht = true;
    }
        
    
}
