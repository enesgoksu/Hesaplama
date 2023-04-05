namespace Hesaplama.Hesaplama
{
    class DikdörtgenHesaplaması
    {
        public static void Diktörtgen()
        {
            Console.WriteLine("(1) Alan Hesaplaması");
            Console.WriteLine("(2) Çevre Hesaplama");
            int islem = int.Parse(Console.ReadLine());
            double alan = 0;
            double cevre = 0;

            if (islem == 1)
            {
                Console.Write("Kısa kenar uzunluğunu giriniz: ");
                double kısakenar = double.Parse(Console.ReadLine());
                Console.Write("Uzunkenar uzunluğunu giriniz: ");
                double uzunkenar = double.Parse(Console.ReadLine());
                alan = uzunkenar * kısakenar;
                Console.WriteLine("Kısakenarı: "+ kısakenar+","+"uzunkenarı: "+ uzunkenar+" "+"olan diktörtgenin alanı: "+ alan);
            }
            else if (islem == 2)
            {
                Console.Write("Kısa kenar uzunluğunu giriniz: ");
                double kısakenar = double.Parse(Console.ReadLine());
                Console.Write("Uzunkenar uzunluğunu giriniz: ");
                double uzunkenar = double.Parse(Console.ReadLine());
                cevre = (uzunkenar + kısakenar) * 2;
                Console.WriteLine("Kısakenarı: "+ kısakenar+","+"uzunkenarı: "+ uzunkenar+" "+"olan diktörtgenin çevresi: "+ cevre);
            }
        }
    }
}