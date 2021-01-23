using System;

namespace kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;

            kurs kurs1 = new kurs();
            kurs1.KursAdi = "java";
            kurs1.Egitmen = "kerem";
            kurs1.IzlenmeOrani = 64;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = "Engin Demirog";
            kurs2.IzlenmeOrani = 68;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "murat";
            kurs3.IzlenmeOrani = 62;

            kurs[] kurslar = new kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
            
        }

    }
    class kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
