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
        public static void Main(string[] args)
        {

            //butun değişkenler burada
            string password;
            double secim, adet, toplam = 0, hesap = 0;
            bool result = true;

            Console.WriteLine("Sifre giriniz:");
            password = Console.ReadLine();

            //kullanıcıların bulunduğu array
            string[] arr = { "11111", "22222", "33333", "44444" };

            foreach (var tc in arr)
            {

                //girilen şifre ile kayıtlı şifre validation oluyor mu kontrolu
                if (password == tc)
                {
                    //menu methodu
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
                else
                {
                    Console.WriteLine("Bu sifre ile kayitli kullanıcı bulunamadı.Kullanıcıyı ekleyebilirsiniz.Evet/Hayır");

                }
            }
            Console.Read();
        }
        //Menu ve içeriği
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
