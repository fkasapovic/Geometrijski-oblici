using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vj
{
    class Trokut
    {
        private double Stranica1;
        private double Stranica2;
        private double Stranica3;
        private double Visina;
        private double povrsina;
        private double opseg;

        private void IzracunajPovrsinu()
        {
            povrsina = (Stranica1 * Visina)/2;
        }

        private void IzracunajOpseg()
        {
            opseg = Stranica1 + Stranica2 + Stranica3;
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
            IzracunajOpseg();
        }

        public void ZadajStranicu3(double Stranica3)
        {
            this.Stranica3 = Stranica3;
            IzracunajOpseg();
        }

        public void ZadajVisinu(double Visina)
        {
            this.Visina = Visina;
            IzracunajPovrsinu();
            
        }

        public string VratiOpis()
        {
            return string.Format("Trokut ima: \na)Stranica a = {0}\nb)Stranica b = {1}\nc)Stranica c = {2}\nd)Visina = {3}\ne)Povrsinu = {4}\nf)Opseg:{5}", Stranica1, Stranica2,Stranica3, Visina, VratiPovrsinu(), VratiOpseg());
        }

        public double VratiPovrsinu()
        {
            return (Stranica1 * Visina) / 2;
        }

        public double VratiOpseg()
        {
            return Stranica1 + Stranica2 + Stranica3;
        }
    }
}
