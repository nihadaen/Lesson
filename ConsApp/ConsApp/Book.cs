using System;

namespace ConsApp
{
    public class Book:Product
    {
        private string _author;
        private string _genre;

        public string Author
        {
            get => _author;
            set
            {
                _author = value;
            }
        }
        public string Genre
        {
            get => _genre;
            set
            {
                _genre = value;
            }
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Name: {Name} - Price: {Price} - Author: {Author} - Genre: {Genre}");
        }
    }
}