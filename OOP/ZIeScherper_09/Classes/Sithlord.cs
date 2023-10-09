using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIeScherper_09.Classes
{
    class SithLord
    {
        private int energie;
        private string sithName;
        public void ResetLord(int resetWaarde)
        {
            energie = resetWaarde;
        }
        public int Energie
        {
            get
            {
                return energie;
            }
            private set
            {
                if (value >= 0)
                    energie = value;
            }

        }
    }
}