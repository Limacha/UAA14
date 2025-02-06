using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAct11.classe
{
    public class Cours
    {
        private string _nom;
        private Salle _salle;
        private List<double> _listNotes = new List<double>();

        public Cours(string nom, Salle salle)
        {
            _nom = nom;
            _salle = salle;
        }

        public void AjouterNote(double note)
        {
            _listNotes.Add(note);
        }

        public double CalculerMoyenneCount()
        {
            double total = 0;
            foreach (double note in _listNotes)
            {
                total += note;
            }
            return total / _listNotes.Count;
        }
    }
}
