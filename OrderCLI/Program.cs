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
            //string deneme = string.Empty;
            int newUser = 11;
            int nextUser = 10;
            

            //misafir giris numarası Dizisi
            string[] guestNo = new string[newUser];
            guestNo[0] = "101";
            guestNo[1] = "102";
            guestNo[2] = "103";
            guestNo[3] = "104";
            guestNo[4] = "105";
            guestNo[5] = "106";
            guestNo[6] = "107";
            guestNo[7] = "108";
            guestNo[8] = "109";
            guestNo[9] = "110";

            

            //misafir adı Dizisi
            ///string[] isim = { "Ali", "Veli", "Hasan", "Kemal", "Can", "Ahmet", "Mehmet", "Enis", "Bilal", "Burak" };
            string[] guestName = new string[newUser];
            guestName[0] = "Ali";
            guestName[1] = "Veli";
            guestName[2] = "Hasan";
            guestName[3] = "Kemal";
            guestName[4] = "Can";
            guestName[5] = "Ahmet";
            guestName[6] = "Mehmet";
            guestName[7] = "Enis";
            guestName[8] = "Bilal";
            guestName[9] = "Burak";

            deneme:
            Console.Write("Kişi No'yu girin: ");
            string wantedUser = Console.ReadLine();
            int no = Array.IndexOf(guestNo, wantedUser.ToString());
            Console.WriteLine("===========================================================================");


            
            //Kayıtlı misafir olmadığın yeni kayıt yeri
            if (no == -1)
            {
                Console.Write("Kişi Bulunamadı ");
                Console.Write("Lütfen yeni kayıt yapınız ");


                Console.Write("TC No'yu girin: ");
                guestNo[nextUser] = Console.ReadLine();
                Console.Write("Ad Soyad  girin: ");
                guestName[nextUser] = Console.ReadLine();
                //Console.Write("Telefon  girin: ");
                //telefon[siradaki] = Console.ReadLine();
                //Console.Write("Mail  girin: ");
                //mail[siradaki] = Console.ReadLine();
                Console.Write("Kayıt başarılı");

                nextUser++;
                newUser++;
                Console.Clear();
                Console.Write("Kayıt başarılı");
                goto deneme;

            }
            else
            {
                Console.WriteLine("Misafirimiz : {0}", guestName[no]);

            }
            foreach (var user in guestNo)
            {
                //butun değişkenler burada
                string password=string.Empty;
                double selected, piece, total = 0, amount = 0;
                bool result = true;
                if (wantedUser == user)
                {
                    Menu();
                    while (result)
                    {
                        for (int i = 0; i < 100; i++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Siparis numarasını giriniz :");
                            selected = Convert.ToDouble(Console.ReadLine());

                            if (selected == 1)
                            {
                                Console.WriteLine("Kaç porsiyon Et Döner istersiniz : ");
                                piece = Convert.ToDouble(Console.ReadLine());
                                total = piece * 7;
                                amount = amount + total;
                                result = false;
                                break;

                            }
                            else if (selected == 2)
                            {
                                Console.WriteLine("Kaç porsiyon Tavuk Döner istersiniz : ");
                                piece = Convert.ToDouble(Console.ReadLine());
                                total = piece * 5.00;
                                amount = amount + total;
                                result = false;
                                break;
                            }
                            else if (selected == 3)
                            {
                                Console.WriteLine("Kaç porsiyon Kuru/Pilav istersiniz : ");
                                piece = Convert.ToDouble(Console.ReadLine());
                                total = piece * 8.00;
                                amount = amount + total;
                                result = false;
                                break;
                            }
                            else if (selected == 4)
                            {
                                Console.WriteLine("Kaç porsiyon Pide  istersiniz : ");
                                piece = Convert.ToDouble(Console.ReadLine());
                                total = piece * 6.50;
                                amount = amount + total;

                           
                                result = false;
                                break;
                            }
                            else if (selected == 5)
                            {
                                Console.WriteLine("Kaç porsiyon Corba  istersiniz : ");

                                piece = Convert.ToDouble(Console.ReadLine());
                                total = piece * 5.50;
                                amount = amount + total;

                         
                                result = false;

                                break;
                            }
                            else if (selected == 6)
                            {
                                Console.WriteLine("Kaç porsiyon Salata  istersiniz : ");

                                piece = Convert.ToDouble(Console.ReadLine());
                                total = piece * 3.50;
                                amount = amount + total;

                           
                                result = false;

                                break;
                            }
                            else if (selected == 7)
                            {
                                Console.WriteLine("Kaç porsiyon Ayran  istersiniz : ");

                                piece = Convert.ToDouble(Console.ReadLine());
                                total = piece * 1.00;
                                amount = amount + total;
                       
                                result = false;

                                break;
                            }
                            else if (selected == 8)
                            {
                                Console.WriteLine("Kaç porsiyon Cola  istersiniz : ");

                                piece = Convert.ToDouble(Console.ReadLine());
                                total = piece * 3.00;
                                amount = amount + total;

                           
                                result = false;

                                break;
                            }
                            else if (selected == 9)
                            {
                                Console.WriteLine("Kaç porsiyon Su  istersiniz : ");

                                piece = Convert.ToDouble(Console.ReadLine());
                                total = piece * 1.00;
                                amount = amount + total;

                             
                                result = false;

                                break;
                            }
                            else if (selected == 10)
                            {
                                Console.WriteLine("Kaç porsiyon Cay  istersiniz : ");

                                piece = Convert.ToDouble(Console.ReadLine());
                                total = piece * 2.00;
                                amount = amount + total;

                              
                             
                                result = false;

                                break;
                            }
                            else if (selected == 11)
                            {
                                Console.WriteLine("Kaç porsiyon Soda  istersiniz : ");

                                piece = Convert.ToDouble(Console.ReadLine());
                                total = piece * 2.00;
                                amount = amount + total;

                            
                                result = false;
                                break;
                            }
                            else if (selected == 12)
                            {
                                Console.WriteLine("Kaç porsiyon Fanta  istersiniz : ");
                                piece = Convert.ToDouble(Console.ReadLine());
                                total = piece * 3.00;
                                amount = amount + total;
                               
                                result = false;
                                break;
                            }
                        }
                    }
                    Console.WriteLine("Toplam Hesap :" + amount + "£");
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




