using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Cizim
{
    internal class Elips : Sekil
    {
        public override void tasi(Pozisyon yeniPozisyon)
        {
            Console.Write("Elips ");
            base.tasi(yeniPozisyon);
        }

        public override void yenidenBoyutlandir(int genislik, int yukseklik)
        {
            Boyut.Genislik = genislik;
            Boyut.Yukseklik = yukseklik;
        }
    }
}
