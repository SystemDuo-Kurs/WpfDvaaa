using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDvaaa
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Radnik();
        }

        private void MisUpao(object sender, MouseEventArgs e)
        {
            dugme.Content = "BUUUUUU";
        }

        private void MisOtisao(object sender, MouseEventArgs e)
        {
            dugme.Content = "Unos";
        }

        private void Unos(object sender, RoutedEventArgs e)
        {
            // Radnik.Ime = ImeTesktboks.Text;
            //Radnik.Prezime = PrezimeTekstboks.Text;
        }

        private void Prikaz(object sender, RoutedEventArgs e)
        {
            //ImeLabela.Content = Radnik.Ime;
            //PrezimeLabela.Content = Radnik.Prezime;
        }
    }
}