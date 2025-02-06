using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAct11.classe
{
    public abstract class Personne
    {
        private string _nom;
        private string _prenom;
        private string _email;
        private string _telephone;

        public string Info()
        {
            return $"nom:{_nom}, prenom:{_prenom}, email:{_email}, tel:{_telephone}";
        }
    }
}
