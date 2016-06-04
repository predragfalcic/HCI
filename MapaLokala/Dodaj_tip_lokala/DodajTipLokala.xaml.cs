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
using System.Collections.ObjectModel;

namespace MapaLokala.Dodaj_tip_lokala
{
    /// <summary>
    /// Interaction logic for DodajTipLokala.xaml
    /// </summary>
    public partial class DodajTipLokala : Window, INotifyPropertyChanged
    {
        string url;
        ObservableCollection<TipLokala> tipoviLokala = new ObservableCollection<TipLokala>();
        CitanjePisanjeuFile mw = new CitanjePisanjeuFile();

        string fileName = "tipoviLokala.txt";
        string fullPath;

        public DodajTipLokala()
        {
            InitializeComponent();
            tipoviLokala = mw.procitajIzFileTipoveLokala();
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
                img_ikonaTipaLokala.Source = Image;
            }
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            string oznaka = txt_oznakaTipaLokala.Text;
            string ime = txt_imeTipaLokala.Text;
            string opis = txt_opisTipaLokala.Text;

            TipLokala tipLokala = new TipLokala(oznaka, ime, opis, url);
            tipoviLokala.Add(tipLokala);
            upisiEtiketuUFile(tipoviLokala);
            this.Close();
        }

        private void upisiEtiketuUFile(ObservableCollection<TipLokala> listaTipova)
        {
            if (listaTipova != null)
            {
                fullPath = System.IO.Path.GetFullPath(fileName);
                System.IO.StreamWriter file = new System.IO.StreamWriter(fullPath);
                //System.IO.StreamWriter file = new System.IO.StreamWriter("C:/Pedja/Programiranje/Interakcija covek racunar/Projekat/Mapa Lokala/MapaLokala/MapaLokala/Podaci/tipoviLokala.txt");
                foreach (TipLokala e in listaTipova)
                {
                    string text = e.OznakaTipaLokala + "|" + e.Ime + "|" + e.Opis + "|" + e.IkonaTipaLokala;
                    file.WriteLine(text);
                }
                MessageBox.Show("Tip lokala je uspesno sacuvan");
                file.Close();
            }
            else
            {
                MessageBox.Show("Tip lokala nije uspesno sacuvan");
            }
        }

        public TipLokala pronadjiTipPoOznaci(string oznaka)
        {
            foreach (TipLokala tip in tipoviLokala)
            {
                if (oznaka.Equals(tip.OznakaTipaLokala))
                {
                    return tip;
                }
            }
            return null;
        }

        public TipLokala pronadjiTipPoNazivu(string naziv)
        {
            foreach (TipLokala tip in tipoviLokala)
            {
                if (naziv.Equals(tip.Ime))
                {
                    return tip;
                }
            }
            return null;
        }
    }
}
