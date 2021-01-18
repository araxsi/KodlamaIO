using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_IO_Day2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Type safety - Tip Güvenliği
            //Do not repeat yourself
            string kategorietiketi = "Kategori";
            int sayi1 = 14;
            double sayi2=1.45;
            bool kontrol = true;
            double dolardun = 7.35;
            double dolarbugun = 7.50;

            if (dolardun<dolarbugun)
            {
                Console.WriteLine("Dolar Yükselmiştir");
            }
            else if (true)
            {
                Console.WriteLine("Dolar Düşmüştür");
            }
            else
            {
                Console.WriteLine("Dolar Değişmemiştir.");
            }
            

            
            


            //Şartların yazılması
            if (kontrol==true)
            {
                Console.WriteLine("Hoşgeldiniz");
            }
            else
            {

            }

            Console.WriteLine(kategorietiketi);
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            Console.WriteLine(kontrol);
            
        }
    }
}
