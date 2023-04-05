namespace Hesaplama.Hesaplama
{
    class KareHesaplama
    {
        public static void Kare()
        {
            Console.WriteLine("(1) Alan Hesaplaması");
            Console.WriteLine("(2) Çevre Hesaplama");
            int islem = int.Parse(Console.ReadLine());
            double alan = 0;
            double cevre = 0;

            if (islem == 1)
            {
                Console.Write("Kare'nin kenar uzunluğunu giriniz: ");
                double kenar = double.Parse(Console.ReadLine());
                alan = kenar * kenar;
                Console.WriteLine(kenar+" "+"kenar uzunluklukları olan karenin alanı: "+ alan);

            }

            else if (islem == 2)
            {
                Console.Write("Karenin kenar uzunluğunu giriniz: ");
                double kenar = double.Parse(Console.ReadLine());
                cevre = kenar * 4;
                Console.WriteLine(kenar+" "+"kenar uzunlukları olan karenin çevresi: "+ cevre);
            }
        }

    }
}