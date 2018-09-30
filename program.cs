using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            string k_ad = null, pass = null;
            if(k_ad == null && pass == null) {
                Console.Write("Kayıt bulunamadı!\nKullanıcı Adı Giriniz: ");
                k_ad = Console.ReadLine();
                Console.Write("Parola Giriniz: ");
                pass = Console.ReadLine();
            }

            while (true)
            {
                bool giris = false;
                if (giris == false)
                {
                    Console.Clear();
                    Console.WriteLine("Kullanıcı adınız '{0}' olarak belirlendi", k_ad);
                    Console.WriteLine("Parolanız '{0}' olarak belirlendi.", pass);
                    string giris_ad, giris_pass;
                    Console.WriteLine("Lütfen giriş yapınız");
                    Console.Write("Kullanıcı adı:");
                    giris_ad = Console.ReadLine();
                    Console.Write("Parola:");
                    giris_pass = Console.ReadLine();
                    if (giris_ad == k_ad && giris_pass == pass)
                    {
                        giris = true;
                        Console.WriteLine("Programa başarıyla giriş yapıldı");
                        bastan:
                        Console.Write("Üye Menüsü V1\nHoşgeldin, {0}\n1-)Kullanıcı Adını Düzenle\n2-)Parolanı Düzenle\n99-)Çıkış Yap\n>>",k_ad);
                        int menu = int.Parse(Console.ReadLine());
                        switch (menu)
                        {
                            case 1:
                                Console.Write("Kullanıcı adı değiştir >> ");
                                k_ad = Console.ReadLine();
                                Console.WriteLine("Yeni kullanıcı adınız : '{0}' olarak belirilendi.",k_ad);
                                goto bastan;
                            case 2:
                                Console.Write("Parola değiştir >> ");
                                pass = Console.ReadLine();
                                Console.WriteLine("Yeni parolanız : '{0}' olarak belirilendi.", pass);
                                goto bastan;
                            case 3:
                                Console.Write("Çıkış yapmak istediğinize emin misiniz?[E/H]");
                                string cikis = Console.ReadLine();
                                if (cikis == "e".ToUpper())
                                {
                                    break;
                                }
                                else
                                {
                                    goto bastan;
                                }
                            default:
                                Console.WriteLine("Bu geçerli bir cevap değil!");
                                goto bastan;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı adı veya parola yanlış!");
                    }
                }
                break;
            }
            Console.WriteLine("Oturum sonlandı, programı kapatmak için herhangi bir tuşa basın.");
            Console.ReadLine();
        }
    }
}
