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
            for(int i=0; i<10; i++){
            Console.WriteLine(Fo(i));
             }
            
            //fac van een nummer//
            int a, number, fac;
            Console.WriteLine("enter your number");
            number = int.Parse(Console.ReadLine());
            fac = number;
            for(a=number-1; a >=1; a--){
                fac = fac * a;
            }
            Console.WriteLine("Factoriaal van ingevoerd nummer is "+ fac);
            Console.ReadLine();
             
        }
        
        static int Fo(int number){
            int eerste = 0;
            int tweede = 1;
            int volgende = 1;

            for(int i=2; i<=number; i++){
                volgende = eerste + tweede;
                eerste = tweede;
                tweede = volgende;
            }
            return volgende;
        }
         
    }
}
