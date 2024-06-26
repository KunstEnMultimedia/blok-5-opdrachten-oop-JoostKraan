﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIeScherper_09.Classes
{
    class Balletje
    {
       
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
            
            if ((Console.WindowWidth > 0) && (Console.WindowHeight > 0))
            {
                Console.SetCursorPosition(X, Y);
                Console.Write($"O"); 
            }
        }
    }
}
