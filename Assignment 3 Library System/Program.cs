using System;

namespace Assignment_3_Library_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Book harryPotter = new Book("Harry Potter", "Whoever", 100);
            Console.WriteLine(Book.NumberOfBooks);
            Book TheBible = new Book("The Bible", "God", 1000);
            Console.WriteLine(Book.NumberOfBooks);
            Book OneNineEightFour = new Book("1984", "Me", 200);
            Console.WriteLine(Book.NumberOfBooks);

            Book harpyp = new Book("HP", "JK", 100);
            harpyp = null;
            Console.WriteLine(harpyp.GetTitle());
        }
    }
}
