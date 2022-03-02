using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim__2_Zincirleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Kopek k1 = new Kopek();
            Console.ReadLine();
        }
    }
    class Canli
    {
        public Canli()
        {
            Console.WriteLine("Canli Sınıfı Çalıştı");
        }
    }
    class Hayvan:Canli
    {
        public Hayvan()
        {
            Console.WriteLine("Hayvan Sınıfı Çalıştı");
        }
    }
    class Kurt:Hayvan
    {
        public Kurt()
        {
            Console.WriteLine("Kurt Sınıfı Çalıştı");
        }
    }
    class Kopek:Kurt
    {
        public Kopek()
        {
            Console.WriteLine("Köpek Sınıfı Çalıştı");
        }
    }
}
