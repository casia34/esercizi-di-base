using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetturaFile
{
    public class OpenFile
    {
        string M; // Nome
        string[] arra = new string[0];

        public bool FileEsiste(string m)
        {
            M = m;

            bool Variabile = File.Exists($@"{M}.txt");

            return Variabile;
        }

        public string openFile(string m )
        {
            M = m;
          
           string Variabile = File.ReadAllText($@"{M}.txt");

            return Variabile;
        }

       

        public void openFile()
        {
           
        }
    }
}
