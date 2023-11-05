using System;

namespace ZIeScherper_09.Classes
{
    public class Rekening
    {
        public int Balance { get; private set; }
        public string NaamKlant { get; set; }
        public string RekeningNummer { get; set; }
        public RekeningStaat Staat { get; private set; }

        public Rekening(string naamKlant, string rekeningNummer)
        {
            NaamKlant = naamKlant;
            RekeningNummer = rekeningNummer;
            Balance = 0;
            Staat = RekeningStaat.Open;
        }

        public int RemoveMoney(int amount)
        {
            if (Staat == RekeningStaat.Blocked)
            {
                Console.WriteLine("Kan transactie niet afmaken, gebruiker is geblokkeerd");
                return 0;
            }

            if (amount >= Balance)
            {
                Console.WriteLine("Error: Onvoldoende saldo.");
                return 0;
            }

            Balance -= amount;
            return amount;
        }

        public int StortGeld(int amount)
        {
            if (Staat == RekeningStaat.Blocked)
            {
                Console.WriteLine($"{NaamKlant}, account is blocked.");
                return 0;
            }

            Balance += amount;
            return amount;
        }

        public void ToonInfo()
        {
            Console.WriteLine($"Name: {NaamKlant}");
            Console.WriteLine($"BankID: {RekeningNummer}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine($"Account State: {Staat}");
        }

        public void ChangeState()
        {
            if (Staat == RekeningStaat.Blocked)
            {
                Staat = RekeningStaat.Open;
            }
            else
            {
                Staat = RekeningStaat.Blocked;
            }
        }
    }

    public enum RekeningStaat
    {
        Open,
        Blocked
    }
}
