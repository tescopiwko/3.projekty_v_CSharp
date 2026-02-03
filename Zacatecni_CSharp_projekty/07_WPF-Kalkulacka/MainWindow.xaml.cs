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
using System.Xml;

namespace _07_WPF_Kalkulacka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double prvniCislo = 0;
        double druheCislo = 0;
        double vysledek = 0;
        string operace = "";

        bool aktivniDesetinnaCarka = false;
        bool cekaniNaDruheCislo = false;

        public MainWindow()
        {
            InitializeComponent();
            Display.Text += "0";
        }

        private void Cislice(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string cislicko = btn.Content.ToString();
            if (cekaniNaDruheCislo)
            {
                Display.Text = cislicko;
                cekaniNaDruheCislo = false;
                aktivniDesetinnaCarka = false;
            }

            else if (Display.Text == "0")
            {
                Display.Text = cislicko;
            }
            else
            {
                Display.Text += cislicko;
            }
                

        }

        private void Backspace(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (Display.Text.Length > 0)
            {
                Display.Text = Display.Text.Remove(Display.Text.Length - 1, 1);
            }
            if (Display.Text.Length <= 0)
            {
                Display.Text = "0";
            }
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Display.Text = "0";
        }

        private void desetinnaCarka(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string carka = btn.Content.ToString();
            if (aktivniDesetinnaCarka == false)
            {
                Display.Text += carka;
                aktivniDesetinnaCarka = true;
            } 
        }

        private void naDruhou(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            double aktualniCislo = Convert.ToDouble(Display.Text);
            double vysledek = aktualniCislo * aktualniCislo;
            string zpatkyNaString = Convert.ToString(vysledek);
            Display.Text = "";
            Display.Text += zpatkyNaString;
        }

        private void Negace(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            double aktualniCislo = Convert.ToDouble(Display.Text);
            double vysledek = aktualniCislo * -1;
            string zpatkyNaString = Convert.ToString(vysledek);
            Display.Text = "";
            Display.Text += zpatkyNaString;
        }

        private void Plus(object sender, RoutedEventArgs e)
        {
            prvniCislo = Convert.ToDouble(Display.Text);
            operace = "+";
            cekaniNaDruheCislo = true;
        }

        private void Minus(object sender, RoutedEventArgs e)
        {
            prvniCislo = Convert.ToDouble(Display.Text);
            operace = "-";
            Display.Text = "0";

        }

        private void Krat(object sender, RoutedEventArgs e)
        {

        }

        private void Deleno(object sender, RoutedEventArgs e)
        {

        }

        private void rovnaSe(object sender, RoutedEventArgs e)
        {
            druheCislo = Convert.ToDouble(Display.Text);
            if (operace == "-")
            {

                vysledek = prvniCislo - druheCislo;
            }
            
            if (operace == "+")
            {
                vysledek = prvniCislo + druheCislo;
            }
            Display.Text = vysledek.ToString();
        }
    }
}