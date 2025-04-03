using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act12_BarCocktail
{
    public class Bar
    {
        private string name; //les bouteilles du bar
        private List<Bouteille> bouteilles; //les bouteilles du bar
        private List<Shaker> shakers; //les shaker du bar
        private Menu menu; //le menu du bar

        public string Name { get { return name; } }
        public List<Bouteille> Bouteilles { get { return bouteilles; } }
        public List<Shaker> Shakers { get { return shakers; } }
        public Menu Menu { get { return menu; } }

        /// <summary>
        /// creez un bar
        /// </summary>
        /// <param name="bouteilles">les bouteilles dans le bar</param>
        /// <param name="shakers">les shakers du bar</param>
        /// <param name="menu">le menu du bar</param>
        public Bar(string name, List<Bouteille> bouteilles, List<Shaker> shakers, Menu menu)
        {
            this.name = name;
            this.bouteilles = bouteilles;
            this.shakers = shakers;
            this.menu = menu;
        }

        /// <summary>
        /// restock toute les bouteilles possibles
        /// </summary>
        /// <param name="cave">la cave ou sont les stock</param>
        /// <returns>si le restock global a peut etre fait</returns>
        public bool RestockGlobal(Cave cave)
        {
            bool restock = false;
            foreach (Bouteille bouteille in bouteilles)
            {
                if(bouteille.Liquide.Quantiter < bouteille.MaxQuantiter)
                {
                    restock = restock && Restock(cave, bouteille);
                }
            }
            return restock;
        }

        /// <summary>
        /// remplit une bouteille
        /// </summary>
        /// <param name="cave">la cave ou trouver le stock</param>
        /// <param name="bouteille">la bouteille a remplir</param>
        /// <returns>vrai si la bouteille est remplit</returns>
        private bool Restock(Cave cave, Bouteille bouteille)
        {
            if (bouteille != null)
            {
                if (cave != null)
                {
                    if (cave.Liquides.Contains(bouteille.Liquide))
                    {
                        Liquide? liq = cave.Liquides.FirstOrDefault(l => l.Name == bouteille.Liquide.Name);
                        if (liq != null)
                        {
                            if (liq.Quantiter >= bouteille.MaxQuantiter - bouteille.Liquide.Quantiter)
                            {
                                liq.Quantiter -= bouteille.MaxQuantiter - bouteille.Liquide.Quantiter;
                                bouteille.Liquide.Quantiter = bouteille.MaxQuantiter;
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// change le menu
        /// </summary>
        /// <param name="menu">le nouveau menu</param>
        public void ChangerMenu(Menu menu)
        {
            this.menu = menu;
        }

        /// <summary>
        /// converti le bar en string
        /// </summary>
        /// <returns>renvoit la convertion</returns>
        public override string ToString()
        {
            string bar = $"{name}:\n" +
                $"\nBouteilles:";
            foreach (Bouteille bouteille in bouteilles)
            {
                bar += "\n" + bouteille.ToString();
            }
            bar += "\n\nshakers:";
            foreach (Shaker shaker in shakers)
            {
                bar += "\n" + shaker.ToString();
            }
            bar += "\n";
            bar += "\n" + menu.ToString();
            return bar;
        }
    }
}
