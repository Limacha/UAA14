using POOACTClasseLier2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOActClasseLiees
{
    public class Bibliotheque
    {
        private List<Livre> _contenu;
        private List<Empreint> _empreints;
        public List<Livre> Contenu { get { return _contenu; } }
        public List<Empreint> Empreints { get { return _empreints; } }

        public Bibliotheque()
        {
            _contenu = new List<Livre>();
            _empreints = new List<Empreint>();
        }

        public void Ajoute(Livre livre)
        {
            _contenu.Add(livre);
        }

        public void Supprimer_livre_abimes()
        {
            for (int i = 0; i < _contenu.Count(); i++)
            {
                Livre item = _contenu[i];
                item.Description();
                if (item.Etat < 1)
                {
                    _contenu.Remove(item);
                    Console.WriteLine(item.Titre);
                    i--;
                }
            }
        }

        public void Empreinter(string id, Livre livre, string date)
        {
            _empreints.Add(new Empreint(id, livre, date));
            _contenu.Remove(livre);
        }

        public void Rendre(Empreint empreint)
        {
            empreint.Livre.Degrade();
            _contenu.Add(empreint.Livre);
            _empreints.Remove(empreint);
        }

        public void Inventaire()
        {
            foreach (var item in _contenu)
            {
                item.Description();
            }
            foreach (var item in _empreints)
            {
                item.Info();
            }
        }
    }
}
