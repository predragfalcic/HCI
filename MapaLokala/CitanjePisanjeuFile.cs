using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MapaLokala.Dodaj_lokal;
using MapaLokala.Dodaj_Etiketu;
using MapaLokala.Dodaj_tip_lokala;

namespace MapaLokala
{
    class CitanjePisanjeuFile
    {
        public ObservableCollection<Lokal> listaLokala = new ObservableCollection<Lokal>();
        public ObservableCollection<TipLokala> listaTipovaLokala = new ObservableCollection<TipLokala>();
        public ObservableCollection<Etiketa> listaEtiketa = new ObservableCollection<Etiketa>();

        string fileNameTipovaLokala = "tipoviLokala.txt";
        string fileNameLokala = "lokali.txt";
        string fileNameEtiketa = "etikete.txt";
        string fullPath;

        public ObservableCollection<Lokal> procitajIzFileLokale()
        {
            listaLokala.Clear();
            fullPath = System.IO.Path.GetFullPath(fileNameLokala);
            string[] lines = System.IO.File.ReadAllLines(fullPath);

            foreach (string line in lines)
            {
                Lokal l = new Lokal(line);
                if (l.Obrisan == false)
                {
                    listaLokala.Add(l);
                }
            }
            return listaLokala;
        }

        public ObservableCollection<TipLokala> procitajIzFileTipoveLokala()
        {
            listaTipovaLokala.Clear();
            fullPath = System.IO.Path.GetFullPath(fileNameTipovaLokala);
            string[] lines = System.IO.File.ReadAllLines(fullPath);
            //string[] lines = System.IO.File.ReadAllLines("C:/Pedja/Programiranje/Interakcija covek racunar/Projekat/Mapa Lokala/MapaLokala/MapaLokala/Podaci/tipoviLokala.txt");

            foreach (string line in lines)
            {
                TipLokala l = new TipLokala(line);
                if (l.Obrisan == false)
                {
                    listaTipovaLokala.Add(l);
                }
            }
            return listaTipovaLokala;
        }

        public ObservableCollection<Etiketa> procitajIzFileEtikete()
        {
            listaEtiketa.Clear();
            fullPath = System.IO.Path.GetFullPath(fileNameEtiketa);
            string[] lines = System.IO.File.ReadAllLines(fullPath);
            //string[] lines = System.IO.File.ReadAllLines("C:/Pedja/Programiranje/Interakcija covek racunar/Projekat/Mapa Lokala/MapaLokala/MapaLokala/Podaci/etikete.txt");

            foreach (string line in lines)
            {
                Etiketa l = new Etiketa(line);
                if (l.Obrisana == false)
                {
                    listaEtiketa.Add(l);
                }
            }
            return listaEtiketa;
        }
    }
}
