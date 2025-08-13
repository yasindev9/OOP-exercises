using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Banka
{
    public interface IBankaHesap
    {
        void yatir(decimal miktar);
        bool cek(decimal miktar);
        decimal bakiye { get; }
    }
}
