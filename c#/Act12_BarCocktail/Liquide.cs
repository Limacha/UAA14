using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act12_BarCocktail
{
    public class Liquide
    {
        private string name; //le nom du liquide
        private float quantiter; //la quantiter qu'il y a

        public string Name { get { return name; } }
        public float Quantiter { get { return quantiter; } set { quantiter = value; } }

        /// <summary>
        /// cree un liquide
        /// </summary>
        /// <param name="name">le nom du liquide</param>
        /// <param name="quantiter">la quantiter</param>
        public Liquide(string name, float quantiter)
        {
            this.name = name;
            this.quantiter = quantiter;
        }

        /// <summary>
        /// cree un liquide
        /// </summary>
        /// <param name="liquide">le liquide a copier</param>
        public Liquide(Liquide liquide)
        {
            this.name = liquide.Name;
            this.quantiter = liquide.Quantiter;
        }

        /// <summary>
        /// cree un liquide
        /// </summary>
        /// <param name="liquide">le liquide a copier le nom</param>
        /// <param name="quantiter">la nouvelle quantiter</param>
        public Liquide(Liquide liquide, float quantiter)
        {
            this.name = liquide.Name;
            this.quantiter = quantiter;
        }

        /// <summary>
        /// converti le liquide en string
        /// </summary>
        /// <returns>renvoit la convertion</returns>
        public override string ToString()
        {
            string quant = ""; 
            if (quantiter != 0) 
            { 
                quant = quantiter.ToString(); 
            }
            return $"{name}: {quant}";
        }
    }
}
