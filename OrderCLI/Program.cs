using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCLI
{

    public class Program
    {
        static void Main(string[] args)
        {

            //ana kodun olduğu method
            ThrowEx();
        }
        public static void ThrowEx()
        {
            string deneme = string.Empty;
            int yeniKayit = 11;
            int siradaki = 10;

            //misafir giris numarası Dizisi
            string[] misafirNo = new string[yeniKayit];
            misafirNo[0] = "101";
            misafirNo[1] = "102";
            misafirNo[2] = "103";
            misafirNo[3] = "104";
            misafirNo[4] = "105";
            misafirNo[5] = "106";
            misafirNo[6] = "107";
            misafirNo[7] = "108";
            misafirNo[8] = "109";
            misafirNo[9] = "110";

            //misafir adı Dizisi
            ///string[] isim = { "Ali", "Veli", "Hasan", "Kemal", "Can", "Ahmet", "Mehmet", "Enis", "Bilal", "Burak" };
            string[] misafirAd = new string[yeniKayit];
            misafirAd[0] = "Ali";
            misafirAd[1] = "Veli";
            misafirAd[2] = "Hasan";
            misafirAd[3] = "Kemal";
            misafirAd[4] = "Can";
            misafirAd[5] = "Ahmet";
            misafirAd[6] = "Mehmet";
            misafirAd[7] = "Enis";
            misafirAd[8] = "Bilal";
            misafirAd[9] = "Burak";

            deneme:
            Console.Write("Kişi No'yu girin: ");
            string aranan = Console.ReadLine();
            int no = Array.IndexOf(misafirNo, aranan.ToString());
            Console.WriteLine("===========================================================================");


            //Kayıtlı misafir olmadığın yeni kayıt yeri
            if (no == -1)
            {
                Console.Write("Kişi Bulunamadı ");
                Console.Write("Lütfen yeni kayıt yapınız ");


                Console.Write("TC No'yu girin: ");
                misafirNo[siradaki] = Console.ReadLine();
                Console.Write("Ad Soyad  girin: ");
                misafirAd[siradaki] = Console.ReadLine();
                //Console.Write("Telefon  girin: ");
                //telefon[siradaki] = Console.ReadLine();
                //Console.Write("Mail  girin: ");
                //mail[siradaki] = Console.ReadLine();
                Console.Write("Kayıt başarılı");

                siradaki++;
                yeniKayit++;
                Console.Clear();
                Console.Write("Kayıt başarılı");
                goto deneme;

            }
            else
            {
                Console.WriteLine("Misafirimiz : {0}", misafirAd[no]);

            }
            foreach (var uye in misafirNo)
            {
                //butun değişkenler burada
                string password;
                double secim, adet, toplam = 0, hesap = 0;
                bool result = true;
                if (aranan == uye)
                {
                    Menu();
                    while (result)
                    {
                        for (int i = 0; i < 100; i++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Siparis numarasını giriniz :");
                            secim = Convert.ToDouble(Console.ReadLine());

                            if (secim == 1)
                            {
                                Console.WriteLine("Kaç porsiyon Et Döner istersiniz : ");
                                adet = Convert.ToDouble(Console.ReadLine());
                                toplam = adet * 7;
                                hesap = hesap + toplam;
                                result = false;
                                break;

                            }
                            else if (secim == 2)
                            {
                                Console.WriteLine("Kaç porsiyon Tavuk Döner istersiniz : ");
                                adet = Convert.ToDouble(Console.ReadLine());
                                toplam = adet * 5.00;
                                hesap = hesap + toplam;
                                result = false;
                                break;
                            }
                            else if (secim == 3)
                            {
                                Console.WriteLine("Kaç porsiyon Kuru/Pilav istersiniz : ");
                                adet = Convert.ToDouble(Console.ReadLine());
                                toplam = adet * 8.00;
                                hesap = hesap + toplam;
                                result = false;
                                break;
                            }
                            else if (secim == 4)
                            {
                                Console.WriteLine("Kaç porsiyon Pide  istersiniz : ");
                                adet = Convert.ToDouble(Console.ReadLine());
                                toplam = adet * 6.50;
                                hesap = hesap + toplam;
                                break;
                            }
                            else if (secim == 5)
                            {
                                Console.WriteLine("Kaç porsiyon Corba  istersiniz : ");
                                adet = Convert.ToDouble(Console.ReadLine());
                                toplam = adet * 5.50;
                                hesap = hesap + toplam;
                                break;
                            }
                            else if (secim == 6)
                            {
                                Console.WriteLine("Kaç porsiyon Salata  istersiniz : ");
                                adet = Convert.ToDouble(Console.ReadLine());
                                toplam = adet * 3.50;
                                hesap = hesap + toplam;
                                break;
                            }
                            else if (secim == 7)
                            {
                                Console.WriteLine("Kaç porsiyon Ayran  istersiniz : ");
                                adet = Convert.ToDouble(Console.ReadLine());
                                toplam = adet * 1.00;
                                hesap = hesap + toplam;
                                break;
                            }
                            else if (secim == 8)
                            {
                                Console.WriteLine("Kaç porsiyon Cola  istersiniz : ");
                                adet = Convert.ToDouble(Console.ReadLine());
                                toplam = adet * 3.00;
                                hesap = hesap + toplam;
                                break;
                            }
                            else if (secim == 9)
                            {
                                Console.WriteLine("Kaç porsiyon Su  istersiniz : ");
                                adet = Convert.ToDouble(Console.ReadLine());
                                toplam = adet * 1.00;
                                hesap = hesap + toplam;
                                break;
                            }
                            else if (secim == 10)
                            {
                                Console.WriteLine("Kaç porsiyon Cay  istersiniz : ");
                                adet = Convert.ToDouble(Console.ReadLine());
                                toplam = adet * 2.00;
                                hesap = hesap + toplam;
                                break;
                            }
                            else if (secim == 11)
                            {
                                Console.WriteLine("Kaç porsiyon Soda  istersiniz : ");
                                adet = Convert.ToDouble(Console.ReadLine());
                                toplam = adet * 2.00;
                                hesap = hesap + toplam;
                                break;
                            }
                            else if (secim == 12)
                            {
                                Console.WriteLine("Kaç porsiyon Fanta  istersiniz : ");
                                adet = Convert.ToDouble(Console.ReadLine());
                                toplam = adet * 3.00;
                                hesap = hesap + toplam;
                                break;
                            }
                        }
                    }
                    Console.WriteLine("Toplam Hesap :" + hesap + "£");
                    break;
                }



            }
            Console.ReadKey();
        }


        //menu fiyat ve içerik methodu
        public static void Menu()
        {
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**                     Patika Restorant Menü                         **");
            Console.WriteLine("**                                                                   **");
            Console.WriteLine("**           Yemekler          **        İçecekler                   **");
            Console.WriteLine("**       ----------------      **     --------------                 **");
            Console.WriteLine("**     1-Et Döner     - 7.00   **     7-Ayran   - 1.00 TL            **");
            Console.WriteLine("**                             **                                    **");
            Console.WriteLine("**     2-Tavuk Döner  - 5.00   **     8-Kola    - 3.00 TL            **");
            Console.WriteLine("**                             **                                    **");
            Console.WriteLine("**     3-Kuru/Pilav   - 8.00   **     9-su       -1.00 TL            **");
            Console.WriteLine("**                             **                                    **");
            Console.WriteLine("**     4-Pide         - 6.50   **     10-Cay     -2.00 TL            **");
            Console.WriteLine("**                             **                                    **");
            Console.WriteLine("**     5-Corbalar     - 5.50   **     11-Soda    -2.00 TL            **");
            Console.WriteLine("**                             **                                    **");
            Console.WriteLine("**     6-Salata       - 3.50   **     12-Fanta   -3.00 TL            **");
            Console.WriteLine("**                             **                                    **");
            Console.WriteLine("**********************************************************************");
        }
    }


}




