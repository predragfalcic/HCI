using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapaLokala.Dodaj_tip_lokala
{
    public class TipLokala
    {
        string oznakaTipaLokala;

        public string OznakaTipaLokala
        {
            get { return oznakaTipaLokala; }
            set { oznakaTipaLokala = value; }
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

        string ikonaTipaLokala;

        public string IkonaTipaLokala
        {
            get { return ikonaTipaLokala; }
            set { ikonaTipaLokala = value; }
        }
        public TipLokala(string oznaka, string ime, string opis, string ikona) {
            this.OznakaTipaLokala = oznaka;
            this.Ime = ime;
            this.Opis = opis;
            this.IkonaTipaLokala = ikona;
        }

        public TipLokala() { }

        public TipLokala(string line)
        {
            char[] delimiterChars = {'|'};
            string[] words = line.Split(delimiterChars);
            this.OznakaTipaLokala = words[0];
            this.Ime = words[1];
            this.Opis = words[2];
            this.IkonaTipaLokala = words[3];
        }

    }
}
