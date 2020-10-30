using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int devam;
            do
            {
                Console.Write("Birinci Sayiyi Giriniz: ");
                int x = Int32.Parse(Console.ReadLine());
                Console.Write("Ikinci Sayiyi Giriniz: ");
                int y = Int32.Parse(Console.ReadLine());
                // SEÇENEK DIŞINDAKİ YANLIŞ GİRİLEN DEĞERLER İÇİN (5,6,7 VS.) DÜZELTİLME YAPILMADIw .
                Console.WriteLine("1) Topla");
                Console.WriteLine("2) Cikar");
                Console.WriteLine("3) Bol");
                Console.WriteLine("4) Carp");
                int caseSwitch = Int32.Parse(Console.ReadLine());
                int sonuc;
                switch (caseSwitch)
                {
                    case 1:
                        sonuc = x + y;
                        Console.WriteLine("Sonuç: " + sonuc);
                        break;
                    case 2:
                        sonuc = x - y;
                        Console.WriteLine("Sonuç: " + sonuc);
                        break;
                    case 3:
                        sonuc = x / y;
                        Console.WriteLine("Sonuç: " + sonuc);
                        break;
                    case 4:
                        sonuc = x * y;
                        Console.WriteLine("Sonuç: " + sonuc);
                        break;
                }

                Console.WriteLine("Devam etmek istiyor musunuz ?");   
                Console.WriteLine("1) Evet");
                Console.WriteLine("2) Çıkış");
                devam = Int32.Parse(Console.ReadLine());
            }
            while (devam == 1);
                        
   
        }
    }
}
