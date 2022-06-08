using System;

namespace ConsApp
{
    public class Journal:Product
    {
        private string _company;

        public string Company
        {
            get => _company;
            set
            {
                _company = value;
            }
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Name: {Name} - Price: {Price} - Company: {Company}");
        }
    }
}