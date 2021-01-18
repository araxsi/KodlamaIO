using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_IO_Day2_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Kursadı = "Java";
            kurs1.Egitmen = "İskender.yilmaz";
            kurs1.IzlenmeOranı = 78;

            Kurs kurs2 = new Kurs();
            kurs2.Kursadı = "Python";
            kurs2.Egitmen = "İskender.yilmaz";
            kurs2.IzlenmeOranı = 150;

            Kurs kurs3 = new Kurs();
            kurs3.Kursadı = "C#";
            kurs3.Egitmen = "İskender.yilmaz";
            kurs3.IzlenmeOranı = 78;

            Console.WriteLine(kurs1.Kursadı + " " + kurs1.Egitmen + " " + kurs1.IzlenmeOranı);

            Console.WriteLine(kurs2.Kursadı + " " + kurs2.Egitmen + " " + kurs2.IzlenmeOranı);

            Console.WriteLine(kurs3.Kursadı + " " + kurs3.Egitmen + " " + kurs3.IzlenmeOranı);

            //Kursları array a atarken string tanımlarda aşağıdaki gibi tanımlama yapılmaktadır.

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Kursadı + " " + kurs.Egitmen);
            }



        }
    }
    // Daha önce string olarak tanımlanan ve buna benzer birçok özelliği bir arada tutan bir küme toplaluğu için tanımlanır
    class Kurs
    {
        public string Kursadı { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı{ get; set; }

    }
}
