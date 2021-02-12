using System;

namespace RandomKomutu
{
    class Program
    {
        static void Main(string[] args)
        {

            //Random rastgele = new Random();
            //int a,b;
            //a = rastgele.Next(60); //10 dahil değil | tek değer girersen otomatik 0 ile girdiğinn değer arasını alır
            //b = rastgele.Next(0, 10); // hiç birşey yazmazsan değer aralığı almaz üst sınır olarak int değerinin üst değerinialır
            //Console.WriteLine(a+" "+b);

            // Şehir atam programı
            Console.WriteLine("***Şehir atama programı***");
            string[] sehirler = {"Bursa","Balıkesir","İzmir","Çanakkale","Ankara","Aydın","Muğla","Antalya" };
            Random random = new Random();
            int atama;
            atama = random.Next(0, sehirler.Length+1);
            Console.WriteLine(atama);
            Console.WriteLine("Atanacağınız şehir: "+sehirler[atama]);

        }
    }
}
