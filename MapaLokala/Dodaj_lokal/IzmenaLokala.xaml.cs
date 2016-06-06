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
using System.ComponentModel;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using MapaLokala.Dodaj_Etiketu;
using MapaLokala.Dodaj_tip_lokala;
using System.Collections;

namespace MapaLokala.Dodaj_lokal
{
    /// <summary>
    /// Interaction logic for IzmenaLokala.xaml
    /// </summary>
    public partial class IzmenaLokala : Window, INotifyPropertyChanged
    {
        CitanjePisanjeuFile cpf = new CitanjePisanjeuFile();
        DodajLokal de = new DodajLokal();
        string url;
        TipLokala tip;
        DodajEtiketu dodajEtiketu;

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

        private string _searchText;

        public string SearchText
        {
            get { return _searchText; }
            set
            {
                if (_searchText != value)
                {
                    _searchText = value;

                    OnPropertyChanged("SearchText");
                    OnPropertyChanged("PretrazeniLokali");
                }
            }
        }

        public string etikete_string;

        public string ispis_etiteka
        {
            get;
            set;
        }

        public string tip_lokala;

        public string select_tip
        {
            get;
            set;
        }

        public IEnumerable<Lokal> PretrazeniLokali
        {
            get
            {
                foreach (Lokal l in Lokali) {
                    etikete_string = "";
                    ObservableCollection<String> listaEtiketa = new ObservableCollection<string>();
                    if (l.Lista_etiketa.Count > 1)
                    {
                        foreach (Etiketa e in l.Lista_etiketa)
                        {
                            etikete_string += e.Ime + ",";
                            listaEtiketa.Add(e.Ime);
                        }
                    }
                    if (etikete_string.Length > 0)
                    {
                        etikete_string = etikete_string.Remove(etikete_string.Length - 1);
                    }
                    ispis_etiteka = etikete_string;
                    cmb_Etiketa.SelectedValue = listaEtiketa;
                }
                if (SearchText == null) return Lokali;

                return Lokali.Where(x => x.Ime.ToUpper().StartsWith(SearchText.ToUpper()));
            }
        }

        public ObservableCollection<Lokal> Lokali
        {
            get;
            set;
        }

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

