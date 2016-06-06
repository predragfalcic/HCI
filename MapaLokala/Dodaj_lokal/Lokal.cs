using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapaLokala.Dodaj_Etiketu;
using MapaLokala.Dodaj_tip_lokala;
using System.Collections.ObjectModel;

namespace MapaLokala.Dodaj_lokal
{
    public class Lokal
    {
        string oznaka;

        public string Oznaka
        {
            get { return oznaka; }
            set { oznaka = value; }
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
        string ikona;

        public string Ikona
        {
            get { return ikona; }
            set { ikona = value; }
        }
        int kapacitetLokala;

        public int KapacitetLokala
        {
            get { return kapacitetLokala; }
            set { kapacitetLokala = value; }
        }

        ObservableCollection<Etiketa> lista_etiketa;

        public ObservableCollection<Etiketa> Lista_etiketa
        {
            get { return lista_etiketa; }
            set { lista_etiketa = value; }
        }

        TipLokala tipLokala;

        public TipLokala Tiplokala
        {
            get { return tipLokala; }
            set { tipLokala = value; }
        }

        string statusSluzenjaAlkohola;

        public string StatusSluzenjaAlkohola
        {
            get { return statusSluzenjaAlkohola; }
            set { statusSluzenjaAlkohola = value; }
        }

        string kategorijaCena;

        public string KategorijaCena
        {
            get { return kategorijaCena; }
            set { kategorijaCena = value; }
        }

        bool rezervacija;

        public bool Rezervacija
        {
            get { return rezervacija; }
            set { rezervacija = value; }
        }

        bool pusenje;

        public bool Pusenje
        {
            get { return pusenje; }
            set { pusenje = value; }
        }

        bool hendikepirani;

        public bool Hendikepirani
        {
            get { return hendikepirani; }
            set { hendikepirani = value; }
        }


        string datumOtvaranja;

        public string DatumOtvaranja
        {
            get { return datumOtvaranja; }
            set { datumOtvaranja = value; }
        }

        bool obrisan;
        public bool Obrisan
        {
            get { return obrisan; }
            set { obrisan = value; }
        }

        bool naMapi;
        public bool NaMapi
        {
            get { return naMapi; }
            set { naMapi = value; }
        }

        double x;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        double y;

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Lokal() { }

        public Lokal(string oznakaLokala, string imeLokala, string opisLokala, int kapacitetLokala, ObservableCollection<Etiketa> etikete, TipLokala tipLokala_2, string statusSluzenjaAlkohola, string kategorijeCena, bool primeRezervacije, bool smePusenje, bool zaHendikepirane, string url, string datumOtvaranja)
        {
            // TODO: Complete member initialization
            this.Oznaka = oznakaLokala;
            this.Ime = imeLokala;
            this.Opis = opisLokala;
            this.KapacitetLokala = kapacitetLokala;
            this.Lista_etiketa = etikete;
            this.Tiplokala = tipLokala_2;
            this.StatusSluzenjaAlkohola = statusSluzenjaAlkohola;
            this.KategorijaCena = kategorijeCena;
            this.Rezervacija = primeRezervacije;
            this.Pusenje = smePusenje;
            this.Hendikepirani = zaHendikepirane;
            this.Ikona = url;
            this.DatumOtvaranja = datumOtvaranja;
            this.Obrisan = false;
            this.NaMapi = false;
            this.X = 0;
            this.Y = 0;
        }

        public Lokal(string line)
        {
            char[] delimiterChars = {'|'};
            string[] words = line.Split(delimiterChars);
            this.Oznaka = words[0];
            this.Ime = words[1];
            this.Opis = words[2];
            this.KapacitetLokala = Int32.Parse(words[3]);
            this.Lista_etiketa = podeliEtikete(words[4]);
            DodajTipLokala dtl = new DodajTipLokala();
            this.Tiplokala = dtl.pronadjiTipPoOznaci(words[5]);
            this.StatusSluzenjaAlkohola = words[6];
            this.KategorijaCena = words[7];
            this.Rezervacija = bool.Parse(words[8]);
            this.Pusenje = bool.Parse(words[9]);
            this.Hendikepirani = bool.Parse(words[10]);
            this.Ikona = words[11];
            this.DatumOtvaranja = words[12];
            this.Obrisan = Boolean.Parse(words[13]);
            this.NaMapi = Boolean.Parse(words[14]);
            this.X = Double.Parse(words[15]);
            this.Y = Double.Parse(words[16]);
        }

        private ObservableCollection<Etiketa> podeliEtikete(string s)
        {
            char[] delimiterChars = {'#'};
            ObservableCollection<Etiketa> lista = new ObservableCollection<Etiketa>();
            string[] words = s.Split(delimiterChars);
            DodajEtiketu de = new DodajEtiketu();
            foreach(string w in words){
                Etiketa e = de.pronadjiEtiketuPoOznaci(w);
                lista.Add(e);
            }
            return lista;
        }

    }
}
