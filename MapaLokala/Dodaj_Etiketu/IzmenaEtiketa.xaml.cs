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
using Microsoft.Win32;
using System.ComponentModel;

namespace MapaLokala.Dodaj_Etiketu
{
    /// <summary>
    /// Interaction logic for IzmenaEtiketa.xaml
    /// </summary>
    public partial class IzmenaEtiketa : Window, INotifyPropertyChanged
    {
        CitanjePisanjeuFile cpf = new CitanjePisanjeuFile();
        DodajEtiketu de = new DodajEtiketu();
        string url;

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
                    OnPropertyChanged("PretrazeneEtikete");
                }
            }
        }


        public IEnumerable<Etiketa> PretrazeneEtikete
        {
            get
            {
                if (SearchText == null) return Etikete;

                return Etikete.Where(x => x.Ime.ToUpper().StartsWith(SearchText.ToUpper()));
            }
        }

        public ObservableCollection<MapaLokala.Dodaj_Etiketu.Etiketa> Etikete
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


        public IzmenaEtiketa()
        {

            InitializeComponent();
            
            Etikete = cpf.procitajIzFileEtikete();
            url = "";
            this.DataContext = this;
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_loadImage_Click(object sender, RoutedEventArgs e)
        {
            Etiketa etiketa = (Etiketa)dgrMain.SelectedItem;
            if (etiketa != null)
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
            else
            {
                MessageBox.Show("Izaberite etiketu iz liste.");
            }
        }

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            string oznaka_etikete = txt_oznakaEtikete.Text;
            string Ime_etikete = txt_imeEtikete.Text;
            string Opis_etikete = txt_opisEtikete.Text;

            Etiketa etiketa = (Etiketa)dgrMain.SelectedItem;

            if (etiketa != null)
            {
                etiketa.Ime = Ime_etikete;
                etiketa.Opis = Opis_etikete;
                if (url != "")
                {
                    etiketa.IkonicaEtikete = url;
                }
                de.upisiEtiketuUFile(Etikete);
                url = "";
                MessageBox.Show("Etiketa uspesno izmenjena.");
            }
            else
            {
                MessageBox.Show("Izaberite etiketu iz liste.");
            }
        }

        private void btnObrisi_Click(object sender, RoutedEventArgs e)
        {
            string oznaka_etikete = txt_oznakaEtikete.Text;

            Etiketa etiketa = (Etiketa)dgrMain.SelectedItem;
            if (etiketa != null)
            {
                 etiketa.Obrisana = true;
                 de.upisiEtiketuUFile(Etikete);
                 Etikete.Clear();
                 Etikete = cpf.procitajIzFileEtikete();
                 OnPropertyChanged("PretrazeneEtikete");
                 MessageBox.Show("Etiketa je obrisana");
            }
            else
            {
                MessageBox.Show("Izaberite etiketu iz liste.");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
