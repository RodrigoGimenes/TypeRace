using System;
using System.Collections.Generic;
using System.Text;

namespace TypeRace.NovaPasta
{
    class Frases
    {
        public string Frase;
        private string[] lines = System.IO.File.ReadAllLines(@"C:\Users\User\source\repos\TypeRace\TypeRace\Frases.txt");
        public int NumeroDeLetras;

        public Boolean Correcao(string frase)
        {
            if (frase == Frase)
            {
                return true;
            } else
            return false;
        }
        public string FraseAleatoria()
        {
            Random rnd = new Random();
            int num = rnd.Next(0,lines.Length);
            return lines[num];
        }
    }
}
