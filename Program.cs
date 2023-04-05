namespace Hesaplama.Hesaplama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("(1) Kare");
            Console.WriteLine("(2) Diktörtgen");
            Console.WriteLine("(3) Üçgen");
            Console.Write("Seçmek istediğiniz geometrik şekile karşılık gelen değeri girin: ");
            int cevap = int.Parse(Console.ReadLine());

            switch (cevap)
            {
                case 1: 
                    KareHesaplama.Kare();
                break;

                case 2:
                    DikdörtgenHesaplaması.Diktörtgen();
                break;

                case 3:
                    ÜcgenHesaplaması.Ücgen();
                break;                
            
                
            }
        }
    }
}