using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Banka
{
    public class MevduatHesabi : IBankaHesap
    {
        private decimal _bakiye;
        public decimal bakiye => _bakiye;

        public bool cek(decimal miktar)
        {
            if (_bakiye >= miktar) {
                _bakiye -= miktar;
                return true;
            }
            Console.WriteLine("\aBakiye yetersiz!");
            return false;
        }

        public void yatir(decimal miktar) => _bakiye += miktar;

        public override string? ToString() => $"Mevduat hesabı bakiye bilgisi: {_bakiye,6:C}";
    }
}
