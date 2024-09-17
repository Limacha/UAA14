using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act1_allumer_lampe
{
    internal class Interupteur
    {
        private string _code;
        private Lampe _lampe;

        public Interupteur(string code, Lampe lampe)
        {
            _code = code;
            _lampe = lampe;
        }

        public string GetCode()
        {
            return _code;
        }
        public string GetLampeCode()
        {
            return _lampe.GetCode();
        }
        public Lampe GetLampe()
        {
            return _lampe;
        }
        public void AllumerLampe()
        {
            _lampe.SetStatu(true);
        }
        public void EteindreLampe()
        {
            _lampe.SetStatu(false);
        }
    }
}