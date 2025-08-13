using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Cizim
{
    internal class Dikdortgen : Sekil
    {
        public Dikdortgen() {

            Console.WriteLine("Derived class -> constructor");

        }

        public Dikdortgen(int genislik, int yukseklik, int x, int y) : base(genislik: -5, yukseklik:-5, x:-10, y:-10)
        {
            Console.WriteLine("Derived class -> ctor - 4p");
        }

        public override void Ciz() => Console.WriteLine($"Dikdortgen {Pozisyon} - {Boyut}");

        public override void tasi(Pozisyon yeniPozisyon)
        {
            Console.Write("Dikdörtgen ");
            base.tasi(yeniPozisyon);
        }

        public override void yenidenBoyutlandir(int genislik, int yukseklik)
        {
            Boyut.Genislik = genislik;
            Boyut.Yukseklik = yukseklik;
        }
    }
}
