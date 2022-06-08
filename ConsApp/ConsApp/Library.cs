using System;

namespace ConsApp
{
    public class Library
    {
        public Product[] Products;

        public Library()
        {
            Products = new Product[0];
        }
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

        public int GetBooksCount()
        {
            int sum = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] is Book)
                {
                    sum++;
                }
            }
            return sum;
        }

        public int GetJournalsCount()
        {
            int sum = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] is Journal)
                {
                    sum++;
                }
            }
            return sum;
        }

        public Product[] GetProducts(bool isBook)
        {
            Product[] products = new Product[0];
            if (isBook)
            {
                for (int i = 0; i < Products.Length; i++)
                {
                    if (Products[i] is Book)
                    {
                        Array.Resize(ref products, products.Length + 1);
                        products[products.Length - 1] = Products[i];
                    }
                }   
            }
            else
            {
                for (int i = 0; i < Products.Length; i++)
                {
                    if (Products[i] is Journal)
                    {
                        Array.Resize(ref products, products.Length + 1);
                        products[products.Length - 1] = Products[i];
                    }
                }
            }
            return products;
        }
    }
}