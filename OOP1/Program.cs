using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product { Id = 1, CategoryId = 2,
                UnitsInStock = 5,ProductName = "Kalem", UnitPrice = 35};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }
    }
}
