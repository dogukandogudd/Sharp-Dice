using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zar = new int[6];
            zar[0] = 1;
            zar[1] = 2;
            zar[2] = 3;
            zar[3] = 4;
            zar[4] = 5;
            zar[5] = 6;


            Random RastGeleSayi = new Random();

            int Deger1 = 0;
            int Deger2 = 0;
            int Deger3 = 0;
            int Deger4 = 0;
            int Deger5 = 0;
            int Deger6 = 0;

            int sayi;


            Console.WriteLine("Kaç kere zar atmak istersiniz?");
            int kul_sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Oyun Başlıyor...");


            for (int sayac = 1; sayac <= kul_sayi; sayac++)
            {

                sayi = RastGeleSayi.Next(1, 6);

                Console.WriteLine(sayac + 0 + ".Atışta Gelen Sayı: " + sayi);


                switch (sayi)
                {
                    case 1:
                        ++Deger1;
                        break;
                    case 2:
                        ++Deger2;
                        break;
                    case 3:
                        ++Deger3;
                        break;
                    case 4:
                        ++Deger4;
                        break;
                    case 5:
                        ++Deger5;
                        break;
                    case 6:
                        ++Deger6;
                        break;
                }
            }


            Console.WriteLine("---------------------------");
            Console.WriteLine("Toplam");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Sayı:\tKaç Defa Türetildi:");
            Console.WriteLine();

            Console.WriteLine("1:\t{0}\n2:\t{1}\n3:\t{2}\n4:\t{3}\n5:\t{4}\n6:\t{5}", Deger1, Deger2,
                     Deger3, Deger4, Deger5, Deger6);

            Console.WriteLine("---------------------------");

            if (Deger1 > Deger2 && Deger1 > Deger3 && Deger1 > Deger4 && Deger1 > Deger5 && Deger1 > Deger6)
            {

                Console.WriteLine("En çok türetilen değer :1    --  " + Deger1 + " defa türetildi");
            }

            if (Deger2 > Deger1 && Deger2 > Deger3 && Deger2 > Deger4 && Deger2 > Deger5 && Deger2 > Deger6)
            {
                Console.WriteLine("En çok türetilen değer :2    --  " + Deger2 + " defa türetildi");
            }

            if (Deger3 > Deger1 && Deger3 > Deger2 && Deger3 > Deger4 && Deger3 > Deger5 && Deger3 > Deger6)
            {
                Console.WriteLine("En çok türetilen değer :3    --  " + Deger3 + " defa türetildi");
            }

            if (Deger4 > Deger1 && Deger4 > Deger2 && Deger4 > Deger3 && Deger4 > Deger5 && Deger4 > Deger6)
            {
                Console.WriteLine("En çok türetilen değer :4    --  " + Deger4 + " defa türetildi");
            }

            if (Deger5 > Deger1 && Deger5 > Deger2 && Deger5 > Deger3 && Deger5 > Deger4 && Deger5 > Deger6)
            {
                Console.WriteLine("En çok türetilen değer :5    --  " + Deger5 + " defa türetildi");
            }

            if (Deger6 > Deger1 && Deger6 > Deger2 && Deger6 > Deger3 && Deger6 > Deger4 && Deger6 > Deger5)
            {
                Console.WriteLine("En çok türetilen değer :6    --  " + Deger6 + " defa türetildi");
            }

            Console.WriteLine("---------------------------");
            Console.ReadLine();

        }
    }
}
