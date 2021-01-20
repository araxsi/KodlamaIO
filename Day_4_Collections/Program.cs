using System;
using System.Collections.Generic;

namespace Day_4_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[]
            //    {
            //        "Engin","Murat","İskender","Ayhan"
            //    };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            ////Console.WriteLine(names[4]);//böyle bir eleman olmadığından hata alınması normaldir

            List<string> names2 = new List<string> { "Engin", "Murat", "İskender", "Ayhan" };
            names2.Add("Ahmet");
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            Console.WriteLine(names2[4]);//Yukarıdaki array dizinlerinde alınan hatanın sıkıntısını 
            //gidermek adına kullanılan List listesini kullanma yöntetimidir.Collection konusunda kaynakları araştırmamız gerekiyor.
            //https://www.tutorialspoint.com/csharp/csharp_collections.htm
            //https://www.uguroksuz.com/csharp-collections/
            //https://docs.microsoft.com/tr-tr/dotnet/csharp/programming-guide/concepts/collections

            //List şeklinde bir sınıf oluşturmak istenildiğinde nasıl yapılabilir aşağıdaki şekilde inceleyelim.

            
        }
    }
}
