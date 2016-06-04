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
using System.Windows.Navigation;
using System.Windows.Shapes;

using MapaLokala.Dodaj_lokal;
using MapaLokala.Dodaj_tip_lokala;
using MapaLokala.Dodaj_Etiketu;
using System.Collections.ObjectModel;

namespace MapaLokala
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
                }
            }
        }
        
        public MainWindow()
        {
            InitializeComponent();
            Image = new BitmapImage(new Uri("Slike/mapa.jpg", UriKind.Relative));
            img_mapa.Source = Image;
            CitanjePisanjeuFile cpf = new CitanjePisanjeuFile();
            cpf.procitajIzFileEtikete();
            cpf.procitajIzFileTipoveLokala();
            cpf.procitajIzFileLokale();
            
            this.DataContext = this;
        }

        private void DodajLokal_click(object sender, RoutedEventArgs e)
        {
            var s = new DodajLokal();
            s.Show();
        }

        private void DodajTipLokala_click(object sender, RoutedEventArgs e)
        {
            var s = new DodajTipLokala();
            s.Show();
        }

        private void DodajEtiketu_click(object sender, RoutedEventArgs e)
        {
            var s = new DodajEtiketu();
            s.Show();
        }

        private void IzmeniEtiketu_click(object sender, RoutedEventArgs e)
        {
            var s = new IzmenaEtiketa();
            s.Show();
        }
    }
}
