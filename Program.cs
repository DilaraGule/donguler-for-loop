using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            Console.WriteLine("sayı gir");
            int sayac = int.Parse(Console.ReadLine());
            for(int i = 0 ; i < sayac; i++){
                if(i % 2 == 1)
                    toplam += i;
            }
            Console.WriteLine("Tek sayıların toplamı " + toplam);
        
            //break ve continue
            for(int j = 0; j < 10; j++){
                if(j == 4)
                    break;
                Console.WriteLine(j);
            }

            for(int j = 0; j < 10; j++){
                if(j == 4)
                    continue;
                Console.WriteLine(j);
            }
        }

    }
}
