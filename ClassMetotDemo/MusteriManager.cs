using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme()
        {
            Musteri musteri = new Musteri();
            Console.WriteLine("MÜŞTERİ ID:");
            musteri.Id = Console.ReadLine();

            Console.WriteLine("\nADI:");
            musteri.Ad = Console.ReadLine();

            Console.WriteLine("\nSOYADI:");
            musteri.Soyad = Console.ReadLine();

            Console.WriteLine("\nDOĞUM YILI:");
            musteri.DogumYili = Console.ReadLine();

            Console.WriteLine("\nDOĞUM YERİ:");
            musteri.DogumYeri = Console.ReadLine();

            Console.WriteLine("\nMüşteri Eklendi!");
        }

        public void MusteriListeleme(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Musteri ID: " + musteri.Id + "\nAdı: " + musteri.Ad + "\nSoyadı: " + musteri.Soyad + "\nDoğum Yılı: " + musteri.DogumYili + "\nDoğum Yeri: " + musteri.DogumYeri);
                Console.WriteLine("------------------------------");
            }
        }

        public void MusteriSilme(Musteri[] musteriler)
        {
            Console.WriteLine("SİLMEK İSTEDİĞİNİZ MÜŞTERİ ID:");
            string checkId = Console.ReadLine();

            for (int i = 0; i < musteriler.Length; i++)
            {
                if (musteriler[i].Id == checkId)
                {
                    Console.WriteLine("Müşteri Silindi!");
                    break;
                }
                else
                {
                    Console.WriteLine("Böyle bir müşteri bulunamadı.");
                    break;
                }
            }
            
        }
    }
}
