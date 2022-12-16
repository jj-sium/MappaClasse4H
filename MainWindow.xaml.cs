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

using ghinelli.johan._4h.MappaClasse;
using ghinelli.johan._4h.MappaClasse.Models;

namespace ghinelli.johan._4h.MappaClasse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn10.Tag = new Utente { Name = "Maurizio", Inventario = "inv1234", Foto = "foto1.jpg" };
            btn11.Tag = new Utente { Name = "Giovanni", Inventario = "inv5678", Foto = "foto2.jpg" };
            btn12.Tag = new Utente { Name = "Daniele", Inventario = "inv91011", Foto = "foto3.jpg" };
        }
        private void Onclick(object sender, RoutedEventArgs e)
        {
            if (sender != null)
            {
                Button b = sender as Button;
                if (b != null)
                {
                    if 
                    {
                        Utente u = b.Tag as Utente;
                        MessageBox.Show($"hello {u.Name} {u.Inventario} {u.Foto}");
                    }
                   else
                    {
                        MessageBox.Show($"qui Tag era null...");
                    }
                }
            }
            else
            {
                MessageBox.Show($"qui sender era null...");
            }
        }
    }
}
