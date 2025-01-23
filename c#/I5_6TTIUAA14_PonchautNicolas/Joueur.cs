using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace I5_6TTIUAA14_PonchautNicolas
{
    internal class Joueur
    {
        private string _pseudo; //pseudo du joueur
        private byte _nbCartoucheEnPoche;//le nombre de cartouche dans sa poche
        private PaintBallGun _gun;//l'arme qu'il possede

        public string Pseudo { get { return _pseudo; } }
        public byte NbCartoucheEnPoche { get { return _nbCartoucheEnPoche; } set { _nbCartoucheEnPoche = value; } }
        public PaintBallGun Gun { get { return _gun; } set { _gun = value; } }

        public Joueur(string pseudo, byte nbCart, PaintBallGun gun) 
        {
            _pseudo = pseudo;
            _nbCartoucheEnPoche += nbCart;
            _gun = gun;
        }
        /// <summary>
        /// recharge l'arme
        /// </summary>
        /// <returns>comment le rechargement s'est fait</returns>
        public string Recharge()
        {
            if (_nbCartoucheEnPoche > 0)
            {
                if (_nbCartoucheEnPoche >= _gun.TailleChargeur)
                {
                    _gun.BallesChargeur = _gun.TailleChargeur;
                    _nbCartoucheEnPoche -= _gun.TailleChargeur;
                    return "=> Recharge de 16 balles dans le chargeur effectuée";
                }
                _gun.BallesChargeur = _nbCartoucheEnPoche;
                _nbCartoucheEnPoche -= _nbCartoucheEnPoche;
                return $"=> Recharge de {_gun.BallesChargeur} balles dans le chargeur effectuée";
            }
            return "A sec";
        }
        /// <summary>
        /// tir une ball
        /// </summary>
        /// <returns>si a tire true</returns>
        public bool Tirer()
        {
            if(_gun != null)
            {
                if (!_gun.ChargeurEstVide())
                {
                    _gun.BallesChargeur--;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// affiche le nombre de balle en poche
        /// </summary>
        /// <returns>nombre de balle</returns>
        public string VerifPoche()
        {
            return $"Vous avez un total de {_nbCartoucheEnPoche} cartouches dans votre poche et\n {_gun.BallesChargeur} balles dans le chargeur";
        }
    }
}
