using System;

namespace ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddProduct(new Book()
            {
                Name = "Rich dad, poor dad",
                Price = 10,
                Author = "Robert Kiyosaki",
                Genre = "Business"
            });
            library.AddProduct(new Book()
            {
                Name = "13 reasons why",
                Price = 15,
                Author = "Jay Asher",
                Genre = "Novel"
            });
            library.AddProduct(new Journal()
            {
                Name = "Why Code Academy?",
                Price = 5,
                Company = "Code Academy"
            });
            try
            {
                Console.WriteLine("1. GetInfo \n2. GetJournalsCount \n3. GetBooksCount \n4. GetProducts");
                string opt = Console.ReadLine();
                if (opt == "1")
                {
                    for (int i = 0; i < library.Products.Length; i++)
                    {
                        library.Products[i].GetInfo();
                    }
                }
                else if (opt == "2")
                {
                    Console.WriteLine("Jurnalların sayı: " + library.GetJournalsCount());
                }
                else if (opt == "3")
                {
                    Console.WriteLine("Kitabların sayı: " + library.GetBooksCount());
                }
                else if (opt == "4")
                {
                    Console.WriteLine("Kitablar yoxsa jurnallar? 1 - Kitablar, 2 - Jurnallar");
                    string option = Console.ReadLine();
                    if (option == "1")
                    {
                        Product[] newPr = library.GetProducts(true);

                        for (int i = 0; i < newPr.Length; i++)
                        {
                            newPr[i].GetInfo();
                        }
                    }
                    else if (option == "2")
                    {
                        Product[] newPr = library.GetProducts(false);
                        
                        for (int i = 0; i < newPr.Length; i++)
                        {
                            newPr[i].GetInfo();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış seçim daxil edildi.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Bilinmədik bir xəta baş verdi!");
            }
        }
    }
}