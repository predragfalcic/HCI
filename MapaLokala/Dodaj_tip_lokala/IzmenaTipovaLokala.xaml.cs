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

namespace MapaLokala.Dodaj_tip_lokala
{
    /// <summary>
    /// Interaction logic for IzmenaTipovaLokala.xaml
    /// </summary>
    public partial class IzmenaTipovaLokala : Window, INotifyPropertyChanged
    {
        CitanjePisanjeuFile cpf = new CitanjePisanjeuFile();
        DodajTipLokala de = new DodajTipLokala();
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
                    OnPropertyChanged("PretrazeniTipoviLokala");
                }
            }
        }

        public ObservableCollection<TipLokala> TipoviLokala
        {
            get;
            set;
        }

        public IEnumerable<TipLokala> PretrazeniTipoviLokala
        {
            get
            {
                if (SearchText == null) return TipoviLokala;

                return TipoviLokala.Where(x => x.Ime.ToUpper().StartsWith(SearchText.ToUpper()));
            }
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

        public IzmenaTipovaLokala()
        {

            InitializeComponent();

            TipoviLokala = cpf.procitajIzFileTipoveLokala();
            url = "";
            this.DataContext = this;
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_loadImage_Click(object sender, RoutedEventArgs e)
        {
            TipLokala tipLokala = (TipLokala)dgrMain.SelectedItem;
            if (tipLokala != null)
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
            else
            {
                MessageBox.Show("Izaberite tip iz liste.");
            }
        }

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            string Ime_tipa = txt_imeTipaLokala.Text;
            string Opis_tipa = txt_opisTipaLokala.Text;

            TipLokala tipLokala = (TipLokala)dgrMain.SelectedItem;

            if (tipLokala != null)
            {
                tipLokala.Ime = Ime_tipa;
                tipLokala.Opis = Opis_tipa;
                if (url != "")
                {
                    tipLokala.IkonaTipaLokala = url;
                }
                de.upisiTipLokalaUFile(TipoviLokala);
                url = "";
                MessageBox.Show("Tip uspesno izmenjen.");
            }
            else
            {
                MessageBox.Show("Izaberite Tip iz liste.");
            }
        }

        private void btnObrisi_Click(object sender, RoutedEventArgs e)
        {

            TipLokala tipLokala = (TipLokala)dgrMain.SelectedItem;

            if (tipLokala != null)
            {
                 tipLokala.Obrisan = true;
                 de.upisiTipLokalaUFile(TipoviLokala);
                 TipoviLokala.Clear();
                 TipoviLokala = cpf.procitajIzFileTipoveLokala();
                 OnPropertyChanged("PretrazeniTipoviLokala");
                 MessageBox.Show("Tip je obrisan");
            }
            else
            {
                MessageBox.Show("Izaberite Tip iz liste.");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
