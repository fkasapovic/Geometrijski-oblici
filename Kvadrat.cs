using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vj
{
    class Kvadrat
    {
        private double Stranica;
        private double povrsina;
        private double opseg;

        private void IzracunajPovrsinu()
        {
            povrsina = Math.Pow(Stranica, 2);
        }

        private void IzracunajOpseg()
        {
            opseg = 4 * Stranica;
        }

        public void ZadajStranicu(double Stranica)
        {
            this.Stranica = Stranica;
            IzracunajPovrsinu();
            IzracunajOpseg();
        }

        public string VratiOpis()
        {
            return string.Format("Kvadrat ima: \na)Stranica = {0}\nb)Povrsinu = {1}\nc)Opseg:{2}", Stranica, VratiPovrsinu(), VratiOpseg());
        }

        public double VratiPovrsinu()
        {
            return Math.Pow(Stranica, 2);
        }

        public double VratiOpseg()
        {
            return 4 * Stranica;
        }
    }
}
