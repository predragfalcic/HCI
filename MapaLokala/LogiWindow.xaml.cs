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

namespace MapaLokala
{
    /// <summary>
    /// Interaction logic for LogiWindow.xaml
    /// </summary>
    public partial class LogiWindow : Window
    {
        ObservableCollection<Korisnik> korisnici = new ObservableCollection<Korisnik>();
        CitanjePisanjeuFile mw = new CitanjePisanjeuFile();

        public LogiWindow()
        {
            korisnici = mw.procitajIzFileKorisnike();
            InitializeComponent();
        }

        private void btnPrijavi_Click(object sender, RoutedEventArgs e)
        {
            string korIme = txt_username.Text;

            string lozinka1 = txt_lozinka.Password;
            Korisnik k = new Korisnik();
            k = nadjiKorisnika(korIme, lozinka1);
            if (lozinka1.Length > 0 && korIme.Length > 0)
            {
                if (k != null)
                {
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    this.Close();  
                }
                else
                {
                    MessageBox.Show("Korisnicko ime i lozinka su pogresni. Pokusajte ponovo. ");
                }
                    
                
            }
            else {
                MessageBox.Show("Sva polja moraju biti popunjena. ");
            }
        }


        private Korisnik nadjiKorisnika(string korIme, string lozinka) {
            Korisnik korisnik = new Korisnik();
            korisnik = null;
            foreach (Korisnik k in korisnici)
            {
                if (k.KorIme.Equals(korIme) && k.Lozinka1.Equals(lozinka))
                {
                    korisnik = k;
                    break;
                }
            }
            return korisnik;
        
        }

        private Korisnik nadjiKorisnikaKorIme(string korIme)
        {
            Korisnik korisnik = new Korisnik();
            korisnik = null;
            foreach (Korisnik k in korisnici)
            {
                if (k.KorIme.Equals(korIme))
                {
                    korisnik = k;
                }
            }
            return korisnik;

        }

        private void btnRegistruj_Click(object sender, RoutedEventArgs e)
        {
            string korIme = txt_username_reg.Text;

            Korisnik k = new Korisnik();
            k = nadjiKorisnikaKorIme(korIme);
            string lozinka1 = txt_lozinka_reg.Password;
            string lozinka2 = txt_lozinka_reg_ponovo.Password;

            if (k == null)
            {
                if (lozinka1.Length > 0 && lozinka2.Length > 0 && korIme.Length > 0)
                {
                    if (lozinka1.Equals(lozinka2))
                    {
                        Korisnik kor = new Korisnik(korIme, lozinka1);
                        korisnici.Add(kor);
                        mw.upisiKorisnika(korisnici);
                        MessageBox.Show("Uspesno ste registrovani");
                    }
                    else
                    {
                        MessageBox.Show("Lozinke se razlikuju. Moraju biti iste. ");
                    }
                }
                else
                {
                    MessageBox.Show("Sva polja moraju biti popunjena. ");
                }
            }
            else {
                MessageBox.Show("Korisnik sa tim korisnickim imenom vec postoji. ");
            }
        }
    }
}
