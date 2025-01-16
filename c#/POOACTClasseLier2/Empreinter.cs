using POOActClasseLiees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOACTClasseLier2
{
    public class Empreinter
    {
        private string _id;
        private string _nom;
        private string _prenom;
        public string Id { get { return _id; } }
        public string Nom { get { return _nom; } }
        public string Prenom { get { return _prenom; } }

        public Empreinter(string id, string nom, string prenom)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
        }

        public void Info()
        {
            Console.WriteLine($"empreint id {_id} livre {_nom} date {_prenom}");
        }
    }
}
