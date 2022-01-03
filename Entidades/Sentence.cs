using System;
using System.Collections.Generic;
using System.Text;

namespace TypeRace.Entidades
{
    class Sentence
    {
        public string GeneratedSentence;
        public string TypedSentence;
        private string[] lines = System.IO.File.ReadAllLines(@"C:\Users\User\source\repos\TypeRace\TypeRace\Frases.txt");
        
        public Boolean SentenceCorrection(string frase)
        {
            if (frase == GeneratedSentence)
            {
                return true;
            } else
            return false;
        }
        public string RandomSentence()
        {
            Random rnd = new Random();
            int num = rnd.Next(0,lines.Length);
            return lines[num];
        }

        public int LettersCount()
        {
            return GeneratedSentence.Length;
        }

    }
}
