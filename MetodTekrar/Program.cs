using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //GunListele();
            //p.GunListele2();
            //Console.WriteLine(p.kareal());

            //Console.WriteLine("Lütfen büyük harf içeren bir metin giriniz");
            //string girilen = Console.ReadLine();
            //p.kucult(girilen);

            Console.WriteLine("Taban değerini giriniz");
            int taban = int.Parse(Console.ReadLine());
            Console.WriteLine("tavan değerini giriniz");
            int tavan = int.Parse(Console.ReadLine());
            p.topla((p.sayiuret(taban, tavan)), (p.sayiuret(taban, tavan)));
            Console.ReadKey();
        }
        //Geri dönüşümsüz
        //Geri dönüşümlü
        //Geri dönüşümsüz paramtreli
        //geri dönüşümlü prametreli
#region dur
        static void GunListele()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("{0}. gün",i+1);
            }
        }
        void GunListele2()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("{0}. gün", i + 1);
            }
        }
        int kareal()
        {
            Random rnd = new Random();
            return rnd.Next(1,100);
        }
        void kucult(string a)
        {
            Console.WriteLine(a.ToLower());
        }
        #endregion

        int sayiuret(int a,int b)
        {
            Random rnd = new Random();
            int uret = rnd.Next(a, b);
            Console.WriteLine(uret);
            return uret;
        }
        void topla (int c,int d)
        {
            Console.WriteLine(c+d);
        }
    }
}
