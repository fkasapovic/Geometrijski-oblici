using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vj
{
    class Program
    {
        static void Main(string[] args)
        {
            Krug k1;
            k1 = new Krug();
            k1.ZadajPolumjer(5);
            Console.WriteLine(k1.VratiOpis());
            Console.ReadLine();

            Kvadrat kv1;
            kv1 = new Kvadrat();
            kv1.ZadajStranicu(5);
            Console.WriteLine(kv1.VratiOpis());
            Console.ReadLine();

            Pravokutnik p1;
            p1 = new Pravokutnik();
            p1.ZadajStranicu1(5);
            p1.ZadajStranicu2(10);
            Console.WriteLine(p1.VratiOpis());
            Console.ReadLine();

            Trokut t1;
            t1 = new Trokut();
            t1.ZadajStranicu1(5);
            t1.ZadajStranicu2(6);
            t1.ZadajStranicu3(7);
            t1.ZadajVisinu(8);
            Console.WriteLine(t1.VratiOpis());
            Console.ReadLine();
        }
    }
}
