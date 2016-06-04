using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace MapaLokala.Dodaj_Etiketu
{
    public class Etiketa
    {
        string oznakaEtikete;

        public string OznakaEtikete
        {
            get { return oznakaEtikete; }
            set { oznakaEtikete = value; }
        }

        string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        string opis;

        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }

        string ikonicaEtikete;

        public string IkonicaEtikete
        {
            get { return ikonicaEtikete; }
            set { ikonicaEtikete = value; }
        }

        bool obrisana;

        public bool Obrisana
        {
            get { return obrisana; }
            set { obrisana = value; }
        }

        public Etiketa(string oznaka, string ime, string opis, string ikona) {
            this.oznakaEtikete = oznaka;
            this.ime = ime;
            this.opis = opis;
            this.ikonicaEtikete = ikona;
            this.obrisana = false;
        }

        public Etiketa() { }

        public Etiketa(string line)
        {
            char[] delimiterChars = {'|'};
            string[] words = line.Split(delimiterChars);
            this.OznakaEtikete = words[0];
            this.Ime = words[1];
            this.Opis = words[2];
            this.IkonicaEtikete = words[3];
            this.Obrisana = Boolean.Parse(words[4]);
        }
    }
}
