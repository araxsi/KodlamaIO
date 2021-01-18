using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_IO_Day_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liste değerinde verilenlerin tektek yazılması yerine liste şeklinde yazılması konusunda gösterilmesini anlatan bir durumdur. C# da  array yani dizilerdir bunun karşılı
            //string kurs1 = "Yazılım Geliştirici";
            //string kurs2 = "Programlamaya Başlangıç";

            //Array örneğidir.
            string[] kurslar = new string[] { "Yazılım Geliştirici", "Programlamaya Başlangıç" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            //Dizi temelli yapılarda tektek döülmesi için forech döngüsü kullanılmaktadır.Örneğin

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            for (int i = 0; i < 10; i=i+2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
