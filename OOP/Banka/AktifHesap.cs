using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Banka
{
    public class AktifHesap : ITransfer
    {
        private decimal _bakiye;

        public decimal bakiye => _bakiye;

        public bool cek(decimal miktar)
        {
            if (_bakiye >= miktar)
            {
                _bakiye -= miktar;
                return true;
            }
            Console.WriteLine("\aYetersiz bakiye!");
            return false;
        }

        public bool transferYap(IBankaHesap aliciHesap, decimal miktar)
        {
            bool sonuc = cek(miktar);
            if (sonuc)
            {
                aliciHesap.yatir(miktar);
            }
            return sonuc;
        }

        public void yatir(decimal miktar) => _bakiye += miktar;

        public override string? ToString() => $"Aktif hesap bakiye bilgisi: {_bakiye,6:C}";
    }
}
