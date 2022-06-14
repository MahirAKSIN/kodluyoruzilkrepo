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

            string password;
            double secim, adet, toplam = 0, hesap = 0;


            Console.WriteLine("Sifre giriniz:");
            password = Console.ReadLine();

            string[] arr = { "11111", "22222", "33333", "44444" };


            int[] terms = new int[400];


            foreach (var tc in arr)
            {


                if (password == tc)
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
                    Console.WriteLine("**     5-Corbalar     - 5.50   **     11-Sode    -2.00 TL            **");
                    Console.WriteLine("**                             **                                    **");
                    Console.WriteLine("**     6-Salata       - 3.50   **     12-Fanta   -3.00 TL            **");
                    Console.WriteLine("**                             **                                    **");
                    Console.WriteLine("**********************************************************************");

                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Siparis numarasını giriniz :");
                        secim = Convert.ToDouble(Console.ReadLine());

                        if (secim == 1)
                        {
                            Console.WriteLine("Kaç porsiyon istersiniz : ");
                            adet = Convert.ToDouble(Console.ReadLine());
                            toplam = adet * 7;
                            hesap = hesap + toplam;
                            break;

                        }

                    }
                    Console.WriteLine(hesap);






                    break;
                }
                else
                {

                    Console.WriteLine("Bu sifre ile kayitli kullanıcı bulunamadı");
                    break;
                }

            }
            Console.Read();

        }

        //public static void NewUser()
        //{
        //    Console.WriteLine("Yeni kullanıcı bilgileri giriniz..");
        //    string userName, password = string.Empty;

        //    Console.WriteLine("Kullanıcı adı giriniz:");
        //    userName = Console.ReadLine();

        //    Console.WriteLine("Sifre giriniz:");
        //    password = Console.ReadLine();

        //    using (StreamWriter sw = new StreamWriter(File.Create("C:\\User.txt")))
        //    {
        //        sw.WriteLine(userName);
        //        sw.WriteLine(password);
        //        sw.Close();

        //    }
        //    Console.WriteLine("Done");
        //    Console.Read();
        //}
        //public static void Users()
        //{
        //    Console.WriteLine("Yeni kullanıcı bilgileri giriniz..");
        //    string userName1, password1 = string.Empty;

        //    Console.WriteLine("Kullanıcı adı giriniz:");
        //    userName1 = Console.ReadLine();

        //    Console.WriteLine("Sifre giriniz:");
        //    password1 = Console.ReadLine();

        //    using (StreamReader sr= new StreamReader(File.Create("C:\\User.txt")))
        //    {
        //        sr.ReadLine();
        //        sr.ReadLine();
        //        sr.Close();

        //    }
        //    Console.WriteLine("Login Success");
        //    Console.Read();
        //}

    }
}
