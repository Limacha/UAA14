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
        public List<Livre> Contenu { get { return _contenu; } }

        public Bibliotheque()
        {
            _contenu = new List<Livre>();
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

        public void Inventaire()
        {
            foreach (var item in _contenu)
            {
                item.Description();
            }
        }
    }
}
