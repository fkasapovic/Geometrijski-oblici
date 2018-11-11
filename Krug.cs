using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vj
{
     class Krug
    {
        private double polumjer;
        private double pi = 3.14;
        private double povrsina;
        private double opseg;

        private void IzracunajPovrsinu()
        {
            povrsina = pi * Math.Pow(polumjer, 2);
        }

        private void IzracunajOpseg()
        {
            opseg = 2 * pi * polumjer;
        }

        public void ZadajPolumjer(double polumjer)
        {
            this.polumjer = polumjer;
            IzracunajPovrsinu();
            IzracunajOpseg();
        }

        public string VratiOpis()
        {
            return string.Format("Krug ima: \na)Polumjer = {0}\nb)Povrsinu = {1}\nc)Opseg:{2}", polumjer, VratiPovrsinu(), VratiOpseg());
        }

        public double VratiPovrsinu()
        {
            return pi * Math.Pow(polumjer, 2);
        }

        public double VratiOpseg()
        {
            return 2 * pi * polumjer;
        }
    }
}
