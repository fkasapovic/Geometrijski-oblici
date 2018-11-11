using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vj
{
    class Pravokutnik
    {
        private double Stranica1;
        private double Stranica2;
        private double povrsina;
        private double opseg;

        private void IzracunajPovrsinu()
        {
            povrsina = Stranica1 * Stranica2;
        }

        private void IzracunajOpseg()
        {
            opseg = 2 * (Stranica1 + Stranica2);
        }

        public void ZadajStranicu1(double Stranica1)
        {
            this.Stranica1 = Stranica1;
            IzracunajPovrsinu();
            IzracunajOpseg();
        }

        public void ZadajStranicu2(double Stranica2)
        {
            this.Stranica2 = Stranica2;
            IzracunajPovrsinu();
            IzracunajOpseg();
        }

        public string VratiOpis()
        {
            return string.Format("Pravokutnik ima: \na)Stranica a = {0}\nb)Stranica b = {0}\nc)Povrsinu = {2}\nd)Opseg:{3}", Stranica1, Stranica2, VratiPovrsinu(), VratiOpseg());
        }

        public double VratiPovrsinu()
        {
            return Stranica1 * Stranica2;
        }

        public double VratiOpseg()
        {
            return 2 * (Stranica1 + Stranica2);
        }
    }
}
