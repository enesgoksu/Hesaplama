namespace Hesaplama.Hesaplama
{
    class ÜcgenHesaplaması
    {
        public static void Ücgen()
        {
            Console.WriteLine("(1) Alan Hesaplaması");
            Console.WriteLine("(2) Çevre Hesaplama");
            int islem = int.Parse(Console.ReadLine());
            double alan = 0;
            double cevre = 0;
            double hipo = 0;
            double toplam = 0;
            
            if (islem == 1)
            {
                Console.Write("Üçgenin tabanını giriniz: ");
                double taban = double.Parse(Console.ReadLine());
                Console.Write("Üçgenin yüksekliğini giriniz: ");
                double yükseklik = double.Parse(Console.ReadLine());
                alan = (taban * yükseklik) / 2;
                Console.WriteLine("Yüksekliği: "+ yükseklik+","+"tabanı: "+ taban+" "+"olan üçgenin alanı: "+ alan);
            }
            else if (islem == 2)
            {
                Console.Write("Üçgenin tabanını giriniz: ");
                double taban = double.Parse(Console.ReadLine());
                Console.Write("Üçgenin yüksekliğini giriniz: ");
                double yükseklik = double.Parse(Console.ReadLine());
                hipo = (taban * taban) + (yükseklik * yükseklik);
                toplam = Math.Sqrt(hipo);
                cevre = taban + yükseklik + toplam;
                Console.WriteLine("Yüksekliği: "+ yükseklik+","+"tabanı: "+ taban+" "+"olan üçgenin çevresi: "+ cevre);
            }
        }
    }
}