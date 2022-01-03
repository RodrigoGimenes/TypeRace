using System;
using System.Windows;
using TypeRace.Entidades;
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
        Sentence sentence = new Sentence();
        DateTime start;
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            start = DateTime.Now;
            Failed.Content = "";
            sentence.GeneratedSentence = sentence.RandomSentence(); 
            SentenceToCopy.Text = sentence.GeneratedSentence;
        }

        public void Finalizar_Click(object sender, RoutedEventArgs e)
        {
            DateTime end = DateTime.Now;
            TimeSpan totalTime = (end - start);
            sentence.TypedSentence = TypedSentence.Text;
            if (sentence.SentenceCorrection(sentence.TypedSentence) == true)
            {
                Time.Text = "Tempo: " + totalTime.TotalSeconds.ToString("F2") + " segundos";
                TypedLetters.Text = "Letras Digitadas: " + sentence.LettersCount().ToString();
                LPS.Text = "Letras por segundo: " + (sentence.LettersCount()/totalTime.TotalSeconds).ToString("F2");
            }
            else
            {
                Failed.Content = "A frase está incorreta! Tente novamente";
            }
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
