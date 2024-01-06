using System;

class Program
{
    static void Main(string[] args)
    {
        // Örnek araç türü ve kalma süreleri
        Console.WriteLine("Otomobil, 18 saat: " + HesaplaCikisUcreti("Otomobil", 18)); // Örnek: Otomobil, 18 saat kalma süresi
        Console.WriteLine("Otomobil, 32 saat: " + HesaplaCikisUcreti("Otomobil", 32)); // Örnek: Otomobil, 32 saat kalma süresi
    }

    static double HesaplaCikisUcreti(string aracTuru, int kalmaSuresi)
    {
        double ucret = 0;

        switch (aracTuru)
        {
            case "Otomobil":
                if (kalmaSuresi <= 2)
                {
                    ucret = 5;
                }
                else if (kalmaSuresi <= 10)
                {
                    ucret = 5 + (kalmaSuresi - 2);
                }
                else
                {
                    ucret = 13 + Math.Min(kalmaSuresi - 10, 24 - 10) + Math.Max(kalmaSuresi - 24, 0);
                }
                break;

            case "Kamyon":
                if (kalmaSuresi <= 2)
                {
                    ucret = 8;
                }
                else if (kalmaSuresi <= 8)
                {
                    ucret = 8 + (kalmaSuresi - 2) * 2;
                }
                else
                {
                    ucret = 20 + Math.Min(kalmaSuresi - 8, 24 - 8) + Math.Max(kalmaSuresi - 24, 0);
                }
                break;

            case "Is Makinasi":
                if (kalmaSuresi <= 2)
                {
                    ucret = 12;
                }
                else if (kalmaSuresi <= 8)
                {
                    ucret = 12 + (kalmaSuresi - 2) * 3;
                }
                else
                {
                    ucret = 36 + Math.Min(kalmaSuresi - 8, 24 - 8) + Math.Max(kalmaSuresi - 24, 0);
                }
                break;

            default:
                Console.WriteLine("Geçersiz araç türü!");
                break;
        }

        return ucret;
    }
}
