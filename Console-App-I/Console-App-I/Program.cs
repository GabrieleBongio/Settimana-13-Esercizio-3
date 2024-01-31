using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///// ///// ///// ///// Esercizio 2
            
            Conto conto = new Conto();
            bool cont = true;

            do
            {
                Console.WriteLine("Ciao, quale comando vuoi eseguire?");
                Console.WriteLine("1: Apri conto");
                Console.WriteLine("2: Versamento");
                Console.WriteLine("3: Prelievo");
                Console.WriteLine("4: Chiudi");
                int comando = Convert.ToInt16(Console.ReadLine());

                switch (comando)
                {
                    case 1:
                        Console.WriteLine("Quanto vuoi depositare?");
                        int deposito = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(conto.Apri(deposito));
                        break;
                    case 2:
                        Console.WriteLine("Quanto vuoi versare?");
                        int versamento = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(conto.Versamento(versamento));
                        break;
                    case 3:
                        Console.WriteLine("Quanto vuoi prelevare?");
                        int prelievo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(conto.Prelievo(prelievo));
                        break;
                    case 4:
                        cont = false;
                        break;
                    default:
                        Console.WriteLine("Comando non valido");
                        break;
                }
                Console.WriteLine("");

            } while (cont);

            ///// ///// ///// ///// Esercizio 2

            Console.WriteLine("Quanto sarà lungo l'array?");
            int lunghezza = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[lunghezza];

            for (int i = 0; i < lunghezza; i++)
            {
                Console.WriteLine($"Inserisci il {i + 1}° elemento");
                string nuovo = Console.ReadLine();
                array[i] = nuovo;
            }

            Console.WriteLine("");
            Console.WriteLine("");

            bool continuare = true;
            bool trovato = false;
            while (continuare)
            {
                Console.WriteLine("Inserire il nome da ricercare nell'array");
                string query = Console.ReadLine();
                foreach (string s in array)
                {
                    if (s == query)
                    {
                        trovato = true;
                    }
                }

                if (trovato)
                {
                    Console.WriteLine("Si, il nome è presente \n");
                }
                else
                {
                    Console.WriteLine("No, il nome non è presente \n");
                }

                Console.WriteLine("Vuoi cercare un altro nome? y/n");
                string scelta = Console.ReadLine();
                if (scelta == "n")
                {
                    continuare = false;
                }
            }

            ///// ///// ///// ///// Esercizio 3

            Console.WriteLine("Quanto sarà lungo l'array?");
            int lunghezzaE3 = Convert.ToInt32(Console.ReadLine());
            int[] arrayE3 = new int[lunghezza];

            for (int i = 0; i < lunghezza; i++)
            {
                Console.WriteLine($"Inserisci il {i + 1}° elemento");
                int nuovo = Convert.ToInt32(Console.ReadLine());
                arrayE3[i] = nuovo;
            }

            Console.WriteLine("");
            Console.WriteLine("");

            double Tot = 0;
            
            foreach (int i in arrayE3)
            {
                Tot += i;
            }

            Console.WriteLine("Somma totale: " + Tot);
            Console.WriteLine("Media: " + (Tot/lunghezza));

            Console.ReadLine();
        }
    }
}
