using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beakovicPaoloPonavljanje4
{
    class Tenisac
    {
        public string Ime;
        public string Prezime;
        public override string ToString()
        {
            string nazad;
            nazad = Ime + " " + Prezime;
            return nazad;
        }
    }