using System.Reflection.PortableExecutable;

namespace LetturaFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region primo

            /*  OpenFile Utilizzo_Metodo = new OpenFile();
              Console.WriteLine("srvivi il nome del file");
              string stamp = Console.ReadLine();
              bool flag = true;
              bool flag1 = true;
              try
              {
                  do
                  {
                      if (Utilizzo_Metodo.FileEsiste($@"C:\Users\Betacom\Desktop\{stamp}"))
                      {
                          string stampa = Utilizzo_Metodo.openFile($@"C:\Users\Betacom\Desktop\{stamp}");
                          Console.WriteLine(stampa);

                          Console.WriteLine("il file è stato trovao ed aperto, ne vuoi aprire un'altro? (S/N)");
                          while (flag1)
                          {
                              string risp = Console.ReadLine();
                              if (risp == "N")
                              {
                                  flag = false;
                                  break;
                              }
                              else if (risp == "S")
                              {
                                  Console.WriteLine("Scrivi un'altro nome file");
                                  stamp = Console.ReadLine();
                                  break;
                              }
                              else
                              {
                                  Console.WriteLine(" comando non valido");
                                  stamp = Console.ReadLine();
                                  break;
                              }
                          }
                      }
                      else
                      {
                          Console.WriteLine("Il file non è stato Trovato, scrivi Nuovamente il nome");
                          stamp = Console.ReadLine();
                          throw new Exception(" l'utente non riesce a trovare il file:"+ stamp);
                      }
                  } while (flag != null);
              }
              catch (Exception Ex)
              {
                  Console.WriteLine(Ex.Message);
                  throw;
              }
               */
            #endregion

            Split_Document split_Document = new Split_Document();

            split_Document.Document("Cars.txt");
        }
    }
}