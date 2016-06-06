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
using System.ComponentModel;

namespace MapaLokala
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Point startPoint = new Point();
        private CitanjePisanjeuFile cpf = new CitanjePisanjeuFile();
        DodajLokal dl = new DodajLokal();
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

        public ObservableCollection<Lokal> lokali
        {
            get;
            set;
        }
        
        public ObservableCollection<Lokal> listaLokalaNaMapi = new ObservableCollection<Lokal>();

        public void razvrstajLokale()
        {
            listaLokalaNaMapi.Clear();
            foreach (Lokal lokal in lokali)
            {
                
                if (lokal.NaMapi == true && lokal.Obrisan == false)
                {
                    listaLokalaNaMapi.Add(lokal);
                }
            }
        }
        
        public MainWindow()
        {
            InitializeComponent();
            Image = new BitmapImage(new Uri("Slike/mapa.jpg", UriKind.Relative));
            cpf.procitajIzFileEtikete();
            cpf.procitajIzFileTipoveLokala();
            lokali = cpf.procitajIzFileLokale();
            razvrstajLokale();
            izbaciLokaleSaMape();
            ispisiLokaleNaMapi();
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

        private void IzmeniTipLokala_click(object sender, RoutedEventArgs e)
        {
            var s = new IzmenaTipovaLokala();
            s.Show();
        }

        private void IzmeniLokal_click(object sender, RoutedEventArgs e)
        {
            var s = new IzmenaLokala();
            s.Show();
        }

        private void ListView_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Store the mouse position
            startPoint = e.GetPosition(null);
        }

        private Point mousePos;
        private void ListView_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the current mouse position
            mousePos = e.GetPosition(this);
            Vector diff = startPoint - mousePos;

            if (e.LeftButton == MouseButtonState.Pressed &&
                (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            {
                // Get the dragged ListViewItem
                ListView listView = sender as ListView;
                ListViewItem listViewItem =
                    FindAncestor<ListViewItem>((DependencyObject)e.OriginalSource);

                // Find the data behind the ListViewItem
                Lokal lokal = (Lokal)listView.ItemContainerGenerator.
                    ItemFromContainer(listViewItem);

                // Initialize the drag & drop operation
                DataObject dragData = new DataObject("myFormat", lokal);
                DragDrop.DoDragDrop(listViewItem, dragData, DragDropEffects.Move);
            }
        }

        private static T FindAncestor<T>(DependencyObject current) where T : DependencyObject
        {
            do
            {
                if (current is T)
                {
                    return (T)current;
                }
                current = VisualTreeHelper.GetParent(current);
            }
            while (current != null);
            return null;
        }

        private void ListView_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent("myFormat") ||
                sender == e.Source)
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void ListView_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("myFormat"))
            {
                Lokal lokal = e.Data.GetData("myFormat") as Lokal;

                Point p = e.GetPosition(img_mapa);
                ImageSource imageSource = new BitmapImage(new Uri(lokal.Ikona, UriKind.Absolute));
                if (imageSource != null)
                {
                    Image img = new Image();
                    img.Height = 50;
                    img.Width = 50;
                    img.Source = imageSource;
                    img.SetValue(Canvas.LeftProperty, p.X);
                    img.SetValue(Canvas.TopProperty, p.Y);
                    img_mapa.Children.Add(img);

                    lokal.NaMapi = true;
                    lokal.X = p.X;
                    lokal.Y = p.Y;
                    foreach (Lokal l in listaLokalaNaMapi) {
                        lokali.Add(l);
                    }
                    dl.upisiLokalUFile(lokali);
                    razvrstajLokale();
                    izbaciLokaleSaMape();
                }

                
            }
        }

        //Izbacujemo lokale koji su na mapi iz liste lokala koji se prikazuju
        private void izbaciLokaleSaMape() {
            foreach (Lokal l in listaLokalaNaMapi) {
                lokali.Remove(l);
            }
        }

        private void ispisiLokaleNaMapi() {
            img_mapa.Children.Clear();
            foreach (Lokal l in listaLokalaNaMapi) {
                ImageSource imageSource = new BitmapImage(new Uri(l.Ikona, UriKind.Absolute));
                if (imageSource != null)
                {
                    Image img = new Image();
                    img.Height = 50;
                    img.Width = 50;
                    img.Source = imageSource;
                    img.SetValue(Canvas.LeftProperty, l.X);
                    img.SetValue(Canvas.TopProperty, l.Y);
                    img_mapa.Children.Add(img);

                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            lokali.Clear();
            lokali = cpf.procitajIzFileLokale();
            razvrstajLokale();
            ispisiLokaleNaMapi();
            izbaciLokaleSaMape();
        }
    }
}
