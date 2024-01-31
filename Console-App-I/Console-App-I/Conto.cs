using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_I
{
    internal class Conto
    {
        public string Name {  get; set; }

        private int Total { get; set; }

        private bool Open { get; set; }

        public Conto() { }

        public Conto(string name) { Name = name; }

        public string Apri(int versamento)
        {
            if (!Open && versamento > 1000) 
            { 
                Open = true;
                Total = versamento;
                return $"Conto aperto correttamente, saldo iniziale di {Total}";
            }
            else if (Open)
            {
                return "il conto è già aperto, per fare un versamento usare il metodo Versamento";
            }
            else if (versamento < 1000)
            {
                return "Per aprire il conto il deposito iniziale deve essere di almeno 1000";
            }
            else
            {
                return "";
            }
        }

        public string Versamento(int versamento)
        {
            if (Open && versamento > 0) {
                Total += versamento;
                return $"Versamento effettuato correttamente, saldo attuale di {Total}";
            } 
            else if (!Open)
            {
                return "Il conto non è aperto, per aprire il conto usare il comando Apri";
            }
            else if (versamento < 0)
            {
                return "Non puoi versare un valore di soldi negativo, se vuoi prelevare usa il comando Preleva";
            }
            else
            {
                return "";
            }
        }

        public string Prelievo(int prelievo)
        {
            if (Open && prelievo > 0 && prelievo < Total)
            {
                Total -= prelievo;
                return $"prelievo effettuato correttamente, saldo attuale di {Total}";
            }
            else if (!Open) 
            {
                return "Il conto non è aperto, per aprire il conto usare il comendo Apri";
            }
            else if (prelievo < 0)
            {
                return "Non puoi prelevare un valore di soldi negativo, se vuoi caricare soldi usa il comando Versamento";
            }
            else if (prelievo > Total)
            {
                return "Sul tuo conto non ci sono abbstanza soldi, per fare il versamento usare il comando Versamento";
            }
            else
            {
                return "";
            }
        }

    }
}
