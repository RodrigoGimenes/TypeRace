using System;
using System.Windows;
using TypeRace.NovaPasta;
using System.Globalization;

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
        DateTime start;
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            start = DateTime.Now;
            Falha.Content = "";
            frase.FraseGerada = frase.FraseAleatoria(); 
            FraseParaCopiar.Text = frase.FraseGerada;
        }

        public void Finalizar_Click(object sender, RoutedEventArgs e)
        {
            DateTime end = DateTime.Now;
            TimeSpan tempoTotal = (end - start);
            frase.FraseDigitada = FraseDigitada.Text;
            if (frase.Correcao(frase.FraseDigitada) == true)
            {
                Tempo.Text = "Tempo: " + tempoTotal.TotalSeconds.ToString("F2") + " segundos";
                LetrasDigitadas.Text = "Letras Digitadas: " + frase.NumeroDeLetras().ToString();
                LPS.Text = "Letras por segundo: " + (frase.NumeroDeLetras()/tempoTotal.TotalSeconds).ToString("F2");
            }
            else
            {
                Falha.Content = "A frase está incorreta! Tente novamente";
            }
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
