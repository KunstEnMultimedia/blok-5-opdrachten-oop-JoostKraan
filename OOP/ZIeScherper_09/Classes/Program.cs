namespace ZieScherper_09
{

    class Balletje
    {
        //Eigenschappen
        public int X { get; set; }
        public int Y { get; set; }
        public int VectorX { get; set; }
        public int VectorY { get; set; }

        //Methoden
        public void Update()
        {
            if (X + VectorX >= Console.WindowWidth || X + VectorX < 0)
            {
                VectorX = -VectorX;
            }
            X = X + VectorX;


            if (Y + VectorY >= Console.WindowHeight || Y + VectorY < 0)
            {
                VectorY = -VectorY;
            }
            Y = Y + VectorY;
        }

        public void TekenOpScherm()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("O");
        }
        static void Main(string[] args)
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
                bal1.Update();
                bal2.Update(); //zo simpel!
                bal1.TekenOpScherm();
                bal2.TekenOpScherm(); //wow, zooo simpel :)
                System.Threading.Thread.Sleep(50);
                Console.Clear();
            }
        }
    }

    
}
