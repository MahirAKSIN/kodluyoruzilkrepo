using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obss
{
    class Program
    {
        static void Main(string[] args)
        {
            //Topla();
            //KareTopla();
            //KupTopla();
            //Yas();
            //PozNum();
            //Faktoriyel();
            //BolmeCık();
            //AsalSayi();
            //TersYazma();
            //Minute();
            //KareKok();
            //Console.Write("Tersten Yazılacak Metni Giriniz = ");
            //HarfSay(Console.ReadLine());
            //ObebOkek();
            //AmstrongSayisi();
            Fibonnaci();



            Console.Read();
        }
        #region MyRegion
        public static void Topla()
        {

            bool result = true;
            string againTry = null;


            while (result)
            {
                try
                {
                    Console.Write("I.sayiyi giriniz :");
                    int sayi1 = int.Parse(Console.ReadLine());
                    Console.Write("II.sayiyi giriniz :");
                    int sayi2 = int.Parse(Console.ReadLine());


                    Console.WriteLine(sayi1 + sayi2);
                    Console.WriteLine("Isleme devam etmek ister misiniz:(e),(E),(evet),(Evet)");
                    againTry = Console.ReadLine();

                    if (againTry == "E" || againTry == "e" || againTry == "evet" || againTry == "Evet")
                    {
                        result = true;
                    }
                    else
                    {
                        Console.WriteLine("Gorusuruz");

                        result = false;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Lutfen sadece numerik giriniz.");
                    result = true;
                }
            }

        }
        public static void KareTopla()
        {

            int sayi1, sayi2;
            Console.Write("I.Sayi :");
            sayi1 = int.Parse(Console.ReadLine());

            Console.Write("II.Sayi :");
            sayi2 = int.Parse(Console.ReadLine());



            Console.Write((sayi1 * sayi1) + (sayi2 * sayi2));

        }
        public static void KupTopla()
        {

            int toplam = 0, count = 10;

            for (int i = 1; i <= count; i++)
            {

                toplam += i * i * i;

            }
            Console.WriteLine(toplam);



        }
        public static void Yas()
        {
            int nowYear = 2022;

            Console.Write("Lutfen dogum yilliniz giriniz");
            int dogumYilli = int.Parse(Console.ReadLine());

            if (nowYear > dogumYilli)
            {

                int result = nowYear - dogumYilli;

                Console.Write("Yasiniz :" + result);

            }
            else
            {
                Console.Write("yanlislik var");

            }


        }
        public static void Faktoriyel()
        {

            int num = 1, val = 1;

            Console.WriteLine("Sayi giriniz :");
            num = int.Parse(Console.ReadLine());



            for (int i = 1; i <= num; i++)
            {
                val *= i;

            }
            Console.WriteLine(val);


        }
        public static void PozNum()
        {
            //5x3=15 = 5+5+5

            int sayi1, sayi2, toplam = 0;

            Console.Write("İlk sayiyi gir :");
            sayi1 = int.Parse(Console.ReadLine());


            Console.Write("İlk sayiyi gir :");
            sayi2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < sayi1; i++)
            {
                toplam += sayi2;
            }
            Console.Write($"{sayi1}x{sayi2} : " + toplam);


        }
        public static void BolmeCık()
        {

            //7/2=1
            //7-2=5
            //5-2=3
            //3-2=1 ---->Break;

            int sayi1, sayi2, toplam = 0, count = 0;

            Console.Write("İlk sayiyi gir :");
            sayi1 = int.Parse(Console.ReadLine());


            Console.Write("İlk sayiyi gir :");
            sayi2 = int.Parse(Console.ReadLine());

            int _sayi1 = sayi1;

            for (int i = 0; i < _sayi1; i++)
            {
                sayi1 -= sayi2;
                count++;
                if (sayi2 > sayi1)
                {
                    toplam = sayi1;
                    break;
                }
            }
            Console.Write($"{sayi1}/{sayi2} : {count}| Kalan : {toplam} ");



        }
        public static void BasamakSayisi()
        {
            float sayi1;
            int count = 0;
            Console.Write("İlk sayiyi gir :");
            sayi1 = float.Parse(Console.ReadLine());
            for (; 10 <= sayi1;)
            {
                sayi1 /= 10;
                count++;
            }
            count += 1;
            Console.Write($"{sayi1} sayisini basamak değer {count}");
        }
        public static void KupToplama()
        {

            int sayi1 = 1;
            int count = 0;

            Console.Write("İlk sayiyi gir :\nasdsad");
            sayi1 = int.Parse(Console.ReadLine());

            int temp = sayi1;

        }
        public static void AsalSayi()
        {
            int sayi;


            Console.Write("Bir sayi giriniz : ");
            sayi = int.Parse(Console.ReadLine());

            bool result = true;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    result = false;
                    break;
                }
            }
            if (result)
            {
                Console.WriteLine("ASaldır");
            }
            else
            {
                Console.WriteLine("ASaldır değildir");


            }


        }
        public static void TersYazma()
        {
            String text;
            int count = 0;
            Console.Write("Tersten Yazılacak Metni Giriniz = ");
            text = Console.ReadLine();
            for (int i = 0; i <= text.Length - 1; i++)
            {
                Console.Write(text[text.Length - i - 1]);



            }
            Console.ReadLine();
        }
        public static void Minute()
        {

            DateTime simdikiZaman = DateTime.Now;
            DateTime birDkOnce = DateTime.Now.AddMinutes(1);
            DateTime birDkSonra = DateTime.Now.AddMinutes(-1);
            string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            Console.WriteLine($"{simdikiZaman},{birDkOnce},{birDkSonra} ,{masaustuYolu}");



        }
        public static void KareKok()
        {

            int sayi = 1, kok = 1, usSayisi = 1;

            Console.WriteLine("koku alinacak sayiyi giriniz :");
            sayi = int.Parse(Console.ReadLine());
            if (sayi < 0)
            {
                Console.WriteLine("Koku alinacak sayinin 0 dan büyük olması gerek");
            }
            else
            {
                kok = Convert.ToInt32(Math.Sqrt(sayi));
                Console.Write(kok);
            }

        }
        #endregion
        public static void HarfSay(string cumle)
        {
            string harf = null;
            int sayac = 0;

            for (int i = 0; i <= cumle.Length - 1; i++)
            {
                string str = cumle;
                Console.Write(str[str.Length - i - 1]);
            }
            if (!string.IsNullOrWhiteSpace(cumle))
            {
                sayac = cumle.Length;
                harf = cumle.Substring(0, 1);
                cumle = cumle.Replace(harf, "");
                sayac -= cumle.Length;
                Console.WriteLine($"{harf} -> {sayac} Adet");
                HarfSay(cumle);
            }
            Console.ReadLine();
        }
        public static void ObebOkek()
        {
            int sayi1, sayi2, ebob = 0, okek = 0;

            Console.WriteLine("ilk sayiyi gir");
            sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ilk sayiyi gir");
            sayi2 = int.Parse(Console.ReadLine());

            int max = sayi1 * sayi2;
            for (int i = 1; i < sayi1; i++)
            {
                if (sayi1 % i == 0 && sayi2 % i == 0)
                {

                    ebob = i;
                }

            }

            for (int j = max; j > 0; j--)
            {
                if (j % sayi1 == 0 && j % sayi2 == 0)
                {
                    okek = j;
                }
            }

            Console.Write($"Ebob : {ebob} Ekok : {okek}");

        }

        public static void AmstrongSayisi()
        {

            int temp, birler, onlar, yuzler,toplam,basmak;
            Console.WriteLine("Basamak değeri giriniz :");
            basmak = int.Parse(Console.ReadLine());

            for (int i = 100; i < basmak; i++)
            {
                temp = i;

                birler = temp % 10;
                temp /= 10;


                onlar = temp % 10;
                temp /= 10;

                yuzler = temp % 10;
                temp /= 10;

                toplam = (birler*birler*birler) + (onlar*onlar*onlar) + (yuzler*yuzler*yuzler);

                if (i==toplam)
                {
                    Console.WriteLine(" Amstrog sayilari " + i);
                }

            }

        }
        public static void Fibonnaci()
        {

            int input;
            Console.WriteLine("Fibonnaci değeri giriniz :");
            input = int.Parse(Console.ReadLine());
            

            int s1=0, s2=1, toplam;

            for (int i = 1; i < input; i++)
            {

                Console.WriteLine(s1 + " , ");

                toplam = s1 + s2;
                s1 = s2;
                s2 = toplam;

            }


        }

    }
}
