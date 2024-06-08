using ZIeScherper_09.Classes;

namespace ZieScherper_09
{

    class Program
    {
        static void Main(string[] args)
        {

            opdracht09_6d();
            Console.ReadLine();


        }

        private static void Opdracht09_6()
        {

        }
        private static void Opdracht09_5()
        {
            DateTime currentTime = DateTime.Now;
            DateTime Birthday = new DateTime(2020, 5, 17);
            Console.WriteLine(Birthday.ToString());
            Birthday = Birthday.AddMinutes(10);
            Console.WriteLine(Birthday.ToString());
            if (DateTime.IsLeapYear(Birthday.Year))
            {
                Console.WriteLine("This is a leap year");
            }
            else
            {
                Console.WriteLine("This is not a leap year");
            }

        }
        private static void Opdracht09_4()
        {
            SithLord Vader = new SithLord();
            //Vader.Energie = 20; //set
            Console.WriteLine($"Vaders energie is {Vader.Energie}"); 
        }
        public void Opdracht09_3()
        {
            Mens elvis = new Mens();
            Mens bono = new Mens();
            elvis.StartVerjongingskuur();
            elvis.Praat();
            bono.Praat();
            Mens deelnemer1 = new Mens();
            Mens deelnemer2 = new Mens();
            deelnemer1.Praat();
            deelnemer2.Praat();

            deelnemer2.VeranderLief("phoebe");
            deelnemer1.Praat();
            deelnemer2.Praat();

            deelnemer1.VeranderLief("camilla");
            deelnemer1.Praat();
            deelnemer2.Praat();
            Console.ReadKey();
        }
        
        public int X { get; set; }
        public int Y { get; set; }
        public int VectorX { get; set; }
        public int VectorY { get; set; }

        
        static void Opdracht09_1()
        {
           
            Console.CursorVisible = false;
            Balletje bal1 = new Balletje();
            bal1.X = 20;
            bal1.Y = 20;
            bal1.VectorX = 2;
            bal1.VectorY = 1;

            Balletje bal2 = new Balletje();
            bal2.X = 10;
            bal2.Y = 8;
            bal2.VectorX = 2;
            bal2.VectorY = -1;

            while (true)
            {
                
                bal1.TekenOpScherm();
                bal2.TekenOpScherm(); 
                System.Threading.Thread.Sleep(50);
                Console.Clear();
            }
        }

        public void TekenOpScherm()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("O");
        }
        
        public void opdracht09_2()
        {
            Auto mijnEersteAuto = new Auto();
            Auto mijnAndereAuto;
            Console.WriteLine(mijnEersteAuto);
            mijnAndereAuto = new Auto();
            Console.WriteLine(mijnAndereAuto);
        }

        public static void opdracht09_6b()
        {
            Nummers paar1 = new Nummers();
            paar1.Getal1 = 12;
            paar1.Getal2 = 34;
            Console.WriteLine($"paar:{paar1.Getal1},{paar1.Getal2}");
            Console.WriteLine($"Som = {paar1.Som()}");
            Console.WriteLine($"Verschil = {paar1.Verschil()}");
            Console.WriteLine($"Product = {paar1.Product()}");
            Console.WriteLine($"Quotient = {paar1.Quotient()}");
        }
        public static void opdracht09_6c()
        {
            DateTime geboorteDag;
            Console.WriteLine("Uw geboortedatum alstublieft : ");
            geboorteDag = DateTime.Parse(Console.ReadLine());
            DateTime vandaag = DateTime.Today;
            float updated;
            DateTime today = DateTime.Today;
            DateTime nextBirthday = new DateTime(today.Year + 1, geboorteDag.Month, geboorteDag.Day);

            int daysUntilNextBirthday = (nextBirthday - today).Days;
            string dayOfTheWeek = nextBirthday.ToString("dddd");

            Console.WriteLine($"Op je volgende verjaardag, volgend jaar, valt het op een {dayOfTheWeek}.");
            Console.WriteLine($"Je moet nog {daysUntilNextBirthday} dagen wachten.");
        }
        public static void opdracht09_6d()
        {
            //Rekening rekening1 = new Rekening();
            //Rekening rekening2 = new Rekening();

            //rekening1.naamKlant = "Pietje";
            //rekening1.rekeningNummer = "12";
            //rekening1.balance = 1000;
            
            //rekening2.naamKlant = "Karel";
            //rekening2.rekeningNummer = "13";
            //rekening2.balance = 0;

            //rekening1.ToonInfo();
            //rekening2.ToonInfo();
            //rekening2.StortGeld(300); rekening1.HaalGeldAf(300);
            //rekening1.ToonInfo();
            //rekening2.ToonInfo();

            //Console.ReadLine();

        }
    }

}
