using System;

namespace Opdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Author auteur1 = new Author("Stephen Hawkins", "SH@hotmail.com", 'M');
            Book boek1 = new Book("Space and Time", auteur1, 15.0, 3);
           
            Console.WriteLine(boek1.Print());
            Console.WriteLine(boek1.getName());
            Console.WriteLine(boek1.getAuthor());
            Console.WriteLine(boek1.getPrice());
            Console.WriteLine(boek1.getQtyInStock());

            boek1.setPrice(20.0);
            boek1.setQtyInStock(5);
            
            Console.WriteLine(boek1.Print());
            Console.WriteLine(boek1.getName());
            Console.WriteLine(boek1.getAuthor());
            Console.WriteLine(boek1.getPrice());
            Console.WriteLine(boek1.getQtyInStock());
        }
    }
}
