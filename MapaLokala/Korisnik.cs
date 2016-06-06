using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapaLokala
{
    class Korisnik
    {
        string korIme;

        public string KorIme
        {
            get { return korIme; }
            set { korIme = value;  }
        }

        string lozinka1;

        public string Lozinka1
        {
            get { return lozinka1; }
            set { lozinka1 = value; }
        }

        public Korisnik(string korIme, string loz1) {
            this.KorIme = korIme;
            this.Lozinka1 = loz1;
        }

        public Korisnik() { }

        public Korisnik(string line)
        {
            char[] delimiterChars = {'|'};
            string[] words = line.Split(delimiterChars);
            this.KorIme = words[0];
            this.Lozinka1 = words[1];
        }
    }
}