        public IzmenaLokala()
        {

            InitializeComponent();

            statusSluzenjaAlkohola = new ObservableCollection<string>();
            statusSluzenjaAlkohola.Add("Ne sluzi se");
            statusSluzenjaAlkohola.Add("Sluzi se samo do 23h");
            statusSluzenjaAlkohola.Add("Sluzi se i kasno u noc");

            kategorijeCena = new ObservableCollection<string>();
            kategorijeCena.Add("Niske cene");
            kategorijeCena.Add("Srednje cene");
            kategorijeCena.Add("Visoke cene");
            kategorijeCena.Add("Izuzetno visoke cene");
            
            cmb_kategorijeCena.ItemsSource = kategorijeCena;
            cmb_statusSluzenjaAlkohola.ItemsSource = statusSluzenjaAlkohola;

            tipoviLokala = new ObservableCollection<string>();
            foreach (TipLokala tl in cpf.procitajIzFileTipoveLokala())
            {
                tipoviLokala.Add(tl.Ime);
            }

            cmb_TipLokala.ItemsSource = tipoviLokala;

            etikete = new ObservableCollection<string>();
            foreach (Etiketa e in cpf.procitajIzFileEtikete())
            {
                etikete.Add(e.Ime);
            }

            cmb_Etiketa.ItemsSource = etikete;

            Lokali = cpf.procitajIzFileLokale();
            url = "";
            this.DataContext = this;
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_loadImage_Click(object sender, RoutedEventArgs e)
        {
            Lokal lokal = (Lokal)dgrMain.SelectedItem;
            if (lokal != null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Images|*.jpg;*.png";
                if (openFileDialog.ShowDialog() == true)
                {
                    url = openFileDialog.FileName;
                    Image = new BitmapImage(new Uri(url, UriKind.Absolute));
                    img_ikona.Source = Image;
                }
            }
            else
            {
                MessageBox.Show("Izaberite lokal iz liste.");
            }
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            // Referenca na DatePicker
            var picker = sender as DatePicker;

            // Dobijamo DateTime od DatePicker
            DateTime? date = picker.SelectedDate;

        }

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            string Ime_etikete = txt_ime.Text;
            string Opis_etikete = txt_opis.Text;

            bool zaHendikepirane = false;
            bool smePusenje = false;
            bool primeRezervacije = false;

            if (rdb_hendikepirani_da.IsChecked == true)
            {
                zaHendikepirane = true;
            }
            else
            {
                zaHendikepirane = false;
            }

            if (rdb_pusenje_da.IsChecked == true)
            {
                smePusenje = true;
            }
            else
            {
                smePusenje = false;
            }

            if (rdb_rezervacije_da.IsChecked == true)
            {
                primeRezervacije = true;
            }
            else
            {
                primeRezervacije = false;
            }

            string tipLokala = cmb_TipLokala.SelectionBoxItem.ToString();
            DodajTipLokala dtl = new DodajTipLokala();
            tip = dtl.pronadjiTipPoNazivu(tipLokala);

            string statusSluzenjaAlkohola = cmb_statusSluzenjaAlkohola.SelectionBoxItem.ToString();

            string kategorijeCena = cmb_kategorijeCena.SelectionBoxItem.ToString();

            int kapacitetLokala;
            if (Int32.TryParse(txt_kapacitetLokala.Text, out kapacitetLokala))
            {

                IList etikete = new ObservableCollection<string>();
                etikete = cmb_Etiketa.SelectedItems;

                ObservableCollection<Etiketa> lista = new ObservableCollection<Etiketa>();
                dodajEtiketu = new DodajEtiketu();
                foreach (string et in etikete)
                {
                    lista.Add(dodajEtiketu.pronadjiEtiketuPoNazivu(et));
                }

                string datum = dp_datum.SelectedDate.Value.ToShortDateString();

                Lokal lokal = (Lokal)dgrMain.SelectedItem;

                if (lokal != null)
                {
                    lokal.Ime = Ime_etikete;
                    lokal.Opis = Opis_etikete;
                    lokal.Hendikepirani = zaHendikepirane;
                    lokal.Pusenje = smePusenje;
                    lokal.Rezervacija = primeRezervacije;
                    lokal.Tiplokala = tip;
                    lokal.StatusSluzenjaAlkohola = statusSluzenjaAlkohola;
                    lokal.KategorijaCena = kategorijeCena;
                    if (lista.Count > 0)
                    {
                        lokal.Lista_etiketa = lista;
                    }
                    lokal.KapacitetLokala = kapacitetLokala;

                    if (datum.Length > 0)
                    {
                        lokal.DatumOtvaranja = datum;
                    }
                    if (url != "")
                    {
                        lokal.Ikona = url;
                    }
                    de.upisiLokalUFile(Lokali);
                    url = "";
                    MessageBox.Show("Lokal je uspesno izmenjen");
                }
                else
                {
                    MessageBox.Show("Izaberite Lokal iz liste.");
                }
            }
            else {
                MessageBox.Show("Molimo vas unesti ceo broj za kapacitet lokala.");
            }
            
        }

        private void btnObrisi_Click(object sender, RoutedEventArgs e)
        {

            Lokal lokal = (Lokal)dgrMain.SelectedItem;
            if (lokal != null)
            {
                lokal.Obrisan = true;
                de.upisiLokalUFile(Lokali);
                Lokali.Clear();
                Lokali = cpf.procitajIzFileLokale();
                OnPropertyChanged("PretrazeniLokali");
                MessageBox.Show("Lokal je obrisana");
            }
            else
            {
                MessageBox.Show("Izaberite lokal iz liste.");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
