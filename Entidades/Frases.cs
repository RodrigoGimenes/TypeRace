using System;
using System.Collections.Generic;
using System.Text;

namespace TypeRace.NovaPasta
{
    class Frases
    {
        public string FraseGerada;
        private string[] lines = System.IO.File.ReadAllLines(@"C:\Users\User\source\repos\TypeRace\TypeRace\Frases.txt");
        
        public Boolean Correcao(string frase)
        {
            if (frase == FraseGerada)
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

        public int NumeroDeLetras()
        {
            return FraseGerada.Length;
        }

    }
}
