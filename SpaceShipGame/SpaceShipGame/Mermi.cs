using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpaceShipGame
{
    class Mermi
    {
        Point konum;
        int hiz;
        int hasarGucu;
        string mermiResmi;

        public Mermi(Point _konum, int _hiz, int _hasarGucu, string _mermiResmi)
        {
            this.konum = _konum;
            this.hiz = _hiz;
            this.hasarGucu = _hasarGucu;
            this.mermiResmi = _mermiResmi;
        }

        void hareketEt()
        {
            int mermiX = this.konum.X;
            int mermiY = this.konum.Y;
            // Mermi Y ekseninde hiz kadar ilerleyecek
            mermiY -= hiz;
            this.konum = new Point(mermiX, mermiY);

        }

        void hizArttir(int miktar)
        {
            this.hiz += miktar;
        }
    }
}
