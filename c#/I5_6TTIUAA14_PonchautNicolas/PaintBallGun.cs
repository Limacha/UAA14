using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I5_6TTIUAA14_PonchautNicolas
{
    internal class PaintBallGun
    {
        private byte _nbBallesChargeur;//nombre de balle dans le chargeur
        private byte _tailleChargeur;//taille max du chargeur

        public byte BallesChargeur { get { return _nbBallesChargeur; } set { _nbBallesChargeur = value; } }
        public byte TailleChargeur { get { return _tailleChargeur; } }

        public PaintBallGun(byte taille) 
        {
            _tailleChargeur = taille;
        }

        /// <summary>
        /// si le chargeur est vide
        /// </summary>
        /// <returns>si vide true</returns>
        public bool ChargeurEstVide()
        {
            return _nbBallesChargeur <= 0 ;
        }
    }
}
