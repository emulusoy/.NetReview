using System;
using System.Globalization;

namespace ConsoleApp
{

    class Ogrenci
    {

        public int OgrNo { get; set; }
        public string Ad { get; set; }
        public string Sube { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogr1 = new Ogrenci();

            ogr1.OgrNo = 199;
            ogr1.Ad = "Mehmet";
            ogr1.Sube = "11A";
            Ogrenci ogr2 = new Ogrenci();
            ogr2.OgrNo = 222;
            ogr2.Ad = "Melike";
            ogr2.Sube = "10A";
            Ogrenci ogr3 = new Ogrenci();
            ogr3.OgrNo = 333;
            ogr3.Ad = "Çınar";
            ogr3.Sube = "9A";
            Console.WriteLine($"no:{ogr1.OgrNo} ad:{ogr1.Ad} Şubesi:{ogr1.Sube}");
            Console.WriteLine($"no:{ogr2.OgrNo} ad:{ogr2.Ad} Şubesi:{ogr2.Sube}");
            Console.WriteLine($"no:{ogr3.OgrNo} ad:{ogr3.Ad} Şubesi:{ogr3.Sube}");
            

            //dAHA İYİ yöntem

            Console.WriteLine("------------------------------------");

            Ogrenci[] ogrenciler=new Ogrenci[3]; //3 elemanlı bir öğrenciler dizisi tanımladım

            ogrenciler[0]=ogr1;
            ogrenciler[1]=ogr2;
            ogrenciler[2]=ogr3;

                for (int i = 0; i < ogrenciler.Length; i++)//ogrencilerin eleman sayısı kadar!
                {
                    Console.WriteLine($"no:{ogrenciler[i].OgrNo} ad:{ogrenciler[i].Ad} Şubesi:{ogrenciler[i].Sube}");
                }




        }
    }
}
