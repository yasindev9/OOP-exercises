using OOP.Banka;
using OOP.Cizim;
using OOP.COLL;
using OOP.Modelleme;

namespace OOP;

public class Kisi {
	public Kisi()
	{
			
	}
	public Kisi(string adi) { 
		Adi = adi;
	}
    public Kisi(string adi, int yas)
    {
		Adi = adi;
		Yas = yas;
    }
    public string Adi { get; set; }
	public int Yas { get; set; }
}

public static class StringExtension {

	public static int kelimeSayisi(this string s) => s.Split().Length; 

}

class Program
{
    public static void sekilCiz(Sekil sekil) => sekil.Ciz();

    static void Main(string[] args) {

		/*Kisi k = new Kisi("Ahmet", 18);
		Console.WriteLine(k.Adi + " : " + k.Yas);

		Kisi k1 = new Kisi("Mehmet");
		Console.WriteLine(k1.Adi + " : " + k1.Yas);

		Kisi k2 = new Kisi();
        Console.WriteLine(k2.Adi + " : " + k2.Yas);*/

		/*string s = "Merhaba sevimli dünya.";
		Console.WriteLine($"{s.kelimeSayisi()}");*/

		/*Arac benimAracim = new Arac("Skoda", "SuperB", "Gri", 2025);
		Arac benimAracim = new Arac();
		benimAracim.Marka = "Skoda";
		benimAracim.Model = "SuperB";
		benimAracim.Renk = Renk.Gri.ToString();
		benimAracim.Yil = 2025;
		benimAracim.Motor = Motor.Dizel.ToString();
		benimAracim.Hacim = 1.6;

		Arac seninAracin = new Arac()
		{
			Marka = "Skoda",
			Model = "Octavia",
			Renk = Renk.Beyaz.ToString(),
			Yil = 2023,
			Motor = Motor.Benzin.ToString(),
			Hacim = 1.5
		};

		benimAracim.ToString();
		seninAracin.ToString();

        benimAracim.Temizle(); */

		/*List<Arac> filo = new List<Arac>();

		filo.Add(new Arac { 
			Marka = "Skoda",
			Model = "Octavia",
			Renk = Renk.Beyaz.ToString(),
			Yil = 2024,
			Motor = Motor.Dizel.ToString(),
			Hacim = 1.6
		});
        filo.Add(new Arac
        {
            Marka = "Opel",
            Model = "Corsa",
            Renk = Renk.Beyaz.ToString(),
            Yil = 2018,
            Motor = Motor.Benzin.ToString(),
            Hacim = 1.4
        }); //1
        filo.Add(new Arac
        {
            Marka = "Renault",
            Model = "Fluence",
            Renk = Renk.Siyah.ToString(),
            Yil = 2017,
            Motor = Motor.Dizel.ToString(),
            Hacim = 1.6
        });
		filo.RemoveAt(1);
		foreach (Arac item in filo) { 
		item.ToString();
		}*/

		/*var r = new Dikdortgen(); // new Dikdortgen(); // new Sekil(); şekil classı abstract olduğu için artık nesne oluşturulamaz. // new Elips();
		r.Pozisyon.X = 55;
		r.Pozisyon.Y = 25;
		r.Boyut.Genislik = 200;
		r.Boyut.Yukseklik = 100;
		//r.Ciz();
		sekilCiz(r);
		r.tasi(new Pozisyon {X=20,Y=30 });
		sekilCiz(r);*/

		/*Sekil s1 = new Dikdortgen();
		s1.Pozisyon.X = 50;
		s1.Pozisyon.Y = 50;
		s1.Boyut.Genislik = 100;
		s1.Boyut.Yukseklik = 50;
		sekilCiz(s1);*/

		/*Sekil s1 = new Dikdortgen(50,50,100,100);
		sekilCiz(s1);*/

		/*IBankaHesap mevduatHesabi = new YatirimHesabi();
		mevduatHesabi.yatir(100);
		mevduatHesabi.cek(500);
		mevduatHesabi.cek(50);
		Console.WriteLine(mevduatHesabi.ToString());*/

		/*IBankaHesap mevduatHesabi = new MevduatHesabi();
		ITransfer aktifHesap = new AktifHesap();
		aktifHesap.yatir(250);
		mevduatHesabi.yatir(500);
		aktifHesap.transferYap(mevduatHesabi, 200);
		Console.WriteLine(aktifHesap.ToString());
		Console.WriteLine(mevduatHesabi.ToString());*/


		CollectionProgram.collMainCode();

    }

	//sealed anahtar sözcüğü o sınıftan başka sınıflar türetilmemesi için kullanılır. örn String sınıfı

}
