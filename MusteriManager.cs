using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        private Musteri _musteri;
        public MusteriManager(Musteri musteri)
        {
            _musteri = musteri;
        }
        public void MusteriEkle()
        {
            Console.WriteLine("Müsteri ekleniyor : " + _musteri.FirstName + "|| Id => " + _musteri.Id);
        }
        public void MüsteriListele()
        {
            Console.WriteLine("Müsteri listeniyor : " + _musteri.FirstName + "|| Id => " + _musteri.Id);
        }
        public void MüsteriSil()
        {
            Console.WriteLine("Müsteri siliniyor : " + _musteri.FirstName + "|| Id => " + _musteri.Id);
        }
    }
}
