using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act12_BarCocktail
{
    public class Shaker
    {
        private int contentSize; //le contenu max du shaker
        private List<Liquide> liquides; //les liquides contenu
        private bool shaked; //si il est secouer ou pas
        private bool propre; //si il est propre ou pas

        public int ContentSize { get { return contentSize; } }
        public List<Liquide> Liquides { get { return liquides; } set { liquides = value; } }
        public bool Shaked { get { return shaked; } set { shaked = value; } }
        public bool Propre { get { return propre; } set { propre = value; } }

        /// <summary>
        /// cree un shaker
        /// </summary>
        /// <param name="contentSize">la taille du shaker</param>
        /// <param name="shaked">si il est secouer</param>
        /// <param name="propre">si il est propre</param>
        public Shaker(int contentSize, bool shaked, bool propre) 
        { 
            this.contentSize = contentSize;
            this.liquides = new List<Liquide>();
            this.shaked = shaked;
            this.propre = propre;
        }
        /// <summary>
        /// secoue le shaker
        /// </summary>
        public void Shake()
        {
            shaked = true;
        }
        /// <summary>
        /// lave le shaker
        /// </summary>
        public void Wash()
        {
            propre = true;
        }

        /// <summary>
        /// converti le shaker en string
        /// </summary>
        /// <returns>renvoit la convertion</returns>
        public override string ToString()
        {
            string shaker =  $"{contentSize}cl\n" +
                   $"propre: {propre}\n" +
                   $"shaked: {shaked}";
            foreach (Liquide liquide in liquides)
            {
                shaker += "\n" + liquide.ToString();
            }
            return shaker;
        }
    }
}
