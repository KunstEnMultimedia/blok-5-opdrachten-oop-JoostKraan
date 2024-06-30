using System;

namespace ZieScherper_13.Classes
{
    public class Patient
    {
        public string Naam { get; set; }
        public int UrenInZiekenhuis { get; set; }
        private const int basisKosten = 50;
        private const int kostenPerUur = 20;
        public virtual double BerekenKosten()
        {
            double kosten = basisKosten + (UrenInZiekenhuis * kostenPerUur);
            return kosten;
        }
        public void ToonInfo()
        {
            Console.WriteLine($"naam: {Naam}, kosten: {BerekenKosten()} (Ziekenhuisuren: {UrenInZiekenhuis})");
        }
    }

    public class VerzekerdePatient : Patient
    {
        private const double korting = 0.1;

        public override double BerekenKosten()
        {
            double totaalBasisKost = base.BerekenKosten();
            return totaalBasisKost - (totaalBasisKost * korting);
        }
    }
}
