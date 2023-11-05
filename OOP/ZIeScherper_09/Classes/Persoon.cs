﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIeScherper_09.Classes
{
    public class Persoon
    {

        public string Voornaam { get; set; }
        public string Achternaam { get; set; }




        private DateTime geboorteDatum;


        public DateTime GeboorteDatum
        {
            get { return geboorteDatum; }
            set
            {

                if (value > new DateTime(1990, 1, 1) && value < DateTime.Today)
                    geboorteDatum = value;
                else
                    geboorteDatum = DateTime.Today;
            }
        }

        public int BerekenLeeftijd()
        {
            int leeftijd = DateTime.Now.Year - geboorteDatum.Year;


            if (DateTime.Now.Month < geboorteDatum.Month ||
               (DateTime.Now.Month == geboorteDatum.Month &&
                    DateTime.Now.Day < geboorteDatum.Day))
            {
                leeftijd--;
            }
            return leeftijd;
        }

    }

}

