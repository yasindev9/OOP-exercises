using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Modelleme
{
    public class Arac : Tasit // single inheritance
    {
        #region Fields değişkenleri
        private string marka, model, renk;
        private int yil;
        #endregion

        #region Properties
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string Renk { get => renk; set => renk = value; }
        public int Yil { get => yil; set => yil = value; }
        #endregion

        #region Constructors
        public Arac() { 
        }

        public Arac(string marka, string model, string renk,int yil) { 
            Marka = marka;
            Model = model;
            Renk = renk;
            Yil = yil;
        }
        #endregion

        #region Methods

        public void calistir() => Console.WriteLine("Araç çalıştı!");
        public void durdur() => Console.WriteLine("Araç durduruldu!");

        public override string? ToString()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"{this.Marka}");
            Console.WriteLine($"{this.Model}");
            Console.WriteLine($"{this.Renk}");
            Console.WriteLine($"{this.Yil}");
            Console.WriteLine($"{this.Motor}");
            Console.WriteLine($"{this.Hacim}");
            Console.WriteLine(" ");
            return "";
        }

        #endregion


    }
}
