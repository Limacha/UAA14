using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act1_Lampe_v2
{
    internal class Interupteur
    {
        private string _code;
        private Lampe _lampe;

        public string Code { get { return _code; } }
        public Lampe Lampe { get { return _lampe; } }

        public Interupteur(string code, Lampe lampe)
        {
            _code = code;
            _lampe = lampe;
        }

        public string GetLampeCode()
        {
            return _lampe.Code;
        }
        public void AllumerLampe()
        {
            _lampe.Allumer = true;
        }
        public void EteindreLampe()
        {
            _lampe.Allumer = false;
        }
    }
}