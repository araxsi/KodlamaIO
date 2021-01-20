using System;

namespace Day_4_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ürün tanıtımı yapılırken aşağıdaki yöntem ile yapılmaktadır.
            Product product1 = new Product();
            product1.ProductName = "Masa";
            product1.ProductId = 232;
            product1.ProductCategoryId = 2;
            product1.ProductUnitId = 3;
            product1.ProductPrice = 5000;

            //Diğer ürün tanımlama yöntemidir.
            Product product2 = new Product { ProductId = 363, ProductUnitId = 569, ProductName = "Dolap", };

            //PascalCase   //camelCase
            //case sensitive

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
