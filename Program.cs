using System;
namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.PAZAR);
            Console.WriteLine((int)Gunler.CUMARTESİ);

            int sicaklik=32;
            if(sicaklik<=(int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyin");
            }
            else if(sicaklik>=(int)HavaDurumu.Sicak)
                Console.WriteLine("Dışarıya çıkmak için sıcak bir gün");
            else if(sicaklik>=(int)HavaDurumu.Normal&&sicaklik<(int)HavaDurumu.CokSicak)
                Console.WriteLine("Hadi dışarıya çıkalım");
        }
    }
    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        CUMARTESİ,
        PAZAR
    }
    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sicak=25,
        CokSicak=30
    }
}
