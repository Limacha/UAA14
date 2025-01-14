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
        private string _id;
        private Livre _livre;
        private string _date;
        public string Id { get { return _id; } }
        public Livre Livre { get { return _livre; } }
        public string Date { get { return _date; } }

        public Empreint(string id, Livre livre, string date)
        {
            _id = id;
            _livre = livre;
            _date = date;
        }

        public void Info()
        {
            Console.WriteLine($"empreint id {_id} livre {_livre.Titre} date {_date}");
        }
    }
}
