using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 001;
            product1.Adi ="Televizyon";
            product1.Fiyati = 560000;

             Product product2 = new Product();
            product2.Id = 003;
            product2.Adi = "Buzdolabı";
            product2.Fiyati = 230000;

            Product[] products = new Product[] { product1, product2 };


            //Type Safe ile çalışır Java ve C# dilleri
            foreach (Product product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine("------------------------------------------Diğer Urun----------------------------------------------------");

             }

            Console.WriteLine("-------------------------------Metodlar---------------------------------------------------------------------");

            //İnstance--Örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            //sepetManager.Ekle();
            sepetManager.Ekle2(001, "Televizyon");
        }
    }
}


//birden fazla kullanmayı gerektiren işlemlerin tanımlanması ve kullanılma sırasında çağırarak kullanılan yöntemlere metodlar denir. DO NOT YOURSAELF durumuna uygun yapıdır. CLEAN CODE mantığı ile BEST PRACTICE yöntemi ile çalışılmasıdır.
