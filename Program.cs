using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.FirstName = "Ali";
            musteri.LastName = "Demiroğ";
            musteri.DateOfBirth = DateTime.Now;
            musteri.Id = 1;
            musteri.Email = "dqjeqejwqjewıjqew@gmail.com";


            Musteri musteri2 = new Musteri();
            musteri2.FirstName = "Erkan";
            musteri2.LastName = "Sayılır";
            musteri2.DateOfBirth = DateTime.Now;
            musteri2.Id = 2;
            musteri2.Email = "kelimess@gmail.com";


            MusteriManager musteriManager = new MusteriManager(musteri);
            musteriManager.MusteriEkle();
            musteriManager.MüsteriListele();
            musteriManager.MüsteriSil();

            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");

            MusteriManager musteriManager2 = new MusteriManager(musteri2);
            musteriManager2.MusteriEkle();
            musteriManager2.MüsteriListele();
            musteriManager2.MüsteriSil();

            Console.ReadLine();
        }
    }
}
