using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");

            Musteri musteri1 = new Musteri();
            musteri1.Id = "1111";
            musteri1.Ad = "Semih";
            musteri1.Soyad = "D..";
            musteri1.DogumYili = "1999";
            musteri1.DogumYeri = "Adana";

            Musteri musteri2 = new Musteri();
            musteri2.Id = "2222";
            musteri2.Ad = "Ali Furkan";
            musteri2.Soyad = "T..";
            musteri2.DogumYili = "1999";
            musteri2.DogumYeri = "Kahramanmaraş";

          
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 }; //müşteriler diziye aktarıldı
            
            MusteriManager musteriManager = new MusteriManager(); 

            //işlem sorgulama
            Console.WriteLine("YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİN");
            Console.WriteLine("1-Müşteri Ekleme\n2-Müşteri Silme\n3-Müşteri Listeleme");
          
            Console.WriteLine("\nİŞLEM");
            string islem = Console.ReadLine();
            Console.WriteLine("\n");
            
            //sorgulanan işlemi gerçekleştirme
            switch (islem)
            {
                case "1":
                    musteriManager.MusteriEkleme();
                    break;

                case "2":
                    musteriManager.MusteriSilme(musteriler);
                    break;

                case "3":
                    Console.WriteLine("Müşteriler Listelendi:");
                    Console.WriteLine("------------------------------");
                    musteriManager.MusteriListeleme(musteriler);
                    break;

                default:
                    Console.WriteLine("Geçerli bir işlem seçmediniz!");
                    break;
            }
        }
    }
}
