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
using Microsoft.Win32;
using System.ComponentModel;
using System.IO;
using System.Collections.ObjectModel;

namespace MapaLokala.Dodaj_Etiketu
{
    /// <summary>
    /// Interaction logic for DodajEtiketu.xaml
    /// </summary>
    public partial class DodajEtiketu : Window, INotifyPropertyChanged
    {
        string url;
        public ObservableCollection<Etiketa> etikete = new ObservableCollection<Etiketa>();
        CitanjePisanjeuFile cp = new CitanjePisanjeuFile();

        string fileName = "etikete.txt";
        string fullPath;

        public DodajEtiketu()
        {
            InitializeComponent();
            etikete = cp.procitajIzFileEtikete();
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
                img_ikonaEtikete.Source = Image;
            }
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            string oznaka = txt_oznakaEtikete.Text;
            string ime = txt_imeEtikete.Text;
            string opis = txt_opisEtikete.Text;

            if (oznaka.Length > 0 && ime.Length > 0 && opis.Length > 0 && url != null)
            {
                Etiketa et = pronadjiEtiketuPoOznaci(oznaka);


                if (et == null)
                {
                    Etiketa etiketa = new Etiketa(oznaka, ime, opis, url);
                    etikete.Add(etiketa);
                    upisiEtiketuUFile(etikete);
                    MessageBox.Show("Etiketa je uspesno sacuvana");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Etika sa tom oznakom vec postoji, molimo vas unesite drugu oznaku za etiketu.");
                }
            }
            else
            {
                MessageBox.Show("Da bi ste kreirali etiketu potrebno je popuniti sva polja. ");
            }
        }

        public void upisiEtiketuUFile(ObservableCollection<Etiketa> listaEtiketa)
        {
            if (listaEtiketa != null)
            {
                // System.IO.StreamWriter file = new System.IO.StreamWriter("C:/Pedja/Programiranje/Interakcija covek racunar/Projekat/Mapa Lokala/MapaLokala/MapaLokala/Podaci/etikete.txt");
                fullPath = System.IO.Path.GetFullPath(fileName);
                System.IO.StreamWriter file = new System.IO.StreamWriter(fullPath);
                foreach (Etiketa e in listaEtiketa)
                {
                    string text = e.OznakaEtikete + "|" + e.Ime + "|" + e.Opis + "|" + e.IkonicaEtikete + "|" + e.Obrisana.ToString();
                    file.WriteLine(text);
                }
                file.Close();
            }
        }

        public Etiketa pronadjiEtiketuPoOznaci(string oznaka)
        {
            foreach (Etiketa e in etikete)
            {
                if (oznaka.Equals(e.OznakaEtikete) && e.Obrisana == false)
                {
                    return e;
                }
            }
            return null;
        }

        public Etiketa pronadjiEtiketuPoNazivu(string naziv)
        {
            foreach (Etiketa e in etikete)
            {
                if (naziv.Equals(e.Ime))
                {
                    return e;
                }
            }
            return null;
        }
    }
}
