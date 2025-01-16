using POOActClasseLiees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOACTClasseLier2
{
    public class Empreint
    {
        private Empreinter _empreinter;
        private Livre _livre;
        private string _date;
        public Empreinter Empreinteur { get { return _empreinter; } }
        public Livre Livre { get { return _livre; } }
        public string Date { get { return _date; } }

        public Empreint(Empreinter empreinteur, Livre livre, string date)
        {
            _empreinter = empreinteur;
            _livre = livre;
            _date = date;
        }

        public void Info()
        {
            Console.WriteLine($"empreint id {_empreinter.Nom} livre {_livre.Titre} date {_date}");
        }
    }
}
