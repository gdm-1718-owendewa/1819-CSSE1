using System;

namespace Lesweek6
{
    class Program
    {
        static void Main(string[] args)
        {
            Tables();
            Console.WriteLine("geef het gewenste aantal tafels in");
            int generatedNumber = int.Parse(Console.ReadLine());
            vermeningVuldigingsFactor(generatedNumber); 
            Facutatief(5);
            Console.WriteLine("geef een nummer in voor Fibonacci");
            int fibonacciNumber = int.Parse(Console.ReadLine());
            for(int i=0; i<fibonacciNumber; i++){
            Console.WriteLine(Fibonacci(i));
            }
        }
        static void Tables(){
            
            Console.WriteLine("Geef het gewenste tafelnummer in");
            int grondgetal = int.Parse(Console.ReadLine());
            for(int x = 0; x< grondgetal; x++){
                vermeningVuldigingsFactor(x);
            }
        }
        static void vermeningVuldigingsFactor(int x){
             for(int y = 0; y<10; y++){
                     Console.WriteLine(x+" maal "+y+" is gelijk aan "+ x*y);   
                }
        }
         static void Facutatief(int fac){ 
             int a, number;
            Console.WriteLine("Geef uw facutatief te berekenen nummer in");
            number = int.Parse(Console.ReadLine());
            fac = number;
                for(a=number-1; a >=1; a--){
                    fac = fac * a;
                }
            Console.WriteLine("Factoriaal van ingevoerd nummer is "+ fac);
            Console.ReadLine();
        }
         static int Fibonacci(int number){
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
