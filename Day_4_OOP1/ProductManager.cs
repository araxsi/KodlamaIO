using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4_OOP1
{
    class ProductManager //CRUD
    {
        //Encapsulation
        public void Add(Product product)
        {

            Console.WriteLine(product.ProductName + "eklendi.");

        }

        public void Update(Product product)
        {

            Console.WriteLine(product.ProductName + "güncellendi");
        }

        //Void ve int kavramlarının anlaşılması konusunda yapılan örnektir.Void konusunda şunu belirtmek çok doğru bir yöntemdir , sadece bir defa kullanılacak
        //fonksiyonda void kullanılmaktadır. ama daha sonra kullanılacak durumlarda int veya diğer durumlarda int kullanılmaktadır

        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1+sayi1
        //}

        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi1); 
        //}
    }
}
