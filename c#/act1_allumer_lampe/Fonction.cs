using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act1_allumer_lampe
{
    internal struct Fonction
    {
        public Lampe CreerLampe(string code, string color)
        {
            Lampe lampe = new Lampe(code, color);
            Console.WriteLine($"nouvelle lampe avec comme code{code} et qui produit une magnifique couleur{color}");
            return lampe;
        }

        public Interupteur CreerInterrupteur(string code, Lampe lampe)
        {
            Interupteur interupteur = new Interupteur(code, lampe);
            Console.WriteLine($"nouveau interupteur{interupteur}");
            return interupteur;
        }

        public Lampe SelectLampe(string code, List<Lampe> lampeList)
        {
            foreach (var lampe in lampeList)
            {
                
                if (lampe.GetCode() == code)
                {
                    return lampe;
                }
            }
            return null;
        }

        public Interupteur SelectInterupteur(string code, List<Interupteur> interuptList)
        {
            foreach (var interupt in interuptList)
            {

                if (interupt.GetCode() == code)
                {
                    return interupt;
                }
            }
            return null;
        }

        public void UtiliserInterrupteur(Interupteur interupt)
        {
            if (interupt.GetLampe().GetStatu())
            {
                interupt.EteindreLampe();
            }
            else
            {
                interupt.AllumerLampe();
            }
        }
    }
}