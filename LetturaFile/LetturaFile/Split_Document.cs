using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetturaFile
{
    public class Split_Document
    {
        string Stamp = "";
        public void Equals()
        {

        }
        public void Document(string stamp)
        {
            Stamp = stamp;

            try
            {
                Console.WriteLine($"{Stamp}.txt");

                if (File.Exists($@"C:\Users\Betacom\Desktop\{Stamp}.txt"))
                {
                    Console.WriteLine(" il file è stato trovato: il contenuto del file é:\n");
                    string[] macchina = File.ReadAllLines($@"C:\Users\Betacom\Desktop\{stamp}.txt");
                    string[] car = new string[2];


                    foreach (string dati_array in macchina)
                    {

                        int j = 1;
                        car = dati_array.Split(":");

                        
                        foreach (string car_macchina in car)
                        {
                            if (j == 1)
                            {
                                Console.WriteLine(" Marca " + car_macchina + "\n");
                                j++;
                            }
                            else if (j == 2)
                            {
                                Console.WriteLine(" Modello " + car_macchina + "\n");
                                j++;
                            }
                            else if (j == 3)
                            {
                                Console.WriteLine(" Cilindrata " + car_macchina + "\n");
                                j = 0;
                            }

                        }

                        Console.WriteLine("vuoi Cercare un nuovo File?");

                    }

                }
                else if (File.Exists($@"C:\Users\Betacom\Desktop\{Stamp}"))
                {
                    Console.WriteLine(" il file è stato trovato: il contenuto del file é:\n");
                    string[] macchina = File.ReadAllLines($@"C:\Users\Betacom\Desktop\{stamp}");
                    string[] car = new string[2];


                    foreach (string dati_array in macchina)
                    {

                        int j = 1;
                        car = dati_array.Split(":");

                        Console.WriteLine(j);
                        foreach (string car_macchina in car)
                        {
                            if (j == 1)
                            {
                                Console.WriteLine(" Marca " + car_macchina + "\n");
                                j++;
                            }
                            else if (j == 2)
                            {
                                Console.WriteLine(" Modello " + car_macchina + "\n");
                                j++;
                            }
                            else if (j == 3)
                            {
                                Console.WriteLine(" Cilindrata " + car_macchina + "\n");
                                j = 0;
                            }

                        }

                    }

                }
                else
                {
                    Console.WriteLine("il file non è stato trovato controlla l'estensione o il nome");
                    throw new Exception("l'utente non riesce a trovare il file");
                }


            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);

            }
        }

       
    }
}
