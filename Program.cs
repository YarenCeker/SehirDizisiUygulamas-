using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehirDizisiUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirlerDizisi = { "Elazıg" , "Eskişehir", "Istanbul", "Ankara", "Izmir","Diyarbakır", "Sinop"};
            // Memeleketimi eklemeden olmazdı hocam:))
            Console.WriteLine("Şehir giriniz");
            string girilenSehir = Console.ReadLine();
            bool varMi = true;
            for (int i = 0; i < sehirlerDizisi.Length; i++) 
            {
                if (sehirlerDizisi[i] == girilenSehir)
                {
                    varMi = false;
                    Console.WriteLine("Girilen şehir dizinin " + i + ". sırasındadır. ");
                    break;
                }
            }
            if (varMi)
            {
                Console.WriteLine(girilenSehir + " bulunamadı ");
            }

                Console.ReadLine();
        }
    }
}
