using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for(int x = 0; x< 11; x++){
                for(int y = 0; y<11; y++){
                    Console.WriteLine(x+" maal "+y+" is gelijk aan "+ x*y);   
                }
            }
            
        }
    }
}
