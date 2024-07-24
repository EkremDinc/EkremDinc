using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanÇevreHesaplayıcı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hesapCikis;
            int alanÇevre;
            int secenekler;
            int üçgenSeçenekleri;

            while (true)
            {
                hesapCikis:
                try
                {
                    Console.WriteLine("Hesap yapmak için 1'e bitirmek için 0'a basınız.");
                    hesapCikis = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Hatalı tuşlama");
                    goto hesapCikis;
                }
                if (hesapCikis == 1)
                {
                    alanCevre:
                    try
                    {
                        Console.WriteLine("Alan hesaplamak için 1'e çevre hesaplamak için 2'e basınız.");
                        alanÇevre = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Hatalı tuşlama yaptınız.");
                        goto alanCevre;
                    }
                secenekler:
                    try
                    {
                        Console.WriteLine("Üçgen için:1\nKare için:2\nDikdörtgen için:3\nDaire için:4 tuşuna basınız.");
                        secenekler = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Hatalı tuşlama yaptınız.");
                        goto secenekler;
                    }

                    if (alanÇevre == 1)
                    {
                        if (secenekler == 1)
                        {
                            Console.WriteLine("Eşkenar üçgen için:1\nİkizkenar üçgen için:2\nÇeşitkenar üçgen için:3 tuşuna basınız.");
                            üçgenSeçenekleri = Convert.ToInt32(Console.ReadLine());
                            if (üçgenSeçenekleri == 1)
                            {
                                int eskenarUcgen;
                                eskenar:
                                try
                                {
                                    Console.WriteLine("Lütfen kenar uzunluğunu giriniz");
                                    eskenarUcgen = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Hatalı tuşlama");
                                    goto eskenar;
                                }
                                int s = 3 / 4;
                                Console.Write("Eşkenar üçgenin alanı:");
                                Console.WriteLine(eskenarUcgen * eskenarUcgen * Math.Sqrt(s));
                            }
                            else if (üçgenSeçenekleri == 2)
                            {
                                int taban;
                            taban:
                                try
                                {
                                    Console.Write("Lütfen taban uzunluğu giriniz:");
                                    taban = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Hatalı tuşlama");
                                    goto taban;
                                }
                                int yükseklik;
                                yükseklik:
                                try
                                {
                                    Console.Write("Lütfen üçgenin yüksekliğini giriniz:");
                                    yükseklik = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Hatalı tuşlama");
                                    goto yükseklik;
                                }
                                Console.Write("İkizkenar üçgenin alanı:");
                                Console.WriteLine(taban * yükseklik / 2);
                            }
                            else if (üçgenSeçenekleri == 3)
                            {
                                int taban;
                                taban:
                                try
                                {
                                    Console.Write("Lütfen taban uzunluğu giriniz:");
                                    taban = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Hatalı tuşlama.");
                                    goto taban;
                                }
                                int yükseklik;
                                yükseklik:
                                try
                                {
                                    Console.Write("Lütfen üçgenin yüksekliğini giriniz:");
                                    yükseklik = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Hatalı tuşlama.");
                                    goto yükseklik;
                                }
                                Console.Write("Çeşitkenar üçgenin alanı:");
                                Console.WriteLine(taban * yükseklik / 2);
                            }
                        }
                        else if (secenekler == 2)
                        {
                            int kareKenar;
                            kareKenar:
                            try
                            {
                                Console.Write("Lütfen kare kenar uzunluğunu giriniz:");
                                kareKenar = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Hatalı tuşlama.");
                                goto kareKenar;
                            }
                            Console.Write("Karenin alanı:");
                            Console.WriteLine(kareKenar * kareKenar);
                        }
                        else if (secenekler == 3)
                        {
                            int uzunkenar;
                            uzunkenar:
                            try
                            {
                                Console.Write("Lütfen dikdörtgenin kenarını giriniz:");
                                uzunkenar = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Hatalı tuşlama.");
                                goto uzunkenar;
                            }
                            int kısakenar;
                            kısakenar:
                            try
                            {
                                Console.Write("Lütfen dikdörtgenin kenarını giriniz:");
                                kısakenar = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Hatalı tuşlama");
                                goto kısakenar;
                            }
                            Console.Write("Dikdörtgenin alanı:");
                            Console.WriteLine(uzunkenar * kısakenar);
                        }
                        else if (secenekler == 4)
                        {
                            int yarıçap;
                            yarıcap:
                            try
                            {
                                Console.Write("Lütfen dairenin yarıçapını giriniz:");
                                yarıçap = Convert.ToInt32(Console.ReadLine());
                            } 
                            catch (Exception)
                            {
                                Console.WriteLine("Hatalı tuşlama");
                                goto yarıcap;
                            }
                            Console.Write("Dairenin alanı:");
                            Console.WriteLine(3 * yarıçap * yarıçap);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı tuşlama yaptınız");
                            goto secenekler;
                        }
                    }
                    else if (alanÇevre == 2)
                    {
                        if (secenekler == 1)
                        {
                            Console.WriteLine("Eşkenar üçgen için:1\nİkizkenar üçgen için:2\nÇeşitkenar üçgen için:3 tuşuna basınız.");
                            üçgenSeçenekleri = Convert.ToInt32(Console.ReadLine());
                            if (üçgenSeçenekleri == 1)
                            {
                                int eskenarUcgen;
                            eskenar:
                                try
                                {
                                    Console.WriteLine("Lütfen kenar uzunluğunu giriniz");
                                    eskenarUcgen = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Hatalı tuşlama");
                                    goto eskenar;
                                }
                                Console.Write("Eşkenar üçgenin çevresi:");
                                Console.WriteLine(3 * eskenarUcgen);
                            }
                            else if (üçgenSeçenekleri == 2)
                            {
                                int eskenarlar;
                                eskenarlar:
                                try
                                {
                                    Console.Write("Lütfen uzunluğu giriniz:");
                                    eskenarlar = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Hatalı tuşlama");
                                    goto eskenarlar;
                                }
                                int farkliKenar;
                                farkliKenar:
                                try
                                {
                                    Console.Write("Lütfen farklı kenarı giriniz giriniz:");
                                    farkliKenar = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Hatalı tuşlama");
                                    goto farkliKenar;
                                }
                                Console.Write("İkizkenar üçgenin çevresi:");
                                Console.WriteLine(2 * eskenarlar + farkliKenar);
                            }
                            else if (üçgenSeçenekleri == 3)
                            {
                                int kenar1;
                                kenar1:
                                try
                                {
                                    Console.Write("Lütfen kenarı giriniz:");
                                    kenar1 = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Hatalı tuşlama");
                                    goto kenar1;
                                }
                                int kenar2;
                            kenar2:
                                try
                                {
                                    Console.Write("Lütfen kenarı giriniz:");
                                    kenar2 = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Hatalı tuşlama");
                                    goto kenar2;
                                }
                                int kenar3;
                            kenar3:
                                try
                                {
                                    Console.Write("Lütfen kenarı giriniz:");
                                    kenar3 = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Hatalı tuşlama");
                                    goto kenar3;
                                }
                                Console.Write("Çeşitkenar üçgenin çevresi:");
                                Console.WriteLine(kenar1 + kenar2 + kenar3);
                            }
                        }
                        else if (secenekler == 2)
                        {
                            int kareKenar;
                            kareKenar:
                            try
                            {
                                Console.Write("Lütfen kare kenar uzunluğunu giriniz:");
                                kareKenar = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Hatalı tuşlama");
                                goto kareKenar;
                            }
                            Console.Write("Karenin çevresi:");
                            Console.WriteLine(kareKenar * 4);
                        }
                        else if (secenekler == 3)
                        {
                            int uzunkenar;
                            uzunkenar:
                            try
                            {
                                Console.Write("Lütfen dikdörtgenin kenarını giriniz:");
                                uzunkenar = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Hatalı tuşlama");
                                goto uzunkenar;
                            }
                            int kisakenar;
                        kisakenar:
                            try
                            {
                                Console.Write("Lütfen dikdörtgenin kenarını giriniz:");
                                kisakenar = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Hatalı tuşlama");
                                goto kisakenar;
                            }
                            Console.Write("Dikdörtgenin çevresi:");
                            Console.WriteLine((uzunkenar * 2) + (kisakenar * 2));
                        }
                        else if (secenekler == 4)
                        {
                            int yarıçap;
                            Console.Write("Lütfen dairenin yarıçapını giriniz:");
                            yarıçap = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Dairenin çevresi:");
                            Console.WriteLine(2 * 3 * yarıçap);
                        }
                    }
                }
                else if (hesapCikis == 0)
                {
                    Console.WriteLine("Program kapatılıyor.Teşekkür ederiz.");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama yaptınız.");
                    goto hesapCikis;
                }
            }
            

        }
    }
}
