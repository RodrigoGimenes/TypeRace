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
using TypeRace.NovaPasta;

namespace TypeRace
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Frases frase = new Frases();
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            frase.FraseGerada = frase.FraseAleatoria();
            FraseParaCopiar.Text = frase.FraseGerada;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        public void Finalizar_Click(object sender, RoutedEventArgs e)
        {
            if (frase.Correcao(frase.FraseGerada) == true)
            {
                Tempo.Text = "1";
                LetrasDigitadas.Text = frase.NumeroDeLetras().ToString();
                LPS.Text = "1";
            }
            else
            {
                Tempo.Text = "1";
                LetrasDigitadas.Text = "1";
                LPS.Text = "1";
            }
        }
    }
}
