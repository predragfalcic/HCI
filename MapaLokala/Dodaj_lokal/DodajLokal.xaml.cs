using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Microsoft.Win32;
using System.Collections;
using MapaLokala.Dodaj_Etiketu;
using MapaLokala.Dodaj_tip_lokala;

namespace MapaLokala.Dodaj_lokal
{
    /// <summary>
    /// Interaction logic for DodajLokal.xaml
    /// </summary>
    public partial class DodajLokal : Window, INotifyPropertyChanged
    {

        string url;
        DodajEtiketu de;

        string fileName = "lokali.txt";
        string fullPath;

        public ObservableCollection<Lokal> lokali
        {
            get;
            set;
        }


        CitanjePisanjeuFile mw = new CitanjePisanjeuFile();
        TipLokala tip;

        public ObservableCollection<string> tipoviLokala
        {
            get;
            set;
        }

        public ObservableCollection<string> etikete
        {
            get;
            set;
        }

        public ObservableCollection<string> statusSluzenjaAlkohola
        {
            get;
            set;
        }

        public ObservableCollection<string> kategorijeCena
        {
            get;
            set;
        }

        public DodajLokal()
        {
            InitializeComponent();
            //Da bi se vrednosti prikazivale u comboboxu potrebno nam je ovo
            this.DataContext = this;
            //Ili mozemo koristiti 
            //cmb_TipLokala.ItemsSource = listaTipova; //comboboxu postavljamo ItemsSource na listu nasih tipova, s tim sto se ovo koristi nakon sto je lista kreirana i popunjena

            //cmb_TipLokala.ItemsSource = listaTipova;

            statusSluzenjaAlkohola = new ObservableCollection<string>();
            statusSluzenjaAlkohola.Add("Ne sluzi se");
            statusSluzenjaAlkohola.Add("Sluzi se samo do 23h");
            statusSluzenjaAlkohola.Add("Sluzi se i kasno u noc");

            kategorijeCena = new ObservableCollection<string>();
            kategorijeCena.Add("Niske cene");
            kategorijeCena.Add("Srednje cene");
            kategorijeCena.Add("Visoke cene");
            kategorijeCena.Add("Izuzetno visoke cene");

            tipoviLokala = new ObservableCollection<string>();
            foreach (TipLokala tl in mw.procitajIzFileTipoveLokala())
            {
                tipoviLokala.Add(tl.Ime);
            }

            etikete = new ObservableCollection<string>();
            foreach (Etiketa e in mw.procitajIzFileEtikete())
            {
                etikete.Add(e.Ime);
            }

            lokali = new ObservableCollection<Lokal>();
            lokali = mw.procitajIzFileLokale();
        }

        #region PropertyChangedNotifier
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        private ImageSource _image;

        public ImageSource Image
        {
            get
            {
                return _image;
            }
            set
            {
                if (_image != value)
                {
                    _image = value;
                    OnPropertyChanged("Image");
                }
            }
        }

        private void btn_loadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.jpg;*.png";
            if (openFileDialog.ShowDialog() == true)
            {
                url = openFileDialog.FileName;
                Console.WriteLine(url);
                Image = new BitmapImage(new Uri(url, UriKind.Absolute));
                img_ikonaLokala.Source = Image;
            }
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            // Referenca na DatePicker
            var picker = sender as DatePicker;

            // Dobijamo DateTime od DatePicker
            DateTime? date = picker.SelectedDate;

        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            string oznakaLokala = txt_oznakaLokala.Text;
            string imeLokala = txt_imeLokala.Text;
            string opisLokala = txt_opisLokala.Text;

            bool zaHendikepirane = false;
            bool smePusenje = false;
            bool primeRezervacije = false;

            int kapacitetLokala;
            if (Int32.TryParse(txt_kapacitetLokala.Text, out kapacitetLokala))
                Console.WriteLine(kapacitetLokala);
            else
                MessageBox.Show("Molimo vas unesti ceo broj za kapacitet lokala.");

            if (rdb_hendikepirani_da.IsChecked == true)
            {
                zaHendikepirane = true;
            }
            else if (rdb_hendikepirani_ne.IsChecked == true)
            {
                zaHendikepirane = false;
            }

            if (rdb_pusenje_da.IsChecked == true)
            {
                smePusenje = true;
            }
            else if (rdb_pusenje_ne.IsChecked == true)
            {
                smePusenje = false;
            }

            if (rdb_rezervacije_da.IsChecked == true)
            {
                primeRezervacije = true;
            }
            else if (rdb_rezervacije_ne.IsChecked == true)
            {
                primeRezervacije = false;
            }

            string tipLokala = cmb_TipLokala.SelectionBoxItem.ToString();
            DodajTipLokala dtl = new DodajTipLokala();
            tip = dtl.pronadjiTipPoNazivu(tipLokala);
            string statusSluzenjaAlkohola = cmb_statusSluzenjaAlkohola.SelectionBoxItem.ToString();

            string kategorijeCena = cmb_kategorijeCena.SelectionBoxItem.ToString();

            IList etikete = new ObservableCollection<string>();
            etikete = cmb_Etiketa.SelectedItems;

            ObservableCollection<Etiketa> lista = new ObservableCollection<Etiketa>();
            de = new DodajEtiketu();
            foreach (string et in etikete)
            {
                lista.Add(de.pronadjiEtiketuPoNazivu(et));
            }

            Lokal lokal = new Lokal(oznakaLokala, imeLokala, opisLokala, kapacitetLokala, lista, tip, statusSluzenjaAlkohola, kategorijeCena, primeRezervacije, smePusenje, zaHendikepirane, url);
            lokali.Add(lokal);
            upisiLokalUFile(lokali);
            this.Close();
        }

        private void upisiLokalUFile(ObservableCollection<Lokal> listaLokala)
        {
            if (listaLokala != null)
            {
                fullPath = System.IO.Path.GetFullPath(fileName);
                System.IO.StreamWriter file = new System.IO.StreamWriter(fullPath);
                //System.IO.StreamWriter file = new System.IO.StreamWriter("C:/Pedja/Programiranje/Interakcija covek racunar/Projekat/Mapa Lokala/MapaLokala/MapaLokala/Podaci/lokali.txt");
                foreach (Lokal e in listaLokala)
                {
                    string sveEtikete = "";

                    foreach (Etiketa etiketa in e.Lista_etiketa)
                    {
                        sveEtikete += etiketa.OznakaEtikete + "#";
                    }
                    sveEtikete = sveEtikete.Remove(sveEtikete.Length - 1);

                    string text = e.Oznaka + "|" + e.Ime + "|" + e.Opis + "|" + e.KapacitetLokala.ToString() + "|" + sveEtikete + "|" + e.TipLokala.OznakaTipaLokala + "|" + e.StatusSluzenjaAlkohola + "|" + e.KategorijaCena + "|" + e.Rezervacija.ToString() + "|" + e.Pusenje.ToString() + "|" + e.Hendikepirani.ToString() + "|" + e.Ikona;
                    file.WriteLine(text);
                }
                MessageBox.Show("Lokal je uspesno sacuvana");
                file.Close();
            }
            else
            {
                MessageBox.Show("Lokal nije uspesno sacuvana");
            }
        }
    }
}
